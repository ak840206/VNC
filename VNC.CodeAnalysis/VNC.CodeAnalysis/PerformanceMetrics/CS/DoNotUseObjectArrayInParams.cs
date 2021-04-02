using System.Linq;
using System.Text;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace VNC.CodeAnalysis.PerformanceMetrics.CS
{
    public class DoNotUseObjectArrayInParams
    {
        public static StringBuilder Check(string sourceCode)
        {
            StringBuilder sb = new StringBuilder();

            var tree = CSharpSyntaxTree.ParseText(sourceCode); // 1

            var results = tree.GetRoot()
            .DescendantNodes()
            .OfType<MethodDeclarationSyntax>()//#2
            .Where(mds => mds.ParameterList.Parameters
            .Any(p => p.Modifiers
            .Any(m => m.Text == "params" && //#3
            p.Type.ToFullString().Replace(" ", string.Empty)
            .Contains("object[]"))))
            .Select(mds => new //#4
            {
                //Name of the class
                ClassName = mds.Ancestors()
                .OfType<ClassDeclarationSyntax>()
                .First()
                .Identifier
                .ValueText,
                //The name of defaulter method
                MethodName = mds.Identifier.ValueText
            });
            //.Dump("Methods with param objects");

            foreach (var item in results)
            {
                sb.AppendLine($"  {item.ClassName} {item.MethodName}");
            }

            return sb;
        }
    }
}

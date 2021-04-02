using System.Linq;
using System.Text;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace VNC.CodeAnalysis.DesignMetrics.CS
{
    public class OutParameters
    {
        public static StringBuilder Check(string sourceCode)
        {
            StringBuilder sb = new StringBuilder();

            var tree = CSharpSyntaxTree.ParseText(sourceCode);

            var results = tree.GetRoot()
            .DescendantNodes()
            .OfType<ClassDeclarationSyntax>()// 1
            .Select(cds => new
            {
                ClassName = cds.Identifier.ValueText,
                Methods = cds.Members
            .OfType<MethodDeclarationSyntax>()// 2
            .Where(mds => // 3
            mds.ParameterList
            .Parameters.Any(z =>
            z.Modifiers.Any(m =>
            m.ValueText == "out")))
            .Select(mds => mds.Identifier.ValueText)
            });
            //.Dump("Methods with \"out\" parameters");

            foreach (var item in results)
            {
                sb.AppendLine($"  {item.ClassName} {item.Methods.Count()}");
            }

            return sb;
        }
    }
}

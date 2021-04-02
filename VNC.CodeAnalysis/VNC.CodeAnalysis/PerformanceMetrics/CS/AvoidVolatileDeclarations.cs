using System.Linq;
using System.Text;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace VNC.CodeAnalysis.PerformanceMetrics.CS
{
    public class AvoidVolatileDeclarations
    {
        public static StringBuilder Check(string sourceCode)
        {
            StringBuilder sb = new StringBuilder();

            var tree = CSharpSyntaxTree.ParseText(sourceCode);//#1

            var results = tree.GetRoot()
            .DescendantNodes()
            .OfType<FieldDeclarationSyntax>()//#2
            .Where(vds => vds.Modifiers
            .Any(m => m.ValueText == "volatile"))//#3
            .Select(vds => new //#4
            {
                ClassName = vds.Ancestors()
                    .OfType<ClassDeclarationSyntax>()
                    .First()?.Identifier.ValueText,
                VolatileDeclaration = vds.ToFullString()
            });
            //            .Dump();

            foreach (var item in results)
            {
                sb.AppendLine($"  {item.ClassName}  {item.VolatileDeclaration}");
            }

            return sb;
        }
    }
}

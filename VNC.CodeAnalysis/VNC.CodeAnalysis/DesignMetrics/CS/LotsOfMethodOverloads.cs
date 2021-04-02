using System.Linq;
using System.Text;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
namespace VNC.CodeAnalysis.DesignMetrics.CS
{
    public class LotsOfMethodOverloads
    {
        public static StringBuilder Check(string sourceCode)
        {
            StringBuilder sb = new StringBuilder();

            var tree = CSharpSyntaxTree.ParseText(sourceCode); // 1

            var results = tree.GetRoot()
            .DescendantNodes()
            .Where(t => t.Kind() == SyntaxKind.ClassDeclaration)
            .Cast<ClassDeclarationSyntax>()
            .Select(cds =>
           new
           {
               ClassName = cds.Identifier.ValueText,//#1
               Methods = cds.Members.OfType<MethodDeclarationSyntax>() // 2
           .Select(mds => mds.Identifier.ValueText)
           })
            .Select(cds => new
            {
                ClassName = cds.ClassName,
                Overloads = cds.Methods
           .ToLookup(m => m)
           .ToDictionary(m => m.Key, m => m.Count())
            }); // 3
            //        .Dump("Overloaded Methods");

            foreach (var item in results)
            {
                sb.AppendLine($"  {item}");
            }

            return sb;
        }
    }
}

using System.Linq;
using System.Text;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
namespace VNC.CodeAnalysis.DesignMetrics.CS
{
    public class StaticMembersOnGenericTypes
    {
        public static StringBuilder Check(string sourceCode)
        {
            StringBuilder sb = new StringBuilder();

            var tree = CSharpSyntaxTree.ParseText(sourceCode);

            var results = tree.GetRoot()
            .DescendantNodes()
            .OfType<ClassDeclarationSyntax>()
            .Where(cds => cds.Arity > 0)// 1
            .Select(cds => // 2
            new
            {
                //Name of the generic class
                GenericClassName = cds.Identifier.ValueText,
                //Static methods in the generic class
                StaticMethods = cds.Members
                    .OfType<MethodDeclarationSyntax>()
                    .Where(mds => mds.Modifiers
                    .Any(m => m.ValueText == "static"))
                    .Select(mds => mds.Identifier.ValueText)
            })
            .Where(cds => cds.StaticMethods.Count() > 0); // 3
            //.Dump("Static methods on generic types");

            foreach (var item in results)
            {
                sb.AppendLine($"  {item.GenericClassName} {item.StaticMethods.Count()} ");
            }

            return sb;
        }
    }
}

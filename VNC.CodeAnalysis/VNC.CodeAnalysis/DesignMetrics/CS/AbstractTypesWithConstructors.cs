using System.Linq;
using System.Text;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace VNC.CodeAnalysis.DesignMetrics.CS
{
    public class AbstractTypesWithConstructors
    {
        public static StringBuilder Check(string sourceCode)
        {
            StringBuilder sb = new StringBuilder();

            var tree = CSharpSyntaxTree.ParseText(sourceCode);

            var results =
            tree.GetRoot()
            .DescendantNodes()
            .OfType<ClassDeclarationSyntax>()
            .Where(cds => cds.Modifiers
            .Any(m => m.ValueText == "abstract"))// 1
            .Select(cds => new // 2
            {
                ClassName = cds.Identifier.ValueText,
                PublicConstructors =
                    cds.Members
                    .OfType<ConstructorDeclarationSyntax>()
                    .Any(c => c.Modifiers
                    .Any(m => m.ValueText == "public"))
                    })
            .Where(cds => cds.PublicConstructors);// 3
            //            .Dump("AbstractTypesShouldNotHaveConstructors Violators");

            foreach (var item in results)
            {
                sb.AppendLine($"  {item.ClassName} {item.PublicConstructors}");
            }

            return sb;
        }
    }
}

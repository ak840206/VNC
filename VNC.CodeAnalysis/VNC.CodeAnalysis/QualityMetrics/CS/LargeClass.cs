using System.Linq;
using System.Reflection;
using System.Text;

using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace VNC.CodeAnalysis.QualityMetrics.CS
{
    public class LargeClass
    {
        public static StringBuilder Check(string sourceCode)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Is Large Clasee");

            var tree = CSharpSyntaxTree.ParseText(sourceCode);

            var classAndMembers = tree.GetRoot().DescendantNodes()
            .Where(t => t.Kind() == SyntaxKind.ClassDeclaration)
            .Cast<ClassDeclarationSyntax>() // 1
            .Select(cds =>
               new
               {
                   ClassName = cds.Identifier.ValueText, // 2
                   Size = cds.Members.Count // 3
               });

            if (classAndMembers.Count() > 0)
            {
                var averageLength = classAndMembers
                    .Select(classDetails => classDetails.Size).Average(); // 4

                var largeClass = classAndMembers.Where(am => am.Size > averageLength); // 5

                foreach (var item in largeClass)
                {
                    sb.AppendLine($"LARGE CLASS {item.ClassName} {item.Size} Average:{averageLength}");
                }
            }

            return sb;
        }
    }
}

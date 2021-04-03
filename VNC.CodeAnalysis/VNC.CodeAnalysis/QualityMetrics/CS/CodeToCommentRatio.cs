using System.Linq;
using System.Text;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace VNC.CodeAnalysis.QualityMetrics.CS
{
    public class CodeToCommentRatio
    {
        public static StringBuilder Check(string sourceCode)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Code to Comment Ratio");

            var tree = CSharpSyntaxTree.ParseText(sourceCode);

            var results = tree.GetRoot().DescendantNodes()
            .Where(t => t.Kind() == SyntaxKind.ClassDeclaration)
            .Cast<ClassDeclarationSyntax>()
            .Select(t =>
               new
               {
                   ClassName = t.Identifier.ValueText,
                   Methods = t.Members.OfType<MethodDeclarationSyntax>()
               }
            )//#1
            .Select(t =>
               new
               {
                   ClassName = t.ClassName,
                   MethodDetails = t.Methods
                   .Select(m => 
                       new
                       {
                           Name = m.Identifier.ValueText,
                           Lines = m.Body.Statements.Count, //#2
                           Comments = m.Body.DescendantTrivia()
                            .Count(b => b.Kind() == SyntaxKind.SingleLineCommentTrivia
                            || b.Kind() == SyntaxKind.MultiLineCommentTrivia) //#3
                       }
                   )
               }
            );

            foreach (var item in results)
            {
                sb.AppendLine($"  ClassName: {item.ClassName}");

                foreach (var detail in item.MethodDetails)
                {
                    sb.AppendLine($"    Method: {detail.Name,-40}   Statements:{detail.Lines,5}  Comments:{detail.Comments,5}");
                }
            }

            return sb;
        }
    }
}

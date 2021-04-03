using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace VNC.CodeAnalysis.QualityMetrics.CS
{
    public class MagicNumbersInMath
    {
        public static StringBuilder Check(string sourceCode)
        {
            StringBuilder sb = new StringBuilder();

            List<SyntaxKind> kinds = new List<SyntaxKind>()
            {
                SyntaxKind.AddAssignmentExpression,
                SyntaxKind.SubtractAssignmentExpression,
                SyntaxKind.MultiplyAssignmentExpression,
                SyntaxKind.DivideAssignmentExpression,
                SyntaxKind.AddExpression,
                SyntaxKind.SubtractExpression,
                SyntaxKind.MultiplyExpression,
                SyntaxKind.DivideExpression
            };

            var tree = CSharpSyntaxTree.ParseText(sourceCode);

            var results = tree.GetRoot()
            .DescendantNodes()
            .Where(st => st.Kind() == SyntaxKind.MethodDeclaration)
            .Cast<MethodDeclarationSyntax>()
            .Select(st =>
           new
           {
               MethodName = st.Identifier.ValueText, // 1
               MagicLines = CSharpSyntaxTree.ParseText(st.ToFullString())
               .GetRoot()
               .DescendantNodes()
               .Where(z => kinds
                  .Any(k => k == z.Kind())
               )
                .Select(q => q.ToFullString().Trim())
                .Where(w => CSharpSyntaxTree
                .ParseText("void dummy(){" + w.ToString() + "}")
                .GetRoot()
               .DescendantTokens()
               .Any(s => // 2
               s.Kind() == SyntaxKind.NumericLiteralToken))
           });

            // TODO(crhodes)
            // Need to add up all the item.MagicLines.Count and display only if > 0
            // There must be a cleaner way of doing this

            int resultCount = 0;

            foreach (var item in results)
            {
                resultCount += item.MagicLines.Count();
            }

            if (resultCount > 0)
            {
                sb.AppendLine("Has Magic Numbers in Math");

                foreach (var item in results)
                {
                    if (item.MagicLines.Count() > 0)
                    {
                        sb.AppendLine($"  Method: {item.MethodName,-40}");

                        foreach (var line in item.MagicLines)
                        {
                            sb.AppendLine($"    {line}");
                        }
                    }
                }
            }

            return sb;
        }
    }
}

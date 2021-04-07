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

            var results = tree.GetRoot().DescendantNodes()
            .Where(st => st.Kind() == SyntaxKind.MethodDeclaration)
            .Cast<MethodDeclarationSyntax>()
            .Select(st =>
                new
                {
                    Span = st.Span,
                    MethodName = st.Identifier.ValueText, // 1
                    MagicLines = CSharpSyntaxTree.ParseText(st.ToFullString())
                   .GetRoot().DescendantNodes()
                       .Where(z => kinds.Any(k => k == z.Kind()))
                        .Select(q => q.ToFullString().Trim())
                        .Where(w => CSharpSyntaxTree.ParseText("void dummy(){" + w.ToString() + "}")
                        .GetRoot().DescendantTokens()
                            .Any(s => s.Kind() == SyntaxKind.NumericLiteralToken)) // 2
                });

            int resultCount = results.Select(r => r.MagicLines.Count()).Sum();

            if (resultCount > 0)
            {
                sb.AppendLine($"Has Magic Numbers in Math ({resultCount})");

                foreach (var item in results)
                {
                    if (item.MagicLines.Count() > 0)
                    {
                        sb.AppendLine($"  ({item.Span.Start,4}-{item.Span.End,-4}) Method: {item.MethodName}");

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

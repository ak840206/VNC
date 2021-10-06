using System.Collections.Generic;
using System.Linq;
using System.Text;

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
                    Line = tree.GetLineSpan(st.Span).StartLinePosition.Line + 1,    // Lines start at 0
                    MagicLines = CSharpSyntaxTree.ParseText(st.ToFullString())
                   .GetRoot().DescendantNodes()
                       .Where(z => kinds.Any(k => k == z.Kind()))
                        .Select(q =>
                        new
                        {
                            Code = q.ToFullString().Trim(),
                            CodeLine = tree.GetLineSpan(q.Span).StartLinePosition.Line + 1,    // Lines start at 0
                        })
                        .Where(w => CSharpSyntaxTree.ParseText("void dummy(){" + w.Code.ToString() + "}")
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
                        sb.AppendLine($"  Method:{item.MethodName} at Line:{item.Line}");

                        foreach (var line in item.MagicLines)
                        {
                            sb.AppendLine($"    {line.Code} at Line:{line.CodeLine}");
                        }
                    }
                }
            }

            return sb;
        }
    }
}

using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace VNC.CodeAnalysis.QualityMetrics.CS
{
    public class MagicNumbersInIndex
    {
        public static StringBuilder Check(string sourceCode)
        {
            StringBuilder sb = new StringBuilder();

            var tree = CSharpSyntaxTree.ParseText(sourceCode);

            var results = tree.GetRoot().DescendantNodes()
            .OfType<BracketedArgumentListSyntax>()
            .Select(bals =>
            new
            {
                Method = bals.Ancestors()
                    .OfType<MethodDeclarationSyntax>()
                    .First()
                    .Identifier.ValueText,
                Span = bals.Span,
                Line = tree.GetLineSpan(bals.Span).StartLinePosition.Line + 1,    // Lines start at 0
                Code = bals.Parent,
                Indices = bals.Arguments
                    .Select(a => a.GetText()
                    .Container
                    .CurrentText
                    .ToString())
            })
            //Find methods that use magic indices
            .Where(bals => bals.Indices
                .Any(i => Regex.Match(i, "[0-9]+").Success)
            );

            int resultCount = results.Select(r => r.Indices.Count()).Sum();

            if (resultCount > 0)
            {
                sb.AppendLine($"Has Magic Numbers in Index ({resultCount})");

                foreach (var item in results)
                {
                    sb.AppendLine($"  Method: {item.Method} ");
                    sb.AppendLine($"    {item.Code} at Line:{item.Line}");

                    foreach (var index in item.Indices)
                    {
                        sb.AppendLine($"      Index: {index}");
                    }
                }
            }

            return sb;
        }
    }
}

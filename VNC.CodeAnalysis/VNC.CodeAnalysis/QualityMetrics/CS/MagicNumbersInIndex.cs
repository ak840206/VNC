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
                ClassName = bals.Ancestors()
                    .OfType<ClassDeclarationSyntax>().First()
                    .Identifier.ValueText,
                // TODO(crhodes)
                // See if can just reach back once for Method
                MethodName = bals.Ancestors()
                    .OfType<MethodDeclarationSyntax>()
                    .First()
                    .Identifier.ValueText,
                MethodLine = tree.GetLineSpan(bals.Ancestors()
                    .OfType<MethodDeclarationSyntax>().First().Span)
                    .StartLinePosition.Line + 1,
                Span = bals.Span,
                CodeLine = tree.GetLineSpan(bals.Span).StartLinePosition.Line + 1,    // Lines start at 0
                Code = bals.Parent,
                Indices = bals.Arguments
                    .Select(a => a.GetText()
                    .Container
                    .CurrentText
                    .ToString())
            })
            .Where(bals => bals.Indices
                .Any(i => Regex.Match(i, "[0-9]+").Success)
            );

            int resultCount = results.Select(r => r.Indices.Count()).Sum();

            if (resultCount > 0)
            {
                sb.AppendLine($"Has Magic Numbers in Index ({resultCount})");

                foreach (var item in results)
                {
                    sb.AppendLine($"  Line:{item.MethodLine,-5} - ClassName:{item.ClassName}  MethodName:{item.MethodName}()");

                    sb.AppendLine($"    {item.Code}    - Line:{item.CodeLine}");

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

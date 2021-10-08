using System.Linq;
using System.Text;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace VNC.CodeAnalysis.QualityMetrics.CS
{
    public class GoToLabels
    {
        public static StringBuilder Check(string sourceCode)
        {
            StringBuilder sb = new StringBuilder();

            var tree = CSharpSyntaxTree.ParseText(sourceCode);

            var results = tree.GetRoot().DescendantNodes()
            .Where(t => t.Kind() == SyntaxKind.MethodDeclaration)
            .Cast<MethodDeclarationSyntax>()
            .Select(mds =>
                new
                {
                    ClassName = mds.Ancestors().OfType<ClassDeclarationSyntax>().First().Identifier.ValueText,
                    MethodName = mds.Identifier.ValueText,
                    MethodLine = tree.GetLineSpan(mds.Span).StartLinePosition.Line + 1, // Lines start at 0
                    GoTos = mds.Body.DescendantNodes().Where(n => n.Kind() == SyntaxKind.GotoStatement 
                                                                || n.Kind() == SyntaxKind.GotoCaseStatement),
                    HasGoto = CSharpSyntaxTree.ParseText(mds.ToString())
                        .GetRoot()
                        .DescendantTokens()
                        .Any(st => st.Kind() == SyntaxKind.GotoKeyword)
                })
                .Where(mds => mds.HasGoto);

            int resultCount = results.Select(r => r.GoTos.Count()).Sum();

            if (resultCount > 0)
            {
                sb.AppendLine($"Has Goto Labels ({resultCount})");

                foreach (var item in results)
                {
                    sb.AppendLine($"  {item.ClassName}.{item.MethodName}()    - Line:{item.MethodLine}");

                    foreach (var g in item.GoTos)
                    {
                        sb.AppendLine($"    {g} - Line: {g.GetLocation().GetLineSpan().StartLinePosition.Line + 1}");
                    }
                }
            }

            return sb;
        }
    }
}

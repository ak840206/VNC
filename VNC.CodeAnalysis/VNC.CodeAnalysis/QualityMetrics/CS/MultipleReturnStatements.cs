using System.Linq;
using System.Text;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace VNC.CodeAnalysis.QualityMetrics.CS
{
    public class MultipleReturnStatements
    {
        public static StringBuilder Check(string sourceCode)
        {
            StringBuilder sb = new StringBuilder();

            var tree = CSharpSyntaxTree.ParseText(sourceCode);

            var results = tree.GetRoot().DescendantNodes()
            .Where(t => t.Kind() == SyntaxKind.MethodDeclaration)
            .Cast<MethodDeclarationSyntax>()    // 1 - Get Methods
            .Select(t =>
               new
               {
                   MethodName = t.Identifier.ValueText,
                   //Returns = t.Body.Statements.Where(n => n.Kind() == SyntaxKind.ReturnStatement),
                   //Returns1 = t.Body.ChildNodes().Where(n => n.Kind() == SyntaxKind.ReturnStatement),
                   Returns2 = t.Body.DescendantNodes().Where(n => n.Kind() == SyntaxKind.ReturnStatement),
                   ReturnCount = t.Body.DescendantTokens()
                    .Count(st => st.Kind() == SyntaxKind.ReturnKeyword) // 2 - Return
               })
            .Where(t => t.ReturnCount > 1);

            if (results.Count() > 0)
            {
                sb.AppendLine($"Has Multiple Return Statements ({results.Count()})");

                foreach (var item in results)
                {
                    sb.AppendLine($"  Method: {item.MethodName,-40} Returns: {item.ReturnCount}");

                    //sb.AppendLine($"----Returns-----");
                    //foreach (var r in item.Returns)
                    //{
                    //    sb.AppendLine($"    {r}");
                    //}

                    //sb.AppendLine($"----Returns1-----");

                    //foreach (var r in item.Returns1)
                    //{
                    //    sb.AppendLine($"      {r}");
                    //}

                    //sb.AppendLine($"----Returns2-----");

                    foreach (var r in item.Returns2)
                    {
                        sb.AppendLine($"    ({r.Span.Start,5}-{r.Span.End,5}) {r} ");
                    }
                }
            }

            return sb;
        }
    }
}

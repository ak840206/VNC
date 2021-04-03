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

            var results = tree.GetRoot()
            .DescendantNodes()
            .Where(t => t.Kind() == SyntaxKind.MethodDeclaration)
            .Cast<MethodDeclarationSyntax>()
            .Select(t =>
               new
               {
                   Name = t.Identifier.ValueText, // 1
                   Returns = t.Body.DescendantTokens()
                    .Count(st => st.Kind() == SyntaxKind.ReturnKeyword)// 2
               })
            .Where(t => t.Returns > 1);

            int resultCount = 0;

            foreach (var item in results)
            {
                resultCount += item.Returns;
            }

            if (resultCount > 0)
            {
                sb.AppendLine("Has Multiple Return Statements");

                foreach (var item in results)
                {
                    sb.AppendLine($"  Name: {item.Name,-40} {item.Returns}");
                }
            }

            return sb;
        }
    }
}

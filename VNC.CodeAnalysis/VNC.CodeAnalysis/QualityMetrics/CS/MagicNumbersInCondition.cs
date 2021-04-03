using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace VNC.CodeAnalysis.QualityMetrics.CS
{
    public class MagicNumbersInCondition
    {
        public static StringBuilder Check(string sourceCode)
        {
            StringBuilder sb = new StringBuilder();

            var tree = CSharpSyntaxTree.ParseText(sourceCode);

            var operators = new List<SyntaxKind>()
            {
                SyntaxKind.GreaterThanToken,
                SyntaxKind.GreaterThanEqualsToken,
                SyntaxKind.LessThanEqualsToken,
                SyntaxKind.LessThanToken,
                SyntaxKind.EqualsEqualsToken,
                SyntaxKind.LessThanLessThanEqualsToken,
                SyntaxKind.GreaterThanGreaterThanEqualsToken
            };

            var results = tree.GetRoot()
            .DescendantNodes()
            .Where(t => t.Kind() == SyntaxKind.ClassDeclaration)
            .Cast<ClassDeclarationSyntax>()
            .Select(t =>
               new
               {
                   ClassName = t.Identifier.ValueText, // 1
                   MethodTokens = t.Members
                   .Where(m => m.Kind() == SyntaxKind.MethodDeclaration)
                   .Cast<MethodDeclarationSyntax>()
                   .Select(mds =>
                       new
                       {
                           MethodName = mds.Identifier.ValueText,
                           Tokens = CSharpSyntaxTree.ParseText(mds.ToFullString())
                               .GetRoot()
                               .DescendantTokens()
                               .Select(c => c.Kind())
                       })
                       .Select(w =>
                          new
                          {
                              MethodName = w.MethodName, // 2
                              Toks = w.Tokens.Zip(w.Tokens.Skip(1), (a, b) =>
                               operators.Any(op => op == a) && b
                               == SyntaxKind.NumericLiteralToken) // 3
                          })
                   .Where(w => w.Toks.Any(to => to == true)) // 4
                   .Select(w => w.MethodName)
                   });

            int resultCount = 0;

            foreach (var item in results)
            {
                resultCount += item.MethodTokens.Count();
            }

            if (resultCount > 0)
            {
                sb.AppendLine("Has Magic Numbers in Condition");

                foreach (var item in results)
                {
                    sb.AppendLine($"  ClassName: {item.ClassName}");

                    foreach (var token in item.MethodTokens)
                    {
                        sb.AppendLine($"    Token: {token}");
                    }

                    // TODO(crhodes)
                    // Needs work.

                }
            }

            return sb;
        }
    }
}

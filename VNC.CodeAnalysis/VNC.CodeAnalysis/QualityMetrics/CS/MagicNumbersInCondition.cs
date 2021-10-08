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

            var tree = CSharpSyntaxTree.ParseText(sourceCode);

            // NOTE(crhodes)
            // This is what was in the book.
            // NB. It starts with Class
            // and Descends into Method
            // then looks for Tokens that match operators
            // that have NumericLiteral Tokens
            // It detects x > 5 but not 5 > x
            //
            // Also, I couldn't figure out how to get line numbers on the way down.

            //var resultsA = tree.GetRoot().DescendantNodes()
            //.Where(t => t.Kind() == SyntaxKind.ClassDeclaration)
            //.Cast<ClassDeclarationSyntax>()
            //.Select(t =>
            //new
            //{
            //    ClassName = t.Identifier.ValueText,
            //    MethodTokens = t.Members
            //    .Where(m => m.Kind() == SyntaxKind.MethodDeclaration)
            //    .Cast<MethodDeclarationSyntax>()
            //    .Select(mds =>
            //    new
            //    {
            //        MethodName = mds.Identifier.ValueText,
            //        Tokens = CSharpSyntaxTree.ParseText(mds.ToFullString())
            //        .GetRoot()
            //        .DescendantTokens()
            //        .Select(c => c.Kind())
            //    })
            //    .Select(w =>
            //    new
            //    {
            //        MethodName = w.MethodName,
            //        Toks = w.Tokens.Zip(w.Tokens.Skip(1), (a, b) =>
            //            operators.Any(op => op == a)
            //            && b == SyntaxKind.NumericLiteralToken)
            //    })
            //    .Where(w => w.Toks.Any(to => to == true))
            //    .Select(w => w.MethodName)
            //    });

            // This approach starts with the thing we are looking for
            // Then looks for ancestors to get Methods and Class.
            // It correctly handles numbers on either side

            var results = tree.GetRoot().DescendantNodes()
            .OfType<BinaryExpressionSyntax>()
            .Select(bes =>
            new
            {
                Left = bes.Left,
                Op = bes.OperatorToken,
                Right = bes.Right,
                CodeLine = tree.GetLineSpan(bes.Span).StartLinePosition.Line + 1,
                ClassName = bes.Ancestors()
                    .OfType<ClassDeclarationSyntax>().First()
                    .Identifier.ValueText,
                MethodName = bes.Ancestors()
                    .OfType<MethodDeclarationSyntax>().First()
                    .Identifier.ValueText,
                MethodLine = tree.GetLineSpan(bes.Ancestors()
                    .OfType<MethodDeclarationSyntax>().First().Span)
                    .StartLinePosition.Line + 1
            })
            .Where(bes =>
                bes.Right.Kind() == SyntaxKind.NumericLiteralExpression
                || bes.Left.Kind() == SyntaxKind.NumericLiteralExpression);

            foreach (var bes in results)
            {
                //sb.AppendLine($"Left:{bes.Left}   Op:{bes.Op}   Right:{bes.Right}");
                sb.AppendLine($"  ClassName: {bes.ClassName}");
                sb.AppendLine($"     MethodName: {bes.MethodName}  - Line: {bes.MethodLine}");
                sb.AppendLine($"         {bes.Left} {bes.Op} {bes.Right}  - Line: {bes.CodeLine}");
            }

            return sb;
        }
    }
}

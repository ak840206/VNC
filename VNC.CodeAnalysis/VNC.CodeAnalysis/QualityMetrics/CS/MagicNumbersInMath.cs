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
            //
            //        .Dump("Magic lines. Please avoid these");

            foreach (var item in results)
            {
                sb.AppendLine($"   {item.MethodName,-40}  MagicLines:{item.MagicLines}");
            }

            return sb;
        }
    }
}

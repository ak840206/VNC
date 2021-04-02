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
            //Method should ideally have one return statement
            //That way it is easier to refactor them later.
            .Where(t => t.Returns > 1);
            //.Dump("Multiple return statements");


            foreach (var item in results)
            {
                sb.AppendLine($"   {item.Name,-40} {item.Returns}");
            }

            return sb;
        }
    }
}

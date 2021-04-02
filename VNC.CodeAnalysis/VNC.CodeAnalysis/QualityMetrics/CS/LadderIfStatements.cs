using System.Linq;
using System.Text;

using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace VNC.CodeAnalysis.QualityMetrics.CS
{
    public class LadderIfStatements
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
               Name = t.Identifier.ValueText,
               IfStatements = t.Body.Statements
           .Where(s => s.Kind() == SyntaxKind.IfStatement)
           .Cast<IfStatementSyntax>()
           })
            .Select(t =>
            new
            {
                Name = t.Name,
                Ladders = t.IfStatements
            .Select(i => i.Condition.ToFullString())
            .ToLookup(i => i.Substring(0, i.IndexOf('=')))
            .Where(i => i.Count() >= 2)
            });
            //.Dump();

            foreach (var item in results)
            {
                 sb.AppendLine($"   {item.Name,-40}   IfStatements:{item.Ladders}");
            }

            return sb;
        }
    }
}

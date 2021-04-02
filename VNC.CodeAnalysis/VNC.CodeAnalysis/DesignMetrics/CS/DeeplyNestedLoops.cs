using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace VNC.CodeAnalysis.DesignMetrics.CS
{
    public class DeeplyNestedLoops
    {
        public static StringBuilder Check(string sourceCode)
        {
            StringBuilder sb = new StringBuilder();

            var tree = CSharpSyntaxTree.ParseText(sourceCode);//#1

            var loopTypes = new List<SyntaxKind>()
            {
                SyntaxKind.ForStatement,
                SyntaxKind.ForEachStatement,
                SyntaxKind.WhileStatement
            };// 2

            var results = tree.GetRoot()
                .DescendantNodes()
                .Where(t => loopTypes.Any(l => t.Kind() == l))// 3
                .Select(t => new
                {
                    // 4
                    Method = t.Ancestors().OfType<MethodDeclarationSyntax>()
                .First()
                .Identifier.ValueText,
                    Nesting = 1 + t.Ancestors()
                .Count(z => loopTypes
                .Any(l => z.Kind() == l))
                })// 5
                .ToLookup(t => t.Method)
                .ToDictionary(t => t.Key,
                t => t.Select(m => m.Nesting).Max())// 6
                .Select(t => new { Method = t.Key, Nesting = t.Value })
                .Where(t => t.Nesting >= 3); // 7
            //.Dump("Deeply Nested Loops");

            foreach (var item in results)
            {
                sb.AppendLine($"  {item.Method} {item.Nesting}");
            }

            return sb;
        }
    }
}

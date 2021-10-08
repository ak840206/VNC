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

            var results = tree.GetRoot().DescendantNodes()
            .Where(t => t.Kind() == SyntaxKind.MethodDeclaration)
            .Cast<MethodDeclarationSyntax>()
            .Select(t =>
               new
               {
                   ClassName = t.Ancestors()
                    .OfType<ClassDeclarationSyntax>().First()
                    .Identifier.ValueText,
                   Method = t,
                   IfStatements = t.Body.Statements
                       .Where(s => s.Kind() == SyntaxKind.IfStatement)
                       .Cast<IfStatementSyntax>()
               })
            .Select(mds =>
                new
                {
                    ClassName1 = mds.ClassName,
                    MethodName = mds.Method.Identifier.ValueText,
                    MethodLine = tree.GetLineSpan(mds.Method.Span).StartLinePosition.Line + 1,
                    IfStatements1 = mds.IfStatements,
                    Ladders = mds.IfStatements
                        .Select(i => i.Condition.ToFullString())
                        .ToLookup(i => i.Substring(0, i.IndexOf('=')))
                        .Where(i => i.Count() >= 2)
                }); ;

            int resultCount = results.Select(r => r.Ladders.Count()).Sum();

            if (resultCount > 0)
            {
                sb.AppendLine($"Has Ladder If Statements ({resultCount})");

                foreach (var item in results)
                {
                    if (item.IfStatements1.Count() > 0)
                    {
                        if (item.Ladders.Count() > 0)
                        {
                            sb.AppendLine($"  Line:{item.MethodLine,-5} - {item.ClassName1}.{item.MethodName}()");

                            sb.AppendLine($"   IfStatements:");

                            foreach (var ifs in item.IfStatements1)
                            {
                                sb.AppendLine($"   if ({ifs.Condition})");
                            }
                        }
                    }
                }
            }

            return sb;
        }
    }
}

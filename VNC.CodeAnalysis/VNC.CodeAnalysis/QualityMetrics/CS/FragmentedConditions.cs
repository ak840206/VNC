using System.Linq;
using System.Text;

using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace VNC.CodeAnalysis.QualityMetrics.CS
{
    public class FragmentedConditions
    {
        public static StringBuilder Check(string sourceCode)
        {
            StringBuilder sb = new StringBuilder();

            var tree = CSharpSyntaxTree.ParseText(sourceCode);

            var results = tree.GetRoot()
            .DescendantNodes()
            .Where(t => t.Kind() == SyntaxKind.MethodDeclaration)
            .Cast<MethodDeclarationSyntax>() // 1
            .Select(mds => 
                new
                {
                    ClassName = mds.Ancestors()
                        .OfType<ClassDeclarationSyntax>().First()
                        .Identifier.ValueText,
                    MethodName = mds.Identifier.ValueText,
                    MethodLine = tree.GetLineSpan(mds.Span).StartLinePosition.Line + 1,
                    IfStatements = mds.Body.Statements
                   .Where(m => m.Kind() == SyntaxKind.IfStatement)
                   .Cast<IfStatementSyntax>()
                   .Select(iss =>
                      new
                      {
                          Statement = iss.Statement.ToFullString(),
                          IfStatement = iss.Condition.ToFullString()
                      })
                    //.ToLookup(iss => iss.Statement) // 4
                    // NOTE(crhodes)
                    // What does .ToLookup do?
                });
            //        .Dump("Fragmented conditions");

            int resultCount = results.Select(r => r.IfStatements.Count()).Sum();

            if (resultCount > 0)
            {
                sb.AppendLine($"Has Fragmented Conditions ({resultCount})");

                foreach (var item in results)
                {
                    sb.AppendLine($"  Line:{item.MethodLine,-5} - {item.ClassName}.{item.MethodName}()");

                    if (item.IfStatements.Count() > 0)
                    {
                        sb.AppendLine($"    Statement: {item.IfStatements.First().Statement}");
                    }

                    foreach (var ifs in item.IfStatements)
                    {
                        sb.AppendLine($"    if({ifs.IfStatement})");
                        sb.AppendLine($"       {item.IfStatements.First().Statement}");
                    }
                }
            }

            return sb;
        }
    }
}

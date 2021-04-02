using System.Linq;
using System.Text;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace VNC.CodeAnalysis.PerformanceMetrics.CS
{
    public class DoNotUseThreadAbortOrThreadSuspend
    {
        public static StringBuilder Check(string sourceCode)
        {
            StringBuilder sb = new StringBuilder();

            var tree = CSharpSyntaxTree.ParseText(sourceCode);// 1
            
            //Finding names of all “Thread” objects

            var allThreadNames = tree.GetRoot()
            .DescendantNodes()
            .OfType<LocalDeclarationStatementSyntax>()// 2
            .Where(ldss => ldss.Declaration.Type
            .ToFullString().Trim() == "Thread" ||
            ldss.Declaration.Type.ToFullString().Trim()
            == "System.Threading.Thread")// 3
            .SelectMany(ldss => ldss.Declaration.Variables
            .Select(v => v.Identifier.ValueText));// 4

            //Finding all the method invocations

            var results = tree.GetRoot()
            .DescendantNodes()
            .OfType<InvocationExpressionSyntax>()// 5
            .Where(ies => allThreadNames
            .Any(tn => ies.Expression.ToFullString()
            .Trim().StartsWith(tn + ".Abort")// 6
            || ies.Expression.ToFullString()
            .Trim().StartsWith(tn + ".Suspend")))
            .Select(d => new // 7
            {
                Method = d.Ancestors()
                .OfType<MethodDeclarationSyntax>()
                .First().Identifier.ValueText,
                Line = d.Expression.ToFullString().Trim()
            });
            //            .Dump("Defaulters");

            foreach (var item in results)
            {
                sb.AppendLine($"  {item.Line}  {item.Method}");
            }

            return sb; ;
        }
    }
}

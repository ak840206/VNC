using System.Linq;
using System.Text;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace VNC.CodeAnalysis.PerformanceMetrics.CS
{
    public class AvoidExcessiveLocalVariables
    {
        public static StringBuilder Check(string sourceCode, CodeCheckOptions options)
        {
            StringBuilder sb = new StringBuilder();

            var limit = options.VariableCount;

            SyntaxTree tree = CSharpSyntaxTree.ParseText(sourceCode);
            //The recommended value is 64;
            //But for demonstration purpose it is changed to 4
            //const int MAX_LOCALS_ALLOWED = 4; // 2

            var results = tree.GetRoot().DescendantNodes()
            .OfType<MethodDeclarationSyntax>() // 3
            .Where(mds => 
                mds.Body.Statements
                .OfType<LocalDeclarationStatementSyntax>()
                .Count() >= limit) // 4
                .Select(mds => mds.Identifier.ValueText); // 5

            foreach (var item in results)
            {
                sb.AppendLine($"  {item}");
            }

            return sb;
        }
    }
}

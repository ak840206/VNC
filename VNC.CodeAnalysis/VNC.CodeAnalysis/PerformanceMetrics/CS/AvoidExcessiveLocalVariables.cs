using System.Linq;
using System.Text;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace VNC.CodeAnalysis.PerformanceMetrics.CS
{
    public class AvoidExcessiveLocalVariables
    {
        public static StringBuilder Check(string sourceCode)
        {
            StringBuilder sb = new StringBuilder();

            var tree = CSharpSyntaxTree.ParseText(sourceCode); // 1
            //The recommended value is 64;
            //But for demonstration purpose it is changed to 4
            const int MAX_LOCALS_ALLOWED = 4; // 2

            var results = tree.GetRoot()
            .DescendantNodes()
            .OfType<MethodDeclarationSyntax>() // 3
            .Where(mds =>
            mds.Body.Statements
            .OfType<LocalDeclarationStatementSyntax>()
            .Count() >= MAX_LOCALS_ALLOWED) // 4
            .Select(mds => mds.Identifier.ValueText); // 5
            //.Dump("Methods with many local variable declarations");

            foreach (var item in results)
            {
                sb.AppendLine($"  {item}");
            }

            return sb;
        }
    }
}

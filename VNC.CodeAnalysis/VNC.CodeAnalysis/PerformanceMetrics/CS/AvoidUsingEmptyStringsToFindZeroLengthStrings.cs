using System.Linq;
using System.Text;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace VNC.CodeAnalysis.PerformanceMetrics.CS
{
    public class AvoidUsingEmptyStringsToFindZeroLengthStrings
    {
        public static StringBuilder Check(string sourceCode)
        {
            StringBuilder sb = new StringBuilder();

            var tree = CSharpSyntaxTree.ParseText(sourceCode); // 1
            
            //Finding all instances of “string” in source code.
            var strings = tree
            .GetRoot()
            .DescendantNodes()
            .OfType<VariableDeclarationSyntax>()//#2
            .Where(vds => vds.Type.ToFullString().Trim() ==
            "string")//#3
            .SelectMany(vds => vds.Variables.Select(v =>
            v.Identifier.ValueText));//#4
            var results = tree.GetRoot()
            .DescendantNodes()
            .OfType<IfStatementSyntax>()
            .Where(iss => strings
            .Any(s => iss.Condition.ToFullString()
            .Contains(s + " == \"\""))) //#5
            .Select(iss => new //#6
            {
                MethodName = iss.Ancestors()
            .OfType<MethodDeclarationSyntax>()
            .First()
            .Identifier.ValueText,
                Condition = iss.ToFullString()
            });

            if (results.Any())
            {
                //                results.Dump();

                foreach (var item in results)
                {
                    sb.AppendLine($"  {item}");
                }
            }

            return sb;
        }
    }
}

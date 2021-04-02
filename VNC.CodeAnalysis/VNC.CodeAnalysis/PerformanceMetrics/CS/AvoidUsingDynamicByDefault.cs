using System.Linq;
using System.Text;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace VNC.CodeAnalysis.PerformanceMetrics.CS
{
    public class AvoidUsingDynamicByDefault
    {
        public static StringBuilder Check(string sourceCode)
        {
            StringBuilder sb = new StringBuilder();

            var tree = CSharpSyntaxTree.ParseText(sourceCode);//#1

            var results = tree.GetRoot()
            .DescendantNodes()
            .OfType<VariableDeclarationSyntax>()//#2
                                                //#3
            .Where(vds => vds.Type.ToFullString().Trim() == "dynamic")
            .Select(vds => vds.ToFullString());
            //.Dump("All usages of dynamic. Some may not be required");

            foreach (var item in results)
            {
                sb.AppendLine($"  {item}");
            }

            return sb;
        }
    }
}

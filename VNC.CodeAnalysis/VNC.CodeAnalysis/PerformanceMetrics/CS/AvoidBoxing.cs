using System.Linq;
using System.Text;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace VNC.CodeAnalysis.PerformanceMetrics.CS
{
    public class AvoidBoxing
    {
        public static StringBuilder Check(string sourceCode)
        {
            StringBuilder sb = new StringBuilder();

            var tree = CSharpSyntaxTree.ParseText(sourceCode); // 1
                //There are couple of boxing calls in the provided code sample
                //These should have been avoided
                //x - Int
                //o -> object

            var results = tree.GetRoot()
            .DescendantNodes().OfType<VariableDeclarationSyntax>() // 2
            .SelectMany(aes => aes.Variables.Select(v =>
                new // 3
                {
                    Type = aes.GetFirstToken().ValueText,
                    Name = v.Identifier.ValueText,
                    Value = aes.GetLastToken().ValueText
                })
            );

            var defaulters = results // 4
                .Where(aes => aes.Type == "object"
                && results.FirstOrDefault(d => d.Name == aes.Value
                && d.Type != "object") != null);
            //.Dump("Boxing calls");

            foreach (var item in defaulters)
            {
                sb.AppendLine($"   {item.Name,-40} {item.Type} {item.Value}");
            }

            return sb;
        }
    }
}

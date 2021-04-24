using System.Linq;
using System.Text;

using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace VNC.CodeAnalysis.PerformanceMetrics.CS
{
    public class AvoidBoxing
    {
        public static StringBuilder Check(string sourceCode)
        {
            StringBuilder sb = new StringBuilder();

            var tree = CSharpSyntaxTree.ParseText(sourceCode);

            var results = tree.GetRoot().DescendantNodes()
                .OfType<VariableDeclarationSyntax>()
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
                        && results.FirstOrDefault(
                            d => d.Name == aes.Value
                                 && d.Type != "object") != null);

            foreach (var item in defaulters)
            {
                sb.AppendLine($"   Name: {item.Name,-20} Type: {item.Type} Value: {item.Value}");
            }

            return sb;
        }
    }
}

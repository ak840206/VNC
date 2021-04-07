using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace VNC.CodeAnalysis.QualityMetrics.CS
{
    public class LotsOfLocalVariables
    {
        public static StringBuilder Check(string sourceCode)
        {
            StringBuilder sb = new StringBuilder();

            SyntaxTree tree = CSharpSyntaxTree.ParseText(sourceCode);

            List<MethodDeclarationSyntax> methods = tree.GetRoot().DescendantNodes()
            .Where(d => d.Kind() == SyntaxKind.MethodDeclaration)
            .Cast<MethodDeclarationSyntax>()
            .ToList();//1

            if (methods.Count() > 0)
            {
                var results = methods.Select(z =>
                new
                {
                    MethodName = z.Identifier.ValueText, // 2
                    NBLocal = z.Body.Statements 
                    .Count(x => x.Kind() == SyntaxKind.LocalDeclarationStatement) // 3
                })
                .OrderByDescending(x => x.NBLocal)
                .ToList();

                if (results.Count() > 0)
                {
                    sb.AppendLine("Has Lots of Local Variables");

                    foreach (var item in results)
                    {
                        sb.AppendLine($"  {item.MethodName} Local Variables: {item.NBLocal}");
                    }
                }
            }

            return sb;
        }
    }
}

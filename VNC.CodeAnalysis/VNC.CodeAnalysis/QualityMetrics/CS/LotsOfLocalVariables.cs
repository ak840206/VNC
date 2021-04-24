using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace VNC.CodeAnalysis.QualityMetrics.CS
{
    public static class LotsOfLocalVariables
    {
        public static StringBuilder Check(string sourceCode, CodeCheckOptions options)
        {
            StringBuilder sb = new StringBuilder();

            SyntaxTree tree = CSharpSyntaxTree.ParseText(sourceCode);

            // TODO(crhodes)
            // Look at Long Parameter List.  Is it useful to have class??

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

                var limit = options.VariableCount;

                foreach (var item in results)
                {
                    if (item.NBLocal > limit)
                    {
                        sb.AppendLine($"Has Lots (> {limit}) of Local Variables");

                        sb.AppendLine($"  Method: {item.MethodName, -20} Variables: {item.NBLocal, 2}");
                    }
                }
            }

            return sb;
        }
    }
}

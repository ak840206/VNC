using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace VNC.CodeAnalysis.QualityMetrics.CS
{
    public class UnusedMethodParameters
    {
        public static StringBuilder Check(string sourceCode)
        {
            StringBuilder sb = new StringBuilder();

            SyntaxTree tree = CSharpSyntaxTree.ParseText(sourceCode);

            List<MethodDeclarationSyntax> methods = tree.GetRoot()
            .DescendantNodes()
            .OfType<MethodDeclarationSyntax>().ToList();

            var results = methods.Select(z =>
            {
                var parameters =
                z.ParameterList.Parameters
                .Select(p => p.Identifier.ValueText);

                return
                new
                {
                    MethodName = z.Identifier.ValueText,// 1
                    IsUsingAllParameter = parameters.All // 2
                        (x => z.Body.Statements.SelectMany(s => s.DescendantTokens())
                        .Select(s => s.ValueText).Distinct().Contains(x))
                };
            })
            .Where(x => !x.IsUsingAllParameter);

            //.ToList()
            //.ForEach(x => sb.AppendLine($"{x.MethodName} {x.IsUsingAllParameter}"));

            if (results.Count() > 0)
            {
                sb.AppendLine("Has Unused Method Parameters");

                foreach (var item in results)
                {
                    sb.AppendLine($"  Method: {item.MethodName,-40}  {! item.IsUsingAllParameter }");
                }
            }

            return sb;
        }
    }
}

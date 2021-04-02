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

            List<MethodDeclarationSyntax> methods =
            tree.GetRoot()
            .DescendantNodes()
            .Where(d => d.Kind() == SyntaxKind.MethodDeclaration)
            .Cast<MethodDeclarationSyntax>()
            .ToList();//#1

            if (methods.Count() > 0)
            {
                methods.Select(z =>
                new
                {
                    MethodName = z.Identifier.ValueText,//#2
                    NBLocal = z.Body.Statements
                //#3
                .Count(x => x.Kind() == SyntaxKind.LocalDeclarationStatement)
                })
                .OrderByDescending(x => x.NBLocal)
                .ToList()
                .ForEach(x =>
                    sb.AppendLine($"  {x.MethodName} Local Variables: {x.NBLocal}"));
            }

            return sb;
        }
    }
}

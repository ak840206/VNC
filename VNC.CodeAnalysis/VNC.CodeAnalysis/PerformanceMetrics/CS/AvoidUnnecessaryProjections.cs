using System.Linq;
using System.Text;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace VNC.CodeAnalysis.PerformanceMetrics.CS
{
    public class AvoidUnnecessaryProjections
    {
        public static StringBuilder Check(string sourceCode)
        {
            StringBuilder sb = new StringBuilder();

            var tree = CSharpSyntaxTree.ParseText(sourceCode); // 1

            var decls = tree
                .GetRoot()
                .DescendantNodes()
                .OfType<LocalDeclarationStatementSyntax>(); // 2

            var projectors = new string[2];
            projectors[0] = ".ToList();";
            projectors[1] = "ToArray();";
            //var projectors = new string[] = { ".ToList();", ".ToArray();" };

            if (decls.Count() > 0) // 3
            {
                var defaulters = decls.Select(ldss => new //#4
                {
                    ClassName = ldss.Ancestors()
                        .OfType<ClassDeclarationSyntax>()
                        .FirstOrDefault()
                        ?.Identifier
                        .ValueText,
                    Method = ldss.Ancestors()
                        .OfType<MethodDeclarationSyntax>()
                        .FirstOrDefault()?.Identifier
                        .ValueText,
                    Statement = ldss.ToFullString().Trim()
                })
                //#5
                .Where(ldss => projectors
                .Any(projector => ldss.Statement.Trim()
                .EndsWith(projector)));

                if (defaulters.Count() > 0)
                {
                    //defaulters.Dump("Un-necessary projections");
                    foreach (var item in defaulters)
                    {
                        sb.AppendLine($"   {item.ClassName,-40} {item.Method} {item.Statement}");
                    }
                }

            }

            return sb;
        }
    }
}

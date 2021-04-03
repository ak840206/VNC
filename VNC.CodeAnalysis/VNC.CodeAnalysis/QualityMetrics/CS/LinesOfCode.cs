using System.Linq;
using System.Reflection;
using System.Text;

using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace VNC.CodeAnalysis.QualityMetrics.CS
{
    public class LinesOfCode
    {
        public static StringBuilder Check(string sourceCode)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Lines of Code");

            var tree = CSharpSyntaxTree.ParseText(sourceCode);

            var results = tree.GetRoot()
            .DescendantNodes()
            .Where(t => t.Kind() == SyntaxKind.ClassDeclaration)
            .Cast<ClassDeclarationSyntax>()
            .Select(cds =>
               new
               {
                   ClassName = cds.Identifier.ValueText,//#1
                   Methods = cds.Members.OfType<MethodDeclarationSyntax>()
                    .Select(mds =>
                        new
                        {
                            MethodName = mds.Identifier.ValueText,//#2
                            LOC = mds.Body.SyntaxTree
                            .GetLineSpan(mds.FullSpan).EndLinePosition.Line //#3
                                - mds.Body.SyntaxTree.GetLineSpan(mds.FullSpan)
                            .StartLinePosition.Line - 3 //#4
                        }
                    )
               }
           );

            foreach (var item in results)
            {
                sb.AppendLine($"  Class:{item.ClassName}");

                foreach (var detail in item.Methods)
                {
                    sb.AppendLine($"    MethodName: {detail.MethodName,-40}   LOC:{detail.LOC,4}");
                }
            }

            return sb;
        }
    }
}

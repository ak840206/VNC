using System.Linq;
using System.Reflection;
using System.Text;

using Microsoft.CodeAnalysis.VisualBasic;
using Microsoft.CodeAnalysis.VisualBasic.Syntax;

namespace VNC.CodeAnalysis.QualityMetrics.VB
{
    public class LinesOfCode
    {
        public static StringBuilder Check(string sourceCode)
        {
            StringBuilder sb = new StringBuilder();

            var tree = VisualBasicSyntaxTree.ParseText(sourceCode);

            var results = tree.GetRoot()
            .DescendantNodes()
            .Where(t => t.Kind() == SyntaxKind.ClassBlock)
            .Cast<ClassBlockSyntax>()
            .Select(cds =>
               new
               {
                   ClassName = cds.BlockStatement.Identifier, //#1
                   Methods = cds.Members.OfType<MethodBlockSyntax>()
                    .Select(mds =>
                        new
                        {
                            MethodName = ((MethodStatementSyntax)mds.DescendantNodes().First()).Identifier.ValueText, //#2
                            LOC = mds.BlockStatement.SyntaxTree
                            .GetLineSpan(mds.FullSpan).EndLinePosition.Line //#3
                                - mds.BlockStatement.SyntaxTree.GetLineSpan(mds.FullSpan)
                            .StartLinePosition.Line - 3 //#4
                        }
                    )
               }
           );

            foreach (var item in results)
            {
                sb.AppendLine($" Class:{item.ClassName}");

                foreach (var detail in item.Methods)
                {
                    sb.AppendLine($"   {detail.MethodName,-40}   LOC:{detail.LOC,4}");
                }
            }

            return sb;
        }
    }
}

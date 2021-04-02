using System.Linq;
using System.Text;

using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace VNC.CodeAnalysis.QualityMetrics.CS
{
    public class LongParameterList
    {
        public static StringBuilder Check(string sourceCode)
        {
            StringBuilder sb = new StringBuilder();

            var tree = CSharpSyntaxTree.ParseText(sourceCode);

            var results = tree.GetRoot()
            .DescendantNodes()
            .OfType<ClassDeclarationSyntax>()
            .Select(cds =>
           new
           {
               ClassName = cds.Identifier.ValueText, // 1
                           Methods = cds.Members.OfType<MethodDeclarationSyntax>()
           .Select(mds => new
           {
               MethodName = mds.Identifier.ValueText, // 2
               Parameters = mds.ParameterList.Parameters.Count // 3
                       })
           });

            foreach (var item in results)
            {
                sb.AppendLine($" Class:{item.ClassName}");

                foreach (var detail in item.Methods)
                {
                    sb.AppendLine($"   {detail.MethodName,-40}   Parameters:{detail.Parameters, 4}");
                }
            }

            return sb;
        }
    }
}

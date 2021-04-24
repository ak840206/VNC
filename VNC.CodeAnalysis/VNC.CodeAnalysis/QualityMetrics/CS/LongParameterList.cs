using System.Linq;
using System.Text;

using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace VNC.CodeAnalysis.QualityMetrics.CS
{
    public class LongParameterList : CodeCheckBase
    {
        public static StringBuilder Check(string sourceCode, CodeCheckOptions options)
        {
            StringBuilder sb = new StringBuilder();

            var tree = CSharpSyntaxTree.ParseText(sourceCode);

            var results = tree.GetRoot().DescendantNodes()
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

            var limit = options.ParameterCount;

            if (results.Count() > 0)
            {
                foreach (var item in results)
                {
                    foreach (var method in item.Methods)
                    {
                        if (method.Parameters > limit)
                        {
                            sb.AppendLine($"Has Long (> {limit}) Parameter List");
                            sb.AppendLine($"  Class: {item.ClassName, -20}  Method: {method.MethodName, -20}   Parameters: {method.Parameters,2}");
                        }
                    }
                }
            }

            return sb;
        }
    }
}

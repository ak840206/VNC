using System.Linq;
using System.Text;

using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace VNC.CodeAnalysis.DesignMetrics.CS
{
    public class TooManyParametersOnGenericTypes
    {
        public static StringBuilder Check(string sourceCode)
        {
            StringBuilder sb = new StringBuilder();

            var tree = CSharpSyntaxTree.ParseText(sourceCode); // 1

            var results = tree.GetRoot()
            .DescendantNodes()
            .OfType<MethodDeclarationSyntax>()
            .Select(mds => new
            {
                Name = mds.Identifier.ValueText,
                Arity = mds.Arity
            })
            .Where(mds => mds.Arity > 2);
            //.Dump("Generic Methods with lots of generic attribute");

            foreach (var item in results)
            {
                sb.AppendLine($"  {item.Name} {item.Arity}");
            }

            return sb;
        }
    }
}

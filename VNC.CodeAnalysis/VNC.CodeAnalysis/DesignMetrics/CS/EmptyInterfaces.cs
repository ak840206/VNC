using System.Linq;
using System.Text;

using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace VNC.CodeAnalysis.DesignMetrics.CS
{
    public class EmptyInterfaces
    {
        public static StringBuilder Check(string sourceCode)
        {
            StringBuilder sb = new StringBuilder();

            var tree = CSharpSyntaxTree.ParseText(sourceCode);

            var results = tree.GetRoot()
            .DescendantNodes()
            .OfType<InterfaceDeclarationSyntax>()// 1
            .Select(ids => // 2
            new
            {
                InterfaceName = ids.Identifier.ValueText,
                IsEmpty = ids.Members.Count == 0
            })
            .Where(thisInterface => thisInterface.IsEmpty);// 3
            //.Dump("Empty Interfaces");

            foreach (var item in results)
            {
                sb.AppendLine($"  {item.InterfaceName} {item.IsEmpty}");
            }

            return sb;
        }
    }
}

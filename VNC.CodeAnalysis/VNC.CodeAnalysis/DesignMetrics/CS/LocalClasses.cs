using System.Linq;
using System.Text;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace VNC.CodeAnalysis.DesignMetrics.CS
{
    public class LocalClasses
    {
        public static StringBuilder Check(string sourceCode)
        {
            StringBuilder sb = new StringBuilder();

            var tree = CSharpSyntaxTree.ParseText(sourceCode);

            var results = tree.GetRoot()
            .DescendantNodes()
            .OfType<ClassDeclarationSyntax>()// 1
            .Select(cds =>
           new
           {
               ClassName = cds.Identifier.ValueText,
               LocalClasses = cds.Members
                   .OfType<ClassDeclarationSyntax>()
                   .Select(m => m.Identifier.ValueText)
                   }
            )
            .Where(cds => cds.LocalClasses.Count() >= 1);// 3
            // .Dump("Local Classes");

            foreach (var item in results)
            {
                sb.AppendLine($"  {item.ClassName} {item.LocalClasses.Count()}");
            }

            return sb;
        }
    }
}

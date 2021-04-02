using System.Linq;
using System.Text;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace VNC.CodeAnalysis.PerformanceMetrics.CS
{
    public class DoNotReturnArrayFromProperty
    {
        public static StringBuilder Check(string sourceCode)
        {
            StringBuilder sb = new StringBuilder();

            var tree = CSharpSyntaxTree.ParseText(sourceCode);// 1
            
            var results = tree.GetRoot()
            .DescendantNodes()
            .OfType<ClassDeclarationSyntax>()// 2
            .Select(cds => new // 3
            {
                ClassName = cds.Identifier.ValueText,
                Properties = cds.Members
                    .OfType<PropertyDeclarationSyntax>()
                    .Select(pds => new // 4
                    {
                        PropertyName = pds.Identifier.ValueText,
                        PropertyType = pds.Type.ToFullString()
                    .Trim()
                    })
            })
            .Where(cds => cds.Properties // 5
            .Any(p => p.PropertyType.Contains("[")));
            //.Dump("Properties returning an array");

            foreach (var item in results)
            {
                sb.AppendLine($"  {item.ClassName}");

                foreach (var prop in item.Properties)
                {
                    sb.AppendLine($"  {prop.PropertyName} {prop.PropertyType}");
                }
            }

            return sb;
        }
    }
}

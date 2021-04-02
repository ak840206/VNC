using System.Linq;
using System.Text;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace VNC.CodeAnalysis.PerformanceMetrics.CS
{
    public class ValueTypesShouldOverrideEqualsAndGetHashCode
    {
        public static StringBuilder Check(string sourceCode)
        {
            StringBuilder sb = new StringBuilder();

            var tree = CSharpSyntaxTree.ParseText(sourceCode); // 1

            var results = tree.GetRoot()
            .DescendantNodes()
            .OfType<StructDeclarationSyntax>()// 2
            .Select(sds => new // 3
            {
                StructName = sds.Identifier.ValueText,
                //Flag if “Equals” is overridden
                OverridenEquals =
            sds.Members
            .OfType<MethodDeclarationSyntax>()
            .FirstOrDefault(m => m.Identifier
            .ValueText == "Equals"
            && m.Modifiers.Any(mo =>
            mo.ValueText == "override")) != null,
                //Flag if “GetHashCode” is overridden
                OverridenGetHashCode =
            sds.Members
            .OfType<MethodDeclarationSyntax>()
            .FirstOrDefault(m => m.Identifier
            .ValueText == "GetHashCode"
            && m.Modifiers.Any(mo =>
            mo.ValueText == "override")) != null
            })
            .Where(sds => !sds.OverridenEquals
            || !sds.OverridenGetHashCode);// 4
            //            .Dump("Defaulter Structs");

            foreach (var item in results)
            {
                sb.AppendLine($"  {item.StructName} {item.OverridenEquals} {item.OverridenGetHashCode }");
            }

            return sb;
        }
    }
}

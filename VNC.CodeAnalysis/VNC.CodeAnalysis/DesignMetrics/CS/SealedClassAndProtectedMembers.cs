using System.Linq;
using System.Text;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace VNC.CodeAnalysis.DesignMetrics.CS
{
    public class SealedClassAndProtectedMembers
    {
        public static StringBuilder Check(string sourceCode)
        {
            StringBuilder sb = new StringBuilder();

            var tree = CSharpSyntaxTree.ParseText(sourceCode);

            var results = tree.GetRoot()
            .DescendantNodes()
            .OfType<ClassDeclarationSyntax>()
            .Where(cds => cds.Modifiers
            .Any(m => m.ValueText == "sealed")) //#1
            .Select
            (
            cds => //#2
            new
            {
                ClassName = cds.Identifier.ValueText,
                ProtectedMembers =
                cds.Members
                .OfType<MethodDeclarationSyntax>()
                .Where(mds =>
                mds.Modifiers
                .Any(m => m.ValueText ==
                "protected"))
                .Select(mds => mds.Identifier
                .ValueText)
            }
            )
            .Where(cds => cds.ProtectedMembers.Count() > 0);// 3
            //.Dump("CA1047 Defaulters");

            foreach (var item in results)
            {
                sb.AppendLine($"  {item.ClassName} {item.ProtectedMembers.Count()}");
            }

            return sb;
        }
    }
}

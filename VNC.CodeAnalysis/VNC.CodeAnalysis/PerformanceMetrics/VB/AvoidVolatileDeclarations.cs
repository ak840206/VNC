using System.Reflection;
using System.Text;

using Microsoft.CodeAnalysis.VisualBasic;

namespace VNC.CodeAnalysis.PerformanceMetrics.VB
{
    public class AvoidVolatileDeclarations
    {
        public static StringBuilder Check(string sourceCode)
        {
            StringBuilder sb = new StringBuilder();

            var tree = VisualBasicSyntaxTree.ParseText(sourceCode);
            //            tree.GetRoot()
            //            .DescendantNodes()
            //            .OfType<FieldDeclarationSyntax>()//#2
            //            .Where(vds => vds.Modifiers
            //            .Any(m => m.ValueText == "volatile"))//#3
            //            .Select(vds => new //#4
            //{
            //                ClassName = vds.Ancestors()
            //            .OfType<ClassDeclarationSyntax>()
            //            .First()?.Identifier.ValueText,
            //                VolatileDeclaration = vds.ToFullString()
            //            })
            //            .Dump();

            sb.AppendLine(MethodBase.GetCurrentMethod().DeclaringType
                + "." + MethodBase.GetCurrentMethod().Name
                + " Not Implemented Yet");

            return sb;
        }
    }
}

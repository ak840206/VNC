using System.Reflection;
using System.Text;

using Microsoft.CodeAnalysis.VisualBasic;

namespace VNC.CodeAnalysis.DesignMetrics.VB
{
    public class LocalClasses
    {
        public static StringBuilder Check(string sourceCode)
        {
            StringBuilder sb = new StringBuilder();

            var tree = VisualBasicSyntaxTree.ParseText(sourceCode);
            // tree
            // .GetRoot()
            // .DescendantNodes()
            // .OfType<ClassDeclarationSyntax>()//#1
            // .Select(cds =>
            //new
            // {
            //     ClassName = cds.Identifier.ValueText,
            //     LocalClasses = cds.Members
            //.OfType<ClassDeclarationSyntax>()
            //.Select(m => m.Identifier.ValueText)
            // }
            // )
            // .Where(cds => cds.LocalClasses.Count() >= 1)//#3
            // .Dump("Local Classes");

            sb.AppendLine(MethodBase.GetCurrentMethod().DeclaringType
                + "." + MethodBase.GetCurrentMethod().Name
                + " Not Implemented Yet");

            return sb;
        }
    }
}

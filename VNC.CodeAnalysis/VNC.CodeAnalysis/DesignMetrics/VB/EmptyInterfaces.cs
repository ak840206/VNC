using System.Reflection;
using System.Text;

using Microsoft.CodeAnalysis.VisualBasic;

namespace VNC.CodeAnalysis.DesignMetrics.VB
{
    public class EmptyInterfaces
    {
        public static StringBuilder Check(string sourceCode)
        {
            StringBuilder sb = new StringBuilder();

            var tree = VisualBasicSyntaxTree.ParseText(sourceCode);
            //tree.GetRoot()
            //.DescendantNodes()
            //.OfType<InterfaceDeclarationSyntax>()//#1
            //.Select(ids => //#2
            //new
            //{
            //    InterfaceName = ids.Identifier.ValueText,
            //    IsEmpty = ids.Members.Count == 0
            //})
            //.Where(thisInterface => thisInterface.IsEmpty)//#3
            //.Dump("Empty Interfaces");

            sb.AppendLine(MethodBase.GetCurrentMethod().DeclaringType
                + "." + MethodBase.GetCurrentMethod().Name
                + " Not Implemented Yet");

            return sb;
        }
    }
}

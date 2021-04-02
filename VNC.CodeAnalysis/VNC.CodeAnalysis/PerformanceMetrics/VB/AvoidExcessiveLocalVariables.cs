using System.Reflection;
using System.Text;

using Microsoft.CodeAnalysis.VisualBasic;

namespace VNC.CodeAnalysis.PerformanceMetrics.VB
{
    public class AvoidExcessiveLocalVariables
    {
        public static StringBuilder Check(string sourceCode)
        {
            StringBuilder sb = new StringBuilder();

            var tree = VisualBasicSyntaxTree.ParseText(sourceCode);
            //                                            //The recommended value is 64;
            //                                            //But for deomonstration purpose it is changed to 4
            //const int MAX_LOCALS_ALLOWED = 4; //#2
            //tree.GetRoot()
            //.DescendantNodes()
            //.OfType<MethodDeclarationSyntax>() //#3
            //.Where(mds =>
            //mds.Body.Statements
            //.OfType<LocalDeclarationStatementSyntax>()
            //.Count() >= MAX_LOCALS_ALLOWED) //#4
            //.Select(mds => mds.Identifier.ValueText)//#5
            //.Dump("Methods with many local variable declarations");

            sb.AppendLine(MethodBase.GetCurrentMethod().DeclaringType
                + "." + MethodBase.GetCurrentMethod().Name
                + " Not Implemented Yet");

            return sb;
        }
    }
}

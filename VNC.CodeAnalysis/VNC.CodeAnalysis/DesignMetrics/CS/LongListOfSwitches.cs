using System.Linq;
using System.Text;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace VNC.CodeAnalysis.DesignMetrics.CS
{
    public class LongListOfSwitches
    {
        public static StringBuilder Check(string sourceCode)
        {
            StringBuilder sb = new StringBuilder();

            var tree = CSharpSyntaxTree.ParseText(sourceCode);// 1

            var results = tree.GetRoot()
            .DescendantNodes()
            .OfType<MethodDeclarationSyntax>() // 2
            .Select(mds => // 3
            new
            {
                Name = mds.Identifier.ValueText,
                Switches = mds.Body
                .DescendantNodes()
                .OfType<SwitchStatementSyntax>()
                .Select(st =>
                new
                {
                    SwitchStatement = st.ToFullString(),
                    //52
                    //How many switch sections are there
                    //in the switch statement.
                    Sections = st.Sections.Count
                })
                .OrderByDescending(st => st.Sections)// 4
            });
            //.Dump("Switch statements per functions");

            foreach (var item in results)
            {
                sb.AppendLine($"  {item.Name} {item.Switches.Count()}");
            }

            return sb;
        }
    }
}

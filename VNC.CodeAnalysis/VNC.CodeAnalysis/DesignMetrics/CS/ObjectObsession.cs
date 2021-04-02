using System.Linq;
using System.Text;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace VNC.CodeAnalysis.DesignMetrics.CS
{
    public class ObjectObsession
    {
        public static StringBuilder Check(string sourceCode)
        {
            StringBuilder sb = new StringBuilder();

            var tree = CSharpSyntaxTree.ParseText(sourceCode);

            var results = tree.GetRoot()
            .DescendantNodes()
            .OfType<MethodDeclarationSyntax>() // 1
            .Where(thisMethod => // 2
                                 //This method is not an event declaration
            !thisMethod.IsEventDeclaration()
            && thisMethod.TakesOrReturnsObject())
            .Select(thisMethod =>
            thisMethod.Identifier.ValueText); // 3

            if (results.Count() > 0)
            {
                sb.AppendLine(@"Methods that aren't event handlers but takes or returns objects");

                foreach (var item in results)
                {
                    sb.AppendLine($"  {item}");
                }
            }

            return sb;
        }
    }

    public static class MethoDeclEx
    {
        public static bool IsEventDeclaration
        (this MethodDeclarationSyntax mds)
        {
            return mds.ParameterList
            .Parameters
            .Any(p =>
            p.Type.ToFullString().EndsWith("EventArgs"));
        }
        public static bool TakesOrReturnsObject
        (this MethodDeclarationSyntax mds)
        {
            return mds.ParameterList
            .Parameters
            .Any(p =>
            //If any parameter is of type object
            p.Type.ToFullString().ToLower()
            .Trim() == "object")
            //if return type is of type object
            || mds.ReturnType.ToFullString()
            .ToLower().Trim() == "object";
        }
    }
}

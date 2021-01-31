using System.Collections.Generic;

using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace VNC.CodeAnalysis.SyntaxWalkers.CS
{
    public class MethodDeclarationNames : CSharpSyntaxWalker
    {
        public List<string> MethodNames;

        public override void VisitMethodDeclaration(MethodDeclarationSyntax node)
        {
            //MethodNames.Add(node.ToString());
            MethodNames.Add(node.Identifier.ToString());

            base.VisitMethodDeclaration(node);
        }
    }
}

using System;

using Microsoft.CodeAnalysis.CSharp;

namespace VNC.CodeAnalysis.SyntaxWalkers.CS
{
    public class SyntaxNode : VNCCSSyntaxWalkerBase
    {
        public override void Visit(Microsoft.CodeAnalysis.SyntaxNode node)
        {
            if (_targetPatternRegEx.Match(node.ToString()).Success)
            {
                Messages.AppendLine(String.Format("{0} >{1}<",
                    GetNodeContext((CSharpSyntaxNode)node),
                    node.ToString()));
            }

            base.Visit(node);
        }
    }
}

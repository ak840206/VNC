using Microsoft.CodeAnalysis.VisualBasic.Syntax;

namespace VNC.CodeAnalysis.SyntaxWalkers.VB
{
    public class NamespaceStatement : VNCVBTypedSyntaxWalkerBase
    {
        public override void VisitNamespaceStatement(NamespaceStatementSyntax node)
        {
            if (_targetPatternRegEx.Match(node.Name.ToString()).Success)
            {
                RecordMatchAndContext(node, BlockType.None);
            }

            base.VisitNamespaceStatement(node);
        }
    }
}

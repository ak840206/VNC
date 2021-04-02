using Microsoft.CodeAnalysis.VisualBasic.Syntax;

namespace VNC.CodeAnalysis.SyntaxWalkers.VB
{
    public class HandlesClause : VNCVBTypedSyntaxWalkerBase
    {
        public override void VisitHandlesClause(HandlesClauseSyntax node)
        {
            if (_targetPatternRegEx.Match(node.Events.ToString()).Success)
            {
                RecordMatchAndContext(node, BlockType.None);
            }

            base.VisitHandlesClause(node);
        }
    }
}

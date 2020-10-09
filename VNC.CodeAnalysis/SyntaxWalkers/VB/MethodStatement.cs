using Microsoft.CodeAnalysis.VisualBasic.Syntax;

namespace VNC.CodeAnalysis.SyntaxWalkers.VB
{
    public class MethodStatement : VNCVBTypedSyntaxWalkerBase
    {
        public override void VisitMethodStatement(MethodStatementSyntax node)
        {
            if (_targetPatternRegEx.Match(node.Identifier.ToString()).Success)
            {
                RecordMatchAndContext(node, BlockType.None);
            }

            base.VisitMethodStatement(node);
        }
    }
}

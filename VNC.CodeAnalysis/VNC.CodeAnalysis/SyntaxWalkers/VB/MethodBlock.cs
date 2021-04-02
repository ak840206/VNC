using Microsoft.CodeAnalysis.VisualBasic.Syntax;

namespace VNC.CodeAnalysis.SyntaxWalkers.VB
{
    public class MethodBlock : VNCVBTypedSyntaxWalkerBase
    {
        public override void VisitMethodBlock(MethodBlockSyntax node)
        {
            if (_targetPatternRegEx.Match(node.SubOrFunctionStatement.Identifier.ToString()).Success)
            {
                RecordMatchAndContext(node, BlockType.MethodBlock);
            }

            base.VisitMethodBlock(node);
        }
    }
}

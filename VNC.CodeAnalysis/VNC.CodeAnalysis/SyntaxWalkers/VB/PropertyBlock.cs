using Microsoft.CodeAnalysis.VisualBasic.Syntax;

namespace VNC.CodeAnalysis.SyntaxWalkers.VB
{
    public class PropertyBlock : VNCVBTypedSyntaxWalkerBase
    {
        public override void VisitPropertyBlock(PropertyBlockSyntax node)
        {
            if (_targetPatternRegEx.Match(node.PropertyStatement.Identifier.ToString()).Success)
            {
                if (FilterByType(node.PropertyStatement.AsClause))
                {
                    RecordMatchAndContext(node, BlockType.None);
                }
            }

            base.VisitPropertyBlock(node);
        }
    }
}

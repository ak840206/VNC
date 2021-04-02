using Microsoft.CodeAnalysis.VisualBasic.Syntax;

namespace VNC.CodeAnalysis.SyntaxWalkers.VB
{
    public class ParameterList : VNCVBSyntaxWalkerBase
    {
        public override void VisitParameterList(ParameterListSyntax node)
        {
            if (_targetPatternRegEx.Match(node.ToString()).Success)
            {
                RecordMatchAndContext(node, BlockType.None);
            }

            base.VisitParameterList(node);
        }
    }
}

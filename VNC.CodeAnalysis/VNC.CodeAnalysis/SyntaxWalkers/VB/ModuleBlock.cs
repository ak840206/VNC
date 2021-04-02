using Microsoft.CodeAnalysis.VisualBasic.Syntax;

namespace VNC.CodeAnalysis.SyntaxWalkers.VB
{
    public class ModuleBlock : VNCVBTypedSyntaxWalkerBase
    {
        public override void VisitModuleBlock(ModuleBlockSyntax node)
        {
            if (_targetPatternRegEx.Match(node.ModuleStatement.Identifier.ToString()).Success)
            {
                RecordMatchAndContext(node, BlockType.ModuleBlock);
            }

            base.VisitModuleBlock(node);
        }
    }
}

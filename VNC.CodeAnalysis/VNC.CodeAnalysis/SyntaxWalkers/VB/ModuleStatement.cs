using Microsoft.CodeAnalysis.VisualBasic.Syntax;

namespace VNC.CodeAnalysis.SyntaxWalkers.VB
{
    public class ModuleStatement : VNCVBTypedSyntaxWalkerBase
    {
        public override void VisitModuleStatement(ModuleStatementSyntax node)
        {
            if (_targetPatternRegEx.Match(node.Identifier.ToString()).Success)
            {
                RecordMatchAndContext(node, BlockType.None);
            }

            base.VisitModuleStatement(node);
        }
    }
}

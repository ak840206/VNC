using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace VNC.CodeAnalysis.SyntaxWalkers.CS
{
    public class StructDeclaration : VNCCSTypedSyntaxWalkerBase
    {
        public override void VisitStructDeclaration(StructDeclarationSyntax node)
        {
            if (_targetPatternRegEx.Match(node.Identifier.ToString()).Success)
            {
                RecordMatchAndContext(node, BlockType.StructureBlock);
            }

            base.VisitStructDeclaration(node);
        }
    }
}

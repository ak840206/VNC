using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace VNC.CodeAnalysis.SyntaxWalkers.CS
{
    public class PropertyDeclaration : VNCCSTypedSyntaxWalkerBase
    {
        public override void VisitPropertyDeclaration(PropertyDeclarationSyntax node)
        {
            if (_targetPatternRegEx.Match(node.Identifier.ToString()).Success)
            {
                RecordMatchAndContext(node, BlockType.None);
            }

            base.VisitPropertyDeclaration(node);
        }
    }
}

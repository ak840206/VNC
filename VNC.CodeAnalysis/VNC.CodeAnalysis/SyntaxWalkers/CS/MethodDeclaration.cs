using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace VNC.CodeAnalysis.SyntaxWalkers.CS
{
    public class MethodDeclaration : VNCCSTypedSyntaxWalkerBase
    {
        public override void VisitMethodDeclaration(MethodDeclarationSyntax node)
        {
            if (_targetPatternRegEx.Match(node.Identifier.ToString()).Success)
            {
                RecordMatchAndContext(node, BlockType.None);
            }

            base.VisitMethodDeclaration(node);
        }
    }
}

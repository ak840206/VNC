using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace VNC.CodeAnalysis.SyntaxWalkers.CS
{
    public class NamespaceDeclaration : VNCCSTypedSyntaxWalkerBase
    {
        public override void VisitNamespaceDeclaration(NamespaceDeclarationSyntax node)
        {
            long startTicks = Log.APPLICATIONSERVICES("Enter", Common.LOG_CATEGORY);

            if (_targetPatternRegEx.Match(node.Name.ToString()).Success)
            {
                RecordMatchAndContext(node, BlockType.NamespaceBlock);
                //RecordMatch(node, BlockType.NamespaceBlock);
            }

            base.VisitNamespaceDeclaration(node);

            Log.APPLICATIONSERVICES("Exit", Common.LOG_CATEGORY, startTicks);
        }
    }
}

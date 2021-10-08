using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace VNC.CodeAnalysis.SyntaxWalkers.CS
{
    public class PropertyDeclaration : VNCCSTypedSyntaxWalkerBase
    {
        public override void VisitPropertyDeclaration(PropertyDeclarationSyntax node)
        {
            long startTicks = Log.APPLICATIONSERVICES("Enter", Common.LOG_CATEGORY);

            if (_targetPatternRegEx.Match(node.Identifier.ToString()).Success)
            {
                RecordMatchAndContext(node, BlockType.None);
            }

            base.VisitPropertyDeclaration(node);

            Log.APPLICATIONSERVICES("Exit", Common.LOG_CATEGORY, startTicks);
        }
    }
}

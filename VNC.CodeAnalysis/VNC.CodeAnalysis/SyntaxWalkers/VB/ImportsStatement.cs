using Microsoft.CodeAnalysis.VisualBasic.Syntax;

namespace VNC.CodeAnalysis.SyntaxWalkers.VB
{
    public class ImportsStatement : VNCVBTypedSyntaxWalkerBase
    {
        public override void VisitImportsStatement(ImportsStatementSyntax node)
        {
            long startTicks = Log.APPLICATIONSERVICES("Enter", Common.LOG_CATEGORY);

            if (_targetPatternRegEx.Match(node.ImportsClauses.ToString()).Success)
            {
                RecordMatchAndContext(node, BlockType.None);
            }

            base.VisitImportsStatement(node);

            Log.APPLICATIONSERVICES("Exit", Common.LOG_CATEGORY, startTicks);
        }
    }
}

using Microsoft.CodeAnalysis.VisualBasic.Syntax;

namespace VNC.CodeAnalysis.SyntaxWalkers.VB
{
    public class ImportsStatement : VNCVBTypedSyntaxWalkerBase
    {
        public override void VisitImportsStatement(ImportsStatementSyntax node)
        {
            long startTicks = Log.Trace15("Enter", Common.LOG_CATEGORY);

            if (_targetPatternRegEx.Match(node.ImportsClauses.ToString()).Success)
            {
                //var imports = node.Parent.DescendantNodes().OfType<ImportsStatementSyntax>();

                RecordMatchAndContext(node, BlockType.None);
            }

            base.VisitImportsStatement(node);

            Log.Trace15("Exit", Common.LOG_CATEGORY, startTicks);
        }
    }
}

using Microsoft.CodeAnalysis.VisualBasic.Syntax;

namespace VNC.CodeAnalysis.SyntaxWalkers.VB
{
    public class ImportsStatement : VNCVBTypedSyntaxWalkerBase
    {
        public override void VisitImportsStatement(ImportsStatementSyntax node)
        {
            long startTicks = VNC.Log.Trace15("Start", Common.LOG_APPNAME);

            if (_targetPatternRegEx.Match(node.ImportsClauses.ToString()).Success)
            {
                //var imports = node.Parent.DescendantNodes().OfType<ImportsStatementSyntax>();

                RecordMatchAndContext(node, BlockType.None);
            }

            base.VisitImportsStatement(node);

            VNC.Log.Trace15("Exit", Common.LOG_APPNAME, startTicks);
        }
    }
}

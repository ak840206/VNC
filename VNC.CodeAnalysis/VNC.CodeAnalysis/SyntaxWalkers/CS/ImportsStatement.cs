using Microsoft.CodeAnalysis.CSharp.Syntax;

// NOTE(crhodes)
// I have no idea how Log.Trace15 works without a using VNC

namespace VNC.CodeAnalysis.SyntaxWalkers.CS
{
    public class ImportsStatement : VNCCSTypedSyntaxWalkerBase
    {
        public override void VisitUsingStatement(UsingStatementSyntax node)
        {
            long startTicks = Log.Trace15("Start", Common.LOG_APPNAME);

            if (_targetPatternRegEx.Match(node.UsingKeyword.ToString()).Success)
            {
                //var imports = node.Parent.DescendantNodes().OfType<ImportsStatementSyntax>();

                RecordMatchAndContext(node, BlockType.None);
            }

            base.VisitUsingStatement(node);

            Log.Trace15("Exit", Common.LOG_APPNAME, startTicks);
        }
    }
}

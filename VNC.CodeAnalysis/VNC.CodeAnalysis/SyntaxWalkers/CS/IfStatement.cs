using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace VNC.CodeAnalysis.SyntaxWalkers.CS
{
    public class IfStatement : VNCCSTypedSyntaxWalkerBase
    {
        public override void VisitIfStatement(IfStatementSyntax node)
        {
            long startTicks = Log.APPLICATIONSERVICES("Enter", Common.LOG_CATEGORY);

            // TODO(crhodes)
            // What do we want to match on?  Full Statement or only Condition?

            if (_targetPatternRegEx.Match(node.Condition.ToString()).Success)
            {
                RecordMatchAndContext(node, BlockType.IfBlock);
            }

            base.VisitIfStatement(node);

            Log.APPLICATIONSERVICES("Exit", Common.LOG_CATEGORY, startTicks);
        }
    }
}

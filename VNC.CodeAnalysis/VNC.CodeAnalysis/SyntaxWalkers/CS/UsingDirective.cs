using Microsoft.CodeAnalysis.CSharp.Syntax;

// NOTE(crhodes)
// I have no idea how Log.APPLICATIONSERVICES works without a using VNC

namespace VNC.CodeAnalysis.SyntaxWalkers.CS
{
    public class UsingDirective : VNCCSTypedSyntaxWalkerBase
    {
        public override void VisitUsingDirective(UsingDirectiveSyntax node)
        {
            long startTicks = Log.APPLICATIONSERVICES("Enter", Common.LOG_CATEGORY);

            var ns = node.ToString();

            if (_targetPatternRegEx.Match(node.ToString()).Success)
            {
                RecordMatchAndContext(node, BlockType.None);
            }

            base.VisitUsingDirective(node);

            Log.APPLICATIONSERVICES("Exit", Common.LOG_CATEGORY, startTicks);
        }
    }
}

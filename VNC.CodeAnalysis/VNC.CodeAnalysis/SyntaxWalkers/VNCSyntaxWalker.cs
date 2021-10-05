using System.Text;
using System.Text.RegularExpressions;

using Microsoft.CodeAnalysis;

namespace VNC.CodeAnalysis.SyntaxWalkers
{
    public class VNCSyntaxWalker : SyntaxWalker
    {
        public StringBuilder Messages = new StringBuilder();
        public StringBuilder WalkerNode = new StringBuilder();
        public StringBuilder WalkerToken = new StringBuilder();
        public StringBuilder WalkerTrivia = new StringBuilder();
        public StringBuilder WalkerStructuredTrivia = new StringBuilder();
 
        public CodeAnalysisOptions _configurationOptions = new CodeAnalysisOptions();

        private string _targetPattern;
        internal Regex _targetPatternRegEx;

        public ASCIIEncoding asciiEncoding = new System.Text.ASCIIEncoding();
  
        public string TargetPattern
        {
            get => _targetPattern;

            set
            {
                _targetPattern = value;
                _targetPatternRegEx = Helpers.Common.InitializeRegEx(_targetPattern, Messages, RegexOptions.IgnoreCase);
            }
        }

        public VNCSyntaxWalker(SyntaxWalkerDepth depth = SyntaxWalkerDepth.Node) : base(depth)
        {

        }

        public override void Visit(Microsoft.CodeAnalysis.SyntaxNode node)
        {
            if (_targetPatternRegEx.Match(node.ToString()).Success)
            {
                Messages.AppendLine(
                    $"N {node.GetType().Name, -40}({node.RawKind})" +
                    $"[{node.Span.Start, 4}..{node.Span.End, 4}] [{node.FullSpan.Start, 4}..{node.FullSpan.End, 4}]");
            }

            base.Visit(node);
        }

        protected override void VisitToken(SyntaxToken token)
        {
            if (_targetPatternRegEx.Match(token.ToString()).Success)
            {
                Messages.AppendLine(
                    $"T {token.GetType().Name, -40}({token.RawKind})" +
                    $"[{token.Span.Start, 4}..{token.Span.End, 4}] [{token.FullSpan.Start, 4}..{token.FullSpan.End, 4}] >{token}<");
            }

            base.VisitToken(token);
        }

        protected override void VisitTrivia(SyntaxTrivia trivia)
        {
            if (_targetPatternRegEx.Match(trivia.ToString()).Success)
            {
                Messages.AppendLine(
                    $"t {trivia.GetType().Name, -40}({trivia.RawKind})" +
                    $"[{trivia.Span.Start, 4}..{trivia.Span.End, 4}] [{trivia.FullSpan.Start, 4}..{trivia.FullSpan.End, 4}] >{trivia}<");
            }

            base.VisitTrivia(trivia);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.CodeAnalysis;

using VNC.CodeAnalysis.SyntaxWalkers;

namespace VNC.CodeAnalysis
{
    public class RewriteFileCommandConfiguration
    {
        public SyntaxTree SyntaxTree;
        public string FilePath;

        public StringBuilder Results;

        public WalkerPattern WalkerPattern;

        public string TargetPattern;
        public string ReplacementPattern;
        public string Comment;

        public CodeAnalysisOptions CodeAnalysisOptions;

        public Dictionary<string, Int32> Replacements;
        public Dictionary<string, Int32> CRCMatchesToString;
        public Dictionary<string, Int32> CRCMatchesToFullString;
    }
}

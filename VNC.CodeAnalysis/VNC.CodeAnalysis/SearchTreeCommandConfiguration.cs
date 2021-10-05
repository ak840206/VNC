using System;
using System.Collections.Generic;

using Microsoft.CodeAnalysis;

using VNC.CodeAnalysis.SyntaxWalkers;

namespace VNC.CodeAnalysis
{
    public class SearchTreeCommandConfiguration
    {
        public SyntaxTree SyntaxTree;
        public SyntaxLanguage Language;

        public WalkerPattern WalkerPattern;

        public CodeAnalysisOptions CodeAnalysisOptions;

        public Dictionary<string, Int32> Matches;
        public Dictionary<string, Int32> CRCMatchesToString;
        public Dictionary<string, Int32> CRCMatchesToFullString;
    }
}

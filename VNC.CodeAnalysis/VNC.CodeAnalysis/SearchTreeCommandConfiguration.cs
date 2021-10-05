using System;
using System.Collections.Generic;

using Microsoft.CodeAnalysis;

namespace VNC.CodeAnalysis
{
    public class SearchTreeCommandConfiguration
    {
        public SyntaxTree SyntaxTree;
        public SyntaxLanguage Language;

        //public StringBuilder Results;

        public WalkerPattern WalkerPattern;

        public CodeAnalysisOptions CodeAnalysisOptions;

        public Dictionary<string, Int32> Matches;
        public Dictionary<string, Int32> CRCMatchesToString;
        public Dictionary<string, Int32> CRCMatchesToFullString;
    }
}

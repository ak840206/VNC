using System;
using System.Collections.Generic;

using VNC.CodeAnalysis.SyntaxWalkers;

namespace VNC.CodeAnalysis
{
    public class SearchFileCommandConfiguration
    {
        public string FilePath;

        public WalkerPattern WalkerPattern;

        public CodeAnalysisOptions CodeAnalysisOptions;

        public Dictionary<string, Int32> Matches;
        public Dictionary<string, Int32> CRCMatchesToString;
        public Dictionary<string, Int32> CRCMatchesToFullString;
    }

    public class CopyOfSearchFileCommandConfiguration
    {
        public string FilePath;

        public WalkerPattern WalkerPattern;

        public CodeAnalysisOptions CodeAnalysisOptions;

        public Dictionary<string, Int32> Matches;
        public Dictionary<string, Int32> CRCMatchesToString;
        public Dictionary<string, Int32> CRCMatchesToFullString;
    }
}

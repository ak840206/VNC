using System;
using System.Collections.Generic;
using System.Text;

namespace VNC.CodeAnalysis
{
    public class SearchFileCommandConfiguration
    {
        public string FilePath;

        public StringBuilder Results;

        public WalkerPattern WalkerPattern;
        //public Boolean UseRegEx;
        //public string RegEx;

        public CodeAnalysisOptions CodeAnalysisOptions;

        public Dictionary<string, Int32> Matches;
        public Dictionary<string, Int32> CRCMatchesToString;
        public Dictionary<string, Int32> CRCMatchesToFullString;
    }
}

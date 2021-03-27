using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.CodeAnalysis;

namespace VNC.CodeAnalysis
{
    public class SearchTreeCommandConfiguration
    {
        public SyntaxTree SyntaxTree;
        public SyntaxLanguage Language;

        public StringBuilder Results;

        public Boolean UseRegEx;
        public string RegEx;

        public CodeAnalysisOptions ConfigurationOptions;

        public Dictionary<string, Int32> Matches;
        public Dictionary<string, Int32> CRCMatchesToString;
        public Dictionary<string, Int32> CRCMatchesToFullString;
    }

    public enum SyntaxLanguage : Int16
    {
        CS = 0,
        VB = 1
    }
}

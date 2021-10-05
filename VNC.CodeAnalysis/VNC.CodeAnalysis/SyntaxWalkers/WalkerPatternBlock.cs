using System;

namespace VNC.CodeAnalysis.SyntaxWalkers
{
    public class WalkerPatternBlock : WalkerPattern
    {
        public WalkerPatternBlock(
            string controlHeader, 
            string buttonContent, 
            string commandParameter,
            string regExLabel,
            string displayBlockLabel)
            : base(controlHeader, buttonContent, commandParameter, regExLabel)
        {
            DisplayBlockLabel = displayBlockLabel;
        }

        public WalkerPatternBlock(
            string controlHeader, 
            string buttonContent, 
            string commandParameter, 
            string regExLabel, 
            bool useRegEx, 
            string regEx,
            string displayBlockLabel)
            : base(controlHeader, buttonContent, commandParameter, regExLabel, useRegEx, regEx)
        {
            DisplayBlockLabel = displayBlockLabel;
        }

        public Boolean DisplayBlock
        {
            get;
            set;
        }

        public string DisplayBlockLabel
        { 
            get;
            set;
        }

        // Used for Structures

        public Boolean DisplayFields
        {
            get;
            set;
        }
    }
}

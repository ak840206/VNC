using System;

namespace VNC.CodeAnalysis.SyntaxWalkers
{
    public class WalkerPattern
    {
        public WalkerPattern(
            string controlHeader, 
            string buttonContent, 
            string commandParameter, 
            string regExLabel)
        {
            ControlHeader = controlHeader;
            ButtonContent = buttonContent;
            CommandParameter = commandParameter;
            RegExLabel = regExLabel;
            UseRegEx = false;
            RegEx = ".*";
        }

        public WalkerPattern(
            string controlHeader, 
            string buttonContent, 
            string commandParameter, 
            string regExLabel, 
            bool useRegEx, 
            string regEx)
        {
            ControlHeader = controlHeader;
            ButtonContent = buttonContent;
            CommandParameter = commandParameter;
            RegExLabel = regExLabel;
            UseRegEx = useRegEx;
            RegEx = regEx;
        }

        public string ControlHeader { get; set; }

        public string ButtonContent { get; set; }

        public string CommandParameter { get; set; }

        public Boolean UseRegEx { get; set; }

        public string RegExLabel { get; set; }

        public string RegEx { get; set; }
    }
}

using System;

namespace VNC.CodeAnalysis
{
    public class WalkerPattern
    {
        public WalkerPattern(string controlHeader, string buttonContent, string commandParameter, string regExLabel)
        {
            ControlHeader = controlHeader;
            ButtonContent = buttonContent;
            CommandParameter = commandParameter;
            RegExLabel = regExLabel;
            UseRegEx = false;
            RegEx = ".*";
        }

        public WalkerPattern(string controlHeader, string buttonContent, string commandParameter, string regExLabel, bool useRegEx, string regEx)
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

    public class BlockWalkerPattern : WalkerPattern
    {
        public BlockWalkerPattern(string controlHeader, string buttonContent, string commandParameter, string regExLabel,
            string displayBlockLabel)
            : base(controlHeader, buttonContent, commandParameter, regExLabel)
        {
            DisplayBlockLabel = displayBlockLabel;
        }

        public BlockWalkerPattern(string controlHeader, string buttonContent, string commandParameter, string regExLabel, bool useRegEx, string regEx,
            string displayBlockLabel)
            : base(controlHeader, buttonContent, commandParameter, regExLabel, useRegEx, regEx)
        {
            DisplayBlockLabel = displayBlockLabel;
        }

        public Boolean DisplayBlock { get; set; }

        public string DisplayBlockLabel { get; set; }
    }
}

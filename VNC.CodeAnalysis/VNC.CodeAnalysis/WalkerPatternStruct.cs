using System;

namespace VNC.CodeAnalysis
{
    public class WalkerPatternStruct : WalkerPattern
    {
        public WalkerPatternStruct(string controlHeader, string buttonContent, string commandParameter, string regExLabel)
            //string displayBlockLabel)
            : base(controlHeader, buttonContent, commandParameter, regExLabel)
        {
            //DisplayBlockLabel = displayBlockLabel;
            UseRegExFields = false;
            RegExFields = ".*";
        }

        public WalkerPatternStruct(string controlHeader, string buttonContent, string commandParameter, string regExLabel, bool useRegEx, string regEx)
            //string displayBlockLabel)
            : base(controlHeader, buttonContent, commandParameter, regExLabel, useRegEx, regEx)
        {
            //DisplayBlockLabel = displayBlockLabel;
            UseRegExFields = false;
            RegExFields = ".*";
        }

        //public Boolean DisplayBlock
        //{
        //    get;
        //    set;
        //}

        //public string DisplayBlockLabel
        //{
        //    get;
        //    set;
        //}

        // Used for Structures

        public Boolean DisplayFields
        {
            get;
            set;
        }

        public Boolean UseRegExFields { get; set; }

        public string RegExFields { get; set; }
    }
}

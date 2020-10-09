using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

using Microsoft.CodeAnalysis.CSharp;

using VNCCA = VNC.CodeAnalysis;

namespace VNC.CodeAnalysis.SyntaxRewriters.CS
{
    public class VNCCSSyntaxRewriterBase : CSharpSyntaxRewriter
    {
        public StringBuilder Messages;

        public ConfigurationOptions _configurationOptions = new ConfigurationOptions();

        public Boolean PerformedReplacement = false;

        internal string _comment;
        internal SyntaxNode.FieldDeclarationLocation _declarationLocation;
        internal Boolean _commentOutOnly = true;

        private string _targetPattern;
        internal Regex _targetPatternRegEx;

        public Dictionary<string, Int32> Replacements;

         public string TargetPattern
        {
            get => _targetPattern;

            set
            {
                _targetPattern = value;
                _targetPatternRegEx = VNC.CodeAnalysis.Helpers.Common.InitializeRegEx(_targetPattern, Messages, RegexOptions.IgnoreCase);
            }
        }

        public string GetNodeContext(CSharpSyntaxNode node)
        {
            string messageContext = "";

            if (_configurationOptions.ClassOrModuleName)
            {
                messageContext = VNCCA.Helpers.CS.GetContainingContext(node, _configurationOptions);
            }

            if (_configurationOptions.MethodName)
            {
                messageContext += string.Format(" Method:({0, -35})", VNCCA.Helpers.CS.GetContainingMethodName(node));
            }

            return messageContext;
        }

        public void RecordMatch(string nodeValue)
        {
            Messages.AppendLine(String.Format("{0}", 
                nodeValue));

            if (Replacements.ContainsKey(nodeValue))
            {
                Replacements[nodeValue] += 1;
            }
            else
            {
                Replacements.Add(nodeValue, 1);
            }
        }

        public void RecordMatchAndContext(CSharpSyntaxNode node, string nodeValue)
        {
            Messages.AppendLine(String.Format("{0} {1}",
                VNCCA.Helpers.CS.GetContainingContext(node, _configurationOptions),
                nodeValue));

            if (Replacements.ContainsKey(nodeValue))
            {
                Replacements[nodeValue] += 1;
            }
            else
            {
                Replacements.Add(nodeValue, 1);
            }
        }

        public void RecordReplacementAndContext(CSharpSyntaxNode node, string oldNodeValue, string newNodeValue)
        {
            Messages.AppendLine(String.Format("{0} From:>{1}<\n   To:>{2}<",
                VNCCA.Helpers.CS.GetContainingContext(node, _configurationOptions),
                oldNodeValue,
                newNodeValue));

            if (Replacements.ContainsKey(oldNodeValue))
            {
                Replacements[oldNodeValue] += 1;
            }
            else
            {
                Replacements.Add(oldNodeValue, 1);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace VNC.CodeAnalysis.Helpers
{
    public class Common
    {
        public static Regex InitializeRegEx(string pattern, StringBuilder messages, RegexOptions options = RegexOptions.None)
        {
            Regex expression;

            try
            {
                expression = new Regex(pattern, options);
            }
            catch (Exception ex)
            {
                messages.AppendLine(string.Format("Error in RegEx >{0}< Error:({1}), using >.*<",
                    pattern, ex.Message));

                expression = new Regex(".*", RegexOptions.IgnoreCase);
            }

            return expression;
        }

        public static StringBuilder InvokeVNCSyntaxWalker(
            SyntaxWalkers.VNCSyntaxWalker walker,
            SearchTreeCommandConfiguration commandConfiguration)
        {
            Int64 startTicks = Log.DOMAINSERVICES("Enter", CodeAnalysis.Common.LOG_CATEGORY);

            StringBuilder results = new StringBuilder();

            walker.Messages = results;

            walker.TargetPattern = commandConfiguration.WalkerPattern.UseRegEx ? commandConfiguration.WalkerPattern.RegEx : ".*";

            walker._configurationOptions = commandConfiguration.CodeAnalysisOptions;

            walker.Visit(commandConfiguration.SyntaxTree.GetRoot());

            if (results.Length > 0)
            {
                commandConfiguration.Results.AppendLine(results.ToString());
            }

            Log.DOMAINSERVICES("Exit", CodeAnalysis.Common.LOG_CATEGORY, startTicks);

            return commandConfiguration.Results;
        }
    }
}

using System;

using Microsoft.CodeAnalysis;

namespace VNC.CodeAnalysis
{
    public class CodeCheckOptions
    {
        #region General Options

        public bool DisplayClassOrModuleName { get; set; } = false;

        public bool DisplayMethodName { get; set; } = false;

        public bool DisplayContainingMethodBlock { get; set; }

        #endregion

        #region Design Options

        #endregion

        #region Performance Options

        #endregion

        #region Quality Options

        public int ParameterCount { get; set; } = 3;

        public int VariableCount { get; set; } = 3;

        #endregion
    }
}

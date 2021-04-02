using System;

using Microsoft.CodeAnalysis;

namespace VNC.CodeAnalysis
{
    public enum InfoType : Int16
    {
        Names = 0,
        DataType = 1
    }

    public class CodeAnalysisOptions
    {
        public SyntaxWalkerDepth SyntaxWalkerDepth { get; set; } = SyntaxWalkerDepth.StructuredTrivia;

        #region Output Options

        public SyntaxNode.AdditionalNodes AdditionalNodeAnalysis { get; set; } = SyntaxNode.AdditionalNodes.None;

        public bool DisplayNodeKind { get; set; } = false;

        public bool DisplayNodeValue { get; set; } = false;

        public bool DisplayFormattedOutput { get; set; } = false;

        public bool DisplayNodeParent { get; set; } = false;

        public bool DisplayStatementBlock { get; set; } = false;

        public bool IncludeStatementBlockInCRC { get; set; } = false;

        public bool DisplaySourceLocation { get; set; } = false;

        public bool DisplayCRC32 { get; set; } = false;

        public bool ShowAnalysisCRC { get; set; } = false;

        public bool ReplaceCRLFInNodeName { get; set; } = false;

        public bool DisplayClassOrModuleName { get; set; } = false;

        public bool DisplayMethodName { get; set; } = false;

         public bool DisplayContainingMethodBlock { get; set; }    
        
        public bool DisplayContainingBlock { get; set; }

        public bool InTryBlock { get; set; } = false;

        public bool InWhileBlock { get; set; } = false;

        public bool InForBlock { get; set; } = false;

        public bool InIfBlock { get; set; } = false;

        public bool AllTypes { get; set; } = false;

        public bool Boolean { get; set; } = false;

        public bool Byte { get; set; } = false;

        public bool DataTable { get; set; } = false;

        public bool Date { get; set; } = false;

        public bool DateTime { get; set; } = false;

        public bool Int16 { get; set; } = false;

        public bool Int32 { get; set; } = false;

        public bool Int64 { get; set; } = false;

        public bool Integer { get; set; } = false;

        public bool Long { get; set; } = false;

        public bool Single { get; set; } = false;

        public bool String { get; set; } = false;

        public bool OtherTypes { get; set; } = false;

        #endregion

        #region Rewriter Options

        public bool AddFileSuffix { get; set; } = false;

        public string FileSuffix { get; set; } = "xxx";

        #endregion

    }
}

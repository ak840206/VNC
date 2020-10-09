using System.ComponentModel;

using VNC.Xaml.Enums;

namespace VNC.CodeAnalysis.SyntaxNode
{
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum AdditionalNodes
    {
        [Description("None")]
        None,
        [Description("Ancestors")]
        Ancestors,
        [Description("AncestorsAndSelf")]
        AncestorsAndSelf,
        [Description("ChildNodes")]
        ChildNodes,
        [Description("ChildNodesAndTokens")]
        ChildNodesAndTokens,
        [Description("ChildTokens")]
        ChildTokens,
        [Description("DescendantNodes")]
        DescendantNodes,
        [Description("DescendantNodesAndSelf")]
        DescendantNodesAndSelf,
        [Description("DescendantNodesAndTokens")]
        DescendantNodesAndTokens,
        [Description("DescendantNodesAndTokensAndSelf")]
        DescendantNodesAndTokensAndSelf,
        [Description("DescendantTokens")]
        DescendantTokens,
        [Description("DescendantTrivia")]
        DescendantTrivia
    }
}

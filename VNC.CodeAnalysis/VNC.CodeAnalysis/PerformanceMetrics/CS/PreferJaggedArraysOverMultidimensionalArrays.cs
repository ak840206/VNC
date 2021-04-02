using System.Linq;
using System.Text;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace VNC.CodeAnalysis.PerformanceMetrics.CS
{
    public class PreferJaggedArraysOverMultidimensionalArrays
    {
        public static StringBuilder Check(string sourceCode)
        {
            StringBuilder sb = new StringBuilder();

            var tree = CSharpSyntaxTree.ParseText(sourceCode);// 1

            var results = tree.GetRoot()
            .DescendantNodes()
            .OfType<ArrayRankSpecifierSyntax>()// 2
            .Select(ats => new // 3
            {
                BelongsTo = ats.Ancestors()
            .OfType<ClassDeclarationSyntax>()
            .First()?.Identifier.ValueText,
                ArrayType = ats.ToFullString()
            })
            .Where(ats => ats.ArrayType.Contains(",")); // 4
            //.Dump("Classes with multi-dimentional array");

            foreach (var item in results)
            {
                sb.AppendLine($"  {item.ArrayType} {item.BelongsTo}");
            }

            return sb;
        }
    }
}

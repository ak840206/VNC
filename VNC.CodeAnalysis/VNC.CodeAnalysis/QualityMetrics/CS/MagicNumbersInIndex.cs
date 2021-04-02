﻿using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace VNC.CodeAnalysis.QualityMetrics.CS
{
    public class MagicNumbersInIndex
    {
        public static StringBuilder Check(string sourceCode)
        {
            StringBuilder sb = new StringBuilder();

            var tree = CSharpSyntaxTree.ParseText(sourceCode);

            var results = tree.GetRoot()
            .DescendantNodes()
            .OfType<BracketedArgumentListSyntax>()
            .Select(bals =>
            new
            {
                Method = bals.Ancestors()
                    .OfType<MethodDeclarationSyntax>()
                    .First()
                    .Identifier.ValueText,
                Indices = bals.Arguments
                    .Select(a => a.GetText()
                    .Container
                    .CurrentText
                    .ToString())
                    })
            //Find defaulter methods that use magic indices
            .Where(bals => bals.Indices
                .Any(i => Regex.Match(i, "[0-9]+").Success)
            );
            //.Dump("Methods using magic indices");

            foreach (var item in results)
            {
                sb.AppendLine($"   {item.Method,-40}");

                foreach (var index in item.Indices)
                {
                    sb.AppendLine($"   {index}");
                }
            }

            return sb;
        }
    }
}

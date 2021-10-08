using System;
using System.Linq;
using System.Reflection;
using System.Text;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace VNC.CodeAnalysis.QualityMetrics.CS
{
    public class ControlFlags
    {
        public static StringBuilder Check(string sourceCode)
        {
            StringBuilder sb = new StringBuilder();

            //Find all boolean variables in the class
            //Find all if statements that solely rely on those
            //Find the methods in which these if statements are

            var tree = CSharpSyntaxTree.ParseText(sourceCode);

            var bools = tree.GetRoot().DescendantNodes()
            .Where(t => t.Kind() == SyntaxKind.VariableDeclaration
                && t.ToFullString().Trim().StartsWith("bool"))
            .Select(t =>
                new
                {
                    VariableName = t.ToFullString().Trim().Split(' ')[1],
                    Class = t.Ancestors()
                       .Where
                       (x => x.Kind() == SyntaxKind.ClassDeclaration)
                       .Cast<ClassDeclarationSyntax>()
                       .First().Identifier.ValueText
                })
                .Select(t => t.VariableName);// 1

            if (bools is null || bools.Count() == 0)
            {
                return sb;
            }

            var results = tree.GetRoot().DescendantNodes()
            .Where(t => t.Kind() == SyntaxKind.IfStatement)
            .Cast<IfStatementSyntax>()
            .Select(ifs =>
               new
               {
                   ClassName = ifs.Ancestors()
                    .OfType<ClassDeclarationSyntax>().First()
                    .Identifier.ValueText,
                   // TODO(crhodes)
                   // See if can just reach back once for Method
                   MethodName = ifs.Ancestors()
                    .OfType<MethodDeclarationSyntax>().First()
                    .Identifier.ValueText,
                   MethodLine = tree.GetLineSpan(ifs.Ancestors()
                    .OfType<MethodDeclarationSyntax>().First().Span)
                    .StartLinePosition.Line + 1,
                   If = ifs.ToFullString(), // 2
                    Condition = ifs.Condition.ToFullString(),// 3
                    Line = ifs.SyntaxTree
                       .GetLineSpan(ifs.FullSpan)
                       .StartLinePosition.Line + 1// 4
                })
                .Where(ifs => ifs.Condition.Split(
                    new string[] { "&&", "||", "==", "(", ")", " " }, StringSplitOptions.RemoveEmptyEntries)
                    //If a control flag is used,
                    .Any(c => bools.Contains(c)
                    //it can also be used in a negative way. skipping "!"
                    || bools.Contains(c.Substring(1))));    // 5

            // TODO(crhodes)
            // Needs output control work

            int resultCount = results.Count();

            if (resultCount > 0)
            {
                sb.AppendLine($"Has ControlFlags ({resultCount})");

                //foreach (var item in bools)
                //{
                //    sb.AppendLine($"{item}");
                //}

                foreach (var item in results)
                {
                    sb.AppendLine($"  Line:{item.MethodLine,-5} - ClassName:{item.ClassName}  MethodName:{item.MethodName}()");

                    sb.AppendLine($"   Condition: {item.Condition}  Line:{item.Line}");

                    sb.AppendLine($"     {item.If}");
                }
            }

            return sb;
        }
    }
}

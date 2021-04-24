using System;
using System.Linq;
using System.Reflection;
using System.Text;

using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace VNC.CodeAnalysis.QualityMetrics.CS
{
    public class HungarianVariableNames
    {
        public static StringBuilder Check(string sourceCode)
        {
            StringBuilder sb = new StringBuilder();

            Func<string, string, bool> IsHungarian = (varName, typeName) =>
            {
                bool result = false;
                string upperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                if (typeName == "bool"
                        && varName.StartsWith("b")
                        && upperCase.Contains(varName[1]))
                    result = true;
                if (typeName == "char"
                        && varName.StartsWith("c")
                        && upperCase.Contains(varName[1]))
                    result = true;
                if (typeName == "string"
                        && varName.StartsWith("str")
                        && upperCase.Contains(varName[3]))
                    result = true;
                if (typeName == "int"
                        && varName.StartsWith("int")
                        && upperCase.Contains(varName[3]))
                    result = true;
                if (typeName == "int"
                        && varName.StartsWith("i")
                        && upperCase.Contains(varName[1]))
                    result = true;
                if (typeName == "float"
                        && varName.StartsWith("f")
                        && upperCase.Contains(varName[1]))
                    result = true;
                if (typeName == "short"
                        && varName.StartsWith("s")
                        && upperCase.Contains(varName[1]))
                    result = true;
                if (typeName == "long"
                        && varName.StartsWith("l")
                        && upperCase.Contains(varName[1]))
                    result = true;
                return result;
            };

            var tree = CSharpSyntaxTree.ParseText(sourceCode);

            // TODO(crhodes)
            // Look at Long Parameter List.  Is it useful to have class / method??

            var results = tree.GetRoot().DescendantNodes()
            .Where(t => t.Kind() == SyntaxKind.FieldDeclaration)
            .Cast<FieldDeclarationSyntax>()
            .Select(fds =>
               new
               {
                   // 2
                   TypeName = fds.Declaration.Type.ToFullString().Trim(),
                   // 3
                   VarName = fds.Declaration.Variables
               .Select(v => v.Identifier.Value).First()
               })
                // 4
                .Where(fds => IsHungarian(fds.VarName.ToString(),
               fds.TypeName.ToString()));

            int resultCount = results.Count();

            if (resultCount > 0)
            {
                sb.AppendLine("Has Hungarian Variable Names");

                foreach (var item in results)
                {
                    sb.AppendLine($"  Type: {item.TypeName,-40}  Var:{item.VarName,-30}");
                }
            }

            return sb;
        }
    }
}

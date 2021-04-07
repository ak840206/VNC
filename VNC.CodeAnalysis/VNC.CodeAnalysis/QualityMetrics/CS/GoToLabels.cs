using System.Linq;
using System.Text;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace VNC.CodeAnalysis.QualityMetrics.CS
{
    public class GoToLabels
    {
        public static StringBuilder Check(string sourceCode)
        {
            StringBuilder sb = new StringBuilder();

            var tree = CSharpSyntaxTree.ParseText(sourceCode);

            //var results = tree.GetRoot().DescendantNodes()
            //    .Where(t => t.Kind() == SyntaxKind.ClassDeclaration)
            //    .Cast<ClassDeclarationSyntax>()
            //    .Select(cds =>
            //    new
            //    {
            //        ClassName = cds.Identifier.ValueText,
            //        Methods = cds.Members
            //            .Where(m => m.Kind() == SyntaxKind.MethodDeclaration)
            //            .Cast<MethodDeclarationSyntax>()
            //            .Select(mds =>
            //            new
            //            {
            //                MethodName = mds.Identifier.ValueText,
            //                GoTos = mds.Body.DescendantNodes().Where(n => n.Kind() == SyntaxKind.GotoStatement),
            //                HasGoto = CSharpSyntaxTree.ParseText(mds.ToString())
            //                    .GetRoot()
            //                    .DescendantTokens()
            //                    .Any(st => st.Kind() == SyntaxKind.GotoKeyword)
            //            })
            //            .Where(mds => mds.HasGoto)
            //            //.Select(mds => mds.MethodName)
            //    });


            //int resultCount = results.Select(r => r.Methods.Count()).Sum();

            //int gotoCount = results.Select(r => r.Methods.Where(m => m.HasGoto == true)).Count();

            //if (resultCount > 0)
            //{
            //    sb.AppendLine("Has Goto Labels");

            //    foreach (var item in results)
            //    {
            //        sb.AppendLine($"  Class: {item.ClassName}  {resultCount}  {gotoCount}");

            //        foreach (var method in item.Methods)
            //        {
            //            sb.AppendLine($"    Method: {method}");

            //            foreach (var gt in method.GoTos)
            //            {
            //                sb.AppendLine($"      {gt}");
            //            }
            //        }
            //    }
            //}

            var results = tree.GetRoot().DescendantNodes()
            .Where(t => t.Kind() == SyntaxKind.MethodDeclaration)
            .Cast<MethodDeclarationSyntax>()    // 1 - Get Methods
                .Select(mds =>
                new
                {
                    MethodName = mds.Identifier.ValueText,
                    GoTos = mds.Body.DescendantNodes().Where(n => n.Kind() == SyntaxKind.GotoStatement 
                                                                || n.Kind() == SyntaxKind.GotoCaseStatement),
                    HasGoto = CSharpSyntaxTree.ParseText(mds.ToString())
                        .GetRoot()
                        .DescendantTokens()
                        .Any(st => st.Kind() == SyntaxKind.GotoKeyword)
                })
                .Where(mds => mds.HasGoto);
                    //.Select(mds => mds.MethodName)
                //});

            //int resultCount = results.Select(r => r.GoTos.Count()).Sum();

            //if (resultCount > 0)
            //{
                sb.AppendLine("Has Goto Labels");

                foreach (var item in results)
                {
                    sb.AppendLine($"  Method: {item.MethodName}");

                    foreach (var g in item.GoTos)
                    {
                        sb.AppendLine($"    Method: {g}");
                    }
                }
            //}

            return sb;
        }
    }
}

using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace VNC.CodeAnalysis.QualityMetrics.CS
{
    public static class LotsOfFields
    {
        public static StringBuilder Check(string sourceCode, CodeCheckOptions options)
        {
            StringBuilder sb = new StringBuilder();

            SyntaxTree tree = CSharpSyntaxTree.ParseText(sourceCode);

            var classes = tree.GetRoot().DescendantNodes()
            .Where(d => d.Kind() == SyntaxKind.ClassDeclaration)
            .Cast<ClassDeclarationSyntax>();

            var classes2 = tree.GetRoot().DescendantNodes().OfType<ClassDeclarationSyntax>();

            sb.AppendLine("--------------------------------------------------------------------------------");
            sb.AppendLine($"classes {classes.Count()}");
            sb.AppendLine("--------------------------------------------------------------------------------");

            foreach (var item in classes)
            {
                sb.AppendLine($"  {item.Identifier.ValueText}");
            }

            sb.AppendLine("================================================================================");
            sb.AppendLine($"classes2 {classes2.Count()}");
            sb.AppendLine("================================================================================");

            foreach (var item in classes2)
            {
                sb.AppendLine($"  {item.Identifier.ValueText}");
            }

            //var foo = tree.GetRoot().DescendantNodes().OfType<ClassDeclarationSyntax>()
            //    .Select(mds => mds.ChildNodes().OfType<FieldDeclarationSyntax>());

            //var foo2 = tree.GetRoot().DescendantNodes().OfType<ClassDeclarationSyntax>()
            //    .Select(mds => mds.ChildNodes().OfType<FieldDeclarationSyntax>()
            //    .Select (fds => 
            //    new
            //    {
            //        AAA = fds.GetFirstToken().ValueText,
            //        BBB = fds.Kind()
            //    })
            //    );

            //sb.AppendLine("foo");

            //foreach (var item in foo)
            //{
            //    sb.AppendLine($"item: {item} Type: {item.GetType()}");

            //    foreach (var itemitem in item)
            //    {
            //        sb.AppendLine($"  itemitem: {itemitem} Type: {itemitem.GetType()} Kind: {itemitem.Kind()}");
            //    }
            //}

            //sb.AppendLine($"{foo2}");

            //foreach (var item in foo2)
            //{
            //    sb.AppendLine($"{item} Type: {item.GetType()}");
            //}

            //if (classes.Count() > 0)
            //{
            //    var results = classes.DescendantNo.Select(z =>
            //    new
            //    {
            //        ClassName = z.Identifier.ValueText, // 2
            //        NBLocal = z.St.Statements 
            //        .Count(x => x.Kind() == SyntaxKind.LocalDeclarationStatement) // 3
            //    })
            //    .OrderByDescending(x => x.NBLocal)
            //    .ToList();

            //    var limit = options.VariableCount;

            //    foreach (var item in results)
            //    {
            //        if (item.NBLocal > limit)
            //        {
            //            sb.AppendLine($"Has Lots (> {limit}) of Local Variables");

            //            sb.AppendLine($"  Method: {item.MethodName, -20} Variables: {item.NBLocal, 2}");
            //        }
            //    }
            //}

            return sb;
        }
    }
}

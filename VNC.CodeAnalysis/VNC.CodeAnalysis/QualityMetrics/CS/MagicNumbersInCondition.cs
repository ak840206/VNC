using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;

namespace VNC.CodeAnalysis.QualityMetrics.CS
{
    public class MagicNumbersInCondition
    {
        public static StringBuilder Check(string sourceCode)
        {
            StringBuilder sb = new StringBuilder();

            var tree = CSharpSyntaxTree.ParseText(sourceCode);

            var operators = new List<SyntaxKind>()
            {
                SyntaxKind.GreaterThanToken,
                SyntaxKind.GreaterThanEqualsToken,
                SyntaxKind.LessThanEqualsToken,
                SyntaxKind.LessThanToken,
                SyntaxKind.EqualsEqualsToken,
                SyntaxKind.LessThanLessThanEqualsToken,
                SyntaxKind.GreaterThanGreaterThanEqualsToken
            };

            var results = tree.GetRoot().DescendantNodes()
            .Where(t => t.Kind() == SyntaxKind.ClassDeclaration)
            .Cast<ClassDeclarationSyntax>()
            .Select(t =>
               new
               {
                   Span = t.Span,
                   ClassName = t.Identifier.ValueText, // 1
                   MethodTokens = t.Members
                   .Where(m => m.Kind() == SyntaxKind.MethodDeclaration)
                   .Cast<MethodDeclarationSyntax>()
                   .Select(mds =>
                       new
                       {
                           ClassName1 = t.Identifier.ValueText,
                           Span1 = mds.Span,
                           MethodName1 = mds.Identifier.ValueText,
                           Tokens1 = CSharpSyntaxTree.ParseText(mds.ToFullString())
                               .GetRoot().DescendantTokens()
                               .Select(c => c.Kind())
                       })
                       .Select(w =>
                          new
                          {
                              ClassName2 = w.ClassName1,
                              Span2 = w.Span1,
                              MethodName2 = w.MethodName1, // 2
                              Tokens2 = w.Tokens1,
                              Toks2 = w.Tokens1.Zip(w.Tokens1.Skip(1), (a, b) =>
                               operators.Any(op => op == a)
                               && b == SyntaxKind.NumericLiteralToken) // 3
                          })
                           .Where(w => w.Toks2.Any(to => to == true)) // 4
                                                                      //.Select(w => w.MethodName)
                           .Select(w =>
                                new
                                {
                                    ClassName3 = w.ClassName2,
                                    MethodName3 = w.MethodName2,
                                    Span3 = w.Span2,                                   
                                    Tok = w.Toks2.Where(to => to == true),
                                    Foo = CSharpSyntaxTree.ParseText(w.Toks2.Where(to => to == true).ToString())
                                        //w.Toks2.Where(to => to == true).ToString()).GetRoot().Ancestors())
                                })
               });

            var resultsX = tree.GetRoot().DescendantNodes()
            .Where(t => t.Kind() == SyntaxKind.ClassDeclaration)
            .Cast<ClassDeclarationSyntax>()
            .Select(t =>
               new
               {
                   Span = t.Span,
                   ClassName = t.Identifier.ValueText, // 1
                               MethodTokens = t.Members
                   .Where(m => m.Kind() == SyntaxKind.MethodDeclaration)
                   .Cast<MethodDeclarationSyntax>()
                   .Select(mds =>
                       new
                       {
                           ClassName1 = t.Identifier.ValueText,
                           Span1 = mds.Span,
                           MethodName1 = mds.Identifier.ValueText,
                           Tokens1 = CSharpSyntaxTree.ParseText(mds.ToFullString())
                               .GetRoot().DescendantTokens()
                               .Select(c => c.Kind())
                       })
                       .Select(w =>
                          new
                          {
                              ClassName2 = w.ClassName1,
                              Span2 = w.Span1,
                              MethodName2 = w.MethodName1, // 2
                                          Tokens2 = w.Tokens1,
                              Toks2 = w.Tokens1.Zip(w.Tokens1.Skip(1), (a, b) =>
                               operators.Any(op => op == a)
                               && b == SyntaxKind.NumericLiteralToken) // 3
                           })
                           .Where(w => w.Toks2.Any(to => to == true)) // 4
               });


            foreach (var item in resultsX)
            {
                foreach (var method in item.MethodTokens)
                {
                    sb.AppendLine($"     ClassName:{method.ClassName2} MethodName: {method.MethodName2} ({method.Span2.Start,4}-{method.Span2.End,4})");
                }
            }

            // HACK(crhodes)
            // Tried to do in chunks but not clear how to leverage anonymous types being returned
            // This worked

            //var results = tree.GetRoot().DescendantNodes()
            //.Where(t => t.Kind() == SyntaxKind.ClassDeclaration)
            //.Cast<ClassDeclarationSyntax>()
            //.Select(t =>
            //   new
            //   {
            //       Span = t.Span,
            //       ClassName = t.Identifier.ValueText, // 1
            //       MethodTokens = t.Members
            //       .Where(m => m.Kind() == SyntaxKind.MethodDeclaration)
            //       .Cast<MethodDeclarationSyntax>()
            //   });

            //Type X = results.GetType();

            // This does not as cannot cast to MethodDeclarationSyntax

            //var magic = results.Cast<MethodDeclarationSyntax>()
            //    .Select(mds =>
            //           new
            //           {
            //               Span1 = mds.Span,
            //               MethodName1 = mds.Identifier.ValueText,
            //               Tokens1 = CSharpSyntaxTree.ParseText(mds.ToFullString())
            //                   .GetRoot()
            //                   .DescendantTokens()
            //                   .Select(c => c.Kind())
            //           });

            //var magic = results
            //    .Select(mds =>
            //           new
            //           {
            //               Span1 = mds.Span,
            //               MethodName1 = ((MethodDeclarationSyntax)mds).Identifier.ValueText,
            //               Tokens1 = CSharpSyntaxTree.ParseText(mds.ToFullString())
            //                   .GetRoot()
            //                   .DescendantTokens()
            //                   .Select(c => c.Kind())
            //           });

            int resultCount = results.Select(r => r.MethodTokens.Count()).Sum();

            int tokensCount = 0;

            foreach (var item in results)
            {
                foreach (var mt in item.MethodTokens)
                {
                    tokensCount += mt.Tok.Where(w => w == true).Count();
                }
            }

            sb.AppendLine($"ResultCount: {resultCount} TokensCount: {tokensCount}");

            if (resultCount > 0)
            {
                sb.AppendLine($"Has Magic Numbers in Condition ({resultCount})");
                foreach (var item in results)
                {
                    //sb.AppendLine($"  ClassName: {item.ClassName, -30} ({item.Span.Start,4}-{item.Span.End,-4})");

                    foreach (var method in item.MethodTokens)
                    {
                        sb.AppendLine($"     ClassName:{method.ClassName3} MethodName: {method.MethodName3} ({method.Span3.Start,4}-{method.Span3.End,4})");
                        sb.AppendLine($"         {method.Tok} {method.Foo}");

                        sb.AppendLine($"  Inside Foo");
                        var xxx = method.Foo.GetRoot().Ancestors();

                        foreach (var a in method.Foo.GetRoot().Ancestors())
                        {
                            sb.AppendLine($"                   {a}");
                        }

                        //sb.AppendLine($"\nTokens\n");

                        //foreach (var tk2 in method.Tokens2)
                        //{
                        //    sb.Append($"{tk2}");
                        //}

                        //sb.AppendLine($"\nToks\n");

                        //foreach (var tk2 in method.Toks2)
                        //{
                        //    sb.Append($"{tk2}");
                        //}
                    }

                    //foreach (var m in magic)
                    //{
                    //    sb.AppendLine($"{m.MethodName1}  {m.Span1}");

                    //    foreach (var t in m.Tokens1)
                    //    {
                    //        sb.AppendLine($"{t}");
                    //    }
                    //}
                }
            }

            //if (resultCount > 0)
            //{
            //    sb.AppendLine($"Has Magic Numbers in Condition ({resultCount})");

            //    foreach (var item in results)
            //    {
            //        sb.AppendLine($"  ClassName: {item.ClassName}");

            //        foreach (var token in item.MethodTokens)
            //        {

            //            sb.AppendLine($"    Token: {token.MethodName2} {token.Toks2} {token.Span2}");

            //            foreach (var t in token.Toks2)
            //            {
            //                sb.AppendLine($"      T: {t}");
            //            }

            //            foreach (var t2 in token.Tokens2)
            //            {
            //                sb.AppendLine($"      T2: {t2}");
            //            }
            //        }

            //        // TODO(crhodes)
            //        // Needs work.

            //    }
            //}

            return sb;
        }
    }
}

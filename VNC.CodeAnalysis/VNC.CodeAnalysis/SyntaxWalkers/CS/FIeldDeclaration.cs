using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace VNC.CodeAnalysis.SyntaxWalkers.CS
{
    public class FieldDeclaration : VNCCSTypedSyntaxWalkerBase
    {
        public FieldDeclaration(CodeAnalysis.SyntaxNode.FieldDeclarationLocation declarationLocation)
        {
            _declarationLocation = declarationLocation;
        }

        public override void VisitFieldDeclaration(FieldDeclarationSyntax node)
        {
            long startTicks = Log.APPLICATIONSERVICES("Enter", Common.LOG_CATEGORY);

            // Verify we have the correct context for the Field Declaration

            var parent = node.Parent;

            switch (_declarationLocation)
            {
                case VNC.CodeAnalysis.SyntaxNode.FieldDeclarationLocation.Class:
                    if (parent.Kind() != SyntaxKind.ClassDeclaration)
                    {
                        return;
                    }
                    break;

                case VNC.CodeAnalysis.SyntaxNode.FieldDeclarationLocation.Structure:
                    if (parent.Kind() != SyntaxKind.StructDeclaration)
                    {
                        return;
                    }
                    break;
            }

            if (_targetPatternRegEx.Match(node.ToString()).Success)
            {
                RecordMatchAndContext(node, BlockType.None);
            }

            // TODO(crhodes)
            // VB version has more code

            //foreach (var declarator in node.Declarators)
            //{
            //    if (_targetPatternRegEx.Match(declarator.Names.First().Identifier.ToString()).Success)
            //    {
            //        if (FilterByType(node.Declarators.First().AsClause))
            //        {
            //            RecordMatchAndContext(node, BlockType.None);
            //        }
            //    }
            //}

            base.VisitFieldDeclaration(node);

            Log.APPLICATIONSERVICES("Exit", Common.LOG_CATEGORY, startTicks);
        }
    }
}

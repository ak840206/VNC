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

            var parent = node.Parent;
            var parentKind = node.Parent.RawKind;

            if (_targetPatternRegEx.Match(node.ToString()).Success)
            {
                RecordMatchAndContext(node, BlockType.None);
            }

            // TODO(crhodes)
            // VB version has more code

            //// Verify we have the correct context for the Field Declaration

            //var parent = node.Parent;

            //switch (_declarationLocation)
            //{
            //    case VNC.CodeAnalysis.SyntaxNode.FieldDeclarationLocation.Class:
            //        if (parent.Kind() != SyntaxKind.ClassBlock)
            //        {
            //            return;
            //        }
            //        break;

            //    case VNC.CodeAnalysis.SyntaxNode.FieldDeclarationLocation.Module:
            //        if (parent.Kind() != SyntaxKind.ModuleBlock)
            //        {
            //            return;
            //        }
            //        break;

            //    case VNC.CodeAnalysis.SyntaxNode.FieldDeclarationLocation.Structure:
            //        if (parent.Kind() != SyntaxKind.StructureBlock)
            //        {
            //            return;
            //        }
            //        break;
            //}

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

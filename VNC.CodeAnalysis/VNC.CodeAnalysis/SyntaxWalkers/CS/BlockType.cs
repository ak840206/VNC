using System;

namespace VNC.CodeAnalysis.SyntaxWalkers.CS
{
    // NOTE(crhodes)
    // CSharp does not have Module Blocks.
    // In CSharp this is really Namespace, Class, Method, Block

    public enum BlockType : Int16
    {
        None = 0,
        NamespaceBlock = 1,
        ClassBlock = 2,
        ModuleBlock = 3,
        MethodBlock = 4,
        StructureBlock = 5,
        IfBlock = 6
    }
}
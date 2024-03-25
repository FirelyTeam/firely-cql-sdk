namespace Hl7.Cql.Compiler;

internal interface IBuilderNode
{
    IBuilderNode? OuterBuilder { get; }
    BuilderDebuggerInfo BuilderDebuggerInfo { get; }
}
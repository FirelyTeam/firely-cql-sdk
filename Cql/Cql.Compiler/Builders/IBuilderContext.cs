namespace Hl7.Cql.Compiler.Builders;

internal interface IBuilderNode
{
    IBuilderNode? OuterBuilder { get; }
    BuilderDebuggerInfo? BuilderDebuggerInfo { get; }
}
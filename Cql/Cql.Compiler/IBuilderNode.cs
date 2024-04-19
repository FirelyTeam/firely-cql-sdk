namespace Hl7.Cql.Compiler.Builders;

internal interface IBuilderContext
{
    IBuilderContext? OuterBuilderContext { get; }
    BuilderContextDebuggerInfo? DebuggerInfo { get; }
}
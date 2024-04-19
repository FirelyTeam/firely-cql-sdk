namespace Hl7.Cql.Compiler;

internal interface IBuilderContext
{
    IBuilderContext? OuterBuilderContext { get; }
    BuilderContextDebuggerInfo? DebuggerInfo { get; }
}
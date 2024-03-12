namespace Hl7.Cql.Compiler;

internal interface IBuilderContext
{
    IBuilderContext? OuterContext { get; }
    BuilderContextInfo ContextInfo { get; }
}
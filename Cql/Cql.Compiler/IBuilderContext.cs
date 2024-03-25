namespace Hl7.Cql.Compiler;

internal interface IContextualExpressionBuilder
{
    IContextualExpressionBuilder? OuterContext { get; }
    BuilderContextInfo ContextInfo { get; }
}
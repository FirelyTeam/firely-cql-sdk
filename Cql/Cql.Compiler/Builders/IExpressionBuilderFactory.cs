namespace Hl7.Cql.Compiler.Builders;

internal interface IExpressionBuilderFactory
{
    ExpressionBuilder New(ILibraryExpressionBuilderContext libCtx);
}
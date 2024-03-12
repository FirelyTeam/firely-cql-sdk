using System;
using System.Linq;

namespace Hl7.Cql.Compiler;

internal class ExpressionBuildingException : Exception
{
    private const string DefaultMessage = "Exception occurred during expression building.";

    private IBuilderContext? Context { get; }

    public ExpressionBuildingException(
        IBuilderContext? context = null, 
        string? message = null, 
        Exception? innerException = null)
        : base(message ?? DefaultMessage, innerException) =>
        Context = context;

    public override string Message
    {
        get
        {
            var message = Context is null
                ? base.Message
                : $$"""
                    {{base.Message}} 
                        Expression Path:{{
                        string.Concat(
                            from context in Context.SelfAndAncestorContexts().Reverse()
                            select $@"
    * {context.ContextInfo}"
                        )
                    }}
                    """;
            return message;
        }
    }
}

internal static class ExpressionBuildingExceptionExtensions
{
    public static ExpressionBuildingException WithContext(
        this Exception e,
        IBuilderContext ctx) =>
        ctx.NewExpressionBuildingException(innerException: e);
}
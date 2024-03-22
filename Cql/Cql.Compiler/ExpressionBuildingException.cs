using System;
using System.Linq;
using Hl7.Cql.Abstractions.Exceptions;

namespace Hl7.Cql.Compiler;

internal readonly record struct ExpressionBuildingError : ICqlError
{
    private const string DefaultMessage = "Exception occurred during expression building.";

    public ExpressionBuildingError(
        IBuilderContext? context = null,
        string? message = null)
    {
        Context = context;
        Message = message ?? DefaultMessage;
    }

    public IBuilderContext? Context { get; }

    private string Message { get; }

    public string GetMessage()
    {
        var message = Context is null
            ? Message
            : $$"""
                {{Message}}{{Context.GetExpressionPath()}}
                """;
        return message;
    }
}

internal static class ExpressionBuildingErrorExtensions
{
    public static CqlException WithContext(
        this Exception e,
        IBuilderContext ctx) =>
        ctx.NewExpressionBuildingException(innerException: e);
}
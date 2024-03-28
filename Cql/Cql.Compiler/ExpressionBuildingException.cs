using System;
using System.Linq;
using Hl7.Cql.Abstractions.Exceptions;

namespace Hl7.Cql.Compiler;

internal readonly record struct ExpressionBuildingError : ICqlError
{
    private const string DefaultMessage = "Exception occurred during expression building.";

    public ExpressionBuildingError(
        IBuilderNode? context = null,
        string? message = null)
    {
        Context = context;
        Message = message ?? DefaultMessage;
    }

    public IBuilderNode? Context { get; }

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
        IBuilderNode ctx) =>
        ctx.NewExpressionBuildingException(innerException: e);
}
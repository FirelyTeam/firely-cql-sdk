﻿using System;
using System.Linq;
using Hl7.Cql.Abstractions;

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
                {{Message}}
                    Expression Path:{{string.Concat(
                        from context in Context.SelfAndAncestorContexts().Reverse()
                        select $@"
    * {context.ContextInfo}"
                    )}}
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
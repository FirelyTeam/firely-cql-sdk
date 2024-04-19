using Hl7.Cql.Abstractions.Exceptions;
using Hl7.Cql.Compiler.Builders;
using Hl7.Cql.Elm;
using System;

namespace Hl7.Cql.Compiler;


internal readonly record struct LibraryIncludeDefUnresolvedError(Library Library, IncludeDef IncludeDef) : ILibraryError
{
    public string GetMessage() => $"Library has an include definition that did not resolve to a target library in the set. Library Identifier: '{Library}', IncludeDef: '{IncludeDef}'";
}

internal readonly record struct LibraryIdentifierMustBeUniqueError(Library Library) : ILibraryError
{
    public string GetMessage() => $"Library did not have a unique name and version in the set. Duplicate Identifier: '{Library}'";
}

internal readonly record struct LibraryAliasUnresolvedError(Library Library) : ILibraryError
{
    public string GetMessage() => $"Could not resolve alias from the Library name and version. Library Identifier: '{Library}'";
}

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
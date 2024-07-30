/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */
using Hl7.Cql.Abstractions.Exceptions;
using Hl7.Cql.Elm;
using System;

namespace Hl7.Cql.Compiler;


internal readonly record struct LibraryIncludeDefUnresolvedError(Library Library, IncludeDef IncludeDef) : ILibraryError
{
    public string GetMessage() => $"Library has an include definition that did not resolve to a target library in the set. Library Identifier: '{Library}', IncludeDef: '{IncludeDef}'";
}

internal readonly record struct LibraryHasDuplicateDefinition(Library Library, IDefinitionElement Def) : ILibraryError
{
    public string GetMessage() => $"Library has multiple {Def.GetType()}s with the same name. Library Identifier: '{Library}', Name: '{Def.Name}'.";
}

internal readonly record struct LibraryDefinitionHasNoName(Library Library, IDefinitionElement Def) : ILibraryError
{
    public string GetMessage() => $"Library has an {Def.GetType()} element without a name. Library Identifier: '{Library}', Name: '{Def.Name}'.";
}

internal readonly record struct LibraryIdentifierMustBeUniqueError(Library Library) : ILibraryError
{
    public string GetMessage() => $"Library did not have a unique name and version in the set. Duplicate Identifier: '{Library}'";
}

internal readonly record struct CouldNotResolveAliasFromTheLibraryNameAndVersionError(Library Library) : ILibraryError
{
    public string GetMessage() => $"Could not resolve alias from the Library name and version. Library Identifier: '{Library}'";
}

internal readonly record struct LibraryAliasUnresolvedError(Library Library, string Alias) : ILibraryError
{
    public string GetMessage() => $"Could not resolve alias in the library. Library Identifier: '{Library}', alias: '{Alias}'.";
}

internal readonly record struct UnresolvedReferenceError(Library Library, IReferenceElement re) : ILibraryError
{
    public string GetMessage() => $"Cannot resolve {re.GetType().Name} with name {re.name}. Library Identifier: '{Library}'.";
}

internal readonly record struct AmbiguousMatch(Library Library, FunctionRef Ref) : ILibraryError
{
    public string GetMessage() => $"FunctionRef '{Ref.name}' cannot be resolved unambiguously. Library Identifier: '{Library}'.";
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
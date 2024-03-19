using Hl7.Cql.Abstractions.Exceptions;
using Hl7.Cql.Elm;

namespace Hl7.Cql.Compiler;


internal readonly record struct LibraryIncludeDefUnresolvedError(Library Library, IncludeDef IncludeDef) : ILibraryError
{
    public string GetMessage() => $"Library has an include definition that did not resolve to a target library in the set. Library Identifier: '{Library.NameAndVersion()}', IncludeDef: '{IncludeDef.NameAndVersion(false)}'";
}

internal readonly record struct LibraryIdentifierMustBeUniqueError(Library Library) : ILibraryError
{
    public string GetMessage() => $"Library did not have a unique name and version in the set. Duplicate Identifier: '{Library.NameAndVersion()}'";
}
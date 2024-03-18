using Hl7.Cql.Abstractions.Exceptions;

namespace Hl7.Cql.Elm;

internal interface ILibraryError : ICqlError
{
    Library Library { get; }
}

internal readonly record struct LibraryMissingNameAndVersionError(Library Library, string FilePath) : ILibraryError
{
    public string GetMessage() => $"Library did not have a valid name and version. Library Name&Version: '{Library.NameAndVersion}', Library Path: '{FilePath}'";
}
internal readonly record struct LibraryMissingIncludeDefPathError(Library Library, IncludeDef IncludeDef) : ILibraryError
{
    public string GetMessage() => $"Library has an include definition with a missing path. Library Identifier: '{Library.NameAndVersion}'";
}
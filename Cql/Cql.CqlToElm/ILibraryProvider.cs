using Hl7.Cql.Elm;
using System.Diagnostics.CodeAnalysis;

namespace Hl7.Cql.CqlToElm
{
    internal interface ILibraryProvider
    {
        bool TryResolveLibrary(string libraryName, string? version,
            [NotNullWhen(true)] out LibraryBuilder? library,
            [NotNullWhen(false)] out string? error);
    }
}

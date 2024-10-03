using System.Diagnostics.CodeAnalysis;

namespace Hl7.Cql.CqlToElm
{
    internal interface ILibraryProvider
    {
        bool TryResolveLibrary(string libraryName, string? version, [NotNullWhen(true)] out LibraryBuilder? library, out string? error);
    }
}

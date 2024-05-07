using Hl7.Cql.Elm;

namespace Hl7.Cql.CqlToElm
{
    internal interface ILibraryProvider
    {
        bool TryResolveLibrary(string libraryName, string? version, out Library? library, out string? error);
    }
}

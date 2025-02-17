using CqlSdkPrototype.Infrastructure;
using Hl7.Cql.Runtime;

namespace CqlSdkPrototype.Invocation.Extensions;

public static class LibrarySetInvokerExtensions
{
    public static IEnumerable<(LibraryInvoker libraryInvoker, DefinitionInvoker definitionInvoker, Func<object?> getResult)> EnumerateLibrarySetDefinitionsResults(
        this LibrarySetInvoker librarySetInvoker,
        CqlContext cqlContext)
    {
        foreach (var libraryInvoker in librarySetInvoker.LibraryInvokers.Values)
            foreach (var (definition, getResult) in libraryInvoker.EnumerateLibraryDefinitionsResults(cqlContext))
                yield return (libraryInvoker, definition, getResult);
    }

    public static IEnumerable<(LibraryInvoker libraryInvoker, DefinitionInvoker definitionInvoker, Func<object?> getResult)> EnumerateLibraryDefinitionsResults(
        this LibrarySetInvoker librarySetInvoker,
        CqlContext cqlContext,
        CqlVersionedLibraryIdentifier cqlVersionedLibraryIdentifier)
    {
        var libraryInvoker = librarySetInvoker.LibraryInvokers[cqlVersionedLibraryIdentifier];
        foreach (var (definitionInvoker, getResult) in libraryInvoker.EnumerateLibraryDefinitionsResults(cqlContext))
            yield return (libraryInvoker, definitionInvoker, getResult);
    }


    public static object? GetLibraryDefinitionResult(
        this LibrarySetInvoker librarySetInvoker,
        CqlContext cqlContext,
        CqlVersionedLibraryIdentifier cqlVersionedLibraryIdentifier,
        string definitionName)
    {
        var libraryInvoker = librarySetInvoker.LibraryInvokers[cqlVersionedLibraryIdentifier];
        var libraryDefinitionInvoker = libraryInvoker.Definitions[definitionName];
        var result = libraryDefinitionInvoker.Invoke(cqlContext);
        return result;
    }
}
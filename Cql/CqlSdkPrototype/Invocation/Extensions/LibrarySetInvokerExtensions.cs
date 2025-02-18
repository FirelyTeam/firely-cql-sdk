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
        CqlVersionedLibraryIdentifier libraryIdentifier)
    {
        var libraryInvoker = librarySetInvoker.LibraryInvokers[libraryIdentifier];
        foreach (var (definitionInvoker, getResult) in libraryInvoker.EnumerateLibraryDefinitionsResults(cqlContext))
            yield return (libraryInvoker, definitionInvoker, getResult);
    }


    public static object? GetLibraryDefinitionResult(
        this LibrarySetInvoker librarySetInvoker,
        CqlContext cqlContext,
        CqlVersionedLibraryIdentifier libraryIdentifier,
        string definitionName)
    {
        var libraryInvoker = librarySetInvoker.LibraryInvokers[libraryIdentifier];
        var libraryDefinitionInvoker = libraryInvoker.Definitions[definitionName];
        var result = libraryDefinitionInvoker.Invoke(cqlContext);
        return result;
    }
}
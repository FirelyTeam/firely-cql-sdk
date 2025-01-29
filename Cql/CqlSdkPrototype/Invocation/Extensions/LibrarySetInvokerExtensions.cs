using System.Text;
using CqlSdkPrototype.Infrastructure;
using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.Runtime;

namespace CqlSdkPrototype.Invocation.Extensions;

public static class LibrarySetInvokerExtensions
{
    public static IEnumerable<(CqlVersionedLibraryIdentifier library, string declarationName, Func<object?> getResult)> EnumerateLibrarySetDefinitionsResults(
        this LibrarySetInvoker scope,
        CqlContext cqlContext)
    {
        foreach (var (libId, lib) in scope.LibraryInvokers)
        {
            foreach (var (declId, decl) in lib.Definitions)
            {
                if (decl.ValueSetId is not null)
                    continue;

                yield return (libId, declId, () =>
                                 {
                                     var result = decl.Invoke(cqlContext);
                                     return result;
                                 }
                );
            }
        }
    }

    public static IEnumerable<(string definition, Func<object?> getResult)> EnumerateLibraryDefinitionsResults(
        this LibrarySetInvoker scope,
        CqlContext cqlContext,
        CqlVersionedLibraryIdentifier library)
    {
        var lib = scope.LibraryInvokers[library];
        foreach (var (declId, decl) in lib.Definitions)
        {
            if (decl.ValueSetId is not null)
                continue;

            yield return (declId, () =>
                             {
                                 var result = decl.Invoke(cqlContext);
                                 return result;
                             }
            );
        }
    }

    public static object? GetLibraryDefinitionResult(
        this LibrarySetInvoker scope,
        CqlContext cqlContext,
        CqlVersionedLibraryIdentifier versionedLibraryIdentifier,
        string definitionName)
    {
        var libraryInvoker = scope.LibraryInvokers[versionedLibraryIdentifier];
        var libraryDeclarationInvoker = libraryInvoker.Definitions[definitionName];
        var result = libraryDeclarationInvoker.Invoke(cqlContext);
        return result;
    }
}

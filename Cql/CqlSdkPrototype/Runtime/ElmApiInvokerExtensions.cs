using CqlSdkPrototype.ElmToAssembly;
using Hl7.Cql.Runtime;

namespace CqlSdkPrototype.Runtime;

internal static class ElmApiInvokerExtensions
{
    public static object? InvokeLibraryDeclaration(
        this ElmApi elmApi,
        CqlVersionedLibraryIdentifier versionedLibraryIdentifier,
        string declaration,
        CqlContext cqlContext)
    {
        if (!LibrarySetInvoker.TryCreate(
                out var librarySetInvoker,
                elmApi))
            throw new InvalidOperationException("Could not create LibrarySetInvoker.");
        var libraryInvoker = librarySetInvoker.LibraryInvokers[versionedLibraryIdentifier];
        var libraryDeclarationInvoker = libraryInvoker.Declarations[declaration];
        var result = libraryDeclarationInvoker.Invoke(cqlContext);
        return result;
    }
}
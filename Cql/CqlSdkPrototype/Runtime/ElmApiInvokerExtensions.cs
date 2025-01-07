using System.Reflection;
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
        var cqlRuntimeApiOptions = new CqlRuntimeApiOptions(elmApi.Options.ServiceProvider);
        var cqlRuntimeApi = CqlRuntimeApi
                            .Create(cqlRuntimeApiOptions)
                            .AddAssemblies(elmApi.GetAssemblyBinaries().Values);
        using var invokationScope = cqlRuntimeApi.CreateInvokationScope();
        var libraryInvoker = invokationScope.LibraryInvokers[versionedLibraryIdentifier];
        var libraryDeclarationInvoker = libraryInvoker.Declarations[declaration];
        var result = libraryDeclarationInvoker.Invoke(cqlContext);
        return result;
    }
}
using CqlSdkPrototype.Elm;
using CqlSdkPrototype.Internal;
using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Compiler;

namespace Hl7.Cql.CqlToElm.Test;

internal static class ElmServiceProviderAccessorForTesting
{
    private static TService GetCqlRequiredService<TService>(this IServiceProviderAccessorForTesting<ElmToolkit> spAccessor) where TService : notnull =>
        spAccessor.ServiceProvider.GetRequiredService<TService>();

    public static LibrarySetCSharpCodeGenerator GetLibrarySetCSharpCodeGenerator(this IServiceProviderAccessorForTesting<ElmToolkit> scope) =>
        scope.ServiceProvider.GetRequiredService<LibrarySetCSharpCodeGenerator>();

    public static AssemblyCompiler GetAssemblyCompiler(this IServiceProviderAccessorForTesting<ElmToolkit> scope) =>
        scope.ServiceProvider.GetRequiredService<AssemblyCompiler>();

    public static ElmToolkitServiceScope CreateScope(this IServiceProviderAccessorForTesting<ElmToolkit> spAccessor) =>
        new (spAccessor.ServiceProvider.CreateScope());

    public static LibraryExpressionBuilder GetLibraryExpressionBuilder(this ElmToolkitServiceScope scope) =>
        scope.ServiceProvider.GetRequiredService<LibraryExpressionBuilder>();
}
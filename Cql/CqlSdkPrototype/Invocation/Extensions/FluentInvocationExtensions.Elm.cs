using CqlSdkPrototype.Elm;
using CqlSdkPrototype.Invocation.Invokers;
using Hl7.Cql.CodeGeneration.NET;

namespace CqlSdkPrototype.Invocation.Extensions;

public static partial class FluentInvocationExtensions
{
    public static LibrarySetInvokerBuilder CreateRuntimeApi(
        this ElmFluentToolkit elmApi,
        Func<LibrarySetInvokerBuilderSettings, LibrarySetInvokerBuilderSettings>? configureOptions = null)
    {
        var runtimeApiOptions = LibrarySetInvokerBuilderSettings.Default;
        if (configureOptions is not null) runtimeApiOptions = configureOptions(runtimeApiOptions);

        var assemblyDatas =
            from entry in elmApi.ElmToAssemblyConversions
            let assembly = entry.Value.AssemblyBinary
            where assembly is not null
            let debugSymbols = entry.Value.DebugSymbolsBinary
            let assemblyData = new AssemblyData(assembly, debugSymbols)
            select assemblyData;

        var runtimeApi = new LibrarySetInvokerBuilder(elmApi.LoggerFactory, runtimeApiOptions).AddAssemblies(assemblyDatas);
        return runtimeApi;
    }

#pragma warning disable RS0026
    public static LibrarySetInvoker CreateRuntimeScope(
#pragma warning restore RS0026
        this ElmFluentToolkit elmApi,
        Func<LibrarySetInvokerBuilderSettings, LibrarySetInvokerBuilderSettings>? configureOptions = null)
    {
        return elmApi
               .ProcessElmToAssemblies()
               .CreateRuntimeApi(configureOptions)
               .CreateRuntimeScope();
    }
}

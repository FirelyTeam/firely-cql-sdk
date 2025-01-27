using CqlSdkPrototype.Elm;
using Hl7.Cql.CodeGeneration.NET;

namespace CqlSdkPrototype.Runtime.Extensions;

public static partial class RuntimeApiExtensions
{
    public static RuntimeApi CreateRuntimeApi(
        this ElmFluentToolkit elmApi,
        Func<RuntimeApiOptions, RuntimeApiOptions>? configureOptions = null)
    {
        var runtimeApiOptions = RuntimeApiOptions.Default;
        if (configureOptions is not null) runtimeApiOptions = configureOptions(runtimeApiOptions);

        var assemblyDatas =
            from entry in elmApi.ElmToAssemblyConversions
            let assembly = entry.Value.AssemblyBinary
            where assembly is not null
            let debugSymbols = entry.Value.DebugSymbolsBinary
            let assemblyData = new AssemblyData(assembly, debugSymbols)
            select assemblyData;

        var runtimeApi = new RuntimeApi(elmApi.LoggerFactory, runtimeApiOptions).AddAssemblies(assemblyDatas);
        return runtimeApi;
    }

#pragma warning disable RS0026
    public static RuntimeScope CreateRuntimeScope(
#pragma warning restore RS0026
        this ElmFluentToolkit elmApi,
        Func<RuntimeApiOptions, RuntimeApiOptions>? configureOptions = null)
    {
        return elmApi
               .ProcessElmToAssemblies()
               .CreateRuntimeApi(configureOptions)
               .CreateRuntimeScope();
    }
}

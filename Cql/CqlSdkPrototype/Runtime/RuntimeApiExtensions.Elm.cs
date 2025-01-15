using CqlSdkPrototype.Elm.Extensibility;
using Hl7.Cql.CodeGeneration.NET;

namespace CqlSdkPrototype.Runtime;
public static partial class RuntimeApiExtensions
{
    public static RuntimeApi CreateRuntimeApi<TElmApi>(
        this TElmApi elmApi,
        Func<RuntimeApiOptions, RuntimeApiOptions>? configureOptions = null)
        where TElmApi : IElmApiExtensible<TElmApi>
    {
        var runtimeApiOptions = RuntimeApiOptions.Default with
        {
            LoggerFactory = elmApi.Options.LoggerFactory,
        };

        if (configureOptions is not null) runtimeApiOptions = configureOptions(runtimeApiOptions);

        var assemblyDatas =
            from entry in elmApi.Entries
            let assembly = entry.Value.AssemblyBinary
            where assembly is not null
            let debugSymbols = entry.Value.DebugSymbolsBinary
            let assemblyData = new AssemblyData(assembly, debugSymbols)
            select assemblyData;

        var runtimeApi = new RuntimeApi(runtimeApiOptions).AddAssemblies(assemblyDatas);
        return runtimeApi;
    }

#pragma warning disable RS0026
    public static RuntimeScope CreateRuntimeScope<TElmApi>(
#pragma warning restore RS0026
        this TElmApi elmApi,
        Func<RuntimeApiOptions, RuntimeApiOptions>? configureOptions = null)
        where TElmApi : IElmApiExtensible<TElmApi>
    {
        return elmApi
               .Compile()
               .CreateRuntimeApi(configureOptions)
               .CreateRuntimeScope();
    }
}

using CqlSdkPrototype.Elm.Extensibility;
using Hl7.Cql.CodeGeneration.NET;

namespace CqlSdkPrototype.Invocation.Extensions;

public static partial class RuntimeApiExtensions
{
    public static InvokerApi CreateRuntimeApi<TElmApi>(
        this TElmApi elmApi,
        Func<InvokerApiOptions, InvokerApiOptions>? configureOptions = null)
        where TElmApi : IElmApiExtendable<TElmApi>
    {
        var runtimeApiOptions = InvokerApiOptions.Default;
        if (configureOptions is not null) runtimeApiOptions = configureOptions(runtimeApiOptions);

        var assemblyDatas =
            from entry in elmApi.Entries
            let assembly = entry.Value.AssemblyBinary
            where assembly is not null
            let debugSymbols = entry.Value.DebugSymbolsBinary
            let assemblyData = new AssemblyData(assembly, debugSymbols)
            select assemblyData;

        var runtimeApi = new InvokerApi(elmApi.LoggerFactory, runtimeApiOptions).AddAssemblies(assemblyDatas);
        return runtimeApi;
    }

#pragma warning disable RS0026
    public static LibrarySetInvoker CreateRuntimeScope<TElmApi>(
#pragma warning restore RS0026
        this TElmApi elmApi,
        Func<InvokerApiOptions, InvokerApiOptions>? configureOptions = null)
        where TElmApi : IElmApiExtendable<TElmApi>
    {
        return elmApi
               .Compile()
               .CreateRuntimeApi(configureOptions)
               .CreateLibrarySetInvoker();
    }
}

using CqlSdkPrototype.Elm;
using CqlSdkPrototype.Elm.Extensibility;
using Hl7.Cql.CodeGeneration.NET;

namespace CqlSdkPrototype.Invocation.Extensions;

public static partial class InvokerApiExtensions
{
    public static InvocationApi CreateRuntimeApi(
        this ElmApi elmApi,
        Func<InvocationApiOptions, InvocationApiOptions>? configureOptions = null)
    {
        var runtimeApiOptions = InvocationApiOptions.Default;
        if (configureOptions is not null) runtimeApiOptions = configureOptions(runtimeApiOptions);

        var assemblyDatas =
            from entry in elmApi.Entries
            let assembly = entry.Value.AssemblyBinary
            where assembly is not null
            let debugSymbols = entry.Value.DebugSymbolsBinary
            let assemblyData = new AssemblyData(assembly, debugSymbols)
            select assemblyData;

        var runtimeApi = new InvocationApi(elmApi.LoggerFactory, runtimeApiOptions).AddAssemblies(assemblyDatas);
        return runtimeApi;
    }

#pragma warning disable RS0026
    public static LibrarySetInvoker CreateRuntimeScope(
#pragma warning restore RS0026
        this ElmApi elmApi,
        Func<InvocationApiOptions, InvocationApiOptions>? configureOptions = null)
    {
        return elmApi
               .Compile()
               .CreateRuntimeApi(configureOptions)
               .CreateLibrarySetInvoker();
    }
}

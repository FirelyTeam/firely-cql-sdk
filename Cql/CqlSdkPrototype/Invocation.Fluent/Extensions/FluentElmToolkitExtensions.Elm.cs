using CqlSdkPrototype.Elm.Fluent;

namespace CqlSdkPrototype.Invocation.Fluent.Extensions;

public static partial class FluentElmToolkitExtensions
{
    public static FluentInvocationToolkit CreateFluentLibrarySetInvokerBuilder(
        this FluentElmToolkit elmToolkit,
        Func<LibrarySetInvokerBuilderConfig, LibrarySetInvokerBuilderConfig>? configureLibrarySetInvokerBuilderSettings = null)
    {
        var runtimeApiOptions = LibrarySetInvokerBuilderConfig.Default;
        if (configureLibrarySetInvokerBuilderSettings is not null) runtimeApiOptions = configureLibrarySetInvokerBuilderSettings(runtimeApiOptions);

        var assemblyDatas =
            from entry in elmToolkit.ElmToAssemblyConversions
            let assembly = entry.Value.AssemblyBinary
            where assembly is not null
            let debugSymbols = entry.Value.DebugSymbolsBinary
            let assemblyData = new Hl7.Cql.CodeGeneration.NET.AssemblyData(assembly, debugSymbols)
            select assemblyData;

        var runtimeApi = new FluentInvocationToolkit(elmToolkit.LoggerFactory, runtimeApiOptions).AddAssemblies(assemblyDatas);
        return runtimeApi;
    }

#pragma warning disable RS0026 // Do not add multiple public overloads with optional parameters
    public static LibrarySetInvoker CreateLibrarySetInvoker(
#pragma warning restore RS0026
        this FluentElmToolkit elmToolkit,
        string name = "",
        Func<LibrarySetInvokerBuilderConfig, LibrarySetInvokerBuilderConfig>? configureLibrarySetInvokerBuilderSettings = null)
    {
        return elmToolkit
               .ProcessElmToAssemblies()
               .CreateFluentLibrarySetInvokerBuilder(configureLibrarySetInvokerBuilderSettings)
               .CreateLibrarySetInvoker(name);
    }
}

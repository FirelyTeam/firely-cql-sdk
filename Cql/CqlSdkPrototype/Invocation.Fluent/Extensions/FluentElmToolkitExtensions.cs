using CqlSdkPrototype.Elm.Fluent;

namespace CqlSdkPrototype.Invocation.Fluent.Extensions;

public static class FluentElmToolkitExtensions
{
    public static FluentInvocationToolkit CreateFluentInvocationToolkit(
        this FluentElmToolkit elmToolkit,
        Func<LibrarySetInvokerBuilderConfig, LibrarySetInvokerBuilderConfig>? configureLibrarySetInvokerBuilderSettings = null)
    {
        var config = LibrarySetInvokerBuilderConfig.Default;
        if (configureLibrarySetInvokerBuilderSettings is not null) config = configureLibrarySetInvokerBuilderSettings(config);

        var assemblyBinaries =
            from entry in elmToolkit.ElmToAssemblyConversions
            let assembly = entry.Value.AssemblyBinary
            where assembly is not null
            let debugSymbols = entry.Value.DebugSymbolsBinary
            let assemblyBinary = new Hl7.Cql.CodeGeneration.NET.AssemblyBinary(assembly, debugSymbols)
            select assemblyBinary;

        var invocationToolkit = new FluentInvocationToolkit(elmToolkit.LoggerFactory, config).AddAssemblyBinaries(assemblyBinaries);
        return invocationToolkit;
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
               .CreateFluentInvocationToolkit(configureLibrarySetInvokerBuilderSettings)
               .CreateLibrarySetInvoker(name);
    }
}

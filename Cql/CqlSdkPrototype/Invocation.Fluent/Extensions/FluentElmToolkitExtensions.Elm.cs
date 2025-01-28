using CqlSdkPrototype.Elm.Fluent;
using Hl7.Cql.CodeGeneration.NET;

namespace CqlSdkPrototype.Invocation.Fluent.Extensions;

public static partial class FluentElmToolkitExtensions
{
    public static FluentLibrarySetInvokerBuilder ToFluentLibrarySetInvokerBuilder(
        this FluentElmToolkit elmToolkit,
        Func<LibrarySetInvokerBuilderSettings, LibrarySetInvokerBuilderSettings>? configureLibrarySetInvokerBuilderSettings = null)
    {
        var runtimeApiOptions = LibrarySetInvokerBuilderSettings.Default;
        if (configureLibrarySetInvokerBuilderSettings is not null) runtimeApiOptions = configureLibrarySetInvokerBuilderSettings(runtimeApiOptions);

        var assemblyDatas =
            from entry in elmToolkit.ElmToAssemblyConversions
            let assembly = entry.Value.AssemblyBinary
            where assembly is not null
            let debugSymbols = entry.Value.DebugSymbolsBinary
            let assemblyData = new AssemblyData(assembly, debugSymbols)
            select assemblyData;

        var runtimeApi = new FluentLibrarySetInvokerBuilder(elmToolkit.LoggerFactory, runtimeApiOptions).AddAssemblies(assemblyDatas);
        return runtimeApi;
    }

#pragma warning disable RS0026 // Do not add multiple public overloads with optional parameters
    public static LibrarySetInvoker CreateLibrarySetInvoker(
#pragma warning restore RS0026
        this FluentElmToolkit elmToolkit,
        string name = "",
        Func<LibrarySetInvokerBuilderSettings, LibrarySetInvokerBuilderSettings>? configureLibrarySetInvokerBuilderSettings = null)
    {
        return elmToolkit
               .ProcessElmToAssemblies()
               .ToFluentLibrarySetInvokerBuilder(configureLibrarySetInvokerBuilderSettings)
               .CreateLibrarySetInvoker(name);
    }
}

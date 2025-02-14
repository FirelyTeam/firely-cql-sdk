using CqlSdkPrototype.Elm.Fluent;
using CqlSdkPrototype.Elm.Fluent.Extensions;
using Hl7.Cql.CodeGeneration.NET;

namespace CqlSdkPrototype.Invocation.Fluent.Extensions;

public static class ElmToolkitExtensions
{
    public static FluentInvocationToolkit ToFluentInvocationToolkit(
        this ElmToolkit elmToolkit/*,
        Func<LibrarySetInvokerBuilderConfig, LibrarySetInvokerBuilderConfig>? configureLibrarySetInvokerBuilderSettings = null*/)
    {
        /*var config = LibrarySetInvokerBuilderConfig.Default;
        if (configureLibrarySetInvokerBuilderSettings is not null) config = configureLibrarySetInvokerBuilderSettings(config);*/

        var assemblyBinaries =
            elmToolkit.GetCompletedElmToAssemblyCompilations(t => new AssemblyBinary(t.assemblyBinary, t.debugSymbolsBinary));

        var invocationToolkit = new FluentInvocationToolkit(elmToolkit.LoggerFactory/*, config*/).AddAssemblyBinaries(assemblyBinaries);
        return invocationToolkit;
    }

#pragma warning disable RS0026 // Do not add multiple public overloads with optional parameters
    public static LibrarySetInvoker ToLibrarySetInvoker(
#pragma warning restore RS0026
        this ElmToolkit elmToolkit,
        string name = ""/*,
        Func<LibrarySetInvokerBuilderConfig, LibrarySetInvokerBuilderConfig>? configure = null*/)
    {
        return elmToolkit
               .CompileElmToAssemblies()
               .ToFluentInvocationToolkit(/*configure*/)
               .ToLibrarySetInvoker(name);
    }
}

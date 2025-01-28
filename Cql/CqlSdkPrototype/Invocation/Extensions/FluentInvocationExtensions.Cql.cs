using CqlSdkPrototype.Cql.Fluent;
using CqlSdkPrototype.Elm;
using CqlSdkPrototype.Elm.Fluent;
using CqlSdkPrototype.Elm.Fluent.Extensions;
using CqlSdkPrototype.Invocation.Invokers;

namespace CqlSdkPrototype.Invocation.Extensions;

public static partial class FluentInvocationExtensions
{
    public static FluentElmToolkit CreateElmApi(
        this FluentCqlToolkit cqlToolkit,
        Func<ElmToAssemblySettings, ElmToAssemblySettings>? configureOptions = null)
    {
        var elmApiOptions = new ElmToAssemblySettings(ProcessBatchItemExceptionHandling: cqlToolkit.Settings.ProcessBatchItemExceptionHandling);
        if (configureOptions is not null) elmApiOptions = configureOptions(elmApiOptions);
        var elmApi = new FluentElmToolkit(cqlToolkit.LoggerFactory, elmApiOptions).AddElmFrom(cqlToolkit);
        return elmApi;
    }

#pragma warning disable RS0026
    public static LibrarySetInvoker CreateRuntimeScope(
#pragma warning restore RS0026
        this FluentCqlToolkit cqlToolkit,
        Func<ElmToAssemblySettings, ElmToAssemblySettings>? configureElmOptions = null,
        Func<LibrarySetInvokerBuilderSettings, LibrarySetInvokerBuilderSettings>? configureRuntimeOptions = null)
    {
        return cqlToolkit
               .ProcessCqlToElm()
               .CreateElmApi(configureElmOptions)
               .CreateRuntimeScope(configureRuntimeOptions);
    }
}
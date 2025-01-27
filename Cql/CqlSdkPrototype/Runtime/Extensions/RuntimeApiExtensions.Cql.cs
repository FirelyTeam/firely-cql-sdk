using CqlSdkPrototype.Cql;
using CqlSdkPrototype.Elm;
using CqlSdkPrototype.Elm.Extensions;

namespace CqlSdkPrototype.Runtime.Extensions;

public static partial class RuntimeApiExtensions
{
    public static ElmFluentToolkit CreateElmApi(
        this CqlFluentToolkit cqlToolkit,
        Func<ElmToAssemblySettings, ElmToAssemblySettings>? configureOptions = null)
    {
        var elmApiOptions = new ElmToAssemblySettings(ProcessBatchItemExceptionHandling: cqlToolkit.Settings.ProcessBatchItemExceptionHandling);
        if (configureOptions is not null) elmApiOptions = configureOptions(elmApiOptions);
        var elmApi = new ElmFluentToolkit(cqlToolkit.LoggerFactory, elmApiOptions).AddElmFrom(cqlToolkit);
        return elmApi;
    }

#pragma warning disable RS0026
    public static RuntimeScope CreateRuntimeScope(
#pragma warning restore RS0026
        this CqlFluentToolkit cqlToolkit,
        Func<ElmToAssemblySettings, ElmToAssemblySettings>? configureElmOptions = null,
        Func<RuntimeApiOptions, RuntimeApiOptions>? configureRuntimeOptions = null)
    {
        return cqlToolkit
               .ProcessCqlToElm()
               .CreateElmApi(configureElmOptions)
               .CreateRuntimeScope(configureRuntimeOptions);
    }
}
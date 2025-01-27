using CqlSdkPrototype.Cql;
using CqlSdkPrototype.Elm;
using CqlSdkPrototype.Elm.Extensions;

namespace CqlSdkPrototype.Runtime.Extensions;

public static partial class RuntimeApiExtensions
{
    public static IElmFluentToolkit CreateElmApi(
        this ICqlFluentToolkit cqlToolkit,
        Func<ElmToolkitSettings, ElmToolkitSettings>? configureOptions = null)
    {
        var elmApiOptions = new ElmToolkitSettings(ProcessBatchItemExceptionHandling: cqlToolkit.Settings.ProcessBatchItemExceptionHandling);
        if (configureOptions is not null) elmApiOptions = configureOptions(elmApiOptions);
        var elmApi = new ElmToolkit(cqlToolkit.LoggerFactory, elmApiOptions).AddElmFrom(cqlToolkit);
        return elmApi;
    }

#pragma warning disable RS0026
    public static RuntimeScope CreateRuntimeScope(
#pragma warning restore RS0026
        this ICqlFluentToolkit cqlToolkit,
        Func<ElmToolkitSettings, ElmToolkitSettings>? configureElmOptions = null,
        Func<RuntimeApiOptions, RuntimeApiOptions>? configureRuntimeOptions = null)
    {
        return cqlToolkit
               .ProcessCqlToElm()
               .CreateElmApi(configureElmOptions)
               .CreateRuntimeScope(configureRuntimeOptions);
    }
}
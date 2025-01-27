using CqlSdkPrototype.Cql;
using CqlSdkPrototype.Cql.Extensibility;
using CqlSdkPrototype.Elm;
using CqlSdkPrototype.Elm.Extensions;

namespace CqlSdkPrototype.Runtime.Extensions;

public static partial class RuntimeApiExtensions
{
    public static ElmApi CreateElmApi(
        this ICqlToolkit cqlToolkit,
        Func<ElmApiOptions, ElmApiOptions>? configureOptions = null)
    {
        var elmApiOptions = new ElmApiOptions(ProcessBatchItemExceptionHandling: cqlToolkit.Settings.ProcessBatchItemExceptionHandling);
        if (configureOptions is not null) elmApiOptions = configureOptions(elmApiOptions);
        var elmApi = new ElmApi(cqlToolkit.LoggerFactory, elmApiOptions).AddElmFromCqlApi(cqlToolkit);
        return elmApi;
    }

#pragma warning disable RS0026
    public static RuntimeScope CreateRuntimeScope(
#pragma warning restore RS0026
        this ICqlToolkit cqlToolkit,
        Func<ElmApiOptions, ElmApiOptions>? configureElmOptions = null,
        Func<RuntimeApiOptions, RuntimeApiOptions>? configureRuntimeOptions = null)
    {
        return cqlToolkit
               .Translate()
               .CreateElmApi(configureElmOptions)
               .CreateRuntimeScope(configureRuntimeOptions);
    }
}
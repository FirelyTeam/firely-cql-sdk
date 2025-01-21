using CqlSdkPrototype.Cql;
using CqlSdkPrototype.Cql.Extensibility;
using CqlSdkPrototype.Elm;
using CqlSdkPrototype.Elm.Extensions;

namespace CqlSdkPrototype.Invocation.Extensions;

public static partial class RuntimeApiExtensions
{
    public static ElmApi CreateElmApi<TCqlApi>(
        this TCqlApi cqlApi,
        Func<ElmApiOptions, ElmApiOptions>? configureOptions = null)
        where TCqlApi : ICqlApiExtendable<TCqlApi>
    {
        var elmApiOptions = new ElmApiOptions(ProcessBatchItemExceptionHandling: cqlApi.Options.ProcessBatchItemExceptionHandling);
        if (configureOptions is not null) elmApiOptions = configureOptions(elmApiOptions);
        var elmApi = new ElmApi(cqlApi.LoggerFactory, elmApiOptions).AddElmFromCqlApi(cqlApi);
        return elmApi;
    }

#pragma warning disable RS0026
    public static LibrarySetInvoker CreateRuntimeScope(
#pragma warning restore RS0026
        this CqlApi cqlApi,
        Func<ElmApiOptions, ElmApiOptions>? configureElmOptions = null,
        Func<InvokerApiOptions, InvokerApiOptions>? configureRuntimeOptions = null)
    {
        return cqlApi
               .Translate()
               .CreateElmApi(configureElmOptions)
               .CreateRuntimeScope(configureRuntimeOptions);
    }
}
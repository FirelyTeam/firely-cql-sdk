using CqlSdkPrototype.Cql;
using CqlSdkPrototype.Cql.Extensibility;
using CqlSdkPrototype.Elm;
using CqlSdkPrototype.Elm.Extensions;

namespace CqlSdkPrototype.Invocation.Extensions;

public static partial class InvokerApiExtensions
{
    public static ElmApi CreateElmApi(
        this CqlApi cqlApi,
        Func<ElmApiOptions, ElmApiOptions>? configureOptions = null)
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
        Func<InvocationApiOptions, InvocationApiOptions>? configureRuntimeOptions = null)
    {
        return cqlApi
               .Translate()
               .CreateElmApi(configureElmOptions)
               .CreateRuntimeScope(configureRuntimeOptions);
    }
}
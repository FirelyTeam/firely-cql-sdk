using CqlSdkPrototype.App;
using CqlSdkPrototype.Cql;
using CqlSdkPrototype.Cql.Extensibility;
using CqlSdkPrototype.Elm;
using CqlSdkPrototype.Elm.Extensibility;
using Hl7.Cql.CodeGeneration.NET;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace CqlSdkPrototype.Runtime;

internal static class ApiExtensions
{
    public static ElmApi CreateElmApi<TCqlApi>(
        this TCqlApi cqlApi,
        Func<ElmApiOptions, ElmApiOptions>? configureOptions = null)
        where TCqlApi : ICqlApiExtensible<TCqlApi>
    {
        var elmApiOptions = cqlApi.Options.CreateElmApiOptions();
        if (configureOptions is not null) elmApiOptions = configureOptions(elmApiOptions);
        var elmApi = new ElmApi(elmApiOptions).AddElmFromCqlApi(cqlApi);
        return elmApi;
    }
    public static CqlRuntimeApi CreateCqlRuntimeApi<TElmApi>(this TElmApi elmApi)
        where TElmApi : IElmApiExtensible<TElmApi>
    {
        var serviceProvider = new ServiceCollection()
                                    .AddLogging(configure: lb => lb.ClearProviders().UseOptions(options: elmApi.Options.LoggingOptions))
                                    .BuildServiceProvider();
        var cqlRuntimeApiOptions = new CqlRuntimeApiOptions(serviceProvider);
        var cqlRuntimeApi = CqlRuntimeApi
                            .Create(cqlRuntimeApiOptions)
                            .AddAssemblies(
                                from entry in elmApi.Entries
                                let assembly = entry.Value.AssemblyBinary
                                where assembly is not null
                                let debugSymbols = entry.Value.DebugSymbolsBinary
                                let assemblyData = new AssemblyData(assembly, debugSymbols)
                                select assemblyData
                                );
        return cqlRuntimeApi;
    }

    public static CqlInvocationScope CreateInvocationScope<TElmApi>(
        this TElmApi elmApi)
        where TElmApi : IElmApiExtensible<TElmApi>
    {
        return elmApi
               .Compile()
               .CreateCqlRuntimeApi()
               .CreateInvocationScope();
    }

    public static CqlInvocationScope CreateInvocationScope(
        this CqlApi cqlApi)
    {
        return cqlApi
               .Translate()
               .CreateElmApi()
               .CreateInvocationScope();
    }
}
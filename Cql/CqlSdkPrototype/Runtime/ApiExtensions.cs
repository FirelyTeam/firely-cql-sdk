using CqlSdkPrototype.Cql;
using CqlSdkPrototype.Cql.Extensibility;
using CqlSdkPrototype.Elm;
using CqlSdkPrototype.Elm.Extensibility;
using Hl7.Cql.CodeGeneration.NET;

namespace CqlSdkPrototype.Runtime;

internal static class ApiExtensions
{
    public static ElmApi CreateElmApi<TCqlApi>(
        this TCqlApi cqlApi)
        where TCqlApi : ICqlApi<TCqlApi>
    {
        var elmApi = ElmApi
                     .Create(cqlApi.Options.ServiceProvider)
                     .WithOptions(_ => ElmApiOptions.Create(cqlApi.Options))
                     .LoadElmFromCqlApi(cqlApi);
        return elmApi;
    }
    public static CqlRuntimeApi CreateCqlRuntimeApi<TElmApi>(this TElmApi elmApi)
        where TElmApi : IElmApi<TElmApi>
    {
        var cqlRuntimeApiOptions = new CqlRuntimeApiOptions(elmApi.Options.ServiceProvider);
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
        where TElmApi : IElmApi<TElmApi>
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
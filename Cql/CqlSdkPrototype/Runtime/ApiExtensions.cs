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
        where TCqlApi : ICqlApiExtensible<TCqlApi>
    {
        var elmApiOptions = ElmApiOptions.Create(cqlApi.Options);
        var elmApi = ElmApi
                     .Create(elmApiOptions)
                     .LoadElmFromCqlApi(cqlApi);
        return elmApi;
    }
    public static CqlRuntimeApi CreateCqlRuntimeApi<TElmApi>(this TElmApi elmApi)
        where TElmApi : IElmApiExtensible<TElmApi>
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

    public static CqlInvokationScope CreateInvokationScope<TElmApi>(
        this TElmApi elmApi)
        where TElmApi : IElmApiExtensible<TElmApi>
    {
        return elmApi
               .CompileAssemblies()
               .CreateCqlRuntimeApi()
               .CreateInvokationScope();
    }

    public static CqlInvokationScope CreateInvokationScope(
        this CqlApi cqlApi)
    {
        return cqlApi
               .ConvertToElm()
               .CreateElmApi()
               .CreateInvokationScope();
    }
}
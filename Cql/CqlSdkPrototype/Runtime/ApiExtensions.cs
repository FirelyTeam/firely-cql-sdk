using CqlSdkPrototype.CqlToElm;
using CqlSdkPrototype.ElmToAssembly;

namespace CqlSdkPrototype.Runtime;

internal static class ApiExtensions
{
    public static ElmApi CreateElmApi(this CqlApi cqlApi)
    {
        var elmApiOptions = ElmApiOptions.Create(cqlApi.Options);
        var elmApi = ElmApi
                     .Create(elmApiOptions)
                     .LoadElmFromCqlApi(cqlApi);
        return elmApi;
    }
    public static CqlRuntimeApi CreateCqlRuntimeApi(this ElmApi elmApi)
    {
        var cqlRuntimeApiOptions = new CqlRuntimeApiOptions(elmApi.Options.ServiceProvider);
        var cqlRuntimeApi = CqlRuntimeApi
                            .Create(cqlRuntimeApiOptions)
                            .AddAssemblies(elmApi.GetAssemblyBinaries().Values);
        return cqlRuntimeApi;
    }

    public static CqlInvokationScope CreateInvokationScope(
        this ElmApi elmApi)
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
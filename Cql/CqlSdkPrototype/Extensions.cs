using Hl7.Cql.CqlToElm;
using Hl7.Cql.CqlToElm.LibraryProviders;
using Hl7.Cql.Model;
using Microsoft.Extensions.DependencyInjection;

namespace CqlSdkPrototype;

public static class Extensions
{
    public static IServiceCollection AddElmCompilation(
        this IServiceCollection serviceCollection)
    {
        return serviceCollection
            .AddCqlCodeGenerationServices();
    }

    public static IServiceCollection AddCqlTranslation(
        this IServiceCollection serviceCollection)
    {
        return serviceCollection
            .AddCqlToElmServices()
            .AddCqlToElmModels(
                mp => mp
                      .Add(Models.ElmR1)
                      .Add(Models.Fhir401)
            )
            .AddCqlToElmOptions(opt =>
            {
                // Options
            })
            .AddSingleton<ILibraryProvider, MemoryLibraryProvider>()
            .AddCqlToElmMessaging();
    }
}
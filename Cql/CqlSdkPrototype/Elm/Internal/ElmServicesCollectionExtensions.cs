namespace CqlSdkPrototype.Elm.Internal;
internal static class ElmServicesCollectionExtensions
{
    public static IServiceCollection AddElmApi(
        this IServiceCollection serviceCollection)
    {
        return serviceCollection
            .AddCqlCodeGenerationServices();
    }
}

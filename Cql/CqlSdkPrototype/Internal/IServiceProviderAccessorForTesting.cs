namespace CqlSdkPrototype.Internal;

internal interface IServiceProviderAccessorForTesting<TApi>
{
    ServiceProvider ServiceProvider { get; }
}
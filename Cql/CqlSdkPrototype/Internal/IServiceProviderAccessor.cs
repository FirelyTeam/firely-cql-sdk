namespace CqlSdkPrototype.Internal;

internal interface IServiceProviderAccessor<TApi>
{
    ServiceProvider ServiceProvider { get; }
}
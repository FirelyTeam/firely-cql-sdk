namespace CqlSdkPrototype.Internal;

internal interface ITestingOnlyServiceProviderAccessor<TApi>
{
    ServiceProvider ServiceProvider { get; }
}
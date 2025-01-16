using CqlSdkPrototype.Runtime.Extensibility;

namespace CqlSdkPrototype.Runtime.Internal;

internal interface IRuntimeApiInternal<TRuntimeApi> : IRuntimeApiExtendable<TRuntimeApi>
    where TRuntimeApi : IRuntimeApiExtendable<TRuntimeApi>
{
    RuntimeApiState State { get; }
}
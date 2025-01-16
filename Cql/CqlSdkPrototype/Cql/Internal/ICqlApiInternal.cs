using CqlSdkPrototype.Cql.Extensibility;

namespace CqlSdkPrototype.Cql.Internal;

internal interface ICqlApiInternal<TCqlApi> : ICqlApiExtendable<TCqlApi>
    where TCqlApi : ICqlApiExtendable<TCqlApi>
{
    CqlApiState State { get; }
}
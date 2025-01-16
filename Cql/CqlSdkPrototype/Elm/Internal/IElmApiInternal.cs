using CqlSdkPrototype.Elm.Extensibility;

namespace CqlSdkPrototype.Elm.Internal;

internal interface IElmApiInternal<TElmApi> : IElmApiExtendable<TElmApi>
    where TElmApi : IElmApiExtendable<TElmApi>
{
    ElmApiState State { get; }
}
namespace CqlSdkPrototype.Elm.Extensibility;

internal interface IElmApiInternal<TElmApi> : IElmApiExtendable<TElmApi>
    where TElmApi : IElmApiExtendable<TElmApi>
{
    ElmApiState State { get;  }
}
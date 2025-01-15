namespace CqlSdkPrototype.Elm.Extensibility;

internal interface IElmApiInternal<TElmApi> : IElmApiExtensible<TElmApi>
    where TElmApi : IElmApiExtensible<TElmApi>
{
    ElmApiState State { get;  }
}
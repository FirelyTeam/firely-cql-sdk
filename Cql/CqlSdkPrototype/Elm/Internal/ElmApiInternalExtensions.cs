namespace CqlSdkPrototype.Elm.Internal;

internal static class ElmApiInternalExtensions
{
    internal static IElmApiInternal<TElmApi> AsInternal<TElmApi>(this IElmApiInternal<TElmApi> self)
        where TElmApi : IElmApiInternal<TElmApi> => self;
}
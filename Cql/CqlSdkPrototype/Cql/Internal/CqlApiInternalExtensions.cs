namespace CqlSdkPrototype.Cql.Internal;

internal static class CqlApiInternalExtensions
{
    internal static ICqlApiInternal<TCqlApi> AsInternal<TCqlApi>(this ICqlApiInternal<TCqlApi> self)
        where TCqlApi : ICqlApiInternal<TCqlApi> => self;
}
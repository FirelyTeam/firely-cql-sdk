namespace CqlSdkPrototype.Runtime.Internal;

internal static class RuntimeApiInternalExtensions
{
    internal static IRuntimeApiInternal<TRuntimeApi> AsInternal<TRuntimeApi>(this IRuntimeApiInternal<TRuntimeApi> self)
        where TRuntimeApi : IRuntimeApiInternal<TRuntimeApi> => self;
}
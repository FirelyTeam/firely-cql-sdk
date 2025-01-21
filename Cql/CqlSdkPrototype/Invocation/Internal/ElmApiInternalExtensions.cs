namespace CqlSdkPrototype.Invocation.Internal;

internal static class RuntimeApiInternalExtensions
{
    internal static IInvokerApiInternal<TRuntimeApi> AsInternal<TRuntimeApi>(this IInvokerApiInternal<TRuntimeApi> self)
        where TRuntimeApi : IInvokerApiInternal<TRuntimeApi> => self;
}
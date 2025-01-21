using CqlSdkPrototype.Invocation.Extensibility;

namespace CqlSdkPrototype.Invocation.Internal;

internal interface IInvokerApiInternal<TInvokerApi> : IInvokerApiExtendable<TInvokerApi>
    where TInvokerApi : IInvokerApiExtendable<TInvokerApi>
{
    InvokerApiServices Services { get; }
}
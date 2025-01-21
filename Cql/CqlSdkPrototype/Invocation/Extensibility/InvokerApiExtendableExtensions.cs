namespace CqlSdkPrototype.Invocation.Extensibility;

public static class InvokerApiExtendableExtensions
{
    public static IInvokerApiExtendable<InvokerApi> AsExtendable(this InvokerApi self) => self;
}
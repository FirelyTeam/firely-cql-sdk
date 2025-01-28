namespace CqlSdkPrototype.Invocation.Extensibility;

public static class RuntimeApiExtendableExtensions
{
    public static IRuntimeApiExtendable<LibrarySetInvokerBuilder> AsExtendable(this LibrarySetInvokerBuilder self) => self;
}
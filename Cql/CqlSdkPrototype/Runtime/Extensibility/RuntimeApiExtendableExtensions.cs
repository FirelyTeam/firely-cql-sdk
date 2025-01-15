namespace CqlSdkPrototype.Runtime.Extensibility;

public static class RuntimeApiExtendableExtensions
{
    public static IRuntimeApiExtendable<RuntimeApi> AsExtendable(this RuntimeApi self) => self;
}
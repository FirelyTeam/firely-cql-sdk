namespace CqlSdkPrototype.Cql.Extensibility;

public static class CqlApiExtendableExtensions
{
    public static ICqlApiExtendable<CqlApi> AsExtendable(this CqlApi self) => self;
}
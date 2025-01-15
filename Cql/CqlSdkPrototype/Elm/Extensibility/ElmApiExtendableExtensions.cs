namespace CqlSdkPrototype.Elm.Extensibility;

public static class ElmApiExtendableExtensions
{
    public static IElmApiExtendable<ElmApi> AsExtendable(this ElmApi self) => self;
}
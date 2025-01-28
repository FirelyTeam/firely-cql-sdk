namespace CqlSdkPrototype.Elm.Fluent.Extensions;

public static partial class FluentElmToolkitExtensions
{
    private static ILogger CreateLogger(this FluentElmToolkit elmToolkit) =>
        elmToolkit.LoggerFactory.CreateLogger(typeof(FluentElmToolkitExtensions));
}
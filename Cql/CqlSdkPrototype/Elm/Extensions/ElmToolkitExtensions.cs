namespace CqlSdkPrototype.Elm.Extensions;

public static partial class ElmToolkitExtensions
{
    private static ILogger CreateLogger(this IElmFluentToolkit elmToolkit) =>
        elmToolkit.LoggerFactory.CreateLogger(typeof(ElmToolkitExtensions));
}
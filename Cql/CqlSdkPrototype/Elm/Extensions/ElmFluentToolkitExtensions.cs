namespace CqlSdkPrototype.Elm.Extensions;

public static partial class ElmFluentToolkitExtensions
{
    private static ILogger CreateLogger(this ElmFluentToolkit elmToolkit) =>
        elmToolkit.LoggerFactory.CreateLogger(typeof(ElmFluentToolkitExtensions));
}
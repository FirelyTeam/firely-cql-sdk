namespace CqlSdkPrototype.Cql.Extensions;

public static partial class CqlToolkitExtensions
{
    private static ILogger CreateLogger(this ICqlFluentToolkit cqlToolkit) =>
        cqlToolkit.LoggerFactory.CreateLogger(typeof(CqlToolkitExtensions));

}
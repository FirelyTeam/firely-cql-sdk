namespace CqlSdkPrototype.Cql.Extensions;

public static partial class CqlFluentToolkitExtensions
{
    private static ILogger CreateLogger(this CqlFluentToolkit cqlToolkit) =>
        cqlToolkit.LoggerFactory.CreateLogger(typeof(CqlFluentToolkitExtensions));

}
namespace CqlSdkPrototype.Cql.Fluent.Extensions;

public static partial class FluentCqlToolkitExtensions
{
    private static ILogger CreateLogger(this FluentCqlToolkit cqlToolkit) =>
        cqlToolkit.LoggerFactory.CreateLogger(typeof(FluentCqlToolkitExtensions));

}
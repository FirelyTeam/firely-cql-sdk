using CqlSdkPrototype.App;
using CqlSdkPrototype.Cql;
using CqlSdkPrototype.Elm;

namespace CqlSdkPrototype.Runtime;

public record RuntimeApiOptions(
    LoggingOptions LoggingOptions)
{
    public RuntimeApiOptions() : this(LoggingOptions.Default) { }

    public static RuntimeApiOptions Default { get; } = new();
}

public static class CqlApiOptionsExtensions
{
    public static RuntimeApiOptions CreateRuntimeApiOptions(this CqlApiOptions cqlApiOptions)
    {
        return RuntimeApiOptions.Default with
        {
            LoggingOptions = cqlApiOptions.LoggingOptions,
        };
    }

    public static RuntimeApiOptions CreateRuntimeApiOptions(this ElmApiOptions cqlApiOptions)
    {
        return RuntimeApiOptions.Default with
        {
            LoggingOptions = cqlApiOptions.LoggingOptions,
        };
    }
}
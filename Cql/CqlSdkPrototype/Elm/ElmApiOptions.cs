using CqlSdkPrototype.App;
using CqlSdkPrototype.Cql;
using Hl7.Cql.Abstractions.Exceptions;

namespace CqlSdkPrototype.Elm;

public record ElmApiOptions(
    LoggingOptions? LoggingOptions = null,
    ProcessBatchItemExceptionHandling ProcessBatchItemExceptionHandling = default,
    bool ShouldEmitPdbStream = false)
{
    public static ElmApiOptions Default { get; } = new();
    public LoggingOptions LoggingOptions { get; init; } = LoggingOptions ?? LoggingOptions.Default;
}

public static class CqlApiOptionsExtensions
{
    public static ElmApiOptions CreateElmApiOptions(this CqlApiOptions cqlApiOptions)
    {
        return ElmApiOptions.Default with
        {
            LoggingOptions = cqlApiOptions.LoggingOptions,
            ProcessBatchItemExceptionHandling = cqlApiOptions.ProcessBatchItemExceptionHandling,
            //ShouldEmitPdbStream =
        };
    }
}
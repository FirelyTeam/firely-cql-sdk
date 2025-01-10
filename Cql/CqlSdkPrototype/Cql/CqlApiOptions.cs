using CqlSdkPrototype.App;
using Hl7.Cql.Abstractions.Exceptions;
using Hl7.Cql.Model;

namespace CqlSdkPrototype.Cql;

public record CqlApiOptions(
    LoggingOptions? LoggingOptions = null,
    ProcessBatchItemExceptionHandling ProcessBatchItemExceptionHandling = default,
    ModelInfo[]? Models = null)
{
    public static CqlApiOptions Default { get; } = new();
    public LoggingOptions LoggingOptions { get; init; } = LoggingOptions ?? LoggingOptions.Default;
    public ModelInfo[] Models { get; init; } = Models ?? [];
}
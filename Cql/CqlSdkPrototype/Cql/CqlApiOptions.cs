using Hl7.Cql.Abstractions.Exceptions;
using Hl7.Cql.Model;
using Microsoft.Extensions.Logging.Abstractions;

namespace CqlSdkPrototype.Cql;

public record CqlApiOptions(
    ILoggerFactory? LoggerFactory = null,
    ProcessBatchItemExceptionHandling ProcessBatchItemExceptionHandling = default,
    ModelInfo[]? Models = null)
{
    public static CqlApiOptions Default { get; } = new();
    public ILoggerFactory LoggerFactory { get; init; } = LoggerFactory ?? NullLoggerFactory.Instance;
    public ModelInfo[] Models { get; init; } = Models ?? [];
}
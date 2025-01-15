using Hl7.Cql.Abstractions.Exceptions;
using Hl7.Cql.Model;

namespace CqlSdkPrototype.Cql;

public record CqlApiOptions(
    ProcessBatchItemExceptionHandling ProcessBatchItemExceptionHandling = default,
    ModelInfo[]? Models = null)
{
    public static CqlApiOptions Default { get; } = new();
    public ModelInfo[] Models { get; init; } = Models ?? [];
}
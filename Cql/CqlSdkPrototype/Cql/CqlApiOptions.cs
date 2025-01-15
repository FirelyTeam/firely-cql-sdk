using Hl7.Cql.Abstractions.Exceptions;

namespace CqlSdkPrototype.Cql;

public record CqlApiOptions(
    ProcessBatchItemExceptionHandling ProcessBatchItemExceptionHandling = default,
    ImmutableHashSet<CqlModel>? Models = null)
{
    public static CqlApiOptions Default { get; } = new();
    public ImmutableHashSet<CqlModel> Models { get; init; } = Models ?? [];
}
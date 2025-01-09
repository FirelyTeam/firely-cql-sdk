using Hl7.Cql.Abstractions.Exceptions;

namespace CqlSdkPrototype.Cql;

public record CqlApiOptions(
    IServiceProvider ServiceProvider,
    ProcessBatchItemExceptionHandling ProcessBatchItemExceptionHandling)
{
    internal IServiceProvider ServiceProvider { get; } = ServiceProvider ?? throw new ArgumentNullException(nameof(ServiceProvider));

    public static CqlApiOptions Create(
        IServiceProvider serviceProvider,
        ProcessBatchItemExceptionHandling processBatchItemExceptionHandling = default) =>
        new(
            serviceProvider,
            processBatchItemExceptionHandling);
}
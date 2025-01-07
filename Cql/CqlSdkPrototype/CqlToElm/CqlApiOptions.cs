using Hl7.Cql.Abstractions.Exceptions;

namespace CqlSdkPrototype.CqlToElm;

public record CqlApiOptions(
    IServiceProvider ServiceProvider,
    ProcessBatchItemExceptionHandling ProcessBatchItemExceptionHandling)
{
    public IServiceProvider ServiceProvider { get; init; } = ServiceProvider ?? throw new ArgumentNullException(nameof(ServiceProvider));

    public static CqlApiOptions Create(
        IServiceProvider serviceProvider,
        ProcessBatchItemExceptionHandling processBatchItemExceptionHandling = default) =>
        new(
            serviceProvider,
            processBatchItemExceptionHandling);
}
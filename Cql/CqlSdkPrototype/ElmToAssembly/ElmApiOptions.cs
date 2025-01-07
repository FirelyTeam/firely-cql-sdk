using CqlSdkPrototype.CqlToElm;
using Hl7.Cql.Abstractions.Exceptions;

namespace CqlSdkPrototype.ElmToAssembly;

public record ElmApiOptions(
    IServiceProvider ServiceProvider,
    ProcessBatchItemExceptionHandling ProcessBatchItemExceptionHandling)
{
    public IServiceProvider ServiceProvider { get; init; } = ServiceProvider ?? throw new ArgumentNullException(nameof(ServiceProvider));

    public static ElmApiOptions Create(
        IServiceProvider serviceProvider,
        ProcessBatchItemExceptionHandling processBatchItemExceptionHandling = default) =>
        new(
            serviceProvider,
            processBatchItemExceptionHandling);

    public static ElmApiOptions Create(CqlApiOptions cqlApiOptions)
    {
        return Create(cqlApiOptions.ServiceProvider, cqlApiOptions.ProcessBatchItemExceptionHandling);
    }
}
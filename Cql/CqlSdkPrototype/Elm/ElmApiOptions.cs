using CqlSdkPrototype.Cql;
using Hl7.Cql.Abstractions.Exceptions;

namespace CqlSdkPrototype.Elm;

public record ElmApiOptions(
    IServiceProvider ServiceProvider,
    ProcessBatchItemExceptionHandling ProcessBatchItemExceptionHandling,
    bool ShouldEmitPdbStream)
{
    internal IServiceProvider ServiceProvider { get; init; } = ServiceProvider ?? throw new ArgumentNullException(nameof(ServiceProvider));

    public static ElmApiOptions Create(
        IServiceProvider serviceProvider,
        ProcessBatchItemExceptionHandling processBatchItemExceptionHandling = default,
        bool emitPdbStream = false) =>
        new(
            serviceProvider,
            processBatchItemExceptionHandling,
            emitPdbStream);

    public static ElmApiOptions Create(CqlApiOptions cqlApiOptions)
    {
        return Create(cqlApiOptions.ServiceProvider, cqlApiOptions.ProcessBatchItemExceptionHandling);
    }
}
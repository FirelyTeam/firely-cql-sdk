using Hl7.Cql.Abstractions.Exceptions;

namespace CqlSdkPrototype.Packaging;

#pragma warning disable RS0027 
public record FhirResourcePackagerConfig(
#pragma warning restore RS0027
    ProcessBatchItemExceptionHandling ProcessBatchItemExceptionHandling = default)
{
    /// <summary>
    /// Gets the default configuration settings.
    /// </summary>
    public static FhirResourcePackagerConfig Default { get; } = new FhirResourcePackagerConfig();

    public ProcessBatchItemExceptionHandling ProcessBatchItemExceptionHandling { get; init; } = ProcessBatchItemExceptionHandling;
}
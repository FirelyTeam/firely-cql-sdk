using Hl7.Cql.Runtime;

namespace CqlSdkPrototype.Packaging;

#pragma warning disable RS0027 
public record FhirResourcePackagerConfig(
#pragma warning restore RS0027
    EnumerationExceptionHandling EnumerationExceptionHandling = default)
{
    /// <summary>
    /// Gets the default configuration settings.
    /// </summary>
    public static FhirResourcePackagerConfig Default { get; } = new FhirResourcePackagerConfig();

    public EnumerationExceptionHandling EnumerationExceptionHandling { get; init; } = EnumerationExceptionHandling;
}
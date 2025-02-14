using Hl7.Cql.Runtime;

namespace CqlSdkPrototype.Packaging;

#pragma warning disable RS0027
public record FhirResourcePackagerConfig(
#pragma warning restore RS0027
    ErroredEnumerationContinuation ErroredEnumerationContinuation = default)
{
    /// <summary>
    /// Gets the default configuration settings.
    /// </summary>
    public static FhirResourcePackagerConfig Default { get; } = new FhirResourcePackagerConfig();

    public ErroredEnumerationContinuation ErroredEnumerationContinuation { get; init; } = ErroredEnumerationContinuation;
}
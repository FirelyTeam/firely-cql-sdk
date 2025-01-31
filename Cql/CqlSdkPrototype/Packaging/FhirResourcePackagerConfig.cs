namespace CqlSdkPrototype.Packaging;

public record FhirResourcePackagerConfig
{
    /// <summary>
    /// Gets the default configuration settings.
    /// </summary>
    public static FhirResourcePackagerConfig Default { get; } = new FhirResourcePackagerConfig();
}
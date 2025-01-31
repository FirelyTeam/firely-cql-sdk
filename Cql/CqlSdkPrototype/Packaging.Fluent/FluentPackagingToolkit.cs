namespace CqlSdkPrototype.Packaging.Fluent;

/// <summary>
/// Provides a fluent interface for working with the FHIR resource packager.
/// </summary>
public sealed class FluentPackagingToolkit
{
    private readonly FhirResourcePackager _fhirResourcePackager;

    /// <summary>
    /// Initializes a new instance of the <see cref="FluentPackagingToolkit"/> class.
    /// </summary>
    /// <param name="loggerFactory">The logger factory to use for logging.</param>
    /// <param name="config">The configuration settings for the packager.</param>
    public FluentPackagingToolkit(
        ILoggerFactory? loggerFactory = null,
        FhirResourcePackagerConfig? config = null) : this(new FhirResourcePackager(loggerFactory, config))
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="FluentPackagingToolkit"/> class.
    /// </summary>
    /// <param name="fhirResourcePackager">The packager to use.</param>
    public FluentPackagingToolkit(FhirResourcePackager fhirResourcePackager)
    {
        _fhirResourcePackager = fhirResourcePackager;
    }

    /// <summary>
    /// Gets the service provider used by tests.
    /// </summary>
    internal ServiceProvider ServiceProvider => _fhirResourcePackager.ServiceProvider;

    /// <summary>
    /// Gets the logger factory used by extensions.
    /// </summary>
    public ILoggerFactory LoggerFactory => _fhirResourcePackager.LoggerFactory;

    /// <summary>
    /// Gets the configuration for the compiler.
    /// </summary>
    public FhirResourcePackagerConfig PackagerConfig => _fhirResourcePackager.Config;

    /// <summary>
    /// Reconfigures the packager with the specified configuration.
    /// </summary>
    /// <param name="configure">A function that takes the current configuration and returns a new configuration.</param>
    /// <returns>The current instance of <see cref="FluentPackagingToolkit"/>.</returns>
    public FluentPackagingToolkit Reconfigure(Func<FhirResourcePackagerConfig, FhirResourcePackagerConfig> configure)
    {
        _fhirResourcePackager.Reconfigure(configure(PackagerConfig));
        return this;
    }

    /// <summary>
    /// Adds FHIR resource packaging inputs to the packager.
    /// </summary>
    /// <param name="inputs">The collection of FHIR resource packaging inputs to add.</param>
    /// <returns>The current instance of <see cref="FluentPackagingToolkit"/>.</returns>
    public FluentPackagingToolkit AddPackagingInputs(IEnumerable<FhirResourcePackagingInput> inputs)
    {
        _fhirResourcePackager.AddPackagingInputs(inputs);
        return this;
    }


    // private readonly FhirResourcePackagerServices _services = FhirResourcePackagerServices.Create(loggerFactory ?? NullLoggerFactory.Instance);
    //
    // public FhirLibrary CreateLibraryResource(
    //     ElmLibrary elmLibrary,
    //     byte[] elmBytes,
    //     byte[]? cqlBytes,
    //     string? cSharpSourceCode,
    //     byte[]? assemblyBinary,
    //     string? resourceCanonicalRootUrl = null,
    //     DateTime? elmFileLastWriteTimeUtc = null)
    // {
    //     var libraryResource = LibraryPackager.CreateLibraryResource(
    //         _services.CqlTypeToFhirTypeMapper,
    //         elmLibrary,
    //         elmBytes,
    //         cqlBytes,
    //         assemblyBinary,
    //         cSharpSourceCode is not null
    //             ? KeyValuePair.Create($"{CqlVersionedLibraryIdentifier.FromVersionedIdentifier(elmLibrary.identifier)}", cSharpSourceCode).EnumerateSingle()
    //             : [],
    //         resourceCanonicalRootUrl,
    //         elmFileLastWriteTimeUtc);
    //     return libraryResource;
    // }
    public FluentPackagingToolkit PackageFhirResources(
        Uri? canonicalRootUrl = null,
        DateTime? overrideDate = null)
    {
        _fhirResourcePackager.PackageFhirResources(canonicalRootUrl, overrideDate);
        return this;
    }
}
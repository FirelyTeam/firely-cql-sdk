using CqlSdkPrototype.Infrastructure;
using CqlSdkPrototype.Internal;
using Hl7.Cql.Abstractions;
using Hl7.Cql.Fhir;
using Hl7.Cql.Packaging;
using Hl7.Fhir.Introspection;

namespace CqlSdkPrototype.Packaging;

using ElmLibrary = Hl7.Cql.Elm.Library;

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
    public FluentPackagingToolkit AddFhirResourcePackagingInput(IEnumerable<FhirResourcePackagingInput> inputs)
    {
        _fhirResourcePackager.AddFhirResourcePackagingInput(inputs);
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
}

public sealed class FhirResourcePackager
{
    public FhirResourcePackager(
        ILoggerFactory? loggerFactory = null,
        FhirResourcePackagerConfig? config = null)
    {
        config ??= FhirResourcePackagerConfig.Default;
        loggerFactory ??= NullLoggerFactory.Instance;
        LoggerFactory = loggerFactory;
        _fhirResourcePackagings = FhirResourcePackagingDictionary.Empty;
        Config = config;
        _services = FhirResourcePackagerServices.Create(loggerFactory);
    }

    private FhirResourcePackagingDictionary _fhirResourcePackagings;
    private FhirResourcePackagerServices _services;

    /// <summary>
    /// Gets the logger factory used by extensions via <seealso cref="FluentPackagingToolkit.LoggerFactory"/>.
    /// </summary>
    internal ILoggerFactory LoggerFactory { get; }

    /// <summary>
    /// Gets the service provider used by tests via <seealso cref="FluentPackagingToolkit.ServiceProvider"/>.
    /// </summary>
    internal ServiceProvider ServiceProvider => _services.ServiceProvider;


    /// <summary>
    /// Gets the configuration settings for the resource packager.
    /// </summary>
    public FhirResourcePackagerConfig Config { get; private set; }

    /// <summary>
    /// Gets the dictionary of FHIR resource packagings.
    /// </summary>
    public FhirResourcePackagingReadOnlyDictionary FhirResourcePackagings => _fhirResourcePackagings;


    /// <summary>
    /// Reconfigures the packager with the specified configuration.
    /// </summary>
    /// <param name="config">The new configuration for the packager.</param>
    public void Reconfigure(
        FhirResourcePackagerConfig config)
    {
        if (Config == config)
            return;

        //_services.ServiceProvider.Dispose();
        Config = config;
        //_services = ElmToAssemblyProcessorServices.Create(LoggerFactory, config);
    }

    /// <summary>
    /// Adds FHIR resource packaging inputs to the packager.
    /// </summary>
    /// <param name="inputs">The collection of FHIR resource packaging inputs to add.</param>
    public void AddFhirResourcePackagingInput(IEnumerable<FhirResourcePackagingInput> inputs)
    {
        var builder = _fhirResourcePackagings.ToBuilder();
        var hasChanged = false;
        foreach (var input in inputs)
        {
            if (builder.TryGetValue(input.VersionedLibraryIdentifier, out var existing))
            {
                _services.Logger.LogInformation("Skipping replacing library {id} to packager.", input.VersionedLibraryIdentifier);
                continue;
            }

            var fhirResourcePackaging = new FhirResourcePackaging(input);
            builder.Add(input.VersionedLibraryIdentifier, fhirResourcePackaging);
            hasChanged = true;
        }

        if (hasChanged)
            _fhirResourcePackagings = builder.ToImmutable();
    }
}

public record FhirResourcePackagerConfig
{
    /// <summary>
    /// Gets the default configuration settings.
    /// </summary>
    public static FhirResourcePackagerConfig Default { get; } = new FhirResourcePackagerConfig();
}

public readonly record struct FhirResourcePackagingInput
(
    CqlLibraryString CqlLibrary,
    ElmLibrary ElmLibrary,
    string CSharpSourceCode,
    byte[] AssemblyBinary
)
{
    public CqlVersionedLibraryIdentifier VersionedLibraryIdentifier => CqlLibrary.VersionedLibraryIdentifier;
}

public readonly record struct FhirResourcePackaging
(
    // Inputs
    FhirResourcePackagingInput Input,
    // Output
    string? FhirLibraryResourceJson = null
 )
{
    public CqlVersionedLibraryIdentifier VersionedLibraryIdentifier => Input.VersionedLibraryIdentifier;
}

internal readonly record struct FhirResourcePackagerServices(
    ServiceProvider ServiceProvider,
    ILogger<FhirResourcePackager> Logger,
    CqlTypeToFhirTypeMapper CqlTypeToFhirTypeMapper)
{
    public static FhirResourcePackagerServices Create(ILoggerFactory loggerFactory)
    {
        var services = new ServiceCollection();
        services.AddExternalLogging(loggerFactory);
        services.TryAddSingleton<ModelInspector>(_ => Hl7.Fhir.Model.ModelInfo.ModelInspector);
        services.TryAddSingleton<TypeResolver, FhirTypeResolver>();
        services.TryAddSingleton<CqlTypeToFhirTypeMapper>();
        var serviceProvider = services.BuildServiceProvider();
        return ActivatorUtilities.CreateInstance<FhirResourcePackagerServices>(serviceProvider, serviceProvider);
    }

}
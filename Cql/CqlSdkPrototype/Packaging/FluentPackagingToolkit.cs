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
}


public record FhirResourcePackagerConfig
{
    /// <summary>
    /// Gets the default configuration settings.
    /// </summary>
    public static FhirResourcePackagerConfig Default { get; } = new FhirResourcePackagerConfig();
}

public readonly record struct FhirResourcePackaging(
    CqlLibraryString CqlLibrary,
    ElmLibrary ElmLibrary,
    string CSharpSourceCode,
    byte[] AssemblyBinary);

internal readonly record struct FhirResourcePackagerServices(
    ServiceProvider ServiceProvider,
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
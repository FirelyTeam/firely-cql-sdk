using CqlSdkPrototype.Infrastructure;
using CqlSdkPrototype.Packaging.Fluent;
using CqlSdkPrototype.Packaging.Internal;
using Hl7.Cql.Compiler;
using Hl7.Cql.Packaging;

namespace CqlSdkPrototype.Packaging;

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

    private void SetFhirResourcePackagings(FhirResourcePackagingDictionary packagings) =>
        _fhirResourcePackagings = packagings;

    /// <summary>
    /// Adds FHIR resource packaging inputs to the packager.
    /// </summary>
    /// <param name="inputs">The collection of FHIR resource packaging inputs to add.</param>
    public void AddPackagingInputs(IEnumerable<FhirResourcePackagingInput> inputs)
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

    public void PackageFhirResources(Uri? canonicalRootUrl, DateTime? overrideDate)
    {
        var builder = _fhirResourcePackagings.ToBuilder();
        LibrarySet librarySet = new LibrarySet("", builder.Values.Select(o => o.Input.ElmLibrary).ToArray());
        var packageResourcesV2 = _services.ResourcePackager.PackageResourcesV2(
            librarySet,
            builder.Values.Select(o => new ResourcePackager.Input(o.VersionedLibraryIdentifier.ToString(), o.Input.CqlLibrary.Cql, o.Input.ElmLibrary, o.Input.CSharpSourceCode, o.Input.AssemblyBinary)),
            canonicalRootUrl?.ToString(),
            overrideDate);
        bool hasChanged = false;
        foreach (var (versionedLibraryIdentifier, getFhirResource) in packageResourcesV2)
        {
            var fhirResource = getFhirResource();
            var cqlVersionedLibraryIdentifier = CqlVersionedLibraryIdentifier.Parse(versionedLibraryIdentifier);
            var fhirResourcePackaging = builder[cqlVersionedLibraryIdentifier];
            if (fhirResourcePackaging.FhirResource is not null)
                _services.Logger.LogWarning("Skipping replacing existing resource for {id}.", versionedLibraryIdentifier);
            else
            {
                builder[cqlVersionedLibraryIdentifier] = fhirResourcePackaging with { FhirResource = fhirResource};
                hasChanged = true;
            }
        }

        if (hasChanged)
            SetFhirResourcePackagings(builder.ToImmutable());
    }
}
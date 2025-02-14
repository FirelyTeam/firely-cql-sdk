using CqlSdkPrototype.Infrastructure;
using CqlSdkPrototype.Packaging.Fluent;
using CqlSdkPrototype.Packaging.Internal;
using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.Compiler;
using Hl7.Cql.Elm;
using Hl7.Cql.Packaging;
using Hl7.Cql.Runtime;

namespace CqlSdkPrototype.Packaging;

using SysDateTime = System.DateTime;

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
    /// Gets the logger factory used by extensions via <seealso cref="PackagingToolkit.LoggerFactory"/>.
    /// </summary>
    internal ILoggerFactory LoggerFactory { get; }

    /// <summary>
    /// Gets the service provider used by tests via <seealso cref="PackagingToolkit.ServiceProvider"/>.
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

        Config = config;
    }

    private void SetFhirResourcePackagings(FhirResourcePackagingDictionary packagings) =>
        _fhirResourcePackagings = packagings;

    /// <summary>
    /// Adds FHIR resource packaging inputs to the packager.
    /// </summary>
    /// <param name="sources">The collection of FHIR resource packaging inputs to add.</param>
    public void AddPackagingInputs(IEnumerable<FhirResourcePackagingSources> sources)
    {
        var builder = _fhirResourcePackagings.ToBuilder();
        var hasChanged = false;
        foreach (var input in sources)
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

    public void PackageFhirResources(Uri? canonicalRootUrl, SysDateTime? overrideDate)
    {
        var builder = _fhirResourcePackagings.ToBuilder();

        var libraries = builder.Values.Select(o => o.ElmLibrary);

        var nodes = libraries.ToLibraryDependencyNodesByVersionedIdentifiers();

        var logger = _services.Logger;

        var librariesToPackage =
            nodes.Values
                 .Where(n =>
                 {
                     if (n.HasMissingDependenciesRecursive)
                     {
                         logger.LogWarning("Skipping packaging FHIR resources for library {id} due to missing dependencies.", n.VersionedIdentifier);
                         return false;
                     }

                     return true;
                 })
                 .Select(n => n.Library!)
                 .ToArray();
        LibrarySet librarySet = new LibrarySet("", librariesToPackage);

        var resourcePackagerInputs =
            builder.Values
                   .Select(o =>
                   {
                       logger.LogInformation("Packaging FHIR resources for library {id}.", o.VersionedLibraryIdentifier);
                       return ToResourcePackagerInput(o);
                   });

        var logPackageFailed =
            logger.CreateLogExceptionHandler<ElmLibrary>(
                Config.EnumerationExceptionHandling,
                (library, log) => log("Could not package FHIR resources for library {lib}", library.GetVersionedIdentifier()!));

        var inputsById = resourcePackagerInputs.ToDictionary(o => o.VersionedLibraryIdentifier);

        var count =
            _services.ResourcePackager
                     .PackageEachElmLibraryToFhirResources(
                         librarySet: librarySet,
                         inputsById: id => inputsById[id],
                         resourceCanonicalRootUrl: canonicalRootUrl?.ToString(),
                         overrideDate: overrideDate,
                         logPackageFailed)
                     .SelectWhere(o =>
                     {
                         var versionedLibraryIdentifier = CqlVersionedLibraryIdentifier.Parse(o.versionedLibraryIdentifier);
                         var fhirResourcePackaging = builder[versionedLibraryIdentifier];
                         if (fhirResourcePackaging.FhirLibrary is null)
                         {
                             logger.LogInformation("Packaged FHIR resources for library {id}.", versionedLibraryIdentifier);
                             builder[versionedLibraryIdentifier] = fhirResourcePackaging with { FhirLibrary = o.fhirLibrary, FhirMeasure = o.fhirMeasure};
                             return (true, o);
                         }

                         logger.LogWarning("Skipping replacing existing FHIR resources for library {id}.", versionedLibraryIdentifier);
                         return (false, default);
                     })
                     .Count();

        if (count > 0)
            SetFhirResourcePackagings(builder.ToImmutable());
    }

    private static ResourcePackager.SourceArtefacts ToResourcePackagerInput(FhirResourcePackaging o) => new(
        o.VersionedLibraryIdentifier.ToString(),
        o.CqlLibrary.Cql,
        o.ElmLibrary,
        o.CSharpSourceCode,
        o.AssemblyBinary);
}
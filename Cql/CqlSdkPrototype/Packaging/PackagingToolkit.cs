using CqlSdkPrototype.Infrastructure;
using CqlSdkPrototype.Packaging.Internal;
using Hl7.Cql.Abstractions;
using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.Compiler;
using Hl7.Cql.Elm;
using Hl7.Cql.Packaging;
using Hl7.Cql.Runtime;

namespace CqlSdkPrototype.Packaging;

using SysDateTime = System.DateTime;

public sealed class PackagingToolkit
{
    public PackagingToolkit(
        ILoggerFactory? loggerFactory = null,
        PackagingToolkitConfig? config = null)
    {
        config ??= PackagingToolkitConfig.Default;
        loggerFactory ??= NullLoggerFactory.Instance;
        LoggerFactory = loggerFactory;
        _conversions = PackagingToolkitConversionsDictionary.Empty;
        Config = config;
        _services = PackagingToolkitServices.Create(loggerFactory);
    }

    private PackagingToolkitConversionsDictionary _conversions;
    private readonly PackagingToolkitServices _services;

    /// <summary>
    /// Gets the logger factory used by extensions.
    /// </summary>
    internal ILoggerFactory LoggerFactory { get; }

    /// <summary>
    /// Gets the service provider used by tests.
    /// </summary>
    internal ServiceProvider ServiceProvider => _services.ServiceProvider;

    /// <summary>
    /// Gets the configuration settings for the resource packager.
    /// </summary>
    public PackagingToolkitConfig Config { get; private set; }

    /// <summary>
    /// Gets the dictionary of conversions.
    /// </summary>
    public PackagingToolkitConversionsReadOnlyDictionary Conversions => _conversions;


    /// <summary>
    /// Reconfigures the packager with the specified configuration.
    /// </summary>
    /// <param name="reconfigure">The new configuration for the packager.</param>
    public PackagingToolkit Reconfigure(
        Transformer<PackagingToolkitConfig> reconfigure)
    {
        var config = reconfigure(Config);

        Config = config;
        return this;
    }

    private void ReplaceConversions(PackagingToolkitConversionsDictionary conversions) =>
        _conversions = conversions;

    /// <summary>
    /// Adds FHIR resource packaging inputs to the packager.
    /// </summary>
    /// <param name="sources">The collection of FHIR resource packaging inputs to add.</param>
    public PackagingToolkit AddPackagingSources(IEnumerable<PackagingToolkitSourceRecord> sources)
    {
        var builder = _conversions.ToBuilder();
        var hasChanged = false;
        foreach (var input in sources)
        {
            if (builder.TryGetValue(input.VersionedLibraryIdentifier, out var existing))
            {
                _services.Logger.LogInformation("Skipping replacing library {id} to packager.", input.VersionedLibraryIdentifier);
                continue;
            }

            var fhirResourcePackaging = new PackagingToolkitConversionRecord(input);
            builder.Add(input.VersionedLibraryIdentifier, fhirResourcePackaging);
            hasChanged = true;
        }

        if (hasChanged)
            _conversions = builder.ToImmutable();

        return this;
    }

    public PackagingToolkit ConvertToFhirResources(Uri? canonicalRootUrl, SysDateTime? overrideDate)
    {
        var builder = _conversions.ToBuilder();

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

        var inputsById = builder.Values
                                .Select(ToResourcePackagerInput)
                                .ToDictionary(o => o.VersionedLibraryIdentifier);

        var count =
            _services.ResourcePackager
                     .PackageEachElmLibraryToFhirResources(
                         librarySet: librarySet,
                         inputsById: id => inputsById[id],
                         resourceCanonicalRootUrl: canonicalRootUrl?.ToString(),
                         overrideDate: overrideDate,
                         errorStrategy => errorStrategy
                             .SetContinuation(Config.ErroredEnumerationContinuation)
                             .AddLoggerExceptionHandler(logger, (library, logMessage) => logMessage("Could not package FHIR resources for library {lib}", library.GetVersionedIdentifier()!)),
                         onNextLibrary: library => logger.LogInformation("Packaging FHIR resources for library {id}.", library.GetVersionedIdentifier()))
                     .SelectWhere(o =>
                     {
                         var versionedLibraryIdentifier = CqlVersionedLibraryIdentifier.Parse(o.versionedLibraryIdentifier);
                         var fhirResourcePackaging = builder[versionedLibraryIdentifier];
                         if (fhirResourcePackaging.FhirLibrary is null)
                         {
                             builder[versionedLibraryIdentifier] = fhirResourcePackaging with { FhirLibrary = o.fhirLibrary, FhirMeasure = o.fhirMeasure};
                             return (true, o);
                         }

                         logger.LogWarning("Skipping replacing existing FHIR resources for library {id}.", versionedLibraryIdentifier);
                         return (false, default);
                     })
                     .Count();

        if (count > 0)
            ReplaceConversions(builder.ToImmutable());

        return this;
    }

    private static ResourcePackager.SourceArtefacts ToResourcePackagerInput(PackagingToolkitConversionRecord o) => new(
        o.VersionedLibraryIdentifier.ToString(),
        o.CqlLibrary.Cql,
        o.ElmLibrary,
        o.CSharpSourceCode,
        o.AssemblyBinary);
}
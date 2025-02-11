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

        Config = config;
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

    public void PackageFhirResources(Uri? canonicalRootUrl, SysDateTime? overrideDate)
    {
        var builder = _fhirResourcePackagings.ToBuilder();

        var libraries = builder.Values.Select(o => o.Input.ElmLibrary);

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

        IEnumerable<ResourcePackager.Input> resourcePackagerInputs =
            builder.Values
                   .Select(o =>
                   {
                       logger.LogInformation("Packaging FHIR resources for library {id}.", o.VersionedLibraryIdentifier);
                       var input = o.Input;
                       return new ResourcePackager.Input(o.VersionedLibraryIdentifier.ToString(), input.CqlLibrary.Cql, input.ElmLibrary, input.CSharpSourceCode, input.AssemblyBinary);
                   });
        var logPackageFailed =
            logger.CreateLogExceptionHandler<string>(
                Config.EnumerationExceptionHandling,
                (libId, log) => log("Could not package FHIR resources for library {lib}", libId));

        var inputsById = resourcePackagerInputs.ToDictionary(o => o.VersionedLibraryIdentifier);

        var count =
            _services.ResourcePackager
                     .TryPackageEach(
                         librarySet: librarySet,
                         inputsById: id => inputsById[id],
                         resourceCanonicalRootUrl: canonicalRootUrl?.ToString(),
                         overrideDate: overrideDate)
                     .CatchEachPair(logPackageFailed)
                     .SelectWhere(o =>
                     {
                         var versionedLibraryIdentifier = CqlVersionedLibraryIdentifier.Parse(o.Input);
                         var fhirResourcePackaging = builder[versionedLibraryIdentifier];
                         if (fhirResourcePackaging.FhirLibrary is null)
                         {
                             logger.LogInformation("Packaged FHIR resources for library {id}.", versionedLibraryIdentifier);
                             builder[versionedLibraryIdentifier] = fhirResourcePackaging with { FhirLibrary = o.Value.Library, FhirMeasure = o.Value.Measure};
                             return (true, o);
                         }

                         logger.LogWarning("Skipping replacing existing FHIR resources for library {id}.", versionedLibraryIdentifier);
                         return (false, default);
                     })
                     .Count();

        if (count > 0)
            SetFhirResourcePackagings(builder.ToImmutable());
    }
}
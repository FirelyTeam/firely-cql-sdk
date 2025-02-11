using CqlSdkPrototype.Infrastructure;
using CqlSdkPrototype.Packaging.Fluent;
using CqlSdkPrototype.Packaging.Internal;
using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Compiler;
using Hl7.Cql.Elm;
using Hl7.Cql.Packaging;
using Hl7.Cql.Runtime;
using Microsoft.Extensions.Logging;
using DateTime = System.DateTime;

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

        var libraries = builder.Values.Select(o => o.Input.ElmLibrary);

        var nodes = libraries.ToUnresolvedLibraryDependencyNodesDictionary();

        // var mermaid = nodes.Values.BuildMermaidFlowChart(
        //     n => n.Dependencies,
        //     node => $"{node.VersionedIdentifier}{(node.Library is null ? "?" : "")}{(node.HasMissingDependenciesRecursive ? "!" : "")}");

        var librariesToPackage =
            nodes.Values
                 .Where(n => !n.HasMissingDependenciesRecursive)
                 .Select(n => n.Library!)
                 .ToArray();
        LibrarySet librarySet = new LibrarySet("", librariesToPackage);

        var logger = _services.Logger;
        IEnumerable<ResourcePackager.Input> resourcePackagerInputs =
            builder.Values
                   .Select(o =>
                   {
                       logger.LogInformation("Packaging resource for {id}.", o.VersionedLibraryIdentifier);
                       var input = o.Input;
                       return new ResourcePackager.Input(o.VersionedLibraryIdentifier.ToString(), input.CqlLibrary.Cql, input.ElmLibrary, input.CSharpSourceCode, input.AssemblyBinary);
                   });
        var logPackageFailed =
            logger.CreateLoggingEnumerateExceptionHandler<string>(
                Config.EnumerationExceptionHandling,
                (libId, log) => log("Could not package FHIR library resource for {lib}", libId));

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
                         var cqlVersionedLibraryIdentifier = CqlVersionedLibraryIdentifier.Parse(o.Source);
                         var fhirResourcePackaging = builder[cqlVersionedLibraryIdentifier];
                         if (fhirResourcePackaging.FhirResource is null)
                         {
                             logger.LogInformation("Packaged resource for {id}.", cqlVersionedLibraryIdentifier);
                             builder[cqlVersionedLibraryIdentifier] = fhirResourcePackaging with { FhirResource = o.Result };
                             return (true, o);
                         }

                         logger.LogWarning("Skipping replacing existing resource for {id}.", cqlVersionedLibraryIdentifier);
                         return (false, default);
                     })
                     .Count();

        if (count > 0)
            SetFhirResourcePackagings(builder.ToImmutable());
    }
}
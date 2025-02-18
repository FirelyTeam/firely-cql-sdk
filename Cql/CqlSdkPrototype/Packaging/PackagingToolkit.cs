/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

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
        Mutator<PackagingToolkitConfig> reconfigure)
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
    /// <param name="inputRecords">The collection of FHIR resource packaging inputs to add.</param>
    public PackagingToolkit AddPackagingInputs(IEnumerable<PackagingToolkitSourceRecord> inputRecords)
    {
        var conversions = _conversions.ToBuilder();
        var logger = _services.Logger;
        var count = inputRecords
                    .Select(rec => new PackagingToolkitConversionRecord(rec))
                    .TryForEach(conversionRecord =>
                    {
                        var libIdFromCql = conversionRecord.LibraryIdentifier;
                        var libIdFromElm = CqlVersionedLibraryIdentifier.Parse(conversionRecord.SourceElmLibrary.GetVersionedIdentifier()!);
                        if (libIdFromCql != libIdFromElm)
                            throw new InvalidOperationException($"Library identifier mismatch between CQL and ELM libraries: CQL {libIdFromCql}, ELM: {libIdFromElm}.");

                        logger.LogInformation("Adding CQL, ELM, C# and .NET Assembly Binary to PackagingToolkit: {lib}", libIdFromCql);
                        conversions.Add(libIdFromCql, conversionRecord);
                    },
                    errorStrategy => errorStrategy
                                     .SetContinuation(Config.ErroredEnumerationContinuation)
                                     .AddLoggerExceptionHandler(
                                         logger,
                                         (conversionRecord, logMessage) =>
                                             logMessage("Could not add CQL, ELM, C# and .NET Assembly Binary to PackagingToolkit: {lib}.", conversionRecord.LibraryIdentifier)));

        if (count > 0)
            _conversions = conversions.ToImmutable();

        return this;
    }

    public PackagingToolkit ConvertToFhirResources(Uri? canonicalRootUrl, SysDateTime? overrideDate)
    {
        var builder = _conversions.ToBuilder();

        var libraries = builder.Values.Select(o => o.SourceElmLibrary);

        var nodes = libraries.ToLibraryDependencyNodesByVersionedIdentifiers();

        var logger = _services.Logger;

        var librariesToPackage =
            nodes.Values
                 .Where(n =>
                 {
                     if (n.HasMissingDependenciesRecursive)
                     {
                         logger.LogWarning("Skipping packaging FHIR resources for library {lib} due to missing dependencies.", n.VersionedIdentifier);
                         return false;
                     }

                     return true;
                 })
                 .Select(n => n.Library!)
                 .ToArray();
        LibrarySet librarySet = new LibrarySet("", librariesToPackage);

        var inputsById = builder.Values
                                .Select(ToResourcePackagerInput)
                                .ToDictionary(o => o.LibraryIdentifier);

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
                         onNextLibrary: library => logger.LogInformation("Packaging FHIR resources for library: {lib}", library.GetVersionedIdentifier()))
                     .SelectWhere(o =>
                     {
                         var versionedLibraryIdentifier = CqlVersionedLibraryIdentifier.Parse(o.libraryIdentifier);
                         var fhirResourcePackaging = builder[versionedLibraryIdentifier];
                         if (fhirResourcePackaging.ResultFhirLibrary is null)
                         {
                             builder[versionedLibraryIdentifier] = fhirResourcePackaging with { ResultFhirLibrary = o.fhirLibrary, ResultFhirMeasure = o.fhirMeasure};
                             return (true, o);
                         }

                         logger.LogWarning("Skipping replacing existing FHIR resources for library: {lib}.", versionedLibraryIdentifier);
                         return (false, default);
                     })
                     .Count();

        if (count > 0)
            ReplaceConversions(builder.ToImmutable());

        return this;
    }

    private static ResourcePackager.SourceArtefacts ToResourcePackagerInput(PackagingToolkitConversionRecord o) => new(
        o.LibraryIdentifier.ToString(),
        o.SourceCqlLibrary.Cql,
        o.SourceElmLibrary,
        o.SourceCSharpSourceCode,
        o.SourceAssemblyBinary);
}

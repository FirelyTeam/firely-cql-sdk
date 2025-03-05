/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.Compiler;
using Hl7.Cql.Elm;
using Hl7.Cql.Packaging.Toolkit.Internal;
using Hl7.Cql.Runtime;
using Hl7.Cql.Toolkit;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging.Abstractions;

namespace Hl7.Cql.Packaging.Toolkit;

using SysDateTime = System.DateTime;

/// <summary>
/// Provides functionality for packaging FHIR resources.
/// </summary>
public sealed class PackagingToolkit : IToolkit<PackagingToolkit>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PackagingToolkit"/> class.
    /// </summary>
    /// <param name="loggerFactory">The logger factory to use for logging.</param>
    public PackagingToolkit(
        ILoggerFactory? loggerFactory = null)
    {
        loggerFactory ??= NullLoggerFactory.Instance;
        LoggerFactory = loggerFactory;
        _conversions = PackagingToolkitConversionsDictionary.Empty;
        _services = PackagingToolkitServices.Create(loggerFactory);
    }

    private PackagingToolkitConversionsDictionary _conversions;
    private readonly PackagingToolkitServices _services;

    /// <inheritdoc />
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public ILoggerFactory LoggerFactory { get; }

    /// <inheritdoc />
    public BatchProcessExceptionContinuation BatchProcessExceptionContinuation { get; private set; }

    /// <inheritdoc />
    public PackagingToolkit SetBatchProcessExceptionContinuation(BatchProcessExceptionContinuation continuation)
    {
        BatchProcessExceptionContinuation = continuation;
        return this;
    }

    /// <summary>
    /// Gets the service provider used by tests.
    /// </summary>
    internal ServiceProvider ServiceProvider => _services.ServiceProvider;

    /// <summary>
    /// Gets the dictionary of conversions.
    /// </summary>
    public PackagingToolkitConversionsReadOnlyDictionary Conversions => _conversions;

    private void ReplaceConversions(PackagingToolkitConversionsDictionary conversions) =>
        _conversions = conversions;

    /// <summary>
    /// Adds FHIR resource packaging inputs to the packager.
    /// </summary>
    /// <param name="inputRecords">The collection of FHIR resource packaging inputs to add.</param>
    /// <returns>The updated <see cref="PackagingToolkit"/> instance.</returns>
    /// <exception cref="InvalidOperationException">Thrown when there is a library identifier mismatch between CQL and ELM libraries.</exception>
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
                                     .SetContinuation(BatchProcessExceptionContinuation)
                                     .AddLoggerExceptionHandler(
                                         logger,
                                         (conversionRecord, logMessage) =>
                                             logMessage("Could not add CQL, ELM, C# and .NET Assembly Binary to PackagingToolkit: {lib}.", conversionRecord.LibraryIdentifier)));

        if (count > 0)
            _conversions = conversions.ToImmutable();

        return this;
    }

    /// <summary>
    /// Converts the added packaging inputs to FHIR resources.
    /// </summary>
    /// <param name="canonicalRootUrl">The canonical root URL for the FHIR resources.</param>
    /// <param name="overrideDate">The date to override in the FHIR resources.</param>
    /// <returns>The updated <see cref="PackagingToolkit"/> instance.</returns>
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
                             .SetContinuation(BatchProcessExceptionContinuation)
                             .AddLoggerExceptionHandler(logger, (library, logMessage) => logMessage("Could not package FHIR resources for library {lib}", library.GetVersionedIdentifier()!)),
                         onNextLibrary: library => logger.LogInformation("Packaging FHIR resources for library: {lib}", library.GetVersionedIdentifier()))
                     .SelectWhere(o =>
                     {
                         var versionedLibraryIdentifier = CqlVersionedLibraryIdentifier.Parse(o.libraryIdentifier);
                         var fhirResourcePackaging = builder[versionedLibraryIdentifier];
                         if (fhirResourcePackaging.ResultFhirLibrary is null)
                         {
                             builder[versionedLibraryIdentifier] = fhirResourcePackaging with { ResultFhirLibrary = o.fhirLibrary, ResultFhirMeasure = o.fhirMeasure };
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
        o.LibraryIdentifier,
        o.SourceCqlLibrary.Cql,
        o.SourceElmLibrary,
        o.SourceCSharpSourceCode,
        o.SourceAssemblyBinary);
}

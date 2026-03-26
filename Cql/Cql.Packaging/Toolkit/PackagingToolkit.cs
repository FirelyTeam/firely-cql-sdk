/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.Elm;
using Hl7.Cql.Fhir.Serialization.Extensions;
using Hl7.Cql.Packaging.Toolkit.Internal;
using Hl7.Cql.Runtime;
using Hl7.Cql.Toolkit;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging.Abstractions;

namespace Hl7.Cql.Packaging.Toolkit;

/// <summary>
/// Provides functionality for packaging FHIR resources.
/// </summary>
public sealed class PackagingToolkit : IToolkit<PackagingToolkit>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PackagingToolkit"/> class.
    /// </summary>
    /// <param name="loggerFactory">The logger factory to use for logging.</param>
    /// <param name="config">The configuration settings for the toolkit.</param>
    /// <param name="batchProcessExceptionContinuation">The continuation policy to use when an exception occurs during batch processing.</param>
    public PackagingToolkit(
        ILoggerFactory? loggerFactory = null,
        PackagingToolkitConfig? config = null,
        BatchProcessExceptionContinuation batchProcessExceptionContinuation = BatchProcessExceptionContinuation.Throw)
    {
        config ??= PackagingToolkitConfig.Default;
        loggerFactory ??= NullLoggerFactory.Instance;
        LoggerFactory = loggerFactory;
        _artifactsById = PackagingToolkitArtifactsById.Empty;
        Config = config;
        BatchProcessExceptionContinuation = batchProcessExceptionContinuation;
        _services = PackagingToolkitServices.Create(loggerFactory, config);
    }

    private PackagingToolkitArtifactsById _artifactsById;
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
    /// Gets the configuration used by the toolkit.
    /// </summary>
    public PackagingToolkitConfig Config { get; }

    /// <summary>
    /// Gets a read-only collection of artifacts indexed by their unique identifiers.
    /// </summary>
    /// <remarks>
    /// This collection contains all artifacts (C#, ELM, CQL, .NET assembly binaries and debug symbols)
    /// that have been added to the packaging toolkit, indexed by their IDs.
    /// </remarks>
    public ReadOnlyPackagingToolkitArtifactsById ArtifactsById => _artifactsById;

    /// <summary>
    /// Replaces the current collection of artifacts with the specified collection, identified by their IDs.
    /// </summary>
    private void ReplaceArtifactsById(PackagingToolkitArtifactsById artifactsById) =>
        _artifactsById = artifactsById;

    /// <summary>
    /// Adds a collection of input artifacts to the packaging toolkit.
    /// </summary>
    /// <remarks>This method processes the provided input artifacts and adds them to the toolkit. If a
    /// mismatch is detected  between the library identifiers of the CQL and ELM representations of an artifact, an <see
    /// cref="InvalidOperationException"/>  is thrown. The method logs information about successfully added artifacts
    /// and handles errors using a defined  error strategy.</remarks>
    /// <param name="inputArtifactsItems">A collection of <see cref="PackagingToolkitInputArtifacts"/> representing the input artifacts to be added. Each
    /// artifact must have matching library identifiers between its CQL and ELM representations.</param>
    /// <returns>The current instance of <see cref="PackagingToolkit"/> with the added artifacts.</returns>
    /// <exception cref="InvalidOperationException">Thrown if a library identifier mismatch is detected between the CQL and ELM representations of an artifact.</exception>
    public PackagingToolkit AddPackagingInputs(IEnumerable<PackagingToolkitInputArtifacts> inputArtifactsItems)
    {
        var builder = _artifactsById.ToBuilder();
        var logger = _services.Logger;
        var count = inputArtifactsItems
                    .Select(inputArtifactsItem => new PackagingToolkitArtifacts(inputArtifactsItem))
                    .TryForEach(conversionRecord =>
                    {
                        var libIdFromCql = conversionRecord.LibraryIdentifier;
                        var libIdFromElm = CqlVersionedLibraryIdentifier.Parse(conversionRecord.Input.ElmLibrary.VersionedLibraryIdentifier);
                        if (libIdFromCql != libIdFromElm)
                            throw new InvalidOperationException($"Library identifier mismatch between CQL and ELM libraries: CQL {libIdFromCql}, ELM: {libIdFromElm}.");

                        logger.LogInformation("Adding CQL, ELM, C# and .NET Assembly Binary to PackagingToolkit: {lib}", libIdFromCql);
                        builder.Add(libIdFromCql, conversionRecord);
                    },
                    errorStrategy => errorStrategy
                                     .SetContinuation(BatchProcessExceptionContinuation)
                                     .AddLoggerExceptionHandler(
                                         logger,
                                         (conversionRecord, logMessage) =>
                                             logMessage("Could not add CQL, ELM, C# and .NET Assembly Binary to PackagingToolkit: {lib}.", conversionRecord.LibraryIdentifier)));

        if (count > 0)
            _artifactsById = builder.ToImmutable();

        return this;
    }

    /// <summary>
    /// Converts the added packaging inputs to FHIR resources.
    /// </summary>
    /// <returns>The updated <see cref="PackagingToolkit"/> instance.</returns>
    public PackagingToolkit ConvertToFhirResources()
    {
        var builder = _artifactsById.ToBuilder();

        var libraries = builder.Values.Select(conversionRecord => conversionRecord.Input.ElmLibrary);

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
        ElmLibrarySet librarySet = new ElmLibrarySet("", librariesToPackage);

        var inputArtifactsById =
            builder.Values.ToDictionary(
                o => o.LibraryIdentifier.ToString(),
                o => o.Input.ToResourcePackagerInputArtifacts());

        var count =
            _services.ResourcePackager
                     .PackageEachElmLibraryToFhirResources(
                         librarySet: librarySet,
                         inputsById: id => inputArtifactsById[id],
                         overrideDate: Config.OverrideDate,
                         errorStrategy => errorStrategy
                             .SetContinuation(BatchProcessExceptionContinuation)
                             .AddLoggerExceptionHandler(logger, (library, logMessage) => logMessage("Could not package FHIR resources for library {lib}", library.VersionedLibraryIdentifier)),
                         onNextLibrary: library => logger.LogInformation("Packaging FHIR resources for library: {lib}", library.VersionedLibraryIdentifier))
                     .SelectWhere(o =>
                     {
                         var versionedLibraryIdentifier = CqlVersionedLibraryIdentifier.Parse(o.libraryIdentifier);
                         var artifacts = builder[versionedLibraryIdentifier];
                         if (artifacts.Result is null)
                         {
                             builder[versionedLibraryIdentifier] = artifacts.WithResultArtifacts(o.fhirLibrary, o.fhirMeasure);
                             return (true, o);
                         }

                         logger.LogWarning("Skipping replacing existing FHIR resources for library: {lib}.", versionedLibraryIdentifier);
                         return (false, default);
                     })
                     .Count();

        if (count > 0)
            ReplaceArtifactsById(builder.ToImmutable());

        return this;
    }

    /// <summary>
    /// A utility method that serializes FHIR resources to JSON format.
    /// </summary>
    /// <param name="fhirResources">The collection of FHIR resources to serialize.</param>
    /// <param name="writeIndented">Specifies whether the JSON output should be indented.</param>
    /// <returns>A collection of tuples containing the resource file name and its JSON representation.</returns>
    public IEnumerable<(ResourceFileName resourceFileName, string resourceJson)> SerializeFhirResourcesToJson(
       IEnumerable<FhirResource> fhirResources,
       bool writeIndented = false)
    {
        foreach (var resource in fhirResources)
        {
            var resourceJson = FhirLibrarySerializationExtensions.WriteFhirResourceToJson(resource, writeIndented);
            var resourceFileName = resource.GetResourceFileName();
            yield return (resourceFileName, resourceJson);
        }
    }
}

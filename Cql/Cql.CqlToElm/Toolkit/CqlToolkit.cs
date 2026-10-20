/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.CqlToElm.Toolkit.Internal;
using Hl7.Cql.Runtime;
using Hl7.Cql.Toolkit;
using Microsoft.Extensions.Logging.Abstractions;

namespace Hl7.Cql.CqlToElm.Toolkit;

/// <summary>
/// Translates CQL libraries to ELM libraries.
/// </summary>
public sealed class CqlToolkit : IToolkit<CqlToolkit>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CqlToolkit"/> class.
    /// </summary>
    /// <param name="loggerFactory">The logger factory to use for logging.</param>
    /// <param name="config">The configuration settings for the toolkit.</param>
    /// <param name="batchProcessExceptionContinuation">The continuation policy to use when an exception occurs during batch processing.</param>
    public CqlToolkit(
        ILoggerFactory? loggerFactory = null,
        CqlToolkitConfig? config = null,
        BatchProcessExceptionContinuation batchProcessExceptionContinuation = BatchProcessExceptionContinuation.Throw)
    {
        config ??= CqlToolkitConfig.Default;
        loggerFactory ??= NullLoggerFactory.Instance;
        LoggerFactory = loggerFactory;
        _artifactsById = CqlToolkitArtifactsById.Empty;
        Config = config;
        BatchProcessExceptionContinuation = batchProcessExceptionContinuation;
        _services = CqlToolkitServices.Create(loggerFactory, config, _artifactsById);
    }

    private CqlToolkitArtifactsById _artifactsById;
    private readonly CqlToolkitServices _services;

    /// <inheritdoc/>
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public ILoggerFactory LoggerFactory { get; }

    /// <summary>
    /// Gets the service provider used by tests.
    /// </summary>
    internal ServiceProvider ServiceProvider => _services.ServiceProvider;

    /// <summary>
    /// Gets the configuration used by the toolkit.
    /// </summary>
    public CqlToolkitConfig Config { get; }

    /// <inheritdoc />
    public BatchProcessExceptionContinuation BatchProcessExceptionContinuation { get; private set; }

    /// <inheritdoc />
    public CqlToolkit SetBatchProcessExceptionContinuation(BatchProcessExceptionContinuation continuation)
    {
        BatchProcessExceptionContinuation = continuation;
        return this;
    }

    /// <summary>
    /// Gets a read-only collection of artifacts indexed by their unique identifiers.
    /// </summary>
    /// <remarks>
    /// This collection contains the CQL libraries and their corresponding ELM libraries
    /// that have been added to the toolkit.
    /// </remarks>
    public CqlToolkitArtifactsByIdReadOnly ArtifactsById => _artifactsById;

    /// <summary>
    /// Replaces the current set of artifacts with the specified artifacts, identified by their IDs.
    /// </summary>
    /// <remarks>This method updates the internal state to use the provided artifacts and configures the
    /// associated services to reflect the new artifacts.</remarks>
    /// <param name="artifactsById">The collection of artifacts, indexed by their IDs, to replace the existing artifacts. This parameter cannot be
    /// null.</param>
    private void ReplaceArtifactsById(
        CqlToolkitArtifactsById artifactsById)
    {
        _artifactsById = artifactsById;
        _services.LibraryBuilderProvider.CqlToolkitArtifactsByIdBuilder = artifactsById.ToBuilder();
    }

    /// <summary>
    /// Adds CQL libraries to the translator.
    /// </summary>
    /// <param name="cqlLibraries">The CQL libraries to add.</param>
    public CqlToolkit AddCqlLibraries(IEnumerable<CqlLibraryString> cqlLibraries)
    {
        var logger = _services.Logger;
        var builder = _services.LibraryBuilderProvider.CqlToolkitArtifactsByIdBuilder;

        var count = cqlLibraries
                    .Select(lib => new CqlToolkitArtifacts(lib))
                    .TryForEach(
                        conversionRecord =>
                        {
                            var libId = conversionRecord.LibraryIdentifier;
                            logger.LogInformation("Adding CQL library to CqlToolkit: {lib}", libId);
                            builder.Add(libId, conversionRecord); // This fails on duplicate key and value
                        },
                        errorStrategy => errorStrategy
                                         .SetContinuation(BatchProcessExceptionContinuation)
                                         .AddLoggerExceptionHandler(
                                             logger,
                                             (conversionRecord, logMessage) =>
                                                 logMessage("Could not add CQL library to CqlToolkit: {lib}.", conversionRecord.LibraryIdentifier)));

        if (count > 0)
            ReplaceArtifactsById(builder.ToImmutable());

        return this;
    }

    /// <summary>
    /// Adds ELM libraries that the CQL libraries include, but that are not translated themselves.
    /// </summary>
    /// <remarks>
    /// A reference library resolves the includes of the translated libraries, so that a library whose dependency is
    /// available only as ELM translates without an error for that include. The translator reads the signatures of the
    /// definitions from the ELM: their names, access levels and result types, and the operand types of the functions.
    /// A statement whose ELM declares no result type, or a function with an operand whose ELM declares no type, cannot be
    /// referenced; ELM translated without result types has none. A reference library whose ELM declares a name twice in a
    /// way a reference cannot tell apart leaves its includes unresolved. A reference library with the identifier of a CQL
    /// library is ignored, and the first of several reference libraries with the same identifier is kept. A library that
    /// is already translated is not translated again, so reference libraries are added before
    /// <see cref="TranslateToElm"/> is called.
    /// </remarks>
    /// <param name="elmLibraries">The ELM libraries to add.</param>
    /// <returns>The current instance of <see cref="CqlToolkit"/>.</returns>
    public CqlToolkit AddReferenceLibraries(IEnumerable<ElmLibrary> elmLibraries)
    {
        var provider = _services.LibraryBuilderProvider;
        var builder = provider.ReferenceLibrariesById.ToBuilder();
        foreach (var elmLibrary in elmLibraries)
        {
            var libraryIdentifier = elmLibrary.VersionedLibraryIdentifier;
            if (!_artifactsById.ContainsKey(libraryIdentifier) && builder.TryAdd(libraryIdentifier, elmLibrary))
                _services.Logger.LogInformation("Adding ELM reference library to CqlToolkit, which resolves includes but is not translated: {lib}", libraryIdentifier);
        }

        provider.ReferenceLibrariesById = builder.ToImmutable();
        return this;
    }

    /// <summary>
    /// Translates the CQL libraries to ELM libraries.
    /// </summary>
    public CqlToolkit TranslateToElm()
    {
        CqlToolkitArtifactsById.Builder builder = _services.LibraryBuilderProvider.CqlToolkitArtifactsByIdBuilder;

        var count =
            _artifactsById
                .Values
                .Where(conversion => conversion.ResultElmLibrary is null)
                .TryForEach(
                    r =>
                    {
                        if (!_services.LibraryBuilderProvider.TryResolveLibrary(r.LibraryIdentifier, out var libraryBuilder, out var error))
                            throw new InvalidOperationException($"Could not resolve CQL library: {r.LibraryIdentifier} with error {error}.");

                        var elmLibrary = libraryBuilder.Build();
                        var newConversionRecord = r with { ResultElmLibrary = elmLibrary };
                        builder[r.LibraryIdentifier] = newConversionRecord;
                    },
                    errorStrategy => errorStrategy
                                     .SetContinuation(BatchProcessExceptionContinuation)
                                     .AddLoggerExceptionHandler(_services.Logger,
                                                                (conversion, messageBuilder) =>
                                                                    messageBuilder("Could not translate CQL to ELM: {lib}", conversion.LibraryIdentifier))
                );

        if (count > 0)
            ReplaceArtifactsById(artifactsById: builder.ToImmutable());

        return this;
    }
}
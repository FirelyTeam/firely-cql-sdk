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
        _artifactsByIds = CqlToolkitArtifactsById.Empty;
        Config = config;
        BatchProcessExceptionContinuation = batchProcessExceptionContinuation;
        _services = CqlToolkitServices.Create(loggerFactory, config, _artifactsByIds);
    }

    private CqlToolkitArtifactsById _artifactsByIds;
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
    public CqlToolkitArtifactsByIdReadOnly ArtifactsByIds => _artifactsByIds;

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
        _artifactsByIds = artifactsById;
        _services.LibraryBuilderProvider.ConversionsBuilder = artifactsById.ToBuilder();
    }

    /// <summary>
    /// Adds CQL libraries to the translator.
    /// </summary>
    /// <param name="cqlLibraries">The CQL libraries to add.</param>
    public CqlToolkit AddCqlLibraries(IEnumerable<CqlLibraryString> cqlLibraries)
    {
        var logger = _services.Logger;
        var conversions = _services.LibraryBuilderProvider.ConversionsBuilder;

        var count = cqlLibraries
                    .Select(lib => new CqlToolkitArtifacts(lib))
                    .TryForEach(
                        conversionRecord =>
                        {
                            var libId = conversionRecord.LibraryIdentifier;
                            logger.LogInformation("Adding CQL library to CqlToolkit: {lib}", libId);
                            conversions.Add(libId, conversionRecord); // This fails on duplicate key and value
                        },
                        errorStrategy => errorStrategy
                                         .SetContinuation(BatchProcessExceptionContinuation)
                                         .AddLoggerExceptionHandler(
                                             logger,
                                             (conversionRecord, logMessage) =>
                                                 logMessage("Could not add CQL library to CqlToolkit: {lib}.", conversionRecord.LibraryIdentifier)));

        if (count > 0)
            ReplaceArtifactsById(conversions.ToImmutable());

        return this;
    }

    /// <summary>
    /// Translates the CQL libraries to ELM libraries.
    /// </summary>
    public CqlToolkit TranslateToElm()
    {
        CqlToolkitArtifactsById.Builder builder = _services.LibraryBuilderProvider.ConversionsBuilder;

        var count =
            _artifactsByIds
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
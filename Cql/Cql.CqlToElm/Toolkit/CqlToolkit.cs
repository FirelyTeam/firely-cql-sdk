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

#pragma warning disable FirelyCqlSdkPreview

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
        BatchProcessExceptionContinuation batchProcessExceptionContinuation = BatchProcessExceptionContinuation.Throw) : this(loggerFactory, config, batchProcessExceptionContinuation, null)
    {}

    [Experimental("FirelyCqlSdkPreview")]
    internal CqlToolkit(
        ILoggerFactory? loggerFactory,
        CqlToolkitConfig? config,
        BatchProcessExceptionContinuation? batchProcessExceptionContinuation,
        CqlToolkitCallbacks? callbacks)
    {
        loggerFactory ??= NullLoggerFactory.Instance;
        config ??= CqlToolkitConfig.Default;
        _callbacks = callbacks;
        LoggerFactory = loggerFactory;
        _conversions = CqlToolkitConversionDictionary.Empty;
        Config = config;
        BatchProcessExceptionContinuation = batchProcessExceptionContinuation ?? BatchProcessExceptionContinuation.Throw;
        _services = CqlToolkitServices.Create(loggerFactory, config, _conversions);
    }

    private CqlToolkitConversionDictionary _conversions;
    private readonly CqlToolkitServices _services;
    private readonly CqlToolkitCallbacks? _callbacks;

    /// <inheritdoc/>
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public ILoggerFactory LoggerFactory { get; }

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
    /// Gets the dictionary of CQL to ELM translations.
    /// </summary>
    public CqlToolkitConversionReadOnlyDictionary Conversions => _conversions;

    /// <summary>
    /// Replaces the CQL to ELM conversions.
    /// </summary>
    /// <param name="conversions">The dictionary of translations to set.</param>
    private void ReplaceConversions(
        CqlToolkitConversionDictionary conversions)
    {
        _conversions = conversions;
        _services.LibraryBuilderProvider.ConversionsBuilder = conversions.ToBuilder();
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
                    .Select(lib => new CqlToolkitConversionRecord(lib))
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
            ReplaceConversions(conversions.ToImmutable());

        return this;
    }

    /// <summary>
    /// Translates the CQL libraries to ELM libraries.
    /// </summary>
    public CqlToolkit TranslateToElm()
    {
        CqlToolkitConversionDictionary.Builder conversions = _services.LibraryBuilderProvider.ConversionsBuilder;

        var count =
            _conversions
                .Values
                .Where(conversion => conversion.ResultElmLibrary is null)
                .TryForEach(
                    r =>
                    {
                        _callbacks?.TranslateBefore?.Invoke(r.LibraryIdentifier, r.SourceCqlLibrary);

                        if (!_services.LibraryBuilderProvider.TryResolveCqlToolkitConversionRecordWithLibraryBuilder(r.LibraryIdentifier, out var nNewConversionRecord, out var error))
                            throw new InvalidOperationException($"Could not resolve CQL library: {r.LibraryIdentifier} with error {error}.");

                        var newConversionRecord = nNewConversionRecord.Value;
                        var libraryBuilder = newConversionRecord.LibraryBuilder!;
                        var elmLibrary = libraryBuilder.Build();

                        newConversionRecord = newConversionRecord with { ResultElmLibrary = elmLibrary };
                        conversions[r.LibraryIdentifier] = newConversionRecord;

                        _callbacks?.TranslateSuccess?.Invoke(r.LibraryIdentifier, r.SourceCqlLibrary, elmLibrary);
                    },
                    errorStrategy =>
                    {
                        errorStrategy = errorStrategy
                                        .SetContinuation(BatchProcessExceptionContinuation)
                                        .AddLoggerExceptionHandler(_services.Logger,
                                                                   (conversion, messageBuilder) =>
                                                                       messageBuilder("Could not translate CQL to ELM: {lib}", conversion.LibraryIdentifier));
                        if (_callbacks?.TranslateError is { } fn)
                            errorStrategy = errorStrategy.AddExceptionHandler(
                                (conversion, exception, _) =>
                                    fn(conversion.LibraryIdentifier, conversion.SourceCqlLibrary, exception));

                        return errorStrategy;
                    });

        if (count > 0)
            ReplaceConversions(conversions: conversions.ToImmutable());

        return this;
    }
}
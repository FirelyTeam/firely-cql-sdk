/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using Hl7.Cql.CqlToElm.Toolkit.Internal;
using Hl7.Cql.Runtime;
using Hl7.Cql.Toolkit;
using Microsoft.Extensions.Logging.Abstractions;
using System.ComponentModel;

namespace Hl7.Cql.CqlToElm.Toolkit;

/// <summary>
/// Translates CQL libraries to ELM libraries.
/// </summary>
public sealed class CqlToolkit : IToolkitWithConfig<CqlToolkit, CqlToolkitConfig>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CqlToolkit"/> class.
    /// </summary>
    /// <param name="loggerFactory">The logger factory to use for logging.</param>
    /// <param name="config">The configuration settings for the toolkit.</param>
    /// <param name="enumerationExceptionContinuation">The continuation policy to use when an exception occurs during enumeration.</param>
    public CqlToolkit(
        ILoggerFactory? loggerFactory = null,
        CqlToolkitConfig? config = null,
        EnumerationExceptionContinuation enumerationExceptionContinuation = EnumerationExceptionContinuation.Throw)
    {
        config ??= CqlToolkitConfig.Default;
        loggerFactory ??= NullLoggerFactory.Instance;
        LoggerFactory = loggerFactory;
        _conversions = CqlToolkitConversionDictionary.Empty;
        Config = config;
        EnumerationExceptionContinuation = enumerationExceptionContinuation;
        _services = CqlToolkitServices.Create(loggerFactory, config, _conversions);
    }

    private CqlToolkitConversionDictionary _conversions;
    private CqlToolkitServices _services;

    /// <inheritdoc/>
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public ILoggerFactory LoggerFactory { get; }

    /// <summary>
    /// Gets the service provider used by tests.
    /// </summary>
    internal ServiceProvider ServiceProvider => _services.ServiceProvider;

    /// <inheritdoc/>
    public CqlToolkitConfig Config { get; private set; }

    /// <inheritdoc />
    public EnumerationExceptionContinuation EnumerationExceptionContinuation { get; private set; }

    /// <inheritdoc />
    public CqlToolkit SetEnumerationExceptionContinuation(EnumerationExceptionContinuation continuation)
    {
        EnumerationExceptionContinuation = continuation;
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

    /// <inheritdoc />
    public CqlToolkit Reconfigure(
        Mutator<CqlToolkitConfig>? reconfigure)
    {
        if (reconfigure is null)
            return this;

        var config = reconfigure(Config);
        if (Config == config)
            return this;

        _services.Dispose();
        Config = config;
        _services = CqlToolkitServices.Create(_services.LoggerFactory, config, _conversions);
        _services.LibraryBuilderProvider.CqlToElmTranslatorServices = _services;

        return this;
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
                                         .SetContinuation(EnumerationExceptionContinuation)
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
    public CqlToolkit ConvertCqlToElm()
    {
        CqlToolkitConversionDictionary.Builder conversions = _services.LibraryBuilderProvider.ConversionsBuilder;

        var count =
            _conversions
                .Values
                .Where(conversion => conversion.ResultElmLibrary is null)
                .TryForEach(
                    r =>
                    {
                        if (!_services.LibraryBuilderProvider.TryResolveLibrary(r.LibraryIdentifier, out var libraryBuilder, out var error))
                            throw new InvalidOperationException($"Could not resolve CQL library: {r.LibraryIdentifier} with error {error}.");

                        var elmLibrary = libraryBuilder.Build();
                        var newConversionRecord = r with { ResultElmLibrary = elmLibrary };
                        conversions[r.LibraryIdentifier] = newConversionRecord;
                    },
                    errorStrategy => errorStrategy
                                     .SetContinuation(EnumerationExceptionContinuation.Continue)
                                     .AddLoggerExceptionHandler(_services.Logger,
                                                                (conversion, messageBuilder) =>
                                                                    messageBuilder("Could not translate CQL to ELM: {lib}", conversion.LibraryIdentifier))
                );

        if (count > 0)
            ReplaceConversions(conversions: conversions.ToImmutable());

        return this;
    }
}
using CqlSdkPrototype.Cql.Internal;
using CqlSdkPrototype.Infrastructure;
using CqlSdkPrototype.Internal;
using Hl7.Cql.CqlToElm;
using Hl7.Cql.Runtime;

namespace CqlSdkPrototype.Cql;

public class CqlToElmProcessor
{
    public CqlToElmProcessor(
        ILoggerFactory? loggerFactory = null,
        CqlToElmProcessorConfig? config = null)
    {
        config ??= CqlToElmProcessorConfig.Default;
        loggerFactory ??= NullLoggerFactory.Instance;
        _loggerFactory = loggerFactory;
        _conversions = CqlToElmConversionDictionary.Empty;
        _config = config;
        _services = CqlToElmProcessorServices.Create(loggerFactory, config, _conversions);
    }

    private CqlToElmConversionDictionary _conversions;
    private CqlToElmProcessorServices _services;
    private CqlToElmProcessorConfig _config;
    private readonly ILoggerFactory _loggerFactory;

    /// <summary>
    /// Access by the FluentInvocationToolkit.
    /// </summary>
    internal ILoggerFactory LoggerFactory => _loggerFactory;


    /// <summary>
    /// For testing purposes only.
    /// </summary>
    internal ServiceProvider ServiceProvider => _services.ServiceProvider;

    public CqlToElmProcessorConfig Config => _config;

    public CqlToElmConversionReadOnlyDictionary Conversions => _conversions;

    private void SetConversions(
        CqlToElmConversionDictionary conversions)
    {
        _conversions = conversions;
        _services.LibraryProvider.Builder = conversions.ToBuilder();
    }

    public void Reconfigure(
        CqlToElmProcessorConfig config)
    {
        if (_config == config)
            return;

        _services.ServiceProvider.Dispose();
        _config = config;
        _services = CqlToElmProcessorServices.Create(_services.LoggerFactory, config, _conversions);
    }

    public void AddCqlLibraries(IEnumerable<CqlLibraryString> cqlLibraries)
    {
        var logger = _services.Logger;
        var entriesBuilder = _services.LibraryProvider.Builder;
        var cqlToElmConverter = _services.CqlToElmConverter;
        using var scope = _services.ServiceProvider.CreateScope()!;
        var hasChanged = false;
        foreach (var cqlLibrary in cqlLibraries)
        {
            var versionedIdentifier = cqlLibrary.VersionedLibraryIdentifier;

            if (entriesBuilder.ContainsKey(versionedIdentifier))
            {
                logger.LogInformation("Skipping adding previous cql to translation: {versionedIdentifier}", versionedIdentifier);
                continue;
            }

            var libraryVisitor = CqlToElmConverter.GetLibraryVisitorScoped(scope);
            var libraryBuilder = cqlToElmConverter.GetBuilder(libraryVisitor, cqlLibrary.Cql);
            var entry = new CqlToElmConversion(cqlLibrary) { ElmLibraryBuilder = libraryBuilder };
            entriesBuilder.Add(versionedIdentifier, entry);
            logger.LogInformation("Adding cql library to translation: {versionedIdentifier}", versionedIdentifier);
            hasChanged = true;
        }

        if (hasChanged)
            SetConversions(conversions: entriesBuilder.ToImmutable());
    }

    public void ProcessCqlToElm()
    {
        CqlToElmConversionDictionary.Builder processItemsBuilder = _services.LibraryProvider.Builder;
        var logger = _services.Logger;
        bool atFirst = true;

        IEnumerable<(CqlVersionedLibraryIdentifier versionedIdentifier, CqlToElmConversion cqlTranslationEntry)> GetLibrariesForProcessing()
        {
            foreach (var (versionedIdentifier, cqlTranslationEntry) in
                     _conversions.Where(kv => kv.Value.ElmLibrary is null))
            {
                if (atFirst)
                {
                    atFirst = false;
                    logger.LogInformation("Translating CQL into ELM");
                }

                logger.LogInformation("Translating CQL: {id}", versionedIdentifier);
                yield return (versionedIdentifier, cqlTranslationEntry);
            }
        }

        LogExceptionMessageAction log = logger.GetLogExceptionMessageAction(Config.ProcessBatchItemExceptionHandling);

        int changedCount =
                GetLibrariesForProcessing()
                    .TryProcessEach(t => ProcessLibrary(t.versionedIdentifier, t.cqlTranslationEntry))
                    .WithEachException(outcome =>
                    {
                        var libraryName = outcome.Input.versionedIdentifier;
                        log(outcome.Exception, "Error translating CQL library '{libraryName}' to ELM.", libraryName);
                    })
                    .HandleExceptions(Config.ProcessBatchItemExceptionHandling)
                    .Count() // We must enumerate all
            ;

        if (changedCount > 0)
            SetConversions(conversions: processItemsBuilder.ToImmutable());

        void ProcessLibrary(CqlVersionedLibraryIdentifier versionedIdentifier, CqlToElmConversion cqlTranslationEntry)
        {
            var library = cqlTranslationEntry.ElmLibraryBuilder!.Build();
            processItemsBuilder[versionedIdentifier] = cqlTranslationEntry with { ElmLibrary = library };
        }
    }
}
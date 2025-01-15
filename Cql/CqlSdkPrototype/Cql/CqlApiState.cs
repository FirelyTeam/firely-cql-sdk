using CqlSdkPrototype.Cql.Extensibility;
using CqlSdkPrototype.Cql.Internal;
using CqlSdkPrototype.Internal;
using CqlSdkPrototype.Logging.Internal;
using Hl7.Cql.CqlToElm;
using Hl7.Cql.Model;
using Hl7.Cql.Runtime.Hosting;

namespace CqlSdkPrototype.Cql;

internal readonly record struct CqlApiState(
    ILoggerFactory LoggerFactory,
    ImmutableDictionary<CqlVersionedLibraryIdentifier, CqlApiStateEntry> Entries,
    CqlApiOptions Options,
    ServiceProvider ServiceProvider,
    ILogger<CqlApi> Logger,
    CqlToElmConverter CqlToElmConverter)
{
    private static readonly (CqlModel CqlModel, ModelInfo ModelInfo)[] AllMappedModelsInOrder = [
        (CqlModel.ElmR1, Models.ElmR1),
        (CqlModel.Fhir401, Models.Fhir401)];

    public static CqlApiState Create(ILoggerFactory loggerFactory, CqlApiOptions options)
    {
        var entries = ImmutableDictionary<CqlVersionedLibraryIdentifier, CqlApiStateEntry>.Empty.WithComparers(CqlVersionedLibraryIdentifier.IdentifierOnlyEqualityComparer);
        return new CqlApiState(loggerFactory, entries!, null!, null!, null!, null!)
        {
            // Must be set through the property initializer, to ensure the services are created
            Options = options,
        };
    }

    private readonly CqlApiOptions _options = Options;

    public CqlApiOptions Options
    {
        get => _options;
        init
        {
            if (ReferenceEquals(_options, value))
                return;

            ServiceProvider?.Dispose();

            _options = value;
            var services = new ServiceCollection();
            services.AddExternalLogging(LoggerFactory);
            services.AddCqlApi(o =>
            {
                var modelInfos = AllMappedModelsInOrder
                             .SelectWhereNotNull(t => value.Models.Contains(t.CqlModel) ? t.ModelInfo : null)
                             .ToArray();
                o.Models = modelInfos;
            });
            ServiceProvider = services.BuildServiceProvider();
            Logger = ServiceProvider.GetLogger<CqlApi>();
            CqlToElmConverter = ServiceProvider.GetCqlToElmConverter();
        }
    }

    public ILoggerFactory LoggerFactory { get; } = LoggerFactory;
}
using CqlSdkPrototype.Cql.Extensibility;
using CqlSdkPrototype.Cql.Internal;
using CqlSdkPrototype.Logging.Internal;
using Hl7.Cql.CqlToElm;
using Hl7.Cql.Runtime.Hosting;

namespace CqlSdkPrototype.Cql;

internal readonly record struct CqlApiState(
    ImmutableDictionary<CqlVersionedLibraryIdentifier, CqlApiStateEntry> Entries,
    CqlApiOptions Options,
    ServiceProvider ServiceProvider,
    ILogger<CqlApi> Logger,
    CqlToElmConverter CqlToElmConverter)
{
    public static CqlApiState Create(CqlApiOptions options)
    {
        var entries = ImmutableDictionary<CqlVersionedLibraryIdentifier, CqlApiStateEntry>.Empty.WithComparers(CqlVersionedLibraryIdentifier.IdentifierOnlyEqualityComparer);
        return new CqlApiState(entries, null!, null!, null!, null!)
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
            services.AddExternalLogging(value.LoggerFactory!);
            services.AddCqlApi(o => o.Models = value.Models);
            ServiceProvider = services.BuildServiceProvider();
            Logger = ServiceProvider.GetLogger<CqlApi>();
            CqlToElmConverter = ServiceProvider.GetCqlToElmConverter();
        }
    }

}
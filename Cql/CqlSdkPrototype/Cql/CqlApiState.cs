using CqlSdkPrototype.Cql.Extensibility;
using CqlSdkPrototype.Cql.Internal;
using CqlSdkPrototype.Infrastructure;
using CqlSdkPrototype.Internal;
using CqlSdkPrototype.Logging.Internal;
using Hl7.Cql.CqlToElm;
using Hl7.Cql.CqlToElm.LibraryProviders;
using Hl7.Cql.Elm;
using Hl7.Cql.Model;
using Hl7.Cql.Runtime.Hosting;
using ExpressionVisitor = Hl7.Cql.CqlToElm.Visitors.ExpressionVisitor;

namespace CqlSdkPrototype.Cql;

internal readonly record struct CqlApiState(
    ILoggerFactory LoggerFactory,
    ImmutableDictionary<CqlVersionedLibraryIdentifier, CqlApiStateEntry> Entries,
    CqlApiOptions? Options = null,
    ServiceProvider? ServiceProvider = null,
    ILogger<CqlApi>? Logger = null,
    CqlToElmConverter? CqlToElmConverter = null,
    MemoryLibraryProvider? MemoryLibraryProvider = null)
{
    private static readonly (CqlModel CqlModel, ModelInfo ModelInfo)[] AllMappedModelsInOrder = [
        (CqlModel.ElmR1, Models.ElmR1),
        (CqlModel.Fhir401, Models.Fhir401)];

    public static CqlApiState Create(ILoggerFactory loggerFactory, CqlApiOptions options)
    {
        var entries = ImmutableDictionary<CqlVersionedLibraryIdentifier, CqlApiStateEntry>.Empty.WithComparers(CqlVersionedLibraryIdentifier.IdentifierOnlyEqualityComparer);
        return new CqlApiState(loggerFactory, entries)
        {
            // Must be set through the property initializer, to ensure the services are created
            Options = options,
        };
    }

    private readonly CqlApiOptions _options = Options!;

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
            AddCqlServices(services, value);
            ServiceProvider = services.BuildServiceProvider(validateScopes: true);
            Logger = ServiceProvider.GetLogger<CqlApi>();
            CqlToElmConverter = ServiceProvider.GetCqlToElmConverter();
            MemoryLibraryProvider = (MemoryLibraryProvider)ServiceProvider.GetRequiredService<ILibraryProvider>();
        }
    }

    public ILoggerFactory LoggerFactory { get; } = LoggerFactory;
    public MemoryLibraryProvider MemoryLibraryProvider { get; private init; } = MemoryLibraryProvider!;
    public ServiceProvider ServiceProvider { get; private init; } = ServiceProvider!;
    public ILogger<CqlApi> Logger { get; private init; } = Logger!;
    public CqlToElmConverter CqlToElmConverter { get; private init; } = CqlToElmConverter!;

    private static void AddCqlServices(
        IServiceCollection serviceCollection,
        CqlApiOptions options)
    {
        SuppressCqlDebugAssertions(serviceCollection);

        serviceCollection
            .AddCqlToElmServices()
            .AddCqlToElmModels(ConfigureModelProvider())
            .AddCqlToElmOptions(ConfigureCqlToElmOptions())
            .AddSingleton<ILibraryProvider, MemoryLibraryProvider>()
            .AddCqlToElmMessaging();
        return;

        Action<CqlToElmOptions> ConfigureCqlToElmOptions()
        {
            return options.ApplyToCqlToElmOptions;
        }

        Action<IModelProvider> ConfigureModelProvider()
        {
            var modelInfos = AllMappedModelsInOrder
                             .SelectWhereNotNull(t => options.Models.Contains(t.CqlModel) ? t.ModelInfo : null)
                             .Concat(options.ModelInfos);
            return modelProvider =>
            {
                foreach (var modelInfo in modelInfos)
                    modelProvider.Add(modelInfo);
            };
        }
    }

    private static IServiceCollection SuppressCqlDebugAssertions(
        IServiceCollection serviceCollection)
    {
        // This is really annoying in debug mode
        ExpressionVisitor.EnableDebugAssertions = false;
        Library.EnableDebugAssertions = false;
        return serviceCollection;
    }
}
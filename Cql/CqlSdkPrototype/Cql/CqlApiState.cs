using CqlSdkPrototype.Cql.Extensibility;
using CqlSdkPrototype.Infrastructure;
using CqlSdkPrototype.Internal;
using CqlSdkPrototype.Logging.Internal;
using Hl7.Cql.CqlToElm;
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
    CqlToElmConverter? CqlToElmConverter = null)
    : ILibraryProvider
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
    private readonly ImmutableDictionary<CqlVersionedLibraryIdentifier, CqlApiStateEntry> _entries = Entries;

    internal ImmutableDictionary<CqlVersionedLibraryIdentifier, CqlApiStateEntry>.Builder EntriesBuilder { get; private init; } = Entries.ToBuilder()!; // Not ideal, needed during Translate for TryResolveLibrary

    public ImmutableDictionary<CqlVersionedLibraryIdentifier, CqlApiStateEntry> Entries
    {
        get => _entries;
        init
        {
            _entries = value;
            EntriesBuilder = value?.ToBuilder()!;
        }
    }

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
            AddCqlServices(services, value, this);
            ServiceProvider = services.BuildServiceProvider(validateScopes: true);
            Logger = ServiceProvider.GetLogger<CqlApi>();
            CqlToElmConverter = ServiceProvider.GetCqlToElmConverter();
        }
    }

    public ILoggerFactory LoggerFactory { get; } = LoggerFactory;
    public ServiceProvider ServiceProvider { get; private init; } = ServiceProvider!;
    public ILogger<CqlApi> Logger { get; private init; } = Logger!;
    public CqlToElmConverter CqlToElmConverter { get; private init; } = CqlToElmConverter!;

    private static void AddCqlServices(
        IServiceCollection serviceCollection,
        CqlApiOptions options,
        ILibraryProvider libraryProvider)
    {
        SuppressCqlDebugAssertions();

        serviceCollection
            .AddCqlToElmServices()
            .AddCqlToElmModels(ConfigureModelProvider())
            .AddCqlToElmOptions(ConfigureCqlToElmOptions())
            .AddSingleton(libraryProvider)
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

    private static void SuppressCqlDebugAssertions()
    {
        // This is really annoying in debug mode
        ExpressionVisitor.EnableDebugAssertions = false;
        Library.EnableDebugAssertions = false;
    }

    bool ILibraryProvider.TryResolveLibrary(
        string libraryName,
        string? version,
        [NotNullWhen(true)] out LibraryBuilder? libraryBuilder,
        out string? error)
    {
        error = null;
        libraryBuilder = null;

        var libVer = CqlVersionedLibraryIdentifier.FromNameAndVersion(
            CqlLibraryIdentifier.Parse(libraryName),
            CqlLibraryVersion.ParseOrEmpty(version));

        if (EntriesBuilder.TryGetValue(libVer, out var entry))
        {
            if (entry.ElmLibraryBuilder is {} lb)
            {
                libraryBuilder = lb;
                return true;
            }

            ;
        }

        return false;
    }
}
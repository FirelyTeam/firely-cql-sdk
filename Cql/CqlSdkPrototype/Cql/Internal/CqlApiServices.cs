using CqlSdkPrototype.Internal;
using CqlSdkPrototype.Logging.Internal;
using Hl7.Cql.CqlToElm;
using Hl7.Cql.Elm;
using Hl7.Cql.Model;
using Hl7.Cql.Runtime.Hosting;
using ExpressionVisitor = Hl7.Cql.CqlToElm.Visitors.ExpressionVisitor;

namespace CqlSdkPrototype.Cql.Internal;

internal readonly record struct CqlApiServices(
    ILoggerFactory LoggerFactory,
    ServiceProvider ServiceProvider,
    CqlToElmConverter CqlToElmConverter,
    EntriesBuilderLibraryProvider LibraryProvider)
{
    private static readonly (CqlModel CqlModel, ModelInfo ModelInfo)[] AllMappedModelsInOrder = [
        (CqlModel.ElmR1, Models.ElmR1),
        (CqlModel.Fhir401, Models.Fhir401)];

    public static CqlApiServices Create(ILoggerFactory loggerFactory, CqlApiOptions options, EntriesBuilderLibraryProvider libraryProvider)
    {
        var services = new ServiceCollection();
        services.AddExternalLogging(loggerFactory);
        AddCqlServices(services, options, libraryProvider);
        var serviceProvider = services.BuildServiceProvider(validateScopes: true);
        var cqlToElmConverter = serviceProvider.GetCqlToElmConverter();

        return new CqlApiServices(
            loggerFactory,
            serviceProvider,
            cqlToElmConverter,
            libraryProvider);
    }

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

    public ILoggerFactory LoggerFactory { get; } = LoggerFactory;
    public ServiceProvider ServiceProvider { get; } = ServiceProvider!;
    public ILogger<CqlApi> Logger { get; } = ServiceProvider.GetLogger<CqlApi>();
    public CqlToElmConverter CqlToElmConverter { get; } = CqlToElmConverter!;
    public EntriesBuilderLibraryProvider LibraryProvider { get; } = LibraryProvider!;
}
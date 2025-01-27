using CqlSdkPrototype.Internal;
using CqlSdkPrototype.Logging.Internal;
using Hl7.Cql.CqlToElm;
using Hl7.Cql.Elm;
using Hl7.Cql.Model;
using Hl7.Cql.Runtime.Hosting;
using ExpressionVisitor = Hl7.Cql.CqlToElm.Visitors.ExpressionVisitor;

namespace CqlSdkPrototype.Cql.Internal;

internal readonly record struct CqlToElmProcessorServices(
    ILoggerFactory LoggerFactory,
    ServiceProvider ServiceProvider,
    CqlToElmConverter CqlToElmConverter,
    CqlToElmConversionsLibraryProvider LibraryProvider)
{
    private static readonly (CqlModel CqlModel, ModelInfo ModelInfo)[] AllMappedModelsInOrder = [
        (CqlModel.ElmR1, Models.ElmR1),
        (CqlModel.Fhir401, Models.Fhir401)];

    public static CqlToElmProcessorServices Create(
        CqlToElmProcessorSettings settings,
        ILoggerFactory? loggerFactory = null,
        CqlToElmConversionDictionary? conversions = null)
    {
        loggerFactory ??= NullLoggerFactory.Instance;

        var builder = (conversions ?? CqlToElmConversionDictionary.Empty).ToBuilder();
        var libraryProvider = new CqlToElmConversionsLibraryProvider(builder);

        var services = new ServiceCollection();
        services.AddExternalLogging(loggerFactory);
        AddCqlServices(services, settings, libraryProvider);
        var serviceProvider = services.BuildServiceProvider(validateScopes: true);
        var cqlToElmConverter = serviceProvider.GetRequiredService<CqlToElmConverter>();

        return new CqlToElmProcessorServices(
            loggerFactory,
            serviceProvider,
            cqlToElmConverter,
            libraryProvider);
    }

    private static void AddCqlServices(
        IServiceCollection serviceCollection,
        CqlToElmProcessorSettings settings,
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
            return settings.ApplyToCqlToElmOptions;
        }

        Action<IModelProvider> ConfigureModelProvider()
        {
            var modelInfos = AllMappedModelsInOrder
                             .SelectWhereNotNull(t => settings.Models.Contains(t.CqlModel) ? t.ModelInfo : null)
                             .Concat(settings.ModelInfos);
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
    public ILogger<CqlToElmProcessor> Logger { get; } = ServiceProvider.GetLogger<CqlToElmProcessor>();
    public CqlToElmConverter CqlToElmConverter { get; } = CqlToElmConverter!;
    public CqlToElmConversionsLibraryProvider LibraryProvider { get; } = LibraryProvider!;
}
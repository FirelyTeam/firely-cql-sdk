using CqlSdkPrototype.Internal;
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
        ILoggerFactory loggerFactory,
        CqlToElmProcessorConfig config,
        CqlToElmConversionDictionary conversions)
    {
        var builder = conversions.ToBuilder();
        var libraryProvider = new CqlToElmConversionsLibraryProvider(builder);

        var services = new ServiceCollection();
        services.AddExternalLogging(loggerFactory);
        AddCqlServices(services, config, libraryProvider);
        var serviceProvider = services.BuildServiceProvider(validateScopes: true);

        return ActivatorUtilities.CreateInstance<CqlToElmProcessorServices>(serviceProvider, serviceProvider, libraryProvider);
    }

    private static void AddCqlServices(
        IServiceCollection serviceCollection,
        CqlToElmProcessorConfig config,
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
            return config.ApplyToCqlToElmOptions;
        }

        Action<IModelProvider> ConfigureModelProvider()
        {
            var modelInfos = AllMappedModelsInOrder
                             .SelectWhereNotNull(t => config.Models.Contains(t.CqlModel) ? t.ModelInfo : null)
                             .Concat(config.ModelInfos);
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
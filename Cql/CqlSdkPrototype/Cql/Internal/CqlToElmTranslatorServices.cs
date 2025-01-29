using CqlSdkPrototype.Internal;
using Hl7.Cql.CqlToElm;
using Hl7.Cql.Elm;
using Hl7.Cql.Model;
using ExpressionVisitor = Hl7.Cql.CqlToElm.Visitors.ExpressionVisitor;

namespace CqlSdkPrototype.Cql.Internal;

/// <summary>
/// Services for translating CQL to ELM used by the <seealso cref="CqlToElmTranslator"/>.
/// </summary>
internal readonly record struct CqlToElmTranslatorServices(
    ILoggerFactory LoggerFactory,
    ServiceProvider ServiceProvider,
    CqlToElmConverter CqlToElmConverter,
    LibraryBuilderProvider LibraryBuilderProvider)
{
    private static readonly (CqlModel CqlModel, ModelInfo ModelInfo)[] AllMappedModelsInOrder = [
        (CqlModel.ElmR1, Models.ElmR1),
        (CqlModel.Fhir401, Models.Fhir401)];

    /// <summary>
    /// Creates an instance of <see cref="CqlToElmTranslatorServices"/>.
    /// </summary>
    /// <param name="loggerFactory">The logger factory.</param>
    /// <param name="config">The configuration for the translator.</param>
    /// <param name="translations">The translation dictionary.</param>
    /// <returns>A new instance of <see cref="CqlToElmTranslatorServices"/>.</returns>
    public static CqlToElmTranslatorServices Create(
        ILoggerFactory loggerFactory,
        CqlToElmTranslatorConfig config,
        CqlToElmTranslationDictionary translations)
    {
        var translationsBuilder = translations.ToBuilder();
        var libraryBuilderProvider = new LibraryBuilderProvider(translationsBuilder);

        var services = new ServiceCollection();
        services.AddExternalLogging(loggerFactory);
        AddCqlServices(services, config, libraryBuilderProvider);
        var serviceProvider = services.BuildServiceProvider(validateScopes: true);

        return ActivatorUtilities.CreateInstance<CqlToElmTranslatorServices>(serviceProvider, serviceProvider, libraryBuilderProvider);
    }

    /// <summary>
    /// Adds CQL services to the service collection.
    /// </summary>
    /// <param name="serviceCollection">The service collection.</param>
    /// <param name="config">The configuration for the translator.</param>
    /// <param name="libraryProvider">The library provider.</param>
    private static void AddCqlServices(
        IServiceCollection serviceCollection,
        CqlToElmTranslatorConfig config,
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

    /// <summary>
    /// Suppresses CQL debug assertions.
    /// </summary>
    private static void SuppressCqlDebugAssertions()
    {
        // This is really annoying in debug mode
        ExpressionVisitor.EnableDebugAssertions = false;
        Library.EnableDebugAssertions = false;
    }

    /// <summary>
    /// Gets the logger factory.
    /// </summary>
    public ILoggerFactory LoggerFactory { get; } = LoggerFactory;
    /// <summary>
    /// Gets the service provider.
    /// </summary>
    public ServiceProvider ServiceProvider { get; } = ServiceProvider!;
    /// <summary>
    /// Gets the logger for the CQL to ELM translator.
    /// </summary>
    public ILogger<CqlToElmTranslator> Logger { get; } = LoggerFactory.CreateLogger<CqlToElmTranslator>();
    /// <summary>
    /// Gets the CQL to ELM converter.
    /// </summary>
    public CqlToElmConverter CqlToElmConverter { get; } = CqlToElmConverter!;
    /// <summary>
    /// Gets the library builder provider.
    /// </summary>
    public LibraryBuilderProvider LibraryBuilderProvider { get; } = LibraryBuilderProvider!;
}
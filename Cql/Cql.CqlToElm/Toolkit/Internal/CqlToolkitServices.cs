/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.CqlToElm.Visitors;
using Hl7.Cql.Model;
using Hl7.Cql.Runtime.Logging;
using ExpressionVisitor = Hl7.Cql.CqlToElm.Visitors.ExpressionVisitor;

namespace Hl7.Cql.CqlToElm.Toolkit.Internal;

/// <summary>
/// Services for translating CQL to ELM used by the <seealso cref="CqlToolkit"/>.
/// </summary>
internal record CqlToolkitServices(
    ILoggerFactory LoggerFactory,
    ServiceProvider ServiceProvider,
    CqlToElmConverter CqlToElmConverter,
    LibraryBuilderProvider LibraryBuilderProvider,
    IServiceScope ServiceScope,
    LibraryVisitor LibraryVisitor) : IDisposable
{
    private static readonly (CqlModel CqlModel, ModelInfo ModelInfo)[] AllMappedModelsInOrder = [
        (CqlModel.ElmR1, Models.ElmR1),
        (CqlModel.Fhir401, Models.Fhir401)];

    /// <summary>
    /// Creates an instance of <see cref="CqlToolkitServices"/>.
    /// </summary>
    /// <param name="loggerFactory">The logger factory.</param>
    /// <param name="config">The configuration for the translator.</param>
    /// <param name="translations">The translation dictionary.</param>
    /// <returns>A new instance of <see cref="CqlToolkitServices"/>.</returns>
    public static CqlToolkitServices Create(
        ILoggerFactory loggerFactory,
        CqlToolkitConfig config,
        CqlToolkitConversionDictionary translations)
    {
        var translationsBuilder = translations.ToBuilder();
        var libraryBuilderProvider = new LibraryBuilderProvider(translationsBuilder);

        var services = new ServiceCollection();
        services.AddExternalLogging(loggerFactory);
        AddCqlServices(services, config, libraryBuilderProvider);
        var serviceProvider = services.BuildServiceProvider(validateScopes: true);

        var serviceScope = serviceProvider.CreateScope();
        var cqlToElmTranslatorServices = new CqlToolkitServices(
            loggerFactory,
            serviceProvider,
            Get<CqlToElmConverter>(serviceProvider),
            libraryBuilderProvider,
            serviceScope,
            CqlToElmConverter.GetLibraryVisitorScoped(serviceScope));

        libraryBuilderProvider.CqlToElmTranslatorServices = cqlToElmTranslatorServices;

        return cqlToElmTranslatorServices;
        static T Get<T> (IServiceProvider sp) where T : notnull => sp.GetRequiredService<T>();
    }

    /// <summary>
    /// Adds CQL services to the service collection.
    /// </summary>
    /// <param name="serviceCollection">The service collection.</param>
    /// <param name="config">The configuration for the translator.</param>
    /// <param name="libraryProvider">The library provider.</param>
    private static void AddCqlServices(
        IServiceCollection serviceCollection,
        CqlToolkitConfig config,
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
        ElmLibrary.EnableDebugAssertions = false;
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
    public ILogger<CqlToolkit> Logger { get; } = LoggerFactory.CreateLogger<CqlToolkit>();
    /// <summary>
    /// Gets the CQL to ELM converter.
    /// </summary>
    public CqlToElmConverter CqlToElmConverter { get; } = CqlToElmConverter!;
    /// <summary>
    /// Gets the library builder provider.
    /// </summary>
    public LibraryBuilderProvider LibraryBuilderProvider { get; } = LibraryBuilderProvider!;

    public void Dispose()
    {
        ServiceProvider.Dispose();
        ServiceScope.Dispose();
    }
}

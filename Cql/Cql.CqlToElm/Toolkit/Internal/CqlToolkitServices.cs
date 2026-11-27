/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.CqlToElm.Visitors;
using Hl7.Cql.Elm.Serialization;
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
    // A model info is only deserialized when a configuration selects it.
    private static readonly (CqlModel CqlModel, Func<ModelInfo> GetModelInfo)[] AllMappedModelsInOrder = [
        (CqlModel.ElmR1, () => Models.ElmR1),
        (CqlModel.Fhir401, () => Models.Fhir401),
        (CqlModel.USCore311, () => Models.USCore311),
        (CqlModel.QICore411, () => Models.QICore411),
        (CqlModel.USCore610, () => Models.USCore610),
        (CqlModel.QICore600, () => Models.QICore600)];

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
        CqlToolkitArtifactsById translations)
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
            serviceScope.GetLibraryVisitorScoped());

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
            var modelInfos = InDependencyOrder(
                AllMappedModelsInOrder
                    .SelectWhereNotNull(t => config.Models.Contains(t.CqlModel) ? t.GetModelInfo() : null)
                    .Concat(config.ModelInfos)
                    .Distinct()
                    .ToList());

            // The provider keys a model by url and version, so a second copy of one model, such as a model info
            // loaded from a file for a model also selected through Models, cannot be added.
            var duplicateModel = modelInfos
                                 .GroupBy(m => (m.url, m.version))
                                 .FirstOrDefault(g => g.Count() > 1);
            if (duplicateModel is not null)
            {
                var first = duplicateModel.First();
                throw new ArgumentException(
                    $"Model {first.name} ({first.url}) version '{first.version}' is configured more than once. " +
                    "Select each model once, either through Models or through ModelInfos.",
                    nameof(config));
            }

            // A type is identified by its model's url and its name, without the model's version, so the
            // translator can only resolve types when each model url is configured in a single version.
            var multiVersionModel = modelInfos
                                    .GroupBy(m => m.url)
                                    .FirstOrDefault(g => g.Select(m => m.version).Distinct().Count() > 1);
            if (multiVersionModel is not null)
            {
                var first = multiVersionModel.First();
                var versions = string.Join(", ", multiVersionModel.Select(m => $"'{m.version}'").Distinct());
                throw new ArgumentException(
                    $"Model {first.name} ({multiVersionModel.Key}) is selected in more than one version ({versions}). " +
                    "Select one version of each model per toolkit, and translate libraries using another version with a separate toolkit.",
                    nameof(config));
            }

            return modelProvider =>
            {
                foreach (var modelInfo in modelInfos)
                    modelProvider.Add(modelInfo);
            };
        }
    }

    /// <summary>
    /// Orders model infos so that each comes after the models it declares in <c>requiredModelInfo</c>, because the
    /// model provider refuses a model whose required models were not added before it. Models keep their given order
    /// otherwise. A required model that is not in the list, or a cycle, is left for the provider to report.
    /// </summary>
    internal static List<ModelInfo> InDependencyOrder(IReadOnlyList<ModelInfo> modelInfos)
    {
        var ordered = new List<ModelInfo>(modelInfos.Count);
        var remaining = modelInfos.ToList();
        while (remaining.Count > 0)
        {
            var next = remaining.FirstOrDefault(model => (model.requiredModelInfo ?? [])
                                                    .All(required => !remaining.Any(other => other != model && Satisfies(other, required))))
                       ?? remaining[0];
            remaining.Remove(next);
            ordered.Add(next);
        }

        return ordered;

        static bool Satisfies(ModelInfo model, ModelSpecifier required) =>
            model.name == required.name && (required.version is null || model.version == required.version);
    }

    /// <summary>
    /// Suppresses CQL debug assertions.
    /// </summary>
    private static void SuppressCqlDebugAssertions()
    {
        // This is really annoying in debug mode
        ExpressionVisitor.EnableDebugAssertions = false;
        LibraryJsonSerializer.EnableDebugAssertions = false;
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

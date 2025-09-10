/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using Hl7.Cql.Compiler;
using Hl7.Cql.Fhir;
using Hl7.Cql.Runtime.Hosting;
using Hl7.Cql.Runtime.Logging;
using Hl7.Fhir.Introspection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using TypeConverter = Hl7.Cql.Conversion.TypeConverter;

namespace Hl7.Cql.CodeGeneration.NET.Toolkit.Internal;

internal readonly record struct ElmToolkitServices(
    ServiceProvider ServiceProvider,
    ILogger<ElmToolkit> Logger,
    AssemblyCompiler AssemblyCompiler,
    LibrarySetCSharpCodeGenerator LibrarySetCSharpCodeGenerator)
{
    public static ElmToolkitServices Create(
        ILoggerFactory loggerFactory,
        ElmToolkitConfig config)
    {
        var services = new ServiceCollection();
        services.AddExternalLogging(loggerFactory);
        AddCqlCodeGenerationServices(services, config);
        var serviceProvider = services.BuildServiceProvider(validateScopes: true);

        return ActivatorUtilities.CreateInstance<ElmToolkitServices>(serviceProvider, serviceProvider);
    }

    private static void AddCqlCodeGenerationServices(
        IServiceCollection services,
        ElmToolkitConfig config)
    {
        var expressionBuilderSettings = config.ToExpressionBuilderSettings();
        AddCqlCompilerServices(services, config.LRUCacheSize, expressionBuilderSettings);
        services.TryAddSingleton<TypeToCSharpConverter>();
        services.TryAddSingleton<LibrarySetCSharpCodeGenerator>();
        services.TryAddSingleton<AssemblyCompiler>();
    }

    /// <remarks>
    /// Used by <seealso cref="ElmToolkitServices"/> and by many test cases
    /// </remarks>
    public static IServiceCollection AddCqlCompilerServices(
        IServiceCollection services,
        int lruCacheSize = 0,
        ExpressionBuilderSettings? expressionBuilderSettings = null)
    {
        expressionBuilderSettings ??= ExpressionBuilderSettings.Default;
        services.TryAddSingleton(_ => Hl7.Fhir.Model.ModelInfo.ModelInspector);
        services.TryAddSingleton<TypeResolver, FhirTypeResolver>();

        services.TryAddSingleton(sp =>
        {
            var modelInspector = sp.GetRequiredService<ModelInspector>();
            var logger = sp.GetLogger<TypeConverter>();
            var converter = FhirTypeConverter
                            .Create(modelInspector, lruCacheSize)
                            .UseLogger(logger);
            converter.CaptureAvailableConverters();
            return converter;
        });

        services.TryAddSingleton<LibraryPreprocessorBuilder>();
        services.TryAddSingleton<CqlOperatorsBinder>();
        services.TryAddSingleton<CqlContextBinder>();
        services.TryAddSingleton(_ => expressionBuilderSettings);
        services.TryAddScoped<TupleBuilderCache>();
        services.TryAddScoped<LibrarySetExpressionBuilder>();
        services.TryAddScoped<LibraryExpressionBuilder>();
        services.TryAddScoped<ExpressionBuilder>();

        return services;
    }

    public ServiceProvider ServiceProvider { get; } = ServiceProvider;
    public AssemblyCompiler AssemblyCompiler { get; } = AssemblyCompiler;
    public LibrarySetCSharpCodeGenerator LibrarySetCSharpCodeGenerator { get; } = LibrarySetCSharpCodeGenerator;
    public ElmToolkitScopedState CreateScopedState() => new(ServiceProvider.CreateScope());
}

/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */
using System;
using Hl7.Cql.Abstractions;
using Hl7.Cql.Conversion;
using Hl7.Cql.Fhir;
using Hl7.Fhir.Introspection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Hl7.Cql.Compiler;

/// <summary>
/// This creates all services necessary for the Hl7.Cql.Compiler assembly.
/// The idea is not to inject this into service types, it's purpose is to
/// be one alternative to the .net hosting's <see cref="IServiceProvider"/>.
/// </summary>
internal class CqlCompilerFactory(
    IServiceProvider serviceProvider)
{
    protected readonly IServiceProvider _serviceProvider = serviceProvider;

    public virtual TypeConverter TypeConverter => _serviceProvider.GetRequiredService<TypeConverter>();

    public virtual TypeResolver TypeResolver => _serviceProvider.GetRequiredService<TypeResolver>();

    public virtual TypeManager TypeManager => _serviceProvider.GetRequiredService<TypeManager>();

    public virtual LibrarySetExpressionBuilder LibrarySetExpressionBuilder => _serviceProvider.GetRequiredService<LibrarySetExpressionBuilder>();

    public virtual LibraryExpressionBuilder LibraryExpressionBuilder => _serviceProvider.GetRequiredService<LibraryExpressionBuilder>();

    public static CqlCompilerFactory NewHostedCqlCompilerFactory(IServiceCollection? services = null)
    {
        services ??= new ServiceCollection();
        ConfigureServices(services);
        var serviceProvider = services.BuildServiceProvider();
        return new CqlCompilerFactory(serviceProvider);
    }

    internal static void ConfigureServices(IServiceCollection services)
    {
        services.TryAddSingleton<ModelInspector>(_ => Hl7.Fhir.Model.ModelInfo.ModelInspector);

        const int cacheSize = 0; // TODO: Must move to configuration
        services.TryAddSingleton<TypeConverter>(sp =>
        {
            var modelInspector = sp.GetRequiredService<ModelInspector>();
            var logger = sp.GetRequiredService<ILogger<TypeConverter>>();
            var converter = FhirTypeConverter
                            .Create(modelInspector, cacheSize)
                            .UseLogger(logger);
            converter.CaptureAvailableConverters();
            return converter;
        });

        // services.TryAddSingleton<TypeResolver>(serviceProvider =>
        // {
        //     var modelInspector = serviceProvider.GetRequiredService<ModelInspector>();
        //     return new FhirTypeResolver(modelInspector);
        // });
        services.TryAddSingleton<TypeResolver, FhirTypeResolver>();

        services.TryAddSingleton<CqlOperatorsBinder>();

        services.TryAddSingleton<CqlContextBinder>();

        services.TryAddSingleton<TypeManager>();

        services.TryAddSingleton<LibrarySetExpressionBuilder>();

        services.TryAddSingleton<LibraryExpressionBuilder>();

        services.TryAddSingleton<ExpressionBuilderSettings>(_ => ExpressionBuilderSettings.Default); // TODO: Must move to configuration

        services.TryAddSingleton<ExpressionBuilder>();
    }
}

internal static class ServiceProviderExtensions
{
    public static IOptions<T> GetOptions<T>(this IServiceProvider serviceProvider)
        where T : class =>
        serviceProvider.GetRequiredService<IOptions<T>>();

    public static ILogger<T> GetLogger<T>(this IServiceProvider serviceProvider)
        where T : class =>
        serviceProvider.GetRequiredService<ILogger<T>>();
}
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

namespace Hl7.Cql.Compiler.Hosting;

internal static class CqlCompilerServicesInitializer
{
    internal static CqlCompilerServices GetCqlCompilerServices(this IServiceProvider serviceProvider) =>
        new CqlCompilerServices(serviceProvider);

    internal static IServiceCollection AddCqlCompilerServices(this IServiceCollection services)
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

        services.TryAddSingleton<TypeResolver, FhirTypeResolver>();

        services.TryAddSingleton<CqlOperatorsBinder>();

        services.TryAddSingleton<CqlContextBinder>();

        services.TryAddSingleton<DynamicTupleCache>();

        services.TryAddSingleton<LibrarySetExpressionBuilder>();

        services.TryAddSingleton<LibraryExpressionBuilder>();

        services.TryAddSingleton<ExpressionBuilderSettings>(_ => ExpressionBuilderSettings.Default); // TODO: Must move to configuration

        services.TryAddSingleton<ExpressionBuilder>();

        return services;
    }

}
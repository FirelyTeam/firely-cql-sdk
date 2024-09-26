/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using Hl7.Cql.Compiler;
using Hl7.Cql.Conversion;
using Hl7.Cql.Fhir;
using Hl7.Cql.Runtime.Hosting;
using Hl7.Fhir.Introspection;
using Microsoft.Extensions.DependencyInjection.Extensions;

// ReSharper disable once CheckNamespace
#pragma warning disable IDE0130 // Namespace does not match folder structure
namespace Microsoft.Extensions.DependencyInjection;


internal static class CqlCompilerServiceCollectionExtensions
{
    internal static IServiceCollection AddCqlCompilerServices(this IServiceCollection services)
    {
        services.TryAddSingleton<ModelInspector>(_ => Hl7.Fhir.Model.ModelInfo.ModelInspector);

        const int cacheSize = 0; // TODO: Must move to configuration
        services.TryAddSingleton<TypeConverter>(sp =>
        {
            var modelInspector = sp.GetModelInspector();
            var logger = sp.GetLogger<TypeConverter>();
            var converter = FhirTypeConverter
                            .Create(modelInspector, cacheSize)
                            .UseLogger(logger);
            converter.CaptureAvailableConverters();
            return converter;
        });

        services.TryAddSingleton<TypeResolver, FhirTypeResolver>();

        services.TryAddSingleton<CqlOperatorsBinder>();

        services.TryAddSingleton<CqlContextBinder>();

        services.TryAddScoped<TupleBuilderCache>();

        services.TryAddScoped<LibrarySetExpressionBuilder>();

        services.TryAddScoped<LibraryExpressionBuilder>();

        services.TryAddScoped<ExpressionBuilder>();

        return services;
    }

}
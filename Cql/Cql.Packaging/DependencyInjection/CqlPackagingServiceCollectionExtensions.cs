/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using Hl7.Cql.Fhir;
using Hl7.Cql.Packaging;
using Hl7.Fhir.Introspection;
using Microsoft.Extensions.DependencyInjection.Extensions;

// ReSharper disable once CheckNamespace
#pragma warning disable IDE0130 // Namespace does not match folder structure
namespace Microsoft.Extensions.DependencyInjection;


internal static class CqlPackagingServiceCollectionExtensions
{
    public static IServiceCollection AddCqlPackagingServices(this IServiceCollection services)
    {
        services.TryAddSingleton<ModelInspector>(_ => Hl7.Fhir.Model.ModelInfo.ModelInspector);
        services.TryAddSingleton<TypeResolver, FhirTypeResolver>();
        services.TryAddSingleton<ResourcePackager>();
        services.TryAddSingleton<FhirResourceFileWriter>();
        return services;
    }
}
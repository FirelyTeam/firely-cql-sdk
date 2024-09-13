/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Packaging;
using Hl7.Cql.Packaging.PostProcessors;

// ReSharper disable once CheckNamespace
#pragma warning disable IDE0130 // Namespace does not match folder structure
namespace Microsoft.Extensions.DependencyInjection;

internal static class CqlPackagingServiceProviderExtensions
{
    public static CqlTypeToFhirTypeMapper GetCqlTypeToFhirTypeMapper(this IServiceProvider serviceProvider) =>
        serviceProvider.GetRequiredService<CqlTypeToFhirTypeMapper>();

    public static FhirResourcePostProcessor GetFhirResourcePostProcessor(this IServiceProvider serviceProvider) =>
        serviceProvider.GetRequiredService<FhirResourcePostProcessor>();

    public static ResourcePackager GetResourcePackager(this IServiceProvider serviceProvider) =>
        serviceProvider.GetRequiredService<ResourcePackager>();

    public static CqlToResourcePackagingPipeline CqlToResourcePackagingPipelineScoped(this IServiceProvider serviceProvider) =>
        serviceProvider.GetRequiredService<CqlToResourcePackagingPipeline>();
}
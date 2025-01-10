/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Packaging;

// ReSharper disable once CheckNamespace
#pragma warning disable IDE0130 // Namespace does not match folder structure
namespace Microsoft.Extensions.DependencyInjection;

internal static class CqlPackagingServiceProviderExtensions
{
    public static CqlTypeToFhirTypeMapper GetCqlTypeToFhirTypeMapper(this IServiceProvider serviceProvider) =>
        serviceProvider.GetRequiredService<CqlTypeToFhirTypeMapper>();

    public static ResourcePackager GetResourcePackager(this IServiceProvider serviceProvider) =>
        serviceProvider.GetRequiredService<ResourcePackager>();
}
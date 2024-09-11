/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Packaging.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Hl7.Cql.Packager.Services;

internal static class PackagerCliServicesInitializer
{
    internal static PackagerCliServices GetPackagerCliServices(
        this IServiceProvider serviceProvider) =>
        new PackagerCliServices(serviceProvider);

    internal static IServiceCollection AddPackagerCliServices(
        this IServiceCollection services)
    {
        services.AddCqlPackagingServices();

        services.TryAddScoped<PackagerCliProgram>();
        services.TryAddSingleton<OptionsConsoleDumper>();

        return services;
    }
}
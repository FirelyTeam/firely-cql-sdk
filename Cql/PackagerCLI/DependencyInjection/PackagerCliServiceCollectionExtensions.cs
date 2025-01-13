/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Packager;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection.Extensions;

// ReSharper disable once CheckNamespace
#pragma warning disable IDE0130 // Namespace does not match folder structure
namespace Microsoft.Extensions.DependencyInjection;

internal static class PackagerCliServiceCollectionExtensions
{
    internal static IServiceCollection AddPackagerCliServices(
        this IServiceCollection services)
    {
        services.AddCqlPackagingServices();
        services.TryAddScoped<PackagerCli>();
        services.TryAddSingleton<OptionsConsoleDumper>();
        return services;
    }

    public static IServiceCollection AddPackagerCliOptions(
        this IServiceCollection services)
    {
        /*
        if (services.Any(s => s.ServiceType == typeof(IValidateOptions<PackagerCliOptions>)))
            return services;

        services.AddSingleton<IValidateOptions<PackagerCliOptions>, PackagerCliOptions.Validator>();
        */

        services
            .AddOptions<PackagerCliOptions>()
            .Configure<IConfiguration>(PackagerCliOptions.BindConfig)
            .ValidateOnStart();

        return services;
    }
}
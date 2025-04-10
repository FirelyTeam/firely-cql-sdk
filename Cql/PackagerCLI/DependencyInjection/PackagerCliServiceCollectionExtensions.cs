/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Packager;
using Hl7.Cql.Packager.Options;

// ReSharper disable once CheckNamespace
#pragma warning disable IDE0130 // Namespace does not match folder structure

namespace Microsoft.Extensions.DependencyInjection;

internal static class PackagerCliServiceCollectionExtensions
{
    public static IServiceCollection AddPackagerCliOptions(
        this IServiceCollection services)
    {
        services.AddOptions<CqlOptions>()
                .BindConfiguration(CqlOptions.ConfigSection)
                .Configure<IConfiguration>(CqlOptions.Configure)
                .ValidateOnStart();

        services.AddOptions<ElmOptions>()
                .BindConfiguration(ElmOptions.ConfigSection)
                .ValidateOnStart();

        services.AddOptions<PackagingOptions>()
                .BindConfiguration(PackagingOptions.ConfigSection)
                .Configure(PackagingOptions.Configure)
                .ValidateOnStart();

        services.AddOptions<LoggingOptions>()
                .BindConfiguration(LoggingOptions.ConfigSection);

        return services;
    }

    public static IConfigurationBuilder AddPackagerCliAppSettings(
        this IConfigurationBuilder config,
        Func<IEnumerable<KeyValuePair<string, string?>>>? additionalConfiguration = null)
    {
        var buildConfiguration = typeof(Program).Assembly.GetCustomAttribute<AssemblyConfigurationAttribute>()?.Configuration?.ToLowerInvariant();
        var environmentName = buildConfiguration ?? "release";

        config
            .AddEnvironmentVariables("CQLPACKAGER")
            .AddJsonFile("Hl7.Cql.Packager.appsettings.json", optional: true, reloadOnChange: false)
            .AddJsonFile($"Hl7.Cql.Packager.appsettings.{environmentName}.json", optional: true, reloadOnChange: false)
            ;

        if (additionalConfiguration?.Invoke().ToList() is { } additionalData)
        {
            config.Sources.Add(new MemoryConfigurationSource()
            {
                InitialData = additionalData
            });
        }

        return config;
    }
}

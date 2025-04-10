/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System.Collections.ObjectModel;
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
        LegacyProgramArgs legacyProgramArgs)
    {
        var buildConfiguration = typeof(Program).Assembly.GetCustomAttribute<AssemblyConfigurationAttribute>()?.Configuration?.ToLowerInvariant();
        var environmentName = buildConfiguration ?? "release";

        config
            //.SetBasePath()
            .AddJsonFile("Hl7.Cql.Packager.appsettings.json", optional: true, reloadOnChange: false)
            .AddJsonFile($"Hl7.Cql.Packager.appsettings.{environmentName}.json", optional: true, reloadOnChange: false)
            ;

        config.Sources.Add(new LegacyConfigurationSource(legacyProgramArgs));
        return config;
    }
}

file class LegacyConfigurationSource(LegacyProgramArgs legacyProgramArgs) : IConfigurationSource
{
    public IConfigurationProvider Build(IConfigurationBuilder builder) =>
        new LegacyConfigurationProvider(legacyProgramArgs);
}

file class LegacyConfigurationProvider(LegacyProgramArgs legacyProgramArgs) : ConfigurationProvider
{
    public override void Load()
    {
        var dictionary = new Dictionary<string, string?>();
        if (legacyProgramArgs.canonicalRootUrl is { } canonicalRootUrl)
            dictionary.Add($"{PackagingOptions.ConfigSection}:{nameof(PackagingOptions.CanonicalRootUrl)}", canonicalRootUrl);
        if (legacyProgramArgs.overrideUtcDateTime is { } overrideDate)
            dictionary.Add($"{PackagingOptions.ConfigSection}:{nameof(PackagingOptions.OverrideDate)}", overrideDate.ToString("u"));
        if (legacyProgramArgs.jsonPretty is {} jsonPretty)
            dictionary.Add($"{PackagingOptions.ConfigSection}:{nameof(PackagingOptions.JsonPretty)}", JsonSerializer.Serialize(jsonPretty));
        if (legacyProgramArgs.logDebug is { } logDebug)
            dictionary.Add($"{LoggingOptions.ConfigSection}:{nameof(LoggingOptions.Debug)}", JsonSerializer.Serialize(logDebug));
        if (legacyProgramArgs.logAppend is { } logAppend )
            dictionary.Add($"{LoggingOptions.ConfigSection}:{nameof(LoggingOptions.Append)}", JsonSerializer.Serialize(logAppend));
        Data = new ReadOnlyDictionary<string, string?>(dictionary);
    }
}
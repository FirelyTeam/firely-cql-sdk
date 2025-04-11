/*
 * Copyright (c) 2024, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Packager;
using Hl7.Cql.Packager.Options;
using Microsoft.Extensions.Configuration;

// ReSharper disable once CheckNamespace
#pragma warning disable IDE0130 // Namespace does not match folder structure

namespace Microsoft.Extensions.DependencyInjection;

internal static class PackagerCliServiceCollectionExtensions
{
    public static IServiceCollection AddPackagerCliOptions(
        this IServiceCollection services) =>
        services.AddBindAndConfigureOptions<CqlBindOptions>()
                .AddAndBindOptions<ElmOptions>()
                .AddBindAndConfigureOptions<PackagingBindOptions>()
                .AddAndBindOptions<LoggingOptions>();

    public static IConfigurationBuilder AddPackagerCliAppSettings(
        this IConfigurationBuilder config,
        Func<IEnumerable<(object? value, string[] sectionPath)>>? additionalConfiguration = null)
    {
        var buildConfiguration = typeof(Program).Assembly.GetCustomAttribute<AssemblyConfigurationAttribute>()?.Configuration?.ToLowerInvariant();
        var environmentName = buildConfiguration ?? "release";
        var exeDir = Path.GetDirectoryName(typeof(Program).Assembly.Location)!;

        config.AddEnvironmentVariables("CQLPACKAGER");

        config.AddJsonFile(Path.Combine(exeDir, "Hl7.Cql.Packager.appsettings.json"), optional: true, reloadOnChange: false);

        if (exeDir != Environment.CurrentDirectory)
            config.AddJsonFile(Path.Combine(Environment.CurrentDirectory, "Hl7.Cql.Packager.appsettings.json"), optional: true, reloadOnChange: false);

        config.AddJsonFile(Path.Combine(exeDir, $"Hl7.Cql.Packager.appsettings.{environmentName}.json"), optional: true, reloadOnChange: false);

        if (exeDir != Environment.CurrentDirectory)
            config.AddJsonFile(Path.Combine(Environment.CurrentDirectory, $"Hl7.Cql.Packager.appsettings.{environmentName}.json"), optional: true, reloadOnChange: false);

        // Add additionalData (which can be from the command line)
        if (additionalConfiguration
            ?.Invoke()
            .Where(ad => ad.value is not null)
            .Select(ad => KeyValue(
                        ad.sectionPath,
                        ad.value switch
                        {
                            bool b            => b ? "true" : "false",
                            string s          => s,
                            DirectoryInfo di  => di.FullName,
                            DateTimeOffset dt => dt.ToString("u", CultureInfo.InvariantCulture),
                            object o          => throw new NotSupportedException($"Unsupported type: {o.GetType()}"),
                            _                 => throw new UnreachableException()
                        }))
            .ToArray() is { } additionalData)
            config.Sources.Add(new MemoryConfigurationSource()
            {
                InitialData = additionalData
            });

        static KeyValuePair<string, string?> KeyValue(string[] sectionPath, string value) =>
            new(string.Join(':', sectionPath), value);

        return config;
    }
}
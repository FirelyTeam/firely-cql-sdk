/*
 * Copyright (c) 2024, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Packager;
using Hl7.Cql.Packager.Commands.Logging;
using Hl7.Cql.Packager.Options;

// ReSharper disable once CheckNamespace
#pragma warning disable IDE0130 // Namespace does not match folder structure

namespace Microsoft.Extensions.DependencyInjection;

internal static class PackagerCliServiceCollectionExtensions
{
    public static IServiceCollection AddPackagerCliOptions(
        this IServiceCollection services) =>
        services.AddAndBindOptions<CqlOptions>()
                .AddAndBindOptions<ElmOptions>()
                .AddAndBindOptions<FhirOptions>()
                .AddAndBindOptions<LoggingOptions>();

    public static IConfigurationBuilder AddPackagerCliAppSettings(
        this IConfigurationBuilder config,
        Func<IEnumerable<(object? value, string[] sectionPath)>>? additionalConfiguration = null)
    {
        var buildConfiguration = typeof(Program).Assembly.GetCustomAttribute<AssemblyConfigurationAttribute>()?.Configuration?.ToLowerInvariant();
        buildConfiguration ??= "release";

        var curDirName = Environment.CurrentDirectory;
        var asmFileInfo = new FileInfo(Path.GetFullPath(typeof(Program).Assembly.Location));
        var asmDirName = asmFileInfo.DirectoryName!;
        var asmFileNameNoExt = asmFileInfo.Name[..^4]; // Trim ".dll"

        config.AddEnvironmentVariables("CQLPACKAGER");

        IEnumerable<string> files =
        [
            Path.Combine(asmDirName, $"{asmFileNameNoExt}.appsettings.json"),
            Path.Combine(curDirName, $"{asmFileNameNoExt}.appsettings.json"),
            Path.Combine(asmDirName, $"{asmFileNameNoExt}.appsettings.{buildConfiguration}.json"),
            Path.Combine(curDirName, $"{asmFileNameNoExt}.appsettings.{buildConfiguration}.json")
        ];
        files = files.Distinct();
        foreach (var file in files)
            config.AddJsonFile(file, optional: true, reloadOnChange: false);

        // Add additionalData (which can be from the command line)
        if (additionalConfiguration
            ?.Invoke()
            .Where(ad => ad.value is not null)
            .Select(KeyValuePair!)
            .ToArray() is { } additionalData)
            config.Sources.Add(new MemoryConfigurationSource { InitialData = additionalData });

        return config;

        KeyValuePair<string, string?> KeyValuePair((object value, string[] sectionPath) ad)
        {
            string value = ad.value switch
            {
                bool b            => b ? "true" : "false",
                string s          => s,
                DirectoryInfo di  => di.FullName,
                DateTimeOffset dt => dt.ToString("u", CultureInfo.InvariantCulture),
                Enum e            => e.ToString(),
                { } o             => throw new NotSupportedException($"Unsupported type: {o.GetType()}"),
            };
            return new(string.Join(':', ad.sectionPath), value);
        }
    }
}
/*
 *Copyright(c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Packager;
using Hl7.Cql.Packaging;
using Microsoft.Extensions.Configuration;

// ReSharper disable once CheckNamespace
#pragma warning disable IDE0130 // Namespace does not match folder structure
namespace Microsoft.Extensions.DependencyInjection;

internal static class PackagerCliCommandLineSwitchConfigurationExtensions
{
    private static IDictionary<string, string> CommandLineSwitchMappings { get; } = BuildCommandLineSwitchMappings();

    static IDictionary<string, string> BuildCommandLineSwitchMappings()
    {
        const string PackagerCliSection = PackagerCliOptions.ConfigSection + ":";
        const string PackageSection = CqlToResourcePackagingOptions.ConfigSection + ":";
        const string FhirResourceWriterSection = FhirResourceWriterOptions.ConfigSection + ":";

        return new SortedDictionary<string, string>
        {
            // @formatter:off
            ["--elm"] = PackageSection + nameof(CqlToResourcePackagingOptions.ElmDirectory),
            ["--cql"] = PackageSection + nameof(CqlToResourcePackagingOptions.CqlDirectory),
            ["--log-debug"] = PackageSection + nameof(CqlToResourcePackagingOptions.LogDebugEnabled),
            ["--log-dont-clear"] = PackageSection + nameof(CqlToResourcePackagingOptions.DontLogClear),
            ["--canonical-root-url"] = PackageSection + nameof(CqlToResourcePackagingOptions.CanonicalRootUrl),

            ["--cs"] = PackagerCliSection + nameof(PackagerCliOptions.OutDirectoryCSharp),
            ["--dll"] = PackagerCliSection + nameof(PackagerCliOptions.OutDirectoryAssemblies),

            ["--fhir"] = FhirResourceWriterSection + nameof(FhirResourceWriterOptions.OutDirectory),
            ["--override-utc-date-time"] = FhirResourceWriterSection + nameof(FhirResourceWriterOptions.OverrideDate),
            // @formatter:on
        };
    }

    public static T? GetCommandLineSwitchValue<T>(
        this IConfiguration configuration,
        string switchMapKey) =>
        configuration.GetValue<T>(CommandLineSwitchMappings[switchMapKey]);

    public static void AddPackagerCliCommandLineSwitches(
        this IConfigurationBuilder config,
        string[] args)
    {
        config.AddCommandLine(args, CommandLineSwitchMappings);
    }
}
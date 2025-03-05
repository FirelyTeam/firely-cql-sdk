/*
 *Copyright(c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Packager;

// ReSharper disable once CheckNamespace
#pragma warning disable IDE0130 // Namespace does not match folder structure
namespace Microsoft.Extensions.DependencyInjection;

internal static class PackagerCliCommandLineSwitchConfigurationExtensions
{
    private static IDictionary<string, string> CommandLineSwitchMappings { get; } = BuildCommandLineSwitchMappings();

    static IDictionary<string, string> BuildCommandLineSwitchMappings()
    {
        const string PackagerCliSection = PackagerCliOptions.ConfigSection + ":";

        return new SortedDictionary<string, string>
        {
            // @formatter:off

            // Input
            ["--elm"] = PackagerCliSection + nameof(PackagerCliOptions.ElmFromDirectory),
            ["--cql"] = PackagerCliSection + nameof(PackagerCliOptions.CqlFromDirectory),

            // Output
            ["--cs"] = PackagerCliSection + nameof(PackagerCliOptions.CSharpOutDirectory),
            ["--dll"] = PackagerCliSection + nameof(PackagerCliOptions.AssemblyOutDirectory),

            // Logging
            ["--log-debug"] = PackagerCliSection + nameof(PackagerCliOptions.LoggingIncludeDebug),
            ["--log-dont-clear"] = PackagerCliSection + nameof(PackagerCliOptions.LoggingKeepPrevious),

            // Packaging
            ["--canonical-root-url"] = PackagerCliSection + nameof(PackagerCliOptions.FhirCanonicalRootUrl),
            ["--fhir"] = PackagerCliSection + nameof(PackagerCliOptions.FhirOutDirectory),
            ["--override-utc-date-time"] = PackagerCliSection + nameof(PackagerCliOptions.FhirOverrideDate),
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
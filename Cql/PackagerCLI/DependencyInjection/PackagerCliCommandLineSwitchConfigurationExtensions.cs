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
        return new SortedDictionary<string, string>
        {
            // Input Dirs
            ["--cql-in-dir"] = Section(CqlOptions.ConfigSection, nameof(CqlOptions.CqlInDir)),
            ["--elm-in-dir"] = Section(ElmOptions.ConfigSection, nameof(ElmOptions.ElmInDir)),

            // Output Dirs
            ["--elm-out-dir"] = Section(ElmOptions.ConfigSection, nameof(CqlOptions.ElmOutDir)),
            ["--csharp-out-dir"] = Section(ElmOptions.ConfigSection, nameof(ElmOptions.CSharpOutDir)),
            ["--dll-out-dir"] = Section(ElmOptions.ConfigSection, nameof(ElmOptions.DllOutDir)),
            ["--fhir-out-dir"] = Section(PackagingOptions.ConfigSection, nameof(PackagingOptions.FhirOutDir)),

            // Logging
            ["--log-debug"] = Section(LoggingOptions.ConfigSection, nameof(LoggingOptions.IncludeDebug)),
            ["--log-dont-clear"] = Section(LoggingOptions.ConfigSection, nameof(LoggingOptions.KeepPrevious)),

            // Packaging
            ["--canonical-root-url"] = Section(PackagingOptions.ConfigSection, nameof(PackagingOptions.CanonicalRootUrl)),
            ["--override-date-time"] = Section(PackagingOptions.ConfigSection, nameof(PackagingOptions.OverrideDate)),

            // Serialization
            ["--json-indent-enable"] = Section(PackagingOptions.ConfigSection, nameof(PackagingOptions.JsonIndentEnable)),
        };

        static string Section(params string[] sections) => string.Join(':', sections);
    }

    public static T? GetCommandLineSwitchValue<T>(
        this IConfiguration configuration,
        string switchMapKey) =>
        configuration.GetValue<T>(CommandLineSwitchMappings[switchMapKey]);

    public static IConfigurationBuilder AddPackagerCliCommandLineSwitches(
        this IConfigurationBuilder config,
        string[] args)
    {
        config.AddCommandLine(args, CommandLineSwitchMappings);
        return config;
    }
}
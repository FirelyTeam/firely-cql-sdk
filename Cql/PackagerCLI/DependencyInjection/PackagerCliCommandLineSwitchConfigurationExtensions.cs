/*
 *Copyright(c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Packaging;
using Hl7.Cql.Packaging.PostProcessors;
using Microsoft.Extensions.Configuration;

// ReSharper disable once CheckNamespace
#pragma warning disable IDE0130 // Namespace does not match folder structure
namespace Microsoft.Extensions.DependencyInjection;

internal static class PackagerCliCommandLineSwitchConfigurationExtensions
{
    private static IDictionary<string, string> CommandLineSwitchMappings { get; } = BuildCommandLineSwitchMappings();

    static IDictionary<string, string> BuildCommandLineSwitchMappings()
    {
        const string PackageSection = CqlToResourcePackagingOptions.ConfigSection + ":";
        const string CSharpCodeWriterSection = CSharpCodeWriterOptions.ConfigSection + ":";
        const string AssemblyDataWriterSection = AssemblyDataWriterOptions.ConfigSection + ":";
        const string FhirResourceWriterSection = FhirResourceWriterOptions.ConfigSection + ":";

        return new SortedDictionary<string, string>
        {
            // @formatter:off
            [CqlToResourcePackagingOptions.ArgNameElmDirectory] = PackageSection + nameof(CqlToResourcePackagingOptions.ElmDirectory),
            [CqlToResourcePackagingOptions.ArgNameCqlDirectory] = PackageSection + nameof(CqlToResourcePackagingOptions.CqlDirectory),
            [CqlToResourcePackagingOptions.ArgNameLogDebugEnabled] = PackageSection + nameof(CqlToResourcePackagingOptions.LogDebugEnabled),
            [CqlToResourcePackagingOptions.ArgNameLogDontClear] = PackageSection + nameof(CqlToResourcePackagingOptions.DontLogClear),
            [CqlToResourcePackagingOptions.ArgNameCanonicalRootUrl] = PackageSection + nameof(CqlToResourcePackagingOptions.CanonicalRootUrl),

            [CSharpCodeWriterOptions.ArgNameOutDirectory] = CSharpCodeWriterSection + nameof(CSharpCodeWriterOptions.OutDirectory),
            [CSharpCodeWriterOptions.ArgNameTypeFormat] = CSharpCodeWriterSection + nameof(CSharpCodeWriterOptions.TypeFormat),

            [AssemblyDataWriterOptions.ArgNameOutDirectory] = AssemblyDataWriterSection + nameof(CSharpCodeWriterOptions.OutDirectory),

            [FhirResourceWriterOptions.ArgNameOutDirectory] = FhirResourceWriterSection + nameof(FhirResourceWriterOptions.OutDirectory),
            [FhirResourceWriterOptions.ArgNameOverrideDate] = FhirResourceWriterSection + nameof(FhirResourceWriterOptions.OverrideDate),
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
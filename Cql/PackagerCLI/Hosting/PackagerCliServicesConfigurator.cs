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
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace Hl7.Cql.Packager.Hosting;

internal static class PackagerCliServicesConfigurator
{
    private static IDictionary<string, string> SwitchMappings { get; } = BuildSwitchMappings();

    static IDictionary<string, string> BuildSwitchMappings()
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

    public static T? GetSwitchMappedValue<T>(
        this IConfiguration configuration,
        string switchMapKey) =>
        configuration.GetValue<T>(SwitchMappings[switchMapKey]);

    public static void ConfigurePackagerCliApp(
        this IConfigurationBuilder config,
        string[] args)
    {
        config.AddCommandLine(args, SwitchMappings);
    }

    public static IServiceCollection ConfigurePackagerCliOptions(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        if (services.Any(s => s.ServiceType == typeof(IValidateOptions<CqlToResourcePackagingOptions>)))
            return services;

        services.AddSingleton<IValidateOptions<CqlToResourcePackagingOptions>, CqlToResourcePackagingOptions.Validator>();
        services.AddSingleton<IValidateOptions<CSharpCodeWriterOptions>, CSharpCodeWriterOptions.Validator>();

        services
            .AddOptions<CqlToResourcePackagingOptions>()
            .Configure<IConfiguration>(CqlToResourcePackagingOptions.BindConfig)
            .ValidateOnStart();

        services
            .AddOptions<FhirResourceWriterOptions>()
            .Configure<IConfiguration>(FhirResourceWriterOptions.BindConfig)
            .ValidateOnStart();

        services
            .AddOptions<CSharpCodeWriterOptions>()
            .Configure<IConfiguration>(CSharpCodeWriterOptions.BindConfig)
            .ValidateOnStart();

        services
            .AddOptions<AssemblyDataWriterOptions>()
            .Configure<IConfiguration>(AssemblyDataWriterOptions.BindConfig)
            .ValidateOnStart();

        return services;
    }
}
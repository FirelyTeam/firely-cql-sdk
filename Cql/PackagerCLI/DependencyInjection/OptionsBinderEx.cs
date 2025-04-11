/*
 * Copyright(c) 2024, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System.Diagnostics.CodeAnalysis;
using Hl7.Cql.Packager;

// ReSharper disable once CheckNamespace
#pragma warning disable IDE0130 // Namespace does not match folder structure

namespace Microsoft.Extensions.DependencyInjection;

public static class OptionsBinderEx
{
    // Copied from OptionsBuilderConfigurationExtensions
    private const string RequiresDynamicCodeMessage = "Binding strongly typed objects to configuration values may require generating dynamic code at runtime.";

    private const string TrimmingRequiredUnreferencedCodeMessage =
        "TOptions's dependent types may have their members trimmed. Ensure all required members are preserved.";

    [RequiresDynamicCode(RequiresDynamicCodeMessage)]
    [RequiresUnreferencedCode(TrimmingRequiredUnreferencedCodeMessage)]
    public static OptionsBuilder<TOptions> BindConfigurationEx<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] TOptions>(
        this OptionsBuilder<TOptions> optionsBuilder,
        string configSectionPath,
        Action<BinderOptions>? configureBinder = null)
        where TOptions : class =>
        optionsBuilder
            .BindConfiguration(configSectionPath, configureBinder)
            .Configure<IConfiguration>(
                (opt, config) =>
                    BindDirectoryInfoProperties(config, configSectionPath, opt));

    private static void BindDirectoryInfoProperties(
        IConfiguration configuration,
        string key,
        object instance)
    {
        var properties = instance.GetType().GetProperties();
        foreach (var property in properties)
            if (property.PropertyType == typeof(DirectoryInfo))
            {
                var value = configuration[key + ":" + property.Name];
                if (!string.IsNullOrEmpty(value))
                    property.SetValue(instance, new DirectoryInfo(value));
            }
    }
}

public static class OptionsExServiceCollectionExtensions
{
    public static IServiceCollection AddAndBindOptions<TOptions>(this IServiceCollection services) where TOptions : class, IOptionsEx =>
        services.AddOptions<TOptions>(Options.Options.DefaultName)
                .BindConfigurationEx(TOptions.ConfigSection)
                .ValidateOnStart()
                .Services;
}

public static class ConfigureOptionsExServiceCollectionExtensions
{
    public static IServiceCollection AddBindAndConfigureOptions<TOptions>(this IServiceCollection services)
        where TOptions : class, IConfigureOptionsEx<TOptions> =>
        services.AddOptions<TOptions>(Options.Options.DefaultName)
                .BindConfigurationEx(TOptions.ConfigSection)
                .ValidateOnStart()
                .Configure<IConfiguration>(TOptions.Configure)
                .Services;
}
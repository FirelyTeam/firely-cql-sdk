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
    /// <summary>
    /// Binds additional properties of the options class to the configuration
    /// that is not supported out of the box by the Options pattern.
    /// e.g. DirectoryInfo properties.
    /// </summary>
    private static OptionsBuilder<TOptions> BindAdditionalProperties<
        [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] TOptions>(
        this OptionsBuilder<TOptions> optionsBuilder,
        string configSectionPath)
        where TOptions : class =>
        optionsBuilder
            .Configure<IConfiguration>(
                (options, configuration) =>
                {
                    var properties = options.GetType().GetProperties();
                    foreach (var property in properties)
                        if (property.PropertyType == typeof(DirectoryInfo))
                        {
                            var value = configuration[$"{configSectionPath}:{property.Name}"];
                            if (!string.IsNullOrEmpty(value))
                                property.SetValue(options, new DirectoryInfo(value));
                        }
                });

    public static IServiceCollection AddAndBindOptions<TOptions>(this IServiceCollection services)
        where TOptions : class, IBindOptions =>
        services.AddOptions<TOptions>(Options.Options.DefaultName)
                .BindConfiguration(TOptions.ConfigSection)
                .BindAdditionalProperties(TOptions.ConfigSection)
                .ValidateOnStart()
                .Services;

    public static IServiceCollection AddBindAndConfigureOptions<TOptions>(this IServiceCollection services)
        where TOptions : class, IConfigureBindOptions<TOptions> =>
        services.AddOptions<TOptions>(Options.Options.DefaultName)
                .BindConfiguration(TOptions.ConfigSection)
                .BindAdditionalProperties(TOptions.ConfigSection)
                .ValidateOnStart()
                .Configure<IConfiguration>(TOptions.Configure)
                .Services;
}
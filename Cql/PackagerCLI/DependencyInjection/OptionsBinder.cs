/*
 * Copyright(c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Packager;

// ReSharper disable once CheckNamespace
#pragma warning disable IDE0130 // Namespace does not match folder structure

namespace Microsoft.Extensions.DependencyInjection;

public static class OptionsBinder
{
    /// <summary>
    /// Binds additional properties of the options class to the configuration
    /// that is not supported out of the box by the Options pattern.
    /// e.g. DirectoryInfo properties.
    /// </summary>
    private static OptionsBuilder<TOptions> BindConfigurationSpecialPropertyTypes<
        [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)]
        TOptions>(
        this OptionsBuilder<TOptions> optionsBuilder,
        string configSectionPath)
        where TOptions : class =>
        optionsBuilder
            .Configure<IConfiguration>(
                (options, configuration) =>
                {
                    var optionsType = options.GetType();
                    var properties = optionsType
                                     .GetProperties()
                                     .Where(p => p.CanWrite && p.GetIndexParameters() is [])
                                     .AsEnumerable();

                    foreach (var property in properties)
                    {
                        switch (Nullable.GetUnderlyingType(property.PropertyType) ?? property.PropertyType)
                        {
                            case
                            {
                                Name: "DirectoryInfo"
                            } type when type == typeof(DirectoryInfo):

                                var dirValue = configuration[$"{configSectionPath}:{property.Name}"];
                                if (!string.IsNullOrEmpty(dirValue))
                                    property.SetValue(options, new DirectoryInfo(dirValue));
                                break;

                            case var type:
                                var tryBindMethod = optionsType.GetMethod($"TryBind{property.Name}");
                                if (tryBindMethod is { } m
                                    && m.ReturnType == typeof(bool)
                                    && m.GetParameters() is [{} p1, { IsOut: true } p2]
                                    && p1.ParameterType == typeof(IConfiguration)
                                    && p2.ParameterType.GetElementType() /* IsOut parameter will have its property type IsByRef */ == type
                                    && configuration.GetSection(configSectionPath)?.GetSection(property.Name) is {} configSection)
                                {
                                    object?[] inputs = [configSection, null];
                                    var success = (bool)m.Invoke(options, inputs)!;
                                    if (success)
                                        property.SetValue(options, inputs[1]);
                                }
                                break;
                        }
                    }
                });

    public static IServiceCollection AddAndBindOptions<TOptions>(this IServiceCollection services)
        where TOptions : class, IBindOptions =>
        services.AddOptions<TOptions>(Options.Options.DefaultName)
                .BindConfiguration(TOptions.ConfigSection)
                .BindConfigurationSpecialPropertyTypes(TOptions.ConfigSection)
                .ValidateOnStart()
                .Services;

}
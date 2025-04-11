/*
 * Copyright(c) 2025, Firely, NCQA and contributors
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

public static class OptionsBinder
{
    private static readonly MethodInfo ConfigurationGetMethodDef =
            Hl7.Cql.Compiler.Infrastructure.ReflectionUtility
               .GenericMethodDefinitionOf(() => default(IConfiguration)!.Get<object>());

    private static readonly MethodInfo ToImmutableHashSetMethodDef =
            Hl7.Cql.Compiler.Infrastructure.ReflectionUtility
               .GenericMethodDefinitionOf(() => default(IEnumerable<object>)!.ToImmutableHashSet());

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
                    var properties = options.GetType().GetProperties();
                    foreach (var property in properties)
                    {
                        switch (Nullable.GetUnderlyingType(property.PropertyType) ?? property.PropertyType)
                        {
                            case
                            {
                                Name: "ImmutableHashSet`1",
                            } type when type.GetGenericTypeDefinition() == typeof(ImmutableHashSet<>)
                                        && type.GetGenericArguments()[0] is { IsEnum: true } enumType:

                                var getEnumArray = ConfigurationGetMethodDef.MakeGenericMethod(enumType.MakeArrayType())!;
                                var section = configuration.GetSection($"{configSectionPath}:{property.Name}");
                                var enumArray = getEnumArray.Invoke(null, [section]);
                                if (enumArray is not null)
                                {
                                    var toImmutableHashSet = ToImmutableHashSetMethodDef.MakeGenericMethod(enumType);
                                    var enumImmutableHashSet = toImmutableHashSet.Invoke(null, [enumArray]);
                                    property.SetValue(options, enumImmutableHashSet);
                                }
                                break;

                            case
                            {
                                Name: "DirectoryInfo"
                            } type when type == typeof(DirectoryInfo):

                                var dirValue = configuration[$"{configSectionPath}:{property.Name}"];
                                if (!string.IsNullOrEmpty(dirValue))
                                    property.SetValue(options, new DirectoryInfo(dirValue));
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
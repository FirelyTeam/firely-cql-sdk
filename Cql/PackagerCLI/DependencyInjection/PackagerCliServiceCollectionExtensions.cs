/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Packager;
using Hl7.Cql.CodeGeneration.NET.Toolkit;

// ReSharper disable once CheckNamespace
#pragma warning disable IDE0130 // Namespace does not match folder structure

namespace Microsoft.Extensions.DependencyInjection;

internal static class PackagerCliServiceCollectionExtensions
{
    internal static IServiceCollection AddPackagerCliServices(
        this IServiceCollection services)
    {
        services.AddCqlPackagingServices();
        services.TryAddScoped<PackagerCli>();
        services.TryAddSingleton<OptionsConsoleDumper>();
        return services;
    }

    public static IServiceCollection AddToolkitConfigs(
        this IServiceCollection services)
    {
        services.AddOptions<CqlOptions>()
                .UseFactoryMethod(CqlOptions.CreateCqlOptions)
                .BindConfiguration(CqlOptions.ConfigSection);

        services.AddOptions<ElmToolkitConfig>()
                .BindConfiguration(ElmOptions.ConfigSection);

        return services;
    }

    private static OptionsBuilder<TOptions> UseFactoryMethod<TOptions>(
        this OptionsBuilder<TOptions> optionsBuilder,
        Func<IConfiguration, TOptions> factoryMethod) where TOptions : class
    {
        var services = optionsBuilder.Services;

        if (!services.Any(s =>
                              s.ServiceType == typeof(IOptionsFactory<>)
                              && s.ImplementationType == typeof(CustomOptionsFactory<>)))
        {
            services.Replace(ServiceDescriptor.Transient(typeof(IOptionsFactory<>), typeof(CustomOptionsFactory<>)));
        }

        services.AddSingleton(factoryMethod);
        return optionsBuilder;
    }

    public static IServiceCollection AddPackagerCliOptions(
        this IServiceCollection services)
    {
        services
            .AddOptions<PackagerCliOptions>()
            .Configure<IConfiguration>(PackagerCliOptions.BindConfig)
            .ValidateOnStart();

        return services;
    }

    public static IConfigurationBuilder AddPackagerCliAppSettings(
        this IConfigurationBuilder config,
        string[] args)
    {
        var buildConfiguration = typeof(PackagerCli).Assembly.GetCustomAttribute<AssemblyConfigurationAttribute>()?.Configuration?.ToLowerInvariant();
        var environmentName = buildConfiguration ?? "release";

        config
            //.SetBasePath()
            .AddJsonFile("Hl7.Cql.Packager.appsettings.json", optional: true, reloadOnChange: false)
            .AddJsonFile($"Hl7.Cql.Packager.appsettings.{environmentName}.json", optional: true, reloadOnChange: false)
            ;
        return config;
    }
}

file class CustomOptionsFactory<TOptions>(
    IEnumerable<IConfigureOptions<TOptions>> configureOptions,
    IEnumerable<IPostConfigureOptions<TOptions>> postConfigureOptions,
    IEnumerable<IValidateOptions<TOptions>> validations,
    IConfiguration configuration,
    Func<IConfiguration, TOptions>? overrideFactoryMethod = null) :
    OptionsFactory<TOptions>(configureOptions, postConfigureOptions, validations)
    where TOptions : class
{
    protected override TOptions CreateInstance(string name)
    {
        if (overrideFactoryMethod is not null)
        {
            try
            {
                return overrideFactoryMethod(configuration);
            }
            catch (Exception e)
            {
                throw new OptionsValidationException( name, typeof(TOptions), [e.Message]);
            }
        }

        return base.CreateInstance(name);
    }
}
/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.CqlToElm.Toolkit;
using Hl7.Cql.Packager;
using System.Collections.Immutable;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Hl7.Cql.CodeGeneration.NET.Toolkit;

// ReSharper disable once CheckNamespace
#pragma warning disable IDE0130 // Namespace does not match folder structure
namespace Microsoft.Extensions.DependencyInjection;

internal static class PackagerCliServiceCollectionExtensions
{
    private const string CqlSectionName = "Cql";
    private const string ElmSectionName = "Elm";
    private const string CqlModelsSectionName = nameof(CqlToolkitConfig.Models);

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
        services.AddOptions<CqlToolkitConfig>()
                .UseFactoryMethod(CreateCqlToolkitConfig)
                .BindConfiguration(CqlSectionName);

        services.AddOptions<ElmToolkitConfig>()
                .BindConfiguration(ElmSectionName);

        return services;

        static CqlToolkitConfig CreateCqlToolkitConfig(IConfiguration configuration)
        {
            var section = configuration.GetSection(CqlSectionName);

            // Special handling to load Models from the configuration
            var models = section.GetSection(CqlModelsSectionName).Get<CqlModel[]>();

            // Validate
            if (models is not null)
                foreach (var model in models)
                    if (!Enum.IsDefined(typeof(CqlModel), model))
                        throw new InvalidEnumArgumentException(CqlModelsSectionName, (int)model, typeof(CqlModel));

            CqlToolkitConfig config = new CqlToolkitConfig(Models: models?.ToImmutableHashSet());
            return config;
        }
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
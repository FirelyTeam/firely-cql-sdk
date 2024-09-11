/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System;
using System.Globalization;
using Hl7.Cql.CqlToElm.Builtin;
using Hl7.Cql.CqlToElm.LibraryProviders;
using Microsoft.Extensions.DependencyInjection;

namespace Hl7.Cql.CqlToElm.Services;

internal static class CqlToElmServicesInitializer
{
    // public static IConfigurationBuilder WithCqlToElmOptions(
    //     this IConfigurationBuilder builder,
    //     Action<CqlToElmOptions> options)
    // {
    //     var opt = new CqlToElmOptions();
    //     options(opt);
    //     var props = typeof(CqlToElmOptions).GetProperties();
    //     var kvps = new KeyValuePair<string, string?>[props.Length];
    //     for (int i = 0; i < props.Length; i++)
    //     {
    //         var prop = props[i];
    //         kvps[i] = KeyValuePair.Create(prop.Name, prop.GetValue(opt)?.ToString());
    //     }
    //
    //     builder.AddInMemoryCollection(kvps);
    //     return builder;
    // }
    //
    // public static IServiceCollection AddCqlToElmConfiguration(
    //     this IServiceCollection services,
    //     Action<IConfigurationBuilder> builder)
    // {
    //     var cb = new ConfigurationBuilder();
    //     builder(cb);
    //     var config = cb.Build();
    //     services.AddSingleton<IConfiguration>(config);
    //     var options = new CqlToElmOptions();
    //     config.Bind(options);
    //     var wrapper = new OptionsWrapper<CqlToElmOptions>(options);
    //     services.AddSingleton<IOptions<CqlToElmOptions>>(wrapper);
    //     return services;
    // }
    public static IServiceCollection AddCqlToElmOptions(
        this IServiceCollection services,
        Action<CqlToElmOptions>? configureOptions)
    {
        services.AddOptions<CqlToElmOptions>()
                .Configure(configureOptions ?? (_ => { }))
                .ValidateOnStart();
        return services;
    }

    public static IServiceCollection AddCqlToElmModels(
        this IServiceCollection services,
        Action<IModelProvider> builder)
    {
        services.AddSingleton<IModelProvider>(isp =>
        {
            var provider = new BuiltinModelProvider();
            builder(provider);
            return provider;
        });

        return services;
    }

    public static IServiceCollection AddCqlToElmServices(this IServiceCollection services) =>
        services
            .AddSingleton<CqlToElmConverter>()
            .AddSingleton<CoercionProvider>()
            .AddSingleton<ElmFactory>()
            .AddSingleton<SystemLibrary>()
            .AddSingleton<StreamInspector>()
            .AddSingleton<InvocationBuilder>()
            .AddTransient<LocalIdentifierProvider>();

    public static IServiceCollection AddCqlToElmMessaging(
        this IServiceCollection services,
        CultureInfo? culture = null) =>
        services.AddSingleton(_ => new MessageProvider(culture ?? CultureInfo.InvariantCulture));
}
/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.CqlToElm;
using Hl7.Cql.CqlToElm.Builtin;
using Hl7.Cql.CqlToElm.LibraryProviders;
using Hl7.Cql.CqlToElm.Visitors;
using Hl7.Cql.Runtime.Hosting;

// ReSharper disable once CheckNamespace
#pragma warning disable IDE0130 // Namespace does not match folder structure
namespace Microsoft.Extensions.DependencyInjection;

internal static class CqlToElmServiceCollectionExtensions
{
    // For unit testing, there is no need to create the options, then put it into an in-memory collection, only to bind it to a new options object.
    // We can just create the options object directly and pass it to the configureOptions action in the AddCqlToElmOptions method.
    //
    // The commented code below is the original implementation of the AddCqlToElmOptions method.
    // There are some useful things that might be useful for the future.
    //
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
        Action<CqlToElmOptions>? configureOptions = null)
    {
        services.AddOptions<CqlToElmOptions>(
                    b =>
                    {
                        if (configureOptions is not null)
                            b.Configure(configureOptions);
                        b.ValidateOnStart();
                    });
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
            .AddTransient<LocalIdentifierProvider>()
            .AddScoped<LibraryVisitor>()
            .AddFactory<LibraryVisitor.DefinitionVisitor, LibraryBuilder>()
            .AddFactory<ExpressionVisitor, LibraryBuilder>()
            .AddFactory<TypeSpecifierVisitor, LibraryBuilder>()
            ;

    public static IServiceCollection AddCqlToElmMessaging(
        this IServiceCollection services,
        CultureInfo? culture = null) =>
        services.AddSingleton(_ => new MessageProvider(culture ?? CultureInfo.InvariantCulture));
}

file static class ServiceCollectionExtensions
{
    /// <summary>
    /// Adds a factory delegate to the service collection that creates instances of <typeparamref name="TService"/>
    /// using a single dependency of type <typeparamref name="TDep1"/>.
    /// </summary>
    /// <remarks>This method registers a factory delegate of type <see cref="Func{TDep1, TService}"/> as a
    /// singleton in the  service collection. The factory uses <see cref="ActivatorUtilities.CreateInstance{T}"/> to
    /// create instances  of <typeparamref name="TService"/> dynamically, resolving its dependencies from the service
    /// provider.</remarks>
    /// <typeparam name="TService">The type of the service to be created by the factory.</typeparam>
    /// <typeparam name="TDep1">The type of the dependency required to create <typeparamref name="TService"/>.</typeparam>
    /// <param name="services">The <see cref="IServiceCollection"/> to which the factory delegate is added.</param>
    /// <returns>The updated <see cref="IServiceCollection"/> instance.</returns>
    public static IServiceCollection AddFactory<TService, TDep1>(this IServiceCollection services)
        where TService : class
        where TDep1 : class =>
        services.AddSingleton<Func<TDep1, TService>>(
            serviceProvider =>
                dependency1 =>
                    ActivatorUtilities.CreateInstance<TService>(serviceProvider, dependency1));
}
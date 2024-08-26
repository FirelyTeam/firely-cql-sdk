using Hl7.Cql.CqlToElm.Builtin;
using Hl7.Cql.CqlToElm.LibraryProviders;
using Hl7.Cql.CqlToElm.Scopes;
using Hl7.Cql.CqlToElm.Visitors;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Hl7.Cql.CqlToElm
{
    internal static class Services
    {
        public static IConfigurationBuilder WithDefaultOptions(this IConfigurationBuilder builder) =>
            WithOptions(builder, options => { });
        public static IConfigurationBuilder WithOptions(this IConfigurationBuilder builder,
            Action<CqlToElmOptions> options)
        {
            var opt = new CqlToElmOptions();
            options(opt);
            var props = typeof(CqlToElmOptions).GetProperties();
            var kvps = new KeyValuePair<string, string?>[props.Length];
            for (int i = 0; i < props.Length; i++)
            {
                var prop = props[i];
                kvps[i] = KeyValuePair.Create(prop.Name, prop.GetValue(opt)?.ToString());
            }
            builder.AddInMemoryCollection(kvps);
            return builder;
        }

        public static IServiceCollection AddModels(this IServiceCollection services,
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

        public static IServiceCollection AddConfiguration(this IServiceCollection services,
            Action<IConfigurationBuilder> builder)
        {
            var cb = new ConfigurationBuilder();
            builder(cb);
            var config = cb.Build();
            services.AddSingleton<IConfiguration>(config);
            var options = new CqlToElmOptions();
            config.Bind(options);
            var wrapper = new OptionsWrapper<CqlToElmOptions>(options);
            services.AddSingleton<IOptions<CqlToElmOptions>>(wrapper);
            return services;
        }

        public static IServiceCollection AddSystem(this IServiceCollection services) =>
            services
                .AddSingleton<CqlToElmConverter>()
                .AddSingleton<CoercionProvider>()
                .AddSingleton<ElmFactory>()
                .AddSingleton<SystemLibrary>()
                .AddSingleton<StreamInspector>()
                .AddSingleton<InvocationBuilder>()
                .AddTransient<LocalIdentifierProvider>();

        public static IServiceCollection AddMessaging(this IServiceCollection services, CultureInfo? culture = null) =>
            services.AddSingleton(new MessageProvider(culture ?? CultureInfo.InvariantCulture));
    }
}

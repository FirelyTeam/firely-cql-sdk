﻿using Hl7.Cql.CqlToElm.Builtin;
using Hl7.Cql.CqlToElm.Visitors;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

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

        public static IServiceCollection AddVisitors(this IServiceCollection services)
        {
            services.AddScoped<ExpressionVisitor>();
            services.AddScoped<LibraryVisitor>();
            services.AddScoped<DefinitionVisitor>();
            services.AddScoped<TypeSpecifierVisitor>();
            return services;
        }

        public static IServiceCollection AddLocalIdProvider(this IServiceCollection services) =>
            services.AddScoped<LocalIdentifierProvider>();

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
            services.AddScoped<IConfiguration>(isp => cb.Build());
            return services;
        }

        public static IServiceCollection AddContext(this IServiceCollection services) =>
            services
                .AddScoped<SystemLibrary>()
                .AddScoped<LibraryBuilder>()
                .AddScoped<ILibraryProvider, ConverterContext>()
                .AddScoped<ConverterContext>();

        public static ILoggingBuilder ThrowOn(this ILoggingBuilder builder, LogLevel threshold) =>
            builder.AddProvider(new ThrowingLoggerProvider(threshold));
    }
}
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
            services.AddScoped<ContextDefVisitor>();
            services.AddScoped<ExpressionVisitor>();
            services.AddScoped<ExpressionDefinitionVisitor>();
            services.AddScoped<LibraryVisitor>();
            services.AddScoped<ParameterDefinitionVisitor>();
            services.AddScoped<TupleElementVisitor>();
            services.AddScoped<TupleElementDefinitionVisitor>();
            services.AddScoped<TypeSpecifierVisitor>();
            services.AddScoped<VersionedIdentifierVisitor>();
            return services;
        }

        public static IServiceCollection AddLocalIdProvider(this IServiceCollection services) =>
            services.AddScoped<LocalIdentifierProvider>();

        public static IServiceCollection AddModels(this IServiceCollection services,
            Action<IModelProvider> builder)
        {
            var provider = new ModelProvider();
            builder(provider);
            services.AddScoped<IModelProvider>(isp => provider);
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
                .AddScoped<ConverterContext>()
                .AddScoped<LibraryContext>();

        public static ILoggingBuilder ThrowOn(this ILoggingBuilder builder, LogLevel threshold) =>
            builder.AddProvider(new ThrowingLoggerProvider(threshold));

        public static IServiceCollection AddTypeSpecifierComparer(this IServiceCollection services, StringComparer? nameComparer = null) =>
            services.AddScoped<IEqualityComparer<Elm.TypeSpecifier>>(isp => new TypeSpecifierEqualityComparer(nameComparer));
    }
}

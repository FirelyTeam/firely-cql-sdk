using CqlSdkPrototype.Cql;
using Hl7.Cql.CqlToElm;
using Hl7.Cql.CqlToElm.LibraryProviders;
using Hl7.Cql.Elm;
using ExpressionVisitor = Hl7.Cql.CqlToElm.Visitors.ExpressionVisitor;

namespace CqlSdkPrototype.App;

public static class Extensions
{
    public static ILoggingBuilder UseOptions(this ILoggingBuilder builder, LoggingOptions options)
    {
        if (options.LoggerProvider is { } provider)
            builder = builder.AddProvider(provider);
        if (options.LogFilter is { } filter)
            builder = builder.AddFilter((provider, category, level) => filter(new (provider, category, level)));
        return builder;
    }

    public static IServiceCollection AddElmApi(
        this IServiceCollection serviceCollection)
    {
        return serviceCollection
            .AddCqlCodeGenerationServices(configureCSharpCodeWriterOptions: null);
    }

    public static IServiceCollection SuppressCqlDebugAssertions(
        this IServiceCollection serviceCollection)
    {
        // This is really annoying in debug mode
        ExpressionVisitor.EnableDebugAssertions = false;
        Library.EnableDebugAssertions = false;
        return serviceCollection;
    }

    public static IServiceCollection AddCqlApi(
        this IServiceCollection serviceCollection,
        Action<CqlServicesOptions>? configureOptions = null)
    {
        serviceCollection.SuppressCqlDebugAssertions();

        CqlServicesOptions? cqlTranslationOptions = null;
        if (configureOptions is { } fn)
        {
            cqlTranslationOptions = new CqlServicesOptions();
            fn(cqlTranslationOptions);
        }

        return serviceCollection
               .AddCqlToElmServices()
               .AddCqlToElmModels(ConfigureModelProvider())
               .AddCqlToElmOptions(ConfigureCqlToElmOptions())
               .AddSingleton<ILibraryProvider, MemoryLibraryProvider>()
               .AddCqlToElmMessaging();

        Action<CqlToElmOptions>? ConfigureCqlToElmOptions()
        {
            return null;
        }

        Action<IModelProvider> ConfigureModelProvider()
        {
            return cqlTranslationOptions is { } o
                       ? modelProvider =>
                       {
                           foreach (var modelInfo in o.Models)
                               modelProvider.Add(modelInfo);
                       }
            : _ => { };
        }
    }
}
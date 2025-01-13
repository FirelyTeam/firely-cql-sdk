using CqlSdkPrototype.App;

namespace CqlSdkPrototype.Logging;

public static class LoggingServiceCollectionExtensions
{
    public static ILoggingBuilder ApplyLoggingOptions(
        this ILoggingBuilder builder,
        LoggingOptions options,
        bool dontClearExistingLoggerProviders = false)
    {
        if (!dontClearExistingLoggerProviders)
            builder.ClearProviders();

        if (options.LoggerProviders is { } providers)
            foreach (var provider in providers)
                builder.AddProvider(provider);

        if (options.LogFilter is { } filter)
            builder = builder.AddFilter((provider, category, level) => filter(new (provider, category, level)));

        return builder;
    }

    public static IServiceCollection AddLogging(
        this IServiceCollection services,
        LoggingOptions options,
        Action<ILoggingBuilder>? configure = null,
        bool dontClearExistingLoggerProviders = false)
    {
         services.AddLogging(
            lb =>
            {
                lb.ApplyLoggingOptions(options, dontClearExistingLoggerProviders);
                configure?.Invoke(lb);
            });
        return services;
    }
}

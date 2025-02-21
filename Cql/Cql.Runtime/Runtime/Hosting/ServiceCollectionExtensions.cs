namespace Hl7.Cql.Runtime.Hosting;

internal static class ServiceCollectionExtensions
{
    public static IServiceCollection AddDebugLogging(
        this IServiceCollection services) =>
        services.AddLogging(loggingBuilder =>
        {
            loggingBuilder.ClearProviders();
            loggingBuilder.AddDebug();
        });

    public static IServiceCollection AddOptions<TOptions>(
        this IServiceCollection services,
        Action<OptionsBuilder<TOptions>> buildOptions)
        where TOptions : class
    {
        OptionsBuilder<TOptions> optionsBuilder = services.AddOptions<TOptions>();
        buildOptions(optionsBuilder);
        return services;
    }
}
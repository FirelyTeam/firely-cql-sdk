using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Hl7.Cql.Runtime.Hosting;

internal static class LoggingServiceCollectionExtensions
{
    public static IServiceCollection AddExternalLogging(
        this IServiceCollection services,
        ILoggerFactory loggerFactory)
    {
        services.AddOptions();
        services.TryAdd(ServiceDescriptor.Singleton(loggerFactory));
        services.TryAdd(ServiceDescriptor.Singleton(typeof(ILogger<>), typeof(Logger<>)));
        return services;
    }
}

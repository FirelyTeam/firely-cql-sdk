using Hl7.Fhir.Model.CdsHooks;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace CqlSdkPrototype.Logging;

public static class LoggingServiceCollectionExtensions
{
    public static IServiceCollection AddLoggingFromOptions(
        this IServiceCollection services,
        LoggingOptions options)
    {
        services.AddOptions();
        services.TryAdd(ServiceDescriptor.Singleton<ILoggerFactory>(options.LoggerFactory!));
        services.TryAdd(ServiceDescriptor.Singleton(typeof(ILogger<>), typeof(Logger<>)));
        return services;
    }
}

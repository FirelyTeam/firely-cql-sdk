using System;
using System.Threading;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace CoreTests;

internal static class CqlServicesInitializer
{
    public static IServiceCollection AddDebugLogging(
        this IServiceCollection services) =>
        services.AddLogging(loggingBuilder =>
        {
            loggingBuilder.ClearProviders();
            loggingBuilder.AddDebug();
        });
}
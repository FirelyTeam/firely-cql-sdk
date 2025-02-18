/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Hl7.Cql.Runtime.Logging;

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

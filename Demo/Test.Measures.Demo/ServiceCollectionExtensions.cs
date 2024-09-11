using System;
using System.Threading;
using Hl7.Cql.CodeGeneration.NET.Hosting;
using Hl7.Cql.Compiler.Hosting;
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
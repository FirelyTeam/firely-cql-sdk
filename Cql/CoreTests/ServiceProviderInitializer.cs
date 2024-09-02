using Hl7.Cql.CodeGeneration.NET.DependencyInjection;
using Hl7.Cql.Compiler.DependencyInjection;
using Hl7.Cql.Packaging.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace CoreTests;

internal static class ServiceProviderInitializer
{
    public static CqlCompilerServices CreateCqlCompilerServiceProvider()
    {
        var services = new ServiceCollection()
                       .AddLogging(loggingBuilder =>
                       {
                           loggingBuilder.ClearProviders();
                           loggingBuilder.AddDebug();
                       })
                       .AddCqlCompilerServices();
        return services.BuildServiceProvider().GetCqlCompilerServices();
    }

    public static CqlCodeGenerationServices CreateCqlCodeGenerationServices()
    {
        var services = new ServiceCollection()
                       .AddLogging(loggingBuilder =>
                       {
                           loggingBuilder.ClearProviders();
                           loggingBuilder.AddDebug();
                       })
                       .AddCqlCodeGenerationServices();
        return services.BuildServiceProvider().GetCqlCodeGenerationServices();
    }

    public static CqlPackagerServices CreateCqlPackagerServiceProvider()
    {
        var services = new ServiceCollection()
                       .AddLogging(loggingBuilder =>
                       {
                           loggingBuilder.ClearProviders();
                           loggingBuilder.AddDebug();
                       })
                       .AddCqlPackagerServices();
        return services.BuildServiceProvider().GetCqlPackagerServices();
    }
}
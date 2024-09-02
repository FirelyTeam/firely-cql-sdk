using Hl7.Cql.Compiler.DependencyInjection;
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
}
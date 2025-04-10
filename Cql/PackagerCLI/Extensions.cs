namespace Hl7.Cql.Packager;

internal static class Extensions
{
    public static int RunProgram<TProgram>(this IHostBuilder hostBuilder)
        where TProgram : class, IProgram
    {
        hostBuilder.ConfigureServices((_, services) => services.AddScoped<IProgram, TProgram>());
        using var host = hostBuilder.Build();
        var rootServices = host.Services;
        var hostApplicationLifetime = rootServices.GetRequiredService<IHostApplicationLifetime>();
        try
        {
            using IServiceScope scope = rootServices.CreateScope();
            var scopedServices = scope.ServiceProvider;
            var packagerCliProgram = scopedServices.GetRequiredService<IProgram>();
            var result = packagerCliProgram.Run();
            return result;
        }
        catch (Exception e)
        {
            var console = rootServices.GetService<IConsole>();
            var logger = rootServices.GetService<ILogger<Program>>();
            logger?.LogError(e, "An error occurred while running PackagerCLI.");
            console?.Error.WriteLine("An error occurred while running PackagerCLI. Consult the build.log file for more detail.");
            return -1;
        }
        finally
        {
            var hostLifetime = hostApplicationLifetime;
            hostLifetime.StopApplication();
        }
    }
}
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using System.Globalization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Serilog;

namespace Hl7.Cql.Packager;

public class Program
{
    public static int Main(string[] args)
    {
        if (args.Length == 0 ||
            new[] { "-?", "-h", "-help" }.Any(s => args.Contains(s, StringComparer.InvariantCultureIgnoreCase)))
        {
            ShowHelp();
            return -1;
        }

        var hostBuilder = Host.CreateDefaultBuilder()
            .ConfigureAppConfiguration(ConfigureConfiguration(args))
            .ConfigureLogging(ConfigureLogging)
            .ConfigureServices(ConfigureServices);

        return Run(hostBuilder);
    }

    static Action<HostBuilderContext, IConfigurationBuilder> ConfigureConfiguration(string[] args) =>
        (hostContext, config) =>
        {
            IDictionary<string, string> switchMappings = PackagerOptions.BuildSwitchMappings();
            config.AddCommandLine(args, switchMappings);
        };

    static void ConfigureLogging(HostBuilderContext hostContext, ILoggingBuilder logging)
    {
        logging.AddFilter(level => level >= LogLevel.Trace);
        logging.AddConsole(console =>
        {
            console.LogToStandardErrorThreshold = LogLevel.Error;
        });
        var logFile = Path.Combine(".", "build.txt");
        Log.Logger = new LoggerConfiguration()
            .Enrich.FromLogContext()
            .WriteTo
            .File(logFile, formatProvider: CultureInfo.InvariantCulture)
            .CreateLogger();
        logging.AddSerilog();
    }

    static void ConfigureServices(HostBuilderContext hostContext, IServiceCollection services)
    {
        services.AddPackagerServices();
        services.AddResourcePackager();
    }

    private static int Run(IHostBuilder hostBuilder)
    {
        IHost host;
        try
        {
            host = hostBuilder.Build();
        }
        catch (OptionsValidationException e) when (e.OptionsType == typeof(PackagerOptions))
        {
            foreach (var failure in e.Failures)
            {
                Console.Error.WriteLine(failure);
            }

            ShowHelp();
            return -1;
        }


        using var _ = host;
        using var mainScope = host.Services.CreateScope();
        var programLogger = mainScope.ServiceProvider.GetRequiredService<ILogger<Program>>();
        var packageService = mainScope.ServiceProvider.GetRequiredService<PackagerService>();
        try
        {
            return packageService.Run();
        }
        catch (Exception e)
        {
            programLogger.LogError(e, "An error occurred while running the packager");
            Console.Error.WriteLine("An error occurred while running PackagerCLI. Consult the log for more detail.");
            return -1;
        }
    }

    private static void ShowHelp()
    {
        Console.WriteLine(PackagerOptions.Usage);
    }
}
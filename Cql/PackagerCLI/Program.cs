#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using System.Globalization;
using Hl7.Cql.Packaging.ResourceWriters;
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
            .ConfigureAppConfiguration((context, config) => ConfigureAppConfiguration(config, args))
            .ConfigureLogging((context, logging) => ConfigureLogging(logging))
            .ConfigureServices((context, services) => ConfigureServices(context, services));

        return Run(hostBuilder);
    }

    private static IDictionary<string, string> BuildSwitchMappings()
    {
        const string PackageSection = PackagerOptions.ConfigSection + ":";
        const string FhirResourceWriterSection = FhirResourceWriterOptions.ConfigSection + ":";

        return new SortedDictionary<string, string>
        {
            // @formatter:off
            [PackagerOptions.ArgNameElmDirectory]     = PackageSection + nameof(PackagerOptions.ElmDirectory),
            [PackagerOptions.ArgNameCqlDirectory]     = PackageSection + nameof(PackagerOptions.CqlDirectory),
            [PackagerOptions.ArgNameCSharpDirectory]  = PackageSection + nameof(PackagerOptions.CSharpDirectory),
            [PackagerOptions.ArgNameDebug]            = PackageSection + nameof(PackagerOptions.Debug),
            [PackagerOptions.ArgNameForce]            = PackageSection + nameof(PackagerOptions.Force),
            [PackagerOptions.ArgNameCanonicalRootUrl] = PackageSection + nameof(PackagerOptions.CanonicalRootUrl),

            [FhirResourceWriterOptions.ArgNameOutDirectory] = FhirResourceWriterSection + nameof(FhirResourceWriterOptions.OutDirectory),
            [FhirResourceWriterOptions.ArgNameOverrideDate] = FhirResourceWriterSection + nameof(FhirResourceWriterOptions.OverrideDate),
            // @formatter:on
        };
    }

    public const string Usage =
        """
        Packager CLI Usage:
        
            -?|-h|-help                     Show this help
        
            --elm       <directory>         Library root directory
            --cql       <directory>         CQL root directory
            [--fhir]    <file|directory>    Resource location, either file name or directory
            [--cs]      <file|directory>    C# output location, either file name or directory
            [--d]       <true|false>        Produce as a debug assembly
            [--f]       <true|false>        Force an overwrite even if the output file already exists
            [--canonical-root-url]          The root url used for the resource canonical.
                        <url>               If omitted a '#' will be used
            [--override-utc-date-time]      The date time to use for the library and resource last updated.
                        <utc-date-time>     If omitted the current date time will be used.
                                            (example: 2000-12-31T23:59:59.99Z)
        """;


    private static void ConfigureAppConfiguration(IConfigurationBuilder config, string[] args)
    {
        IDictionary<string, string> switchMappings = BuildSwitchMappings();
        config.AddCommandLine(args, switchMappings);
    }

    private static void ConfigureLogging(ILoggingBuilder logging)
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

    private static void ConfigureServices(HostBuilderContext context, IServiceCollection services)
    {
        services.AddPackagerServices(context.Configuration);
        services.AddResourcePackager(context.Configuration);
    }

    private static int Run(IHostBuilder hostBuilder)
    {
        using var host = CreateHost(hostBuilder);
        if (host is null)
        {
            ShowHelp();
            return -1;
        }

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

    private static IHost? CreateHost(IHostBuilder hostBuilder)
    {
        try
        {
            return hostBuilder.Build();
        }
        catch (OptionsValidationException e) when (e.OptionsType == typeof(PackagerOptions))
        {
            foreach (var failure in e.Failures)
            {
                Console.Error.WriteLine(failure);
            }

            ShowHelp();
            return null;
        }
    }

    private static void ShowHelp()
    {
        Console.WriteLine(Usage);
    }
}
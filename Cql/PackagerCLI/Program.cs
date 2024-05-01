#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using System.Diagnostics;
using System.Globalization;
using Hl7.Cql.Abstractions.Exceptions;
using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Packager.Logging;
using Hl7.Cql.Packaging;
using Hl7.Cql.Packaging.PostProcessors;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Serilog;
using Serilog.Events;

namespace Hl7.Cql.Packager;

public class Program
{
    public static int Main(string[] args)
    {
#if DEBUG // Latest Visual Studio can't handle the $(SolutionDir) args in the launchSettings!!
        var dir = new DirectoryInfo(Environment.CurrentDirectory);
        while (!File.Exists(Path.Combine(dir!.FullName, "CqlAndDemo.sln")))
            dir = dir.Parent;

        args = args.SelectToArray(arg =>
        {
            var path = arg.StartsWith('/') ? Path.Combine(dir.FullName, arg[1..]) : arg;
            return path;
        });
#endif

        if (args.Length == 0 ||
            new[] { "-?", "-h", "-help" }.Any(s => args.Contains(s, StringComparer.InvariantCultureIgnoreCase)))
        {
            ShowHelp();
            return -1;
        }

        var hostBuilder = CreateHostBuilder(args);

        return Run(hostBuilder);
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder()
            .ConfigureAppConfiguration((context, config) => ConfigureAppConfiguration(config, args))
            .ConfigureLogging((context, logging) => ConfigureLogging(logging))
            .ConfigureServices((context, services) => ConfigureServices(context, services));

    private static IDictionary<string, string> BuildSwitchMappings()
    {
        const string PackageSection = CqlToResourcePackagingOptions.ConfigSection + ":";
        const string CSharpResourceWriterSection = CSharpCodeWriterOptions.ConfigSection + ":";
        const string FhirResourceWriterSection = FhirResourceWriterOptions.ConfigSection + ":";

        return new SortedDictionary<string, string>
        {
            // @formatter:off
            [CqlToResourcePackagingOptions.ArgNameElmDirectory]     = PackageSection + nameof(CqlToResourcePackagingOptions.ElmDirectory),
            [CqlToResourcePackagingOptions.ArgNameCqlDirectory]     = PackageSection + nameof(CqlToResourcePackagingOptions.CqlDirectory),
            [CqlToResourcePackagingOptions.ArgNameDebug]            = PackageSection + nameof(CqlToResourcePackagingOptions.Debug),
            [CqlToResourcePackagingOptions.ArgNameForce]            = PackageSection + nameof(CqlToResourcePackagingOptions.Force),
            [CqlToResourcePackagingOptions.ArgNameCanonicalRootUrl] = PackageSection + nameof(CqlToResourcePackagingOptions.CanonicalRootUrl),

            [CSharpCodeWriterOptions.ArgNameOutDirectory]           = CSharpResourceWriterSection + nameof(CSharpCodeWriterOptions.OutDirectory),
            [CSharpCodeWriterOptions.ArgNameTypeFormat]             = CSharpResourceWriterSection + nameof(CSharpCodeWriterOptions.TypeFormat),

            [FhirResourceWriterOptions.ArgNameOutDirectory]         = FhirResourceWriterSection + nameof(FhirResourceWriterOptions.OutDirectory),
            [FhirResourceWriterOptions.ArgNameOverrideDate]         = FhirResourceWriterSection + nameof(FhirResourceWriterOptions.OverrideDate),
            // @formatter:on
        };
    }

    private static string Usage { get; }

    static Program()
    {
        Usage = $"""
                 Packager CLI Usage:

                     {"-?|-h|-help", -26} Show this help

                     {CqlToResourcePackagingOptions.ArgNameElmDirectory,-26} {"<directory>", -19} Library root directory
                     {CqlToResourcePackagingOptions.ArgNameCqlDirectory,-26} {"<directory>", -19} CQL root directory
                     {Optional(FhirResourceWriterOptions.ArgNameOutDirectory),-26} {"<file|directory>", -19} Resource location, either file name or directory
                     {Optional(CSharpCodeWriterOptions.ArgNameOutDirectory),-26} {"<file|directory>",-19} C# output location, either file name or directory
                     {Optional(CSharpCodeWriterOptions.ArgNameTypeFormat),-26} {"<var|explicit>",-19} Whether to use var or explicit types in the C# output
                     {Optional(CqlToResourcePackagingOptions.ArgNameDebug),-26} {"<true|false>",-19} Produce as a debug assembly
                     {Optional(CqlToResourcePackagingOptions.ArgNameForce),-26} {"<true|false>",-19} Force an overwrite even if the output file already exists
                     {Optional(CqlToResourcePackagingOptions.ArgNameCanonicalRootUrl),-26} {"<url>",-19} The root url used for the resource canonical.
                     {"", -26-19-1} If omitted a '#' will be used.
                     {Optional(FhirResourceWriterOptions.ArgNameOverrideDate),-26} {"<ISO8601-date-time>",-19} The UTC date to override in the generated FHIR resource libraries.
                     {"", -26-19-1} (example: 2000-12-31T23:59:59.99Z)
                     {"", -26-19-1} If omitted the current date time will be used.
                 """;
        static string Optional(string s) => $"[{s}]";
    }


    private static void ConfigureAppConfiguration(IConfigurationBuilder config, string[] args)
    {
        IDictionary<string, string> switchMappings = BuildSwitchMappings();
        config.AddCommandLine(args, switchMappings);
    }

    private static void ConfigureLogging(ILoggingBuilder logging)
    {
        logging.ClearProviders();

        var minLogLevel = Debugger.IsAttached ? LogLevel.Trace : LogLevel.Information;// TODO: We should base this on the configuration for the 'Debug' flag

        logging.AddFilter(level => level >= minLogLevel);

        logging.AddCleanConsole(opt =>
        {
            // opt.NoColor = true;
        });

        var logFile = Path.Combine(".", "build.log");
        File.Delete(logFile);
        Log.Logger = new LoggerConfiguration()
            .Enrich.FromLogContext()
            .MinimumLevel.Is(MapToSeriLogLogEventLevel(minLogLevel)!.Value)
            .WriteTo.File(
                logFile,
                outputTemplate: "____{NewLine}{Level:u4}: {Message:lj}{NewLine}{Exception}",
                formatProvider: CultureInfo.InvariantCulture)
            .CreateLogger();
        logging.AddSerilog();
    }

    private static LogEventLevel? MapToSeriLogLogEventLevel(LogLevel logLevel) =>
        logLevel switch
        {
            // @formatter: off
            /* 0 */ LogLevel.Trace       => /* 0 */ LogEventLevel.Verbose,
            /* 1 */ LogLevel.Debug       => /* 1 */ LogEventLevel.Debug,
            /* 2 */ LogLevel.Information => /* 2 */ LogEventLevel.Information,
            /* 3 */ LogLevel.Warning     => /* 3 */ LogEventLevel.Warning,
            /* 4 */ LogLevel.Error       => /* 4 */ LogEventLevel.Error,
            /* 5 */ LogLevel.Critical    => /* 5 */ LogEventLevel.Fatal,
            /* 6 */ LogLevel.None        => /* n/a */ null,
            // @formatter: on
            _ => throw new UnsupportedSwitchCaseError(logLevel, typeof(LogLevel).FullName).ToException(),
        };

    public static void ConfigureServices(HostBuilderContext context, IServiceCollection services)
    {
        TryAddPackagerOptions(services, context.Configuration);
        services.AddSingleton<IValidateOptions<CqlToResourcePackagingOptions>, CqlToResourcePackagingOptions.Validator>();
        services.AddSingleton<ProgramCqlPackagerFactory>();
        services.AddSingleton<PackagerCliProgram>();
        services.TryAddSingleton<OptionsConsoleDumper>();
    }

    private static void TryAddPackagerOptions(IServiceCollection services, IConfiguration config)
    {
        if (services.Any(s => s.ServiceType == typeof(IValidateOptions<CqlToResourcePackagingOptions>)))
            return;

        services
            .AddOptions<CqlToResourcePackagingOptions>()
            .Configure<IConfiguration>(CqlToResourcePackagingOptions.BindConfig)
            .ValidateOnStart();

        services
            .AddOptions<FhirResourceWriterOptions>()
            .Configure<IConfiguration>(FhirResourceWriterOptions.BindConfig)
            .ValidateOnStart();

        services
            .AddOptions<CSharpCodeWriterOptions>()
            .Configure<IConfiguration>(CSharpCodeWriterOptions.BindConfig)
            .ValidateOnStart();
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
        var packageService = mainScope.ServiceProvider.GetRequiredService<PackagerCliProgram>();
        return packageService.Run();
    }

    private static IHost? CreateHost(IHostBuilder hostBuilder)
    {
        try
        {
            return hostBuilder.Build();
        }
        catch (OptionsValidationException e) when (e.OptionsType == typeof(CqlToResourcePackagingOptions))
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
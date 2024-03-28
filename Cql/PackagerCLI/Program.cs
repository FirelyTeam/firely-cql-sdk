#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using System.Collections.Concurrent;
using System.Globalization;
using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Compiler;
using Hl7.Cql.Packaging;
using Hl7.Cql.Packaging.PostProcessors;
using Hl7.Fhir.Model;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.Extensions.Logging.Console;
using Microsoft.Extensions.Options;
using Serilog;
using ILogger = Microsoft.Extensions.Logging.ILogger;

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
            [CqlToResourcePackagingOptions.ArgNameElmDirectory]             = PackageSection + nameof(CqlToResourcePackagingOptions.ElmDirectory),
            [CqlToResourcePackagingOptions.ArgNameCqlDirectory]             = PackageSection + nameof(CqlToResourcePackagingOptions.CqlDirectory),
            [CqlToResourcePackagingOptions.ArgNameDebug]                    = PackageSection + nameof(CqlToResourcePackagingOptions.Debug),
            [CqlToResourcePackagingOptions.ArgNameForce]                    = PackageSection + nameof(CqlToResourcePackagingOptions.Force),
            [CqlToResourcePackagingOptions.ArgNameCanonicalRootUrl]         = PackageSection + nameof(CqlToResourcePackagingOptions.CanonicalRootUrl),

            [CSharpCodeWriterOptions.ArgNameOutDirectory] = CSharpResourceWriterSection + nameof(CSharpCodeWriterOptions.OutDirectory),

            [FhirResourceWriterOptions.ArgNameOutDirectory]   = FhirResourceWriterSection + nameof(FhirResourceWriterOptions.OutDirectory),
            // @formatter:on
        };
    }

    private const string Usage =
        """
        Packager CLI Usage:

            -?|-h|-help                                Show this help

            --elm                  <directory>         Library root directory
            --cql                  <directory>         CQL root directory
            [--fhir]               <file|directory>    Resource location, either file name or directory
            [--cs]                 <file|directory>    C# output location, either file name or directory
            [--d]                  <true|false>        Produce as a debug assembly
            [--f]                  <true|false>        Force an overwrite even if the output file already exists
            [--canonical-root-url] <url>               The root url used for the resource canonical.
                                                       If omitted a '#' will be used.
            [--fhir-override-date] <ISO8601-date-time> The UTC date to override in the generated FHIR resource libraries.
                                                       (example: 2000-12-31T23:59:59.99Z)
                                                       If omitted the current date time will be used.
        """;


    private static void ConfigureAppConfiguration(IConfigurationBuilder config, string[] args)
    {
        IDictionary<string, string> switchMappings = BuildSwitchMappings();
        config.AddCommandLine(args, switchMappings);
    }

    private static void ConfigureLogging(ILoggingBuilder logging)
    {
        logging.ClearProviders();

        logging.AddFilter(level => level >= LogLevel.Trace);
        logging
        .AddConsole(opt =>
        {
            opt.FormatterName = "NoCategory";
        })
        .AddConsoleFormatter<NoCategoryConsoleFormatterDecorator, SimpleConsoleFormatterOptions>(opt =>
        {
        });

        var logFile = Path.Combine(".", "build.log");
        Log.Logger = new LoggerConfiguration()
            .Enrich.FromLogContext()
            .WriteTo
            .File(logFile, formatProvider: CultureInfo.InvariantCulture)
            .CreateLogger();
        logging.AddSerilog();
    }

    public static void ConfigureServices(HostBuilderContext context, IServiceCollection services)
    {
        services.AddPackagerServices(context.Configuration);
        services.TryAddResourceWriters(context.Configuration);
        services.TryAddTypeServices();
        services.TryAddCompilationServices();
        services.TryAddBuilders();
        services.TryAddSingleton<OptionsConsoleDumper>();
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

file sealed class NoCategoryConsoleFormatterDecorator : ConsoleFormatter
{
    public NoCategoryConsoleFormatterDecorator(
        IOptionsMonitor<SimpleConsoleFormatterOptions> options) : base("NoCategory")
    {
    }

    public override void Write<TState>(in LogEntry<TState> logEntry, IExternalScopeProvider? scopeProvider, TextWriter textWriter)
    {
        var message = logEntry.Formatter(logEntry.State, logEntry.Exception);
        var logLevelString = GetLogLevelString(logEntry.LogLevel);
        textWriter.WriteLine($"{GetForegroundColorEscapeCode(logLevelString.Item2)}{logLevelString.Item1}{DefaultForegroundColor} : {message}");
    }

    private static (string, ConsoleColor) GetLogLevelString(LogLevel logLevel) =>
        logLevel switch
        {
            LogLevel.Trace => ("trce", ConsoleColor.Gray),
            LogLevel.Debug => ("dbug", ConsoleColor.Gray),
            LogLevel.Information => ("info", ConsoleColor.White),
            LogLevel.Warning => ("warn", ConsoleColor.Yellow),
            LogLevel.Error => ("fail", ConsoleColor.Red),
            LogLevel.Critical => ("crit", ConsoleColor.Magenta),
            _ => throw new ArgumentOutOfRangeException(nameof(logLevel))
        };

    private static string GetForegroundColorEscapeCode(ConsoleColor color)
    {
        return color switch
        {
            ConsoleColor.Black => "\x1B[30m",
            ConsoleColor.DarkRed => "\x1B[31m",
            ConsoleColor.DarkGreen => "\x1B[32m",
            ConsoleColor.DarkYellow => "\x1B[33m",
            ConsoleColor.DarkBlue => "\x1B[34m",
            ConsoleColor.DarkMagenta => "\x1B[35m",
            ConsoleColor.DarkCyan => "\x1B[36m",
            ConsoleColor.Gray => "\x1B[37m",
            ConsoleColor.Red => "\x1B[1m\x1B[31m",
            ConsoleColor.Green => "\x1B[1m\x1B[32m",
            ConsoleColor.Yellow => "\x1B[1m\x1B[33m",
            ConsoleColor.Blue => "\x1B[1m\x1B[34m",
            ConsoleColor.Magenta => "\x1B[1m\x1B[35m",
            ConsoleColor.Cyan => "\x1B[1m\x1B[36m",
            ConsoleColor.White => "\x1B[1m\x1B[37m",
            _ => DefaultForegroundColor // default foreground color
        };
    }

    private const string DefaultForegroundColor = "\x1B[39m\x1B[22m"; // reset to default foreground color
}
/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using System.Diagnostics;
using System.Globalization;
using Hl7.Cql.Abstractions.Exceptions;
using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Packager.Hosting;
using Hl7.Cql.Packager.Logging;
using Hl7.Cql.Packaging;
using Hl7.Cql.Packaging.PostProcessors;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
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
        if (args.Length == 0 ||
            new[] { "-?", "-h", "-help" }.Any(s => args.Contains(s, StringComparer.InvariantCultureIgnoreCase)))
        {
            ShowHelp();
            return -1;
        }

        var hostBuilder = CreateHostBuilder(args);

        try
        {
            return Run(hostBuilder);
        }
        finally
        {
            Log.CloseAndFlush();
        }
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder()
            .ConfigureAppConfiguration((context, config) => config.ConfigurePackagerCliApp(args))
            .ConfigureLogging((context, logging) => ConfigureLogging(logging, context.Configuration))
            .ConfigureServices((context, services) =>
                                   services
                                       .ConfigurePackagerCliOptions(context.Configuration)
                                       .AddPackagerCliServices());

    private static string Usage { get; }

    static Program()
    {
        CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
        Usage = $"""
                 Packager CLI Usage:

                     {"-?|-h|-help",-26} Show this help

                     {CqlToResourcePackagingOptions.ArgNameElmDirectory,-26} {"<directory>",-19} Required: Library root directory
                     {CqlToResourcePackagingOptions.ArgNameCqlDirectory,-26} {"<directory>",-19} Required: CQL root directory
                     {Optional(FhirResourceWriterOptions.ArgNameOutDirectory),-26} {"<directory>",-19} Resource directory
                     {Optional(CSharpCodeWriterOptions.ArgNameOutDirectory),-26} {"<directory>",-19} C# output directory
                     {Optional(CSharpCodeWriterOptions.ArgNameTypeFormat),-26} {"<var|explicit>",-19} Whether to use var (default) or explicit types in the C# output
                     {Optional(AssemblyDataWriterOptions.ArgNameOutDirectory),-26}{"<directory>",-19} DLL output directory
                     {Optional(CqlToResourcePackagingOptions.ArgNameLogDebugEnabled),-26} {"<true|false>",-19} Enable debug logging or not (default)
                     {Optional(CqlToResourcePackagingOptions.ArgNameCanonicalRootUrl),-26} {"<url>",-19} The root url used for the resource canonical
                     {"",-26 - 19 - 1} If omitted a '#' will be used
                     {Optional(FhirResourceWriterOptions.ArgNameOverrideDate),-26} {"<ISO8601-date-time>",-19} The UTC date to override in the generated FHIR resource libraries
                     {"",-26 - 19 - 1} (example: 2000-12-31T23:59:59.99Z)
                     {"",-26 - 19 - 1} If omitted the current date time will be used
                 """;

        static string Optional(string s) => $"[{s}]";
    }

    public static void ConfigureLogging(
        ILoggingBuilder logging,
        IConfiguration configuration)
    {
        logging.ClearProviders();

        bool enableDebugLogging = Debugger.IsAttached;
        enableDebugLogging = enableDebugLogging || configuration.GetSwitchMappedValue<bool>(CqlToResourcePackagingOptions.ArgNameLogDebugEnabled);
        var minLogLevel = enableDebugLogging ? LogLevel.Trace : LogLevel.Information;

        bool shouldClearLog = !configuration.GetSwitchMappedValue<bool>(CqlToResourcePackagingOptions.ArgNameLogDontClear);

        logging.AddFilter(level => level >= minLogLevel);

        logging.AddCleanConsole(opt =>
        {
            // opt.NoColor = true;
        });

        var logFile = Path.Combine(".", "build.log");

        if (shouldClearLog)
            File.WriteAllText(logFile, ""); // Create or clear the log file
                                            //File.Delete(logFile);
        else
            File.OpenText(logFile).Close(); // Touch the file

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
            /* 0 */
            LogLevel.Trace => /* 0 */ LogEventLevel.Verbose,
            /* 1 */
            LogLevel.Debug => /* 1 */ LogEventLevel.Debug,
            /* 2 */
            LogLevel.Information => /* 2 */ LogEventLevel.Information,
            /* 3 */
            LogLevel.Warning => /* 3 */ LogEventLevel.Warning,
            /* 4 */
            LogLevel.Error => /* 4 */ LogEventLevel.Error,
            /* 5 */
            LogLevel.Critical => /* 5 */ LogEventLevel.Fatal,
            /* 6 */
            LogLevel.None => /* n/a */ null,
            // @formatter: on
            _ => throw new UnsupportedSwitchCaseError(logLevel, typeof(LogLevel).FullName).ToException(),
        };

    private static int Run(IHostBuilder hostBuilder)
    {
        using var host = CreateHost(hostBuilder);
        if (host is null)
        {
            ShowHelp();
            return -1;
        }

        using var mainScope = host.Services.CreateScope();
        var packageService = mainScope.ServiceProvider.GetPackagerCliServices().PackagerCliProgramScoped();
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
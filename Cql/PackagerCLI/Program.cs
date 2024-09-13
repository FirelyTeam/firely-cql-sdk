/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using System.Globalization;
using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Packager.DependencyInjection;
using Hl7.Cql.Packaging;
using Hl7.Cql.Packaging.PostProcessors;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
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
            .UseServiceProviderFactory(context =>
                                           new DefaultServiceProviderFactory(
                                               new ServiceProviderOptions()
                                               {
                                                   // Since we are using scopes,
                                                   // we need to validate that they are never used from the root provider,
                                                   // nor that they are included into singletons.
                                                   ValidateScopes = true
                                               }))
            .ConfigureAppConfiguration((context, config) => config.AddPackagerCliCommandLineSwitches(args))
            .ConfigureLogging((context, logging) => logging.AddPackagerCLiLogging(context.Configuration))
            .ConfigureServices((context, services) =>                                   services
                                       .AddPackagerCliOptions(context.Configuration)
                                       .AddPackagerCliServices())
            .UseConsoleLifetime()
            ;

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

    private static int Run(IHostBuilder hostBuilder)
    {
        using var host = CreateHost(hostBuilder);
        if (host is null)
        {
            ShowHelp();
            return -1;
        }

        try
        {
            using IServiceScope mainScope = host.Services.CreateScope();
            var packagerCliProgram = mainScope.ServiceProvider.PackagerCliProgramScoped();
            return packagerCliProgram.Run();
        }
        finally
        {
            var hostLifetime = host.Services.GetRequiredService<IHostApplicationLifetime>();
            hostLifetime.StopApplication();
        }
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
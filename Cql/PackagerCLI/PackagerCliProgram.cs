/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */
using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Packaging;
using Hl7.Cql.Packaging.PostProcessors;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Hl7.Cql.Packager;

internal class PackagerCliProgram
{
    private readonly OptionsConsoleDumper _optionsConsoleDumper;
    private readonly IHostApplicationLifetime _hostLifetime;
    private readonly ILogger<PackagerCliProgram> _logger;
    private readonly CqlToResourcePackagingPipeline _pipeline;


    public PackagerCliProgram(
        ILogger<PackagerCliProgram> logger,
        OptionsConsoleDumper optionsConsoleDumper,
        ProgramCqlPackagerFactory packagerCliFactory,
        IHostApplicationLifetime hostLifetime)
    {
        _logger = logger;
        _optionsConsoleDumper = optionsConsoleDumper;
        _hostLifetime = hostLifetime;
        _pipeline = packagerCliFactory.CqlToResourcePackagingPipeline;
    }

    public int Run()
    {
        try
        {
            _optionsConsoleDumper.DumpToConsole();
            _pipeline.ProcessCqlToResources();
            return 0;
        }
        catch (Exception e)
        {
            _logger.LogError(e, "An error occurred while running the packager");
            Console.Error.WriteLine(
                "An error occurred while running PackagerCLI. Consult the build.log file for more detail.");
            return -1;
        }
        finally
        {
            _hostLifetime.StopApplication();
        }
    }
}



internal class ProgramCqlPackagerFactory(
    ILoggerFactory loggerFactory,
    IHostApplicationLifetime hostLifetime,
    IOptions<CqlToResourcePackagingOptions> cqlToResourcePackagingOptions,
    IOptions<CSharpCodeWriterOptions> cSharpCodeWriterOptions,
    IOptions<FhirResourceWriterOptions> fhirResourceWriterOptions,
    IOptions<AssemblyDataWriterOptions> assemblyDataWriterOptions)
    : CqlPackagerFactory(loggerFactory,
                         cacheSize: 0,
                         cqlToResourcePackagingOptions: cqlToResourcePackagingOptions.Value,
                         cSharpCodeWriterOptions: cSharpCodeWriterOptions.Value,
                         fhirResourceWriterOptions: fhirResourceWriterOptions.Value,
                         assemblyDataWriterOptions: assemblyDataWriterOptions.Value,
                         cancellationToken: hostLifetime.ApplicationStopping);
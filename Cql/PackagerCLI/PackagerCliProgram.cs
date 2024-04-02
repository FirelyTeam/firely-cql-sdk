using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Packaging;
using Hl7.Cql.Packaging.PostProcessors;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Hl7.Cql.Packager;

internal class PackagerCliProgram
{
    private readonly OptionsConsoleDumper _optionsConsoleDumper;
    private readonly ILogger<PackagerCliProgram> _logger;
    private readonly ProgramCqlPackagerFactory _packagerCliFactory;
    private readonly CqlToResourcePackagingPipeline _pipeline;

    public PackagerCliProgram(
        ILogger<PackagerCliProgram> logger,
        OptionsConsoleDumper optionsConsoleDumper,
        ProgramCqlPackagerFactory packagerCliFactory
        )
    {
        _logger = logger;
        _optionsConsoleDumper = optionsConsoleDumper;
        _pipeline = packagerCliFactory.CqlToResourcePackagingPipeline;
        _packagerCliFactory = packagerCliFactory;
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
            Console.Error.WriteLine("An error occurred while running PackagerCLI. Consult the build.log file for more detail.");
            return -1;
        }
    }
}



internal class ProgramCqlPackagerFactory : CqlPackagerFactory
{
    public ProgramCqlPackagerFactory(
        ILoggerFactory loggerFactory,
        IOptions<CqlToResourcePackagingOptions> cqlToResourcePackagingOptions,
        IOptions<CSharpCodeWriterOptions> cSharpCodeWriterOptions,
        IOptions<FhirResourceWriterOptions> fhirResourceWriterOptions) : base(loggerFactory, 0, cqlToResourcePackagingOptions.Value, cSharpCodeWriterOptions.Value, fhirResourceWriterOptions.Value)
    {
    }
}
using Hl7.Cql.Packaging;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Hl7.Cql.Packager;

internal class PackagerCliProgram
{
    private readonly OptionsConsoleDumper _optionsConsoleDumper;
    private readonly ILogger<PackagerCliProgram> _logger;
    private readonly CqlToResourcePackagingPipeline _pipeline;

    public PackagerCliProgram(
        ILogger<PackagerCliProgram> logger,
        IOptions<CqlToResourcePackagingOptions > options,
        OptionsConsoleDumper optionsConsoleDumper,
        CqlToResourcePackagingPipeline pipeline)
    {
        _logger = logger;
        _optionsConsoleDumper = optionsConsoleDumper;
        _pipeline = pipeline;
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
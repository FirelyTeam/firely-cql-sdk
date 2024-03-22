using Hl7.Cql.Packaging;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Hl7.Cql.Packager;

internal class PackagerCliProgram
{
    private readonly OptionsConsoleDumper _optionsConsoleDumper;
    private readonly PackagerOptions _packagerOptions;
    private readonly ILogger<PackagerCliProgram> _logger;
    private readonly ResourcePackager _resourcePackager;

    public PackagerCliProgram(
        ILogger<PackagerCliProgram> logger,
        IOptions<PackagerOptions> packageArgsOptions,
        OptionsConsoleDumper optionsConsoleDumper,
        ResourcePackager resourcePackager)
    {
        _logger = logger;
        _optionsConsoleDumper = optionsConsoleDumper;
        _resourcePackager = resourcePackager;
        _packagerOptions = packageArgsOptions.Value;
    }

    public int Run()
    {
        try
        {
            return RunCore();
        }
        catch (Exception e)
        {
            _logger.LogError(e, "An error occurred while running the packager");
            Console.Error.WriteLine("An error occurred while running PackagerCLI. Consult the build.log file for more detail.");
            return -1;
        }
    }

    private int RunCore()
    {
        _optionsConsoleDumper.DumpToConsole();
        var opt = _packagerOptions;
        _resourcePackager.PackageResources(opt.ElmDirectory, opt.CqlDirectory, opt.CanonicalRootUrl?.ToString());
        return 0;
    }
}
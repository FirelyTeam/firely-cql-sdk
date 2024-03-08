using Hl7.Cql.Packaging;
using Hl7.Cql.Packaging.ResourceWriters;
using Hl7.Fhir.Model;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Hl7.Cql.Packager;

internal class PackagerCliProgram
{
    private readonly OptionsConsoleDumper _optionsConsoleDumper;
    private readonly PackagerOptions _packagerOptions;
    private readonly ResourceWriter[] _resourceWriters;
    private readonly ILogger<PackagerCliProgram> _logger;
    private readonly LibraryPackager _libraryPackager;

    public PackagerCliProgram(
        ILogger<PackagerCliProgram> logger,
        IOptions<PackagerOptions> packageArgsOptions,
        IEnumerable<ResourceWriter> resourceWriters,
        LibraryPackager libraryPackager, 
        OptionsConsoleDumper optionsConsoleDumper)
    {
        _logger = logger;
        _libraryPackager = libraryPackager;
        _optionsConsoleDumper = optionsConsoleDumper;
        _packagerOptions = packageArgsOptions.Value;
        _resourceWriters = resourceWriters.ToArray();
    }

    public int Run()
    {
        return RunCore();
        
        // try
        // {
        //     return RunCore();
        // }
        // catch (Exception e)
        // {
        //     _logger.LogError(e, "An error occurred while running the packager");
        //     Console.Error.WriteLine("An error occurred while running PackagerCLI. Consult the build.log file for more detail.");
        //     return -1;
        // }
    }

    private int RunCore()
    {
        _optionsConsoleDumper.DumpToConsole();

        if (_resourceWriters.Length == 0) return 0; //Skip since no writers provided

        var opt = _packagerOptions;
        var librariesByNameAndVersion = LibraryLoader.LoadLibraries(opt.ElmDirectory!);
        var directedGraph = Elm.LibraryExtensions.GetIncludedLibraries(librariesByNameAndVersion.Values);
        HashSet<Resource> resourcesWritten = new();
        var resources = _libraryPackager.PackageResources(
            opt.ElmDirectory!,
            opt.CqlDirectory!,
            directedGraph,
            new (
                buildUrlFromResource: resource => resource.CanonicalUri(opt.CanonicalRootUrl?.ToString()),
                onLibraryResourceCreated: library =>
                {
                    foreach (var resourceWriter in _resourceWriters)
                    {
                        resourceWriter.WriteResource(library);
                        resourcesWritten.Add(library);
                    }
                }))!;

        var remainingResources = resources.Except(resourcesWritten).ToList();
        if (remainingResources.Any())
        {
            foreach (var resourceWriter in _resourceWriters)
            {
                resourceWriter.WriteResources(remainingResources);
            }
        }

        return 0;
    }
}
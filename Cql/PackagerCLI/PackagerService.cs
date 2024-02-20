using Hl7.Cql.Packaging;
using Hl7.Cql.Packaging.ResourceWriters;
using Hl7.Fhir.Model;
using Microsoft.Extensions.Options;

namespace Hl7.Cql.Packager;

internal class PackagerService
{
    private readonly PackagerOptions _packagerOptions;
    private readonly ResourceWriter[] _resourceWriters;
    private readonly LibraryPackagerService _libraryPackager;

    public PackagerService(
        IOptions<PackagerOptions> packageArgsOptions,
        IEnumerable<ResourceWriter> resourceWriters,
        LibraryPackagerService libraryPackager)
    {
        _libraryPackager = libraryPackager;
        _packagerOptions = packageArgsOptions.Value;
        _resourceWriters = resourceWriters.ToArray();
    }

    public int Package()
    {
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
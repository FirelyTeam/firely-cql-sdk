using Hl7.Cql.Compiler;
using Hl7.Cql.Fhir;
using Hl7.Cql.Packaging;
using Hl7.Cql.Packaging.ResourceWriters;
using Hl7.Fhir.Model;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Library = Hl7.Cql.Elm.Library;

namespace Hl7.Cql.Packager;

internal class PackagerService
{
    private readonly ILoggerFactory _loggerFactory;
    private readonly PackagerOptions _packagerOptions;
    private readonly ResourceWriter[] _resourceWriters;

    public PackagerService(
        ILoggerFactory loggerFactory,
        IEnumerable<ResourceWriter> resourceWriters,
        IOptions<PackagerOptions> packageArgsOptions)
    {
        _loggerFactory = loggerFactory;
        _packagerOptions = packageArgsOptions.Value;
        _resourceWriters = resourceWriters.ToArray();
    }

    public int Package()
    {
        if (_resourceWriters.Length == 0) return 0; //Skip since no writers provided

        var opt = _packagerOptions;
        var librariesByNameAndVersion = LibraryPackager.LoadLibraries(opt.ElmDirectory!);
        var directedGraph = Elm.LibraryExtensions.GetIncludedLibraries(librariesByNameAndVersion.Values);
        var modelInspector = ModelInfo.ModelInspector;
        var fhirTypeResolver = new FhirTypeResolver(modelInspector);
        var libraryPackager = new LibraryPackager();
        var fhirTypeConverter = FhirTypeConverter.Create(modelInspector);
        var cqlOperatorsBinding = new CqlOperatorsBinding(fhirTypeResolver, fhirTypeConverter);
        var typeManager = new TypeManager(fhirTypeResolver);
        HashSet<Resource> resourcesWritten = new();
        var resources = LibraryPackager.PackageResources(libraryPackager, opt.ElmDirectory!,
            opt.CqlDirectory!,
            directedGraph,
            fhirTypeResolver,
            cqlOperatorsBinding,
            typeManager,
            _loggerFactory,
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
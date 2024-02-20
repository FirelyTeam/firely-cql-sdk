using Hl7.Cql.Abstractions;
using Hl7.Cql.Compiler;
using Hl7.Cql.Fhir;
using Hl7.Cql.Packaging;
using Hl7.Cql.Packaging.ResourceWriters;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Model;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Library = Hl7.Cql.Elm.Library;

namespace Hl7.Cql.Packager;

internal class PackagerService
{
    private readonly ILoggerFactory _loggerFactory;
    private readonly PackagerOptions _packagerOptions;
    private readonly ResourceWriter[] _resourceWriters;
    private readonly ModelInspector _modelInspector;
    private readonly OperatorBinding _operatorBinding;
    private readonly TypeResolver _fhirTypeResolver;
    private readonly TypeManager _typeManager;

    public PackagerService(
        ILoggerFactory loggerFactory,
        IEnumerable<ResourceWriter> resourceWriters,
        IOptions<PackagerOptions> packageArgsOptions, 
        ModelInspector modelInspector,
        [FromKeyedServices("Cql")] OperatorBinding operatorBinding,
        [FromKeyedServices("Fhir")] TypeResolver fhirTypeResolver,
        [FromKeyedServices("Fhir")] TypeManager typeManager)
    {
        _loggerFactory = loggerFactory;
        _modelInspector = modelInspector;
        _operatorBinding = operatorBinding;
        _fhirTypeResolver = fhirTypeResolver;
        _typeManager = typeManager;
        _packagerOptions = packageArgsOptions.Value;
        _resourceWriters = resourceWriters.ToArray();
    }

    public int Package()
    {
        if (_resourceWriters.Length == 0) return 0; //Skip since no writers provided

        var opt = _packagerOptions;
        var librariesByNameAndVersion = LibraryPackager.LoadLibraries(opt.ElmDirectory!);
        var directedGraph = Elm.LibraryExtensions.GetIncludedLibraries(librariesByNameAndVersion.Values);
        HashSet<Resource> resourcesWritten = new();
        var resources = LibraryPackager.PackageResources(opt.ElmDirectory!,
            opt.CqlDirectory!,
            directedGraph,
            _fhirTypeResolver,
            _operatorBinding,
            _typeManager,
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
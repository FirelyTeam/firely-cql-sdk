using Hl7.Cql.Compiler;
using Hl7.Cql.Fhir;
using Hl7.Cql.Packaging;
using Hl7.Cql.Packaging.ResourceWriters;
using Hl7.Fhir.Model;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

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
        var packages = LibraryPackager.LoadLibraries(opt.ElmDirectory!);
        var graph = Elm.LibraryExtensions.GetIncludedLibraries(packages.Values);
        var typeResolver = new FhirTypeResolver(ModelInfo.ModelInspector);
        var packager = new LibraryPackager();
        var resources = packager.PackageResources(
            opt.ElmDirectory!,
            opt.CqlDirectory!,
            graph,
            typeResolver,
            new CqlOperatorsBinding(typeResolver, FhirTypeConverter.Create(ModelInfo.ModelInspector)),
            new TypeManager(typeResolver),
            resource => resource.CanonicalUri(opt.CanonicalRootUrl?.ToString()),
            _loggerFactory)!;

        foreach (var writer in _resourceWriters) 
            writer.WriteResources(resources);

        return 0;
    }
}
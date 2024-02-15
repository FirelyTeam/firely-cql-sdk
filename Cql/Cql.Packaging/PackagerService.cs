using Hl7.Cql.Packaging;
using Hl7.Cql.Packaging.ResourceWriters;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Hl7.Cql.Packager;

internal class PackagerService
{
    private readonly ILoggerFactory _loggerFactory;
    private readonly PackagerOptions _packagerOptions;

    public PackagerService(
        ILoggerFactory loggerFactory,
        IOptions<PackagerOptions> packageArgsOptions)
    {
        _loggerFactory = loggerFactory;
        _packagerOptions = packageArgsOptions.Value;
    }

    public int Run()
    {
        var opt = _packagerOptions;
        var elmDir = opt.ElmDirectory!;
        var cqlDir = opt.CqlDirectory!;
        var fhirDir = opt.FhirDirectory;
        var csDir = opt.CSharpDirectory;
        var canonicalRootUrl = opt.CanonicalRootUrl;
        var logFactory = _loggerFactory;
        var cliLogger = _loggerFactory.CreateLogger("CLI");

        List<ResourceWriter> resourceWriters = new();
        if (fhirDir != null) resourceWriters.Add(new FhirResourceWriter(fhirDir, cliLogger));
        if (csDir != null) resourceWriters.Add(new CSharpResourceWriter(csDir, cliLogger));

        var resourcePackager = new ResourcePackager(logFactory, resourceWriters.ToArray());
        resourcePackager.Package(new PackageArgs(elmDir, cqlDir, resourceCanonicalRootUrl: canonicalRootUrl?.ToString()));
        return 0;
    }
}
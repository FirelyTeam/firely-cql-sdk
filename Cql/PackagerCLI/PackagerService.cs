using Hl7.Cql.Packaging;
using Microsoft.Extensions.Options;

namespace Hl7.Cql.Packager;

internal class PackagerService
{
    private readonly ResourcePackager _resourcePackager;
    private readonly PackagerOptions _packagerOptions;

    public PackagerService(
        ResourcePackager resourcePackager,
        IOptions<PackagerOptions> packageArgsOptions)
    {
        _resourcePackager = resourcePackager;
        _packagerOptions = packageArgsOptions.Value;
    }

    public int Run()
    {
        var opt = _packagerOptions;
        var elmDir = opt.ElmDirectory!;
        var cqlDir = opt.CqlDirectory!;
        var canonicalRootUrl = opt.CanonicalRootUrl;
        var packageArgs = new PackageArgs(elmDir, cqlDir, resourceCanonicalRootUrl: canonicalRootUrl?.ToString());
        _resourcePackager.Package(packageArgs);
        return 0;
    }
}
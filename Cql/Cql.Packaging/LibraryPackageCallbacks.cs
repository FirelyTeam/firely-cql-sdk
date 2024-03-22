using Hl7.Fhir.Model;

namespace Hl7.Cql.Packaging;

#pragma warning disable CS1591
internal readonly record struct LibraryPackageCallbacks
{
    public LibraryPackageCallbacks(
        Action<Resource>? afterPackageMutator = null,
        Func<Resource, string>? buildUrlFromResource = null)
    {
        _afterPackageMutator = afterPackageMutator;
        _buildUrlFromResource = buildUrlFromResource;
    }

    private readonly Action<Resource>? _afterPackageMutator;
    private readonly Func<Resource, string>? _buildUrlFromResource;

    public string BuildUrlFromResource(Resource resource) => 
        _buildUrlFromResource?.Invoke(resource) ?? "#";

    public void MutateResource(Resource resource) =>
        _afterPackageMutator?.Invoke(resource);
}
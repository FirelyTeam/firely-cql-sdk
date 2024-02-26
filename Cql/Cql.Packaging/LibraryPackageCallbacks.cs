using Hl7.Fhir.Model;

namespace Hl7.Cql.Packaging;

#pragma warning disable CS1591
internal readonly record struct LibraryPackageCallbacks
{
    public LibraryPackageCallbacks(
        Func<Resource, string>? buildUrlFromResource = null,
        Action<Library>? onLibraryResourceCreated = null)
    {
        _buildUrlFromResource = buildUrlFromResource;
        _onLibraryResourceCreated = onLibraryResourceCreated;
    }

    private readonly Func<Resource, string>? _buildUrlFromResource;
    private readonly Action<Library>? _onLibraryResourceCreated;

    public string BuildUrlFromResource(Resource resource) => 
        _buildUrlFromResource?.Invoke(resource) ?? "#";

    public void NotifyLibraryResourceCreated(Library library) => 
        _onLibraryResourceCreated?.Invoke(library);
}
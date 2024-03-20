using Hl7.Fhir.Model;

namespace Hl7.Cql.Packaging;

#pragma warning disable CS1591
internal readonly record struct LibraryPackageCallbacks
{
    public LibraryPackageCallbacks(
        Func<Resource, string>? buildUrlFromResource = null,
        Action<Resource>? onResourceCreated = null,
        Action<(string name, Stream stream, bool isTyple)>? onBeforeCompileStream = null,
        Action<IEnumerable<Resource>>? afterPackageMutator = null)
    {
        _onBeforeCompileStream = onBeforeCompileStream;
        _afterPackageMutator = afterPackageMutator;
        _buildUrlFromResource = buildUrlFromResource;
        _onResourceCreated = onResourceCreated;
    }

    private readonly Func<Resource, string>? _buildUrlFromResource;
    private readonly Action<Resource>? _onResourceCreated;
    private readonly Action<(string name, Stream stream, bool isTyple)>? _onBeforeCompileStream;
    private readonly Action<IEnumerable<Resource>>? _afterPackageMutator;

    public string BuildUrlFromResource(Resource resource) => 
        _buildUrlFromResource?.Invoke(resource) ?? "#";

    public void NotifyResourceCreated(Resource resource) => 
        _onResourceCreated?.Invoke(resource);

    public void OnBeforeCompileStream(string name, Stream stream, bool isTuple) =>
        _onBeforeCompileStream?.Invoke((name, stream, isTuple));

    public void OnAfterPackageMutate(IEnumerable<Resource> resources) =>
        _afterPackageMutator?.Invoke(resources);
}
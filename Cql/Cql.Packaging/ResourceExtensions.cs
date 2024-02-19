using Hl7.Fhir.Model;

namespace Hl7.Cql.Packaging;

internal static class ResourceExtensions
{
    public static string CanonicalUri(this Resource resource, string? resourceCanonicalRootUrl)
    {
        if (string.IsNullOrWhiteSpace(resource.Id))
            throw new ArgumentException("Resource must have an id", nameof(resource));
        var path = $"{resourceCanonicalRootUrl ?? "#"}/{resource.TypeName}/{resource.Id}";
        return path;
    }
}
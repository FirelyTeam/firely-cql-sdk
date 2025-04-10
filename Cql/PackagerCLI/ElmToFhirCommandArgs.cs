using Hl7.Cql.Packager.Options;

namespace Hl7.Cql.Packager;

internal record ElmToFhirCommandArgs(
    DirectoryInfo Cql,
    DirectoryInfo Elm,
    DirectoryInfo? Cs,
    DirectoryInfo? Dll,
    DirectoryInfo Fhir,
    bool? JsonPretty,
    DateTimeOffset? OverrideUtcDateTime,
    string? CanonicalRootUrl)
{

    public IEnumerable<KeyValuePair<string, string?>> MapToConfiguration()
    {
        if (CanonicalRootUrl is { } canonicalRootUrl)
            yield return KeyValuePair.Create($"{PackagingOptions.ConfigSection}:{nameof(PackagingOptions.CanonicalRootUrl)}", (string?)canonicalRootUrl);
        if (OverrideUtcDateTime is { } overrideDate)
            yield return KeyValuePair.Create($"{PackagingOptions.ConfigSection}:{nameof(PackagingOptions.OverrideDate)}", (string?)overrideDate.ToString("u"));
        if (JsonPretty is { } jsonPretty)
            yield return KeyValuePair.Create($"{PackagingOptions.ConfigSection}:{nameof(PackagingOptions.JsonPretty)}", (string?)JsonSerializer.Serialize(jsonPretty));
    }
}
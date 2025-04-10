namespace Hl7.Cql.Packager;

internal record LegacyCommandArgs(
    DirectoryInfo Cql,
    DirectoryInfo Elm,
    DirectoryInfo? Cs,
    DirectoryInfo? Dll,
    DirectoryInfo Fhir,
    bool? LogDebug,
    bool? LogAppend,
    bool? JsonPretty,
    DateTimeOffset? OverrideUtcDateTime,
    string? CanonicalRootUrl);
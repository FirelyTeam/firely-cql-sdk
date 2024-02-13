namespace Hl7.Cql.Packager;

#pragma warning disable CS1591
internal record PackageOptions
{
    public DirectoryInfo ElmDirectory { get; init; } = null!;
    public DirectoryInfo CqlDirectory { get; init; } = null!;
    public DirectoryInfo? CSharpDirectory { get; init; }
    public DirectoryInfo? FhirDirectory { get; init; }
    public bool Debug { get; init; }
    public bool Force { get; init; }
    public string? CanonicalRootUrl { get; init; }
    public DateTime? OverrideUtcDateTime { get; init; }

}
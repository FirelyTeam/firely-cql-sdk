namespace Hl7.Cql.Packager;

internal partial class PackagerOptions
{
    public const string ConfigSection = "Packager";

    public const string ArgNameElmDirectory = "--elm";
    public DirectoryInfo ElmDirectory { get; set; } = null!;

    public const string ArgNameCqlDirectory = "--cql";
    public DirectoryInfo CqlDirectory { get; set; } = null!;

    public const string ArgNameCSharpDirectory = "--cs";
    public DirectoryInfo? CSharpDirectory { get; set; }

    public const string ArgNameDebug = "--d";
    public bool Debug { get; set; }

    public const string ArgNameForce = "--f";
    public bool Force { get; set; }

    public const string ArgNameCanonicalRootUrl = "--canonical-root-url";
    public Uri? CanonicalRootUrl { get; set; }
}
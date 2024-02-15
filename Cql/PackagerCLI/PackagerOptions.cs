namespace Hl7.Cql.Packager;

internal partial class PackagerOptions
{
    public const string ConfigSection = "Packager";

    public const string Usage = 
        """
         Packager CLI Usage:
         
             -?|-h|-help                     Show this help
         
             --elm       <directory>         Library root directory
             --cql       <directory>         CQL root directory
             [--fhir]    <file|directory>    Resource location, either file name or directory
             [--cs]      <file|directory>    C# output location, either file name or directory
             [--d]       <true|false>        Produce as a debug assembly
             [--f]       <true|false>        Force an overwrite even if the output file already exists
             [--canonical-root-url] <url>    The root url used for the resource canonical.
                                             If omitted a '#' will be used
         """;

    public static IDictionary<string, string> BuildSwitchMappings() =>
        new SortedDictionary<string, string>
        {
            // @formatter:off
            [ArgNameElmDirectory]     = ConfigSection + ':' + nameof(ElmDirectory),
            [ArgNameCqlDirectory]     = ConfigSection + ':' + nameof(CqlDirectory),
            [ArgNameFhirDirectory]    = ConfigSection + ':' + nameof(FhirDirectory),
            [ArgNameCSharpDirectory]  = ConfigSection + ':' + nameof(CSharpDirectory),
            [ArgNameDebug]            = ConfigSection + ':' + nameof(Debug),
            [ArgNameForce]            = ConfigSection + ':' + nameof(Force),
            [ArgNameCanonicalRootUrl] = ConfigSection + ':' + nameof(CanonicalRootUrl),
            // @formatter:on
        };

    public const string ArgNameElmDirectory = "--elm";
    public DirectoryInfo ElmDirectory { get; set; } = null!;

    public const string ArgNameCqlDirectory = "--cql";
    public DirectoryInfo CqlDirectory { get; set; } = null!;

    public const string ArgNameCSharpDirectory = "--cs";
    public DirectoryInfo? CSharpDirectory { get; set; }

    public const string ArgNameFhirDirectory = "--fhir";
    public DirectoryInfo? FhirDirectory { get; set; }

    public const string ArgNameDebug = "--d";
    public bool Debug { get; set; }

    public const string ArgNameForce = "--f";
    public bool Force { get; set; }

    public const string ArgNameCanonicalRootUrl = "--canonical-root-url";
    public Uri? CanonicalRootUrl { get; set; }
}
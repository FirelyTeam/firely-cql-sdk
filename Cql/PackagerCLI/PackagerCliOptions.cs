namespace Hl7.Cql.Packager;

internal class PackagerCliOptions
{
    public const string ConfigSection = "PackagerCli";


    public static void BindConfig(PackagerCliOptions opt, IConfiguration config)
    {
        var section = config.GetRequiredSection(ConfigSection);
        section.Bind(opt);

        // DirectoryInfos cannot be bound directly from IConfiguration, so we do it manually.
        opt.CqlFromDirectory = GetDirectoryInfo(nameof(CqlFromDirectory))!;
        opt.ElmFromDirectory = GetDirectoryInfo(nameof(ElmFromDirectory))!;
        opt.ElmOutDirectory = GetDirectoryInfo(nameof(ElmOutDirectory))!;
        opt.AssemblyOutDirectory = GetDirectoryInfo(nameof(AssemblyOutDirectory))!;
        opt.CSharpOutDirectory = GetDirectoryInfo(nameof(CSharpOutDirectory))!;
        opt.FhirOutDirectory = GetDirectoryInfo(nameof(FhirOutDirectory))!;

        // While DateTimes can be bound directly from IConfiguration, we convert to UTC
        opt.FhirOverrideDate = opt.FhirOverrideDate?.ToUniversalTime();


        DirectoryInfo? GetDirectoryInfo(string key)
        {
            var path = section[key];
            return string.IsNullOrWhiteSpace(path) ? null : new DirectoryInfo(Path.GetFullPath(path));
        }
    }

    public bool LoggingIncludeDebug { get; set; }
    public bool LoggingKeepPrevious { get; set; }
    public DirectoryInfo? CqlFromDirectory { get; set; }
    public DirectoryInfo? ElmFromDirectory { get; set; }
    public DirectoryInfo? ElmOutDirectory { get; set; }
    public DirectoryInfo? CSharpOutDirectory { get; set; }
    public DirectoryInfo? AssemblyOutDirectory { get; set; }
    public DirectoryInfo? FhirOutDirectory { get; set; }
    public Uri? FhirCanonicalRootUrl { get; set; }
    public DateTime? FhirOverrideDate { get; set; }

    public IEnumerable<(string name, DirectoryInfo? dir)> GetInDirectories() =>
    [
        (name: nameof(CqlFromDirectory), dir: CqlFromDirectory),
        (name: nameof(ElmFromDirectory), dir: ElmFromDirectory)
    ];

    public IEnumerable<(string name, DirectoryInfo? dir)> GetOutDirectories() =>
    [
        (name: nameof(ElmOutDirectory), dir: ElmOutDirectory),
        (name: nameof(CSharpOutDirectory), dir: CSharpOutDirectory),
        (name: nameof(AssemblyOutDirectory), dir: AssemblyOutDirectory),
        (name: nameof(FhirOutDirectory), dir: FhirOutDirectory)
    ];
}
namespace Hl7.Cql.Packager;

internal record PackagingOptions
{
    public const string ConfigSection = "Packaging";
    public Uri? CanonicalRootUrl { get; init; }
    public DateTime? OverrideDate { get; set; }
    public bool JsonIndentEnable { get; init; }
    public string? FhirOutDir { get; init; }

    public static void Configure(PackagingOptions opt)
    {
        // While DateTimes can be bound directly from IConfiguration, we convert to UTC
        opt.OverrideDate = opt.OverrideDate?.ToLocalTime();
    }
}
namespace Hl7.Cql.Packager.Options;

internal record PackagingOptions
{
    public const string ConfigSection = "Packaging";

    public Uri? CanonicalRootUrl { get; init; }
    public DateTime? OverrideDate { get; init; }
    public bool JsonPretty { get; init; }

    public static void Configure(PackagingOptions opt)
    {
        // While DateTimes can be bound directly from IConfiguration, we convert to UTC
        var localTime = opt.OverrideDate?.ToLocalTime();
        typeof(PackagingOptions)
            .GetProperty(nameof(OverrideDate))!
            .SetValue(opt, localTime);
    }
}
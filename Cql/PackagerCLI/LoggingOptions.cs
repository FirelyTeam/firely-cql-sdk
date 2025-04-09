namespace Hl7.Cql.Packager;

internal record LoggingOptions
{
    public const string ConfigSection = "Logging";
    public bool IncludeDebug { get; init; }
    public bool KeepPrevious { get; init; }
}
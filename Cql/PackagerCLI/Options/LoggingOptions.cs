namespace Hl7.Cql.Packager.Options;

internal record LoggingOptions
{
    public const string ConfigSection = "Logging";

    public static LoggingOptions Default { get; } = new();

    public bool Debug { get; init; }
    public bool Append { get; init; }
}
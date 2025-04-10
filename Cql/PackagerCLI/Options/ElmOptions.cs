using Hl7.Cql.CodeGeneration.NET.Toolkit;

namespace Hl7.Cql.Packager.Options;

internal record ElmOptions : ElmToolkitConfig
{
    public const string ConfigSection = "Elm";

    public string[] SkipFiles { get; init; } = [];
}
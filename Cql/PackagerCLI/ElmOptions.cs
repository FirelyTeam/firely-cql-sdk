using Hl7.Cql.CodeGeneration.NET.Toolkit;

namespace Hl7.Cql.Packager;

internal record ElmOptions : ElmToolkitConfig
{
    public const string ConfigSection = "Elm";

    public string? ElmInDir { get; init; }
    public string? CSharpOutDir { get; init; }
    public string? DllOutDir { get; init; }

}
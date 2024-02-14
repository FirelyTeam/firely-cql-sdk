using System.ComponentModel.DataAnnotations;
using Microsoft.Extensions.Options;

namespace Hl7.Cql.Packager;

internal class PackagerOptions : IValidateOptions<PackagerOptions>
{
    public const string ConfigSection = "Packager";

    public static IDictionary<string, string> BuildSwitchMappings() => new SortedDictionary<string, string>
    {
        ["--elm"] = ConfigSection + ':' + nameof(ElmDirectory),
        ["--cql"] = ConfigSection + ':' + nameof(CqlDirectory),
        ["--fhir"] = ConfigSection + ':' + nameof(FhirDirectory),
        ["--cs"] = ConfigSection + ':' + nameof(CSharpDirectory),
        ["--d"] = ConfigSection + ':' + nameof(Debug),
        ["--f"] = ConfigSection + ':' + nameof(Force),
        ["--canonical-root-url"] = ConfigSection + ':' + nameof(CanonicalRootUrl),
    };

    [Required(AllowEmptyStrings = false)]
    public string ElmDirectory { get; set; } = null!;

    [Required(AllowEmptyStrings = false)]
    public string CqlDirectory { get; set; } = null!;

    public string? CSharpDirectory { get; set; }

    public string? FhirDirectory { get; set; }

    public bool Debug { get; set; }

    public bool Force { get; set; }

    public string? CanonicalRootUrl { get; set; }

    public ValidateOptionsResult Validate(string? name, PackagerOptions options)
    {
        ValidateOptionsResultBuilder b = new();

        if (string.IsNullOrWhiteSpace(options.ElmDirectory))
        {
            b.AddError("The ELM directory is required.", "--elm");
        }

        if (string.IsNullOrWhiteSpace(options.CqlDirectory))
        {
            b.AddError("The CQL directory is required.", "--cql");
        }

        return b.Build();
    }
}
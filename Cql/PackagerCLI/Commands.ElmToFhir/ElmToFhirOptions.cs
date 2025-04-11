namespace Hl7.Cql.Packager.Commands.ElmToFhir;

internal record ElmToFhirOptions : IBindOptions
{
    public const string ConfigSection = "ElmToFhir";
    static string IBindOptions.ConfigSection => ConfigSection;

    public required DirectoryInfo Cql { get; set; }
    public required DirectoryInfo Elm { get; set; }
    public DirectoryInfo? Cs { get; set; }
    public DirectoryInfo? Dll { get; set; }
    public required DirectoryInfo? Fhir { get; set; }
}
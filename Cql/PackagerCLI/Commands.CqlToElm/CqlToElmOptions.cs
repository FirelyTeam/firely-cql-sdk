namespace Hl7.Cql.Packager.Commands.CqlToElm;

public class CqlToElmOptions : IBindOptions
{
    public const string ConfigSection = "CqlToElm";
    static string IBindOptions.ConfigSection => ConfigSection;

    public required DirectoryInfo Cql { get; set; }

    public required DirectoryInfo Elm { get; set; }

    public bool JsonPretty { get; set; }
}
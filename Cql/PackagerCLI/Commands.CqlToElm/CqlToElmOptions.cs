namespace Hl7.Cql.Packager.Commands.CqlToElm;

public class CqlToElmOptions : IOptionsEx
{
    public const string ConfigSection = "CqlToElm";
    static string IOptionsEx.ConfigSection => ConfigSection;

    public required DirectoryInfo Cql { get; set; }

    public required DirectoryInfo Elm { get; set; }

    public bool JsonPretty { get; set; }
}
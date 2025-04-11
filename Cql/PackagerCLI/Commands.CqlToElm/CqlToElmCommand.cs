namespace Hl7.Cql.Packager.Commands.CqlToElm;

[UsedImplicitly]
public record CqlToElmCommand(
    DirectoryInfo Cql,
    DirectoryInfo Elm,
    bool? JsonPretty)
{
    public const string Name =
        "cql-to-elm";

    public const string Description =
        "Converts CQL to ELM.";

    public static Command CreateCommand() =>
        new Command(Name, Description)
            .AddOptions(Options)
            .SetHandler(typeof(CqlToElmProgram), nameof(CqlToElmProgram.CommandHandler));

    public static readonly Option[] Options =
    [
        Option<DirectoryInfo>("--cql", "CQL input directory")
            .IsRequired()
            .ExistingOnly(),
        Option<DirectoryInfo>("--elm", "ELM input directory")
            .IsRequired(),
        Option<bool>("--json-pretty", "Output JSON using multiline and indentation"),
    ];

    public IEnumerable<(object? value, string[] sectionPath)> GetConfigMapping() =>
        [
            (Cql, [CqlToElmOptions.ConfigSection, nameof(CqlToElmOptions.Cql)]),
            (Elm, [CqlToElmOptions.ConfigSection, nameof(CqlToElmOptions.Elm)]),
            (JsonPretty, [CqlToElmOptions.ConfigSection, nameof(CqlToElmOptions.JsonPretty)]),
        ];
}
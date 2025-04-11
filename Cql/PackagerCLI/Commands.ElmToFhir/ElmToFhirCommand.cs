/*
 * Copyright(c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Packager.Options;

namespace Hl7.Cql.Packager.Commands.ElmToFhir;

[UsedImplicitly]
internal record ElmToFhirCommand(
    DirectoryInfo Cql,
    DirectoryInfo Elm,
    DirectoryInfo? Cs,
    DirectoryInfo? Dll,
    DirectoryInfo? Fhir,
    DateTimeOffset? OverrideUtcDateTime,
    string? CanonicalRootUrl,
    bool? JsonPretty)
{
    public const string Name =
        "elm-to-fhir";

    public const string Description =
        "Converts ELM to C# and .NET assemblies, and package them together with CQL into FHIR resources.";

    public static readonly Option[] Options =
    [
        Option<DirectoryInfo>("--cql", "CQL input directory")
            .IsRequired()
            .ExistingOnly(),
        Option<DirectoryInfo>("--elm", "ELM input directory")
            .IsRequired()
            .ExistingOnly(),
        Option<DirectoryInfo>("--cs", "C# output directory"),
        Option<DirectoryInfo>("--dll", "DLL/PDB output directory"),
        Option<DirectoryInfo>("--fhir", "FHIR Resource output directory"),
        Option<string>("--canonical-root-url", "The root canonical url output in FHIR library"),
        Option<DateTimeOffset>("--override-utc-date-time", "Override date output in FHIR library"),
        Option<bool>("--json-pretty", "Output JSON using multiline and indentation"),
        Option<string>("--cs-typeformat", "Obsolete - Not effect"),
    ];

    public static Command CreateCommand() =>
        new Command(Name, Description)
            .AddOptions(Options)
            .SetHandler(typeof(ElmToFhirProgram), nameof(ElmToFhirProgram.CommandHandler));

    public IEnumerable<(object? value, string[] sectionPath)> GetConfigMapping() =>
    [
        (Cql, [ElmToFhirOptions.ConfigSection, nameof(ElmToFhirOptions.Cql)]),
        (Elm, [ElmToFhirOptions.ConfigSection, nameof(ElmToFhirOptions.Elm)]),
        (Cs, [ElmToFhirOptions.ConfigSection, nameof(ElmToFhirOptions.Cs)]),
        (Dll, [ElmToFhirOptions.ConfigSection, nameof(ElmToFhirOptions.Dll)]),
        (Fhir, [ElmToFhirOptions.ConfigSection, nameof(ElmToFhirOptions.Fhir)]),
        (CanonicalRootUrl, [PackagingBindOptions.ConfigSection, nameof(PackagingBindOptions.CanonicalRootUrl)]),
        (OverrideUtcDateTime, [PackagingBindOptions.ConfigSection, nameof(PackagingBindOptions.OverrideDate)]),
        (JsonPretty, [PackagingBindOptions.ConfigSection, nameof(PackagingBindOptions.JsonPretty)]),
    ];
}
/*
 * Copyright(c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Packager.Options;

namespace Hl7.Cql.Packager.Commands.CqlToFhir;

[UsedImplicitly]
public record CqlToFhirCommand(
    DirectoryInfo Cql,
    DirectoryInfo? Elm,
    DirectoryInfo? Cs,
    DirectoryInfo? Dll,
    DirectoryInfo? Fhir,
    DateTimeOffset? OverrideUtcDateTime,
    string? CanonicalRootUrl,
    bool? JsonPretty)
{
    public const string Name =
        "cql";

    public const string Description =
        "Converts CQL to ELM, C# and .NET assemblies, and package them together into FHIR resources.";

    public static Command CreateCommand() =>
        new Command(Name, Description)
            .AddOptions(Options)
            .SetHandler(typeof(CqlToFhirProgram), nameof(CqlToFhirProgram.CommandHandler));

    public static readonly Option[] Options =
    [
        Option<DirectoryInfo>("--cql", "CQL input directory")
            .IsRequired()
            .ExistingOnly(),
        Option<DirectoryInfo>("--elm", "ELM output directory"),
        Option<DirectoryInfo>("--cs", "C# output directory"),
        Option<DirectoryInfo>("--dll", "DLL/PDB output directory"),
        Option<DirectoryInfo>("--fhir", "FHIR Resource output directory"),
        Option<string>("--canonical-root-url", "The root canonical url output in FHIR library"),
        Option<DateTimeOffset>("--override-utc-date-time", "Override date output in FHIR library"),
        Option<bool>("--json-pretty", "Output JSON using multiline and indentation"),
    ];

    public IEnumerable<(object? value, string[] sectionPath)> GetConfigMapping() =>
    [
        (Cql, [CqlToFhirOptions.ConfigSection, nameof(CqlToFhirOptions.Cql)]),
        (Elm, [CqlToFhirOptions.ConfigSection, nameof(CqlToFhirOptions.Elm)]),
        (Cs, [CqlToFhirOptions.ConfigSection, nameof(CqlToFhirOptions.Cs)]),
        (Dll, [CqlToFhirOptions.ConfigSection, nameof(CqlToFhirOptions.Dll)]),
        (Fhir, [CqlToFhirOptions.ConfigSection, nameof(CqlToFhirOptions.Fhir)]),
        (CanonicalRootUrl, [FhirOptions.ConfigSection, nameof(FhirOptions.CanonicalRootUrl)]),
        (OverrideUtcDateTime, [FhirOptions.ConfigSection, nameof(FhirOptions.OverrideDate)]),
        (JsonPretty, [CqlToFhirOptions.ConfigSection, nameof(CqlToFhirOptions.JsonPretty)]),
    ];
}
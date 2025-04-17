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
    DirectoryInfo? Cql,
    DirectoryInfo Elm,
    DirectoryInfo? Cs,
    DirectoryInfo? Dll,
    DirectoryInfo? Fhir,
    DateTimeOffset? OverrideUtcDateTime,
    string? CanonicalRootUrl,
    bool? JsonPretty)
{
    public const string Name =
        "elm";

    public const string Description =
        "Start from CQL and convert to one or more of the following outputs: ELM, C#, DLL/PDB, FHIR Resources";

    public static readonly Option[] Options =
    [
        Option<DirectoryInfo>("--cql", "CQL input directory. (REQUIRED when using --fhir)"),
        Option<DirectoryInfo>("--elm", "ELM input directory")
            .IsRequired()
            .ExistingOnly(),
        Option<DirectoryInfo>("--cs", "C# output directory"),
        Option<DirectoryInfo>("--dll", "DLL/PDB output directory"),
        Option<DirectoryInfo>("--fhir", "FHIR Resource output directory"),
        Option<string>("--canonical-root-url", "The root canonical url output in FHIR library.  (used with --fhir)"),
        Option<DateTimeOffset>("--override-utc-date-time", "Override date output in FHIR library.  (used with --fhir)"),
        Option<bool>("--json-pretty", "Output JSON using multiline and indentation. (used with --fhir)"),
    ];

    public static Command CreateCommand() =>
        new Command(Name, Description)
            .AddOptions(Options)
            .SetHandler(typeof(ElmToFhirProgram), nameof(ElmToFhirProgram.CommandHandler));

    public IEnumerable<(object? value, string[] sectionPath)> GetConfigMapping() =>
    [
        (Cql, [ElmToFhirOptions.ConfigSection, nameof(ElmToFhirOptions.CqlInDir)]),
        (Elm, [ElmToFhirOptions.ConfigSection, nameof(ElmToFhirOptions.ElmInDir)]),
        (Cs, [ElmToFhirOptions.ConfigSection, nameof(ElmToFhirOptions.CSharpOutDir)]),
        (Dll, [ElmToFhirOptions.ConfigSection, nameof(ElmToFhirOptions.DllOutDir)]),
        (Fhir, [ElmToFhirOptions.ConfigSection, nameof(ElmToFhirOptions.FhirOutDir)]),
        (CanonicalRootUrl, [PackagingOptions.ConfigSection, nameof(PackagingOptions.CanonicalRootUrl)]),
        (OverrideUtcDateTime, [PackagingOptions.ConfigSection, nameof(PackagingOptions.OverrideDate)]),
        (JsonPretty, [PackagingOptions.ConfigSection, nameof(PackagingOptions.JsonPretty)]),
    ];
}
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
        "Start from ELM and convert to one or more of the following outputs: C#, DLL/PDB, FHIR Resources. " +
        "When outputing to FHIR Resources, the CQL matchinging against the ELM based on their versioned " +
        "identifier must be supplied as well.";

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
        Option<string>("--canonical-root-url", "The root canonical url output in FHIR library.  (used with --fhir)"),
        Option<DateTimeOffset>("--override-utc-date-time", "Override date output in FHIR library.  (used with --fhir)"),
        Option<bool>("--json-pretty", "Output JSON using multiline and indentation. (used with --elm or --fhir)"),
    ];

    public IEnumerable<(object? value, string[] sectionPath)> GetConfigMapping() =>
    [
        (Cql, [CqlToFhirOptions.ConfigSection, nameof(CqlToFhirOptions.CqlInDir)]),
        (Elm, [CqlToFhirOptions.ConfigSection, nameof(CqlToFhirOptions.ElmOutDir)]),
        (Cs, [CqlToFhirOptions.ConfigSection, nameof(CqlToFhirOptions.CSharpOutDir)]),
        (Dll, [CqlToFhirOptions.ConfigSection, nameof(CqlToFhirOptions.DllOutDir)]),
        (Fhir, [CqlToFhirOptions.ConfigSection, nameof(CqlToFhirOptions.FhirOutDir)]),
        (CanonicalRootUrl, [PackagingOptions.ConfigSection, nameof(PackagingOptions.CanonicalRootUrl)]),
        (OverrideUtcDateTime, [PackagingOptions.ConfigSection, nameof(PackagingOptions.OverrideDate)]),
        (JsonPretty, [ElmOptions.ConfigSection, nameof(ElmOptions.JsonPretty)]),
    ];
}
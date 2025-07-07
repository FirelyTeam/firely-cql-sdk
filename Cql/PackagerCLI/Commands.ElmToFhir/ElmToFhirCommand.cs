/*
 * Copyright(c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Packager.Options;

namespace Hl7.Cql.Packager.Commands.ElmToFhir;

[UsedImplicitly]
internal record ElmToFhirCommand
(
    // Do not rename these properties, they must match the command line options e.g. --cql maps to Cql, etc
    DirectoryInfo? Cql,
    DirectoryInfo Elm,
    DirectoryInfo? CSharp,
    DirectoryInfo? Dll,
    DirectoryInfo? Pdb,
    DirectoryInfo? Fhir,
    DateTimeOffset? OverrideUtcDateTime,
    string? CanonicalRootUrl,
    bool? JsonPretty,
    AssemblyCompilerDebugInformationFormat? DebugSymbols)
{
    public const string Name =
        "elm";

    public const string Description =
        "Start from CQL and convert to one or more of the following outputs: ELM, C#, DLL/PDB, FHIR Resources";

    public static readonly Option[] Options =
    [
        Option<DirectoryInfo>(
            "--cql",
            """
            CQL input directory containing CQL files "*.cql".
            (REQUIRED with --fhir)
            """),

        Option<DirectoryInfo>(
                "--elm",
                """
                ELM input directory containing ELM files in JSON format "*.json".
                """)
            .IsRequired()
            .ExistingOnly(),

        Option<DirectoryInfo>(
            "--cs",
            """
            C# output directory containing the generated C# source code files "*.g.cs" for the .NET assembly libraries.
            """),

        Option<DirectoryInfo>(
            "--dll",
            """
            DLL output directory which are .NET assembly libraries "*.dll" containing invokable CQL.
            """),

        Option<DirectoryInfo>(
            "--pdb",
            """
            PDB output directory which contain the portable debug symbol files "*.pdb".
            Allowed to be the same as DLL output directory.
            (Used with --debug-symbols=PortablePdb, --dll is REQUIRED)
            """),

        Option<DirectoryInfo>(
            "--fhir",
            """
            FHIR Resource output directory which contains the FHIR library files in JSON format "Library-*.json" and FHIR measures in JSON format "Measure-*.json".
            """),

        Option<string>(
            "--canonical-root-url",
            """
            The root canonical url output in FHIR library.
            (Used with --fhir)
            """),

        Option<DateTimeOffset>(
            "--override-utc-date-time",
            """
            Override date output in FHIR library.
            (Used with --fhir)
            """),

        Option<bool>(
            "--json-pretty",
            """
            Output JSON using multiline and indentation.
            (Used with --fhir)
            """),

        Option<AssemblyCompilerDebugInformationFormat>(
            "--debug-symbols",
            """
            The way debug symbols are emitted when generating .NET assemblies. Options are:
            - None (DEFAULT) = No debug symbols are generated and .NET assemblies are compiled with optimizations enabled.
            - PortablePdb = .NET assemblies are compiled with no optimizations and debug symbols are written as a separate Portable PDB format. Will be emitted to the --pdb directory.
            - Embedded = .NET assemblies are compiled with no optimizations and debug symbols are embedded in the DLL itself, together with the C# source code.
            """)
    ];

    public static Command CreateCommand() =>
        new Command(Name, Description)
            .AddOptions(Options)
            .SetHandler(typeof(ElmToFhirProgram), nameof(ElmToFhirProgram.CommandHandler));

    public IEnumerable<(object? value, string[] sectionPath)> GetConfigMapping() =>
    [
        (Cql, [ElmToFhirOptions.ConfigSection, nameof(ElmToFhirOptions.CqlInDir)]),
        (Elm, [ElmToFhirOptions.ConfigSection, nameof(ElmToFhirOptions.ElmInDir)]),
        (CSharp, [ElmToFhirOptions.ConfigSection, nameof(ElmToFhirOptions.CSharpOutDir)]),
        (Dll, [ElmToFhirOptions.ConfigSection, nameof(ElmToFhirOptions.DllOutDir)]),
        (Pdb, [ElmToFhirOptions.ConfigSection, nameof(ElmToFhirOptions.PdbOutDir)]),
        (Fhir, [ElmToFhirOptions.ConfigSection, nameof(ElmToFhirOptions.FhirOutDir)]),
        (DebugSymbols, [ElmToFhirOptions.ConfigSection, nameof(ElmToFhirOptions.DebugSymbols)]),
        (CanonicalRootUrl, [PackagingOptions.ConfigSection, nameof(PackagingOptions.CanonicalRootUrl)]),
        (OverrideUtcDateTime, [PackagingOptions.ConfigSection, nameof(PackagingOptions.OverrideDate)]),
        (JsonPretty, [PackagingOptions.ConfigSection, nameof(PackagingOptions.JsonPretty)]),
    ];
}
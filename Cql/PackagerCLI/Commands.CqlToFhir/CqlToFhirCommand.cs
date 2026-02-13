/*
 * Copyright(c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Packager.Options;

namespace Hl7.Cql.Packager.Commands.CqlToFhir;

[UsedImplicitly]
public record CqlToFhirCommand
(
    // Do not rename these properties, they must match the command line options e.g. --cql maps to Cql, etc
    DirectoryInfo Cql,
    DirectoryInfo? Elm,
    DirectoryInfo? Cs,
    DirectoryInfo? Dll,
    DirectoryInfo? Pdb,
    DirectoryInfo? Fhir,
    DateTimeOffset? OverrideUtcDateTime,
    string? CanonicalRootUrl,
    string? CSharpNamespace,
    bool? JsonPretty,
    bool? ExitOnError,
    DebugSymbolsFormat? DebugSymbols,
    bool? FlattenDirHierarchy)
{
    public const string Name =
        "cql";

    public static readonly string Description =
        "Start from CQL and convert to one or more of the following outputs: ELM, C#, DLL, PDB, FHIR Resources. " +
        "Take note of the disclaimer above." +
        Program.Disclaimer +
        Environment.NewLine + Environment.NewLine + Environment.NewLine +
        "Exit Codes:" + Environment.NewLine +
        "  0 - Success" + Environment.NewLine +
        "  1 - No CQL libraries found in the CQL input directory" + Environment.NewLine +
        "  3 - No ELM libraries compiled" + Environment.NewLine +
        "  4 - Cannot package: No matching CQL-ELM pairs found" + Environment.NewLine +
        "  5 - No output directories specified";

    public static readonly string ExitCodes =
        "0 - Success" + Environment.NewLine +
        "1 - No CQL libraries found in the CQL input directory" + Environment.NewLine +
        "  3 - No ELM libraries compiled" + Environment.NewLine +
        "4 - Cannot package: No matching CQL-ELM pairs found" + Environment.NewLine +
        "5 - No output directories specified";

    public static Command CreateCommand() =>
        new Command(Name, Description)
            .AddOptions(Options)
            .SetHandler(typeof(CqlToFhirProgram), nameof(CqlToFhirProgram.CommandHandler));

    public static readonly Option[] Options =
    [
        Option<DirectoryInfo>(
                "--cql",
                """
                CQL input directory containing CQL files "*.cql".
                """)
            .IsRequired()
            .ExistingOnly(),

        Option<DirectoryInfo>(
            "--elm",
            """
            ELM input directory containing ELM files in JSON format "*.json".
            """),

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
            (Used with --fhir or -elm)
            """),

        Option<DebugSymbolsFormat>(
            "--debug-symbols",
            """
            The way debug symbols are emitted when generating .NET assemblies. Options are:
            - None (DEFAULT) = No debug symbols are generated and .NET assemblies are compiled with optimizations enabled.
            - PortablePdb = .NET assemblies are compiled with no optimizations and debug symbols are written as a separate Portable PDB format. Will be emitted to the --pdb directory.
            - Embedded = .NET assemblies are compiled with no optimizations and debug symbols are embedded in the DLL itself, together with the C# source code.
            """),

        Option<string>(
            "--cs-namespace",
            """
            The C# namespace to use for generated code.
            (Used with --cs or --dll)
            """),

        Option<bool>(
            "--flatten-dir-hierarchy",
            """
            Flatten the subdirectory hierarchy when outputting files.
            When enabled, all output files are placed in the output directory root.
            When disabled (DEFAULT), subdirectory structure from the CQL input directory is preserved in all output directories.
            """)
    ];

    public IEnumerable<(object? value, string[] sectionPath)> GetConfigMapping() =>
    [
        (Cql, [CqlToFhirOptions.ConfigSection, nameof(CqlToFhirOptions.CqlInDir)]),
        (Elm, [CqlToFhirOptions.ConfigSection, nameof(CqlToFhirOptions.ElmOutDir)]),
        (Cs, [CqlToFhirOptions.ConfigSection, nameof(CqlToFhirOptions.CSharpOutDir)]),
        (Dll, [CqlToFhirOptions.ConfigSection, nameof(CqlToFhirOptions.DllOutDir)]),
        (Pdb, [CqlToFhirOptions.ConfigSection, nameof(CqlToFhirOptions.PdbOutDir)]),
        (Fhir, [CqlToFhirOptions.ConfigSection, nameof(CqlToFhirOptions.FhirOutDir)]),
        (DebugSymbols, [ElmOptions.ConfigSection, nameof(ElmOptions.DebugSymbolsFormat)]),
        (CSharpNamespace, [ElmOptions.ConfigSection, nameof(ElmOptions.CSharpNamespace)]),
        (CanonicalRootUrl, [PackagingOptions.ConfigSection, nameof(PackagingOptions.CanonicalRootUrl)]),
        (OverrideUtcDateTime, [PackagingOptions.ConfigSection, nameof(PackagingOptions.OverrideDate)]),
        (ExitOnError, [PackagingOptions.ConfigSection, nameof(PackagingOptions.ExitOnError)]),
        (JsonPretty, [PackagingOptions.ConfigSection, nameof(PackagingOptions.JsonPretty)]),
        (FlattenDirHierarchy, [CqlToFhirOptions.ConfigSection, nameof(CqlToFhirOptions.FlattenDirHierarchy)]),
    ];
}
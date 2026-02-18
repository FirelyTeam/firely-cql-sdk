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
    DirectoryInfo? Libraries,
    DirectoryInfo? Measures,
    DateTimeOffset? OverrideUtcDateTime,
    string? CanonicalRootUrl,
    string? CSharpNamespace,
    bool? JsonPretty,
    bool? ExitOnError,
    bool? FlattenDirHierarchy,
    DebugSymbolsFormat? DebugSymbols)
{
    public const string Name =
        "cql";

    public static readonly string Description =
        "Start from CQL and convert to one or more of the following outputs: ELM, C#, DLL, PDB, FHIR Resources. " +
        "Take note of the disclaimer above." +
        Program.Disclaimer +
        NewLine + NewLine + NewLine +
        "Exit Codes:" + NewLine +
        "  " + ExitCodes.Success.CodeWithMessage + NewLine +
        "  " + ExitCodes.NoCqlLibsInDir.CodeWithMessage + NewLine +
        "  " + ExitCodes.NoElmLibsCompiled.CodeWithMessage + NewLine +
        "  " + ExitCodes.CantPackageNoCqlElmMatches.CodeWithMessage + NewLine +
        "  " + ExitCodes.NoOutputDirs.CodeWithMessage + NewLine +
        "  " + ExitCodes.PdbDirSpecifiedButDebugSymbolsIsNotPortablePdb.CodeWithMessage + NewLine +
        "  " + ExitCodes.DllDirIsRequiredWhenPdbDirIsSpecified.CodeWithMessage + NewLine +
        "  " + ExitCodes.PdbOrFhirDirNotSpecifiedButDebugSymbolsIsPortablePdb.CodeWithMessage + NewLine +
        "  " + ExitCodes.NoCqlLibsConvertedToElm.CodeWithMessage + NewLine +
        "  " + ExitCodes.MixedFhirAndSpecificDirs.CodeWithMessage + NewLine +
        "  " + ExitCodes.IncompleteLibrariesMeasuresDirs.CodeWithMessage;

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
            Cannot be used with --libraries or --measures (mutually exclusive).
            """),

        Option<DirectoryInfo>(
            "--libraries",
            """
            FHIR Libraries output directory which contains the FHIR library files in JSON format "Library-*.json".
            Must be used together with --measures. Cannot be combined with --fhir.
            """),

        Option<DirectoryInfo>(
            "--measures",
            """
            FHIR Measures output directory which contains the FHIR measure files in JSON format "Measure-*.json".
            Must be used together with --libraries. Cannot be combined with --fhir.
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
            Flatten the output directory structure, ignoring subdirectories from the input.
            By default, subdirectory structure is preserved from input to output directories.
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
        (Libraries, [CqlToFhirOptions.ConfigSection, nameof(CqlToFhirOptions.LibrariesOutDir)]),
        (Measures, [CqlToFhirOptions.ConfigSection, nameof(CqlToFhirOptions.MeasuresOutDir)]),
        (FlattenDirHierarchy, [CqlToFhirOptions.ConfigSection, nameof(CqlToFhirOptions.FlattenDirHierarchy)]),
        (DebugSymbols, [ElmOptions.ConfigSection, nameof(ElmOptions.DebugSymbolsFormat)]),
        (CSharpNamespace, [ElmOptions.ConfigSection, nameof(ElmOptions.CSharpNamespace)]),
        (CanonicalRootUrl, [PackagingOptions.ConfigSection, nameof(PackagingOptions.CanonicalRootUrl)]),
        (OverrideUtcDateTime, [PackagingOptions.ConfigSection, nameof(PackagingOptions.OverrideDate)]),
        (ExitOnError, [PackagingOptions.ConfigSection, nameof(PackagingOptions.ExitOnError)]),
        (JsonPretty, [PackagingOptions.ConfigSection, nameof(PackagingOptions.JsonPretty)]),
    ];
}
/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Packager.Options;

namespace Hl7.Cql.Packager.Commands.ReplaceLibraryAttachments;

[UsedImplicitly]
internal record ReplaceLibraryAttachmentsCommand
(
    // Do not rename these properties, they must match the command line options e.g. --library-file maps to LibraryFile, etc
    FileInfo LibraryFile,
    FileInfo? LibraryOutFile,
    FileInfo? CqlFile,
    FileInfo? ElmFile,
    FileInfo? CSharpFile,
    FileInfo? DllFile,
    FileInfo? PdbFile,
    bool? JsonPretty)
{
    public const string Name = "replace-library-attachments";

    public static readonly string Description =
        "ALPHA FEATURE: This command is currently in alpha and its behavior may change in future releases." +
        Environment.NewLine + Environment.NewLine +
        "Replace attachments in an existing FHIR library resource. " +
        "Given a FHIR library file and one or more attachment files, this command replaces or adds " +
        "the corresponding content in the library (identified by content type: +cql, +elm, +dll, +pdb, +csharp). " +
        "If --library-out-file is not specified, the library-file will be updated in-place. " +
        "If --library-out-file is specified, library-file will be copied to library-out-file, and the latter will be updated." +
        Environment.NewLine + Environment.NewLine +
        "Note: When replacing the ELM attachment (--elm-file), the CQL options parameters in the FHIR Library " +
        "resource will be automatically overridden with the values from the new ELM file." +
        Environment.NewLine + Environment.NewLine + Environment.NewLine +
        "Exit Codes:" + Environment.NewLine +
        $"  {ExitCode.Normal}  - {ExitCodeMessages.Success}" + Environment.NewLine +
        $"  {ExitCode.NoInputFiles} - {ExitCodeMessages.NoInputFiles}" + Environment.NewLine +
        $"  {ExitCode.InvalidLibraryJson} - {ExitCodeMessages.InvalidLibraryJsonOrMissingProperties}" + Environment.NewLine +
        $"  {ExitCode.UnknownError} - {ExitCodeMessages.UnknownError}";

    public static readonly string ExitCodes =
        $"{ExitCode.Normal}  - {ExitCodeMessages.Success}" + Environment.NewLine +
        $"{ExitCode.NoInputFiles} - {ExitCodeMessages.NoInputFiles}" + Environment.NewLine +
        $"{ExitCode.InvalidLibraryJson} - {ExitCodeMessages.InvalidLibraryJsonOrMissingProperties}" + Environment.NewLine +
        $"{ExitCode.UnknownError} - {ExitCodeMessages.UnknownError}";

    public static readonly Option[] Options =
    [
        Option<FileInfo>(
                "--library-file",
                """
                FHIR library file in JSON format to read from.
                """)
            .IsRequired()
            .ExistingOnly(),

        Option<FileInfo>(
            "--library-out-file",
            """
            Output file for the updated library. If not specified, the library-file will be updated in-place.
            If specified, library-file will be copied to this location, and this file will be updated with the new attachments.
            """),

        Option<FileInfo>(
            "--cql-file",
            """
            CQL file to replace or add as +cql content in the library.
            """),

        Option<FileInfo>(
            "--elm-file",
            """
            ELM file in JSON format to replace or add as +elm content in the library.
            Note: When this is replaced, the CQL options parameters in the FHIR Library will be overridden with values from the new ELM file.
            """),

        Option<FileInfo>(
            "--csharp-file",
            """
            C# source file to replace or add as +csharp content in the library.
            """),

        Option<FileInfo>(
            "--dll-file",
            """
            DLL file to replace or add as +dll content in the library.
            """),

        Option<FileInfo>(
            "--pdb-file",
            """
            PDB file to replace or add as +pdb content in the library.
            """),

        Option<bool>(
            "--json-pretty",
            """
            Output JSON using multiline and indentation.
            """),
    ];

    public static Command CreateCommand() =>
        new Command(Name, Description)
            .AddOptions(Options)
            .SetHandler(typeof(ReplaceLibraryAttachmentsProgram), nameof(ReplaceLibraryAttachmentsProgram.CommandHandler));

    public IEnumerable<(object? value, string[] sectionPath)> GetConfigMapping() =>
    [
        (LibraryFile, [ReplaceLibraryAttachmentsOptions.ConfigSection, nameof(ReplaceLibraryAttachmentsOptions.LibraryFile)]),
        (LibraryOutFile, [ReplaceLibraryAttachmentsOptions.ConfigSection, nameof(ReplaceLibraryAttachmentsOptions.LibraryOutFile)]),
        (CqlFile, [ReplaceLibraryAttachmentsOptions.ConfigSection, nameof(ReplaceLibraryAttachmentsOptions.CqlFile)]),
        (ElmFile, [ReplaceLibraryAttachmentsOptions.ConfigSection, nameof(ReplaceLibraryAttachmentsOptions.ElmFile)]),
        (CSharpFile, [ReplaceLibraryAttachmentsOptions.ConfigSection, nameof(ReplaceLibraryAttachmentsOptions.CSharpFile)]),
        (DllFile, [ReplaceLibraryAttachmentsOptions.ConfigSection, nameof(ReplaceLibraryAttachmentsOptions.DllFile)]),
        (PdbFile, [ReplaceLibraryAttachmentsOptions.ConfigSection, nameof(ReplaceLibraryAttachmentsOptions.PdbFile)]),
        (JsonPretty, [PackagingOptions.ConfigSection, nameof(PackagingOptions.JsonPretty)]),
    ];
}

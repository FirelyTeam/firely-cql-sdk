/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Packager.Options;

namespace Hl7.Cql.Packager.Commands.LibraryExtractAttachments;

[UsedImplicitly]
internal record LibraryExtractAttachmentsCommand
(
    // Do not rename these properties, they must match the command line options
    FileInfo LibraryFile,
    DirectoryInfo? CqlDir,
    DirectoryInfo? ElmDir,
    DirectoryInfo? CSharpDir,
    DirectoryInfo? DllDir,
    DirectoryInfo? PdbDir)
{
    public const string Name = "library-extract-attachments";

    public static readonly string Description =
        "Extract attachments from a FHIR Library resource to individual files. " +
        "Given a FHIR Library resource file, this command extracts embedded attachments " +
        "(CQL, ELM, C#, DLL, PDB) and saves them to the specified output directories.";

    public static readonly Option[] Options =
    [
        Option<FileInfo>(
                "--library-file",
                """
                FHIR Library resource file in JSON format containing embedded attachments.
                """)
            .IsRequired()
            .ExistingOnly(),

        Option<DirectoryInfo>(
            "--cql-dir",
            """
            CQL output directory for extracted CQL files "*.cql".
            (At least one output directory must be specified)
            """),

        Option<DirectoryInfo>(
            "--elm-dir",
            """
            ELM output directory for extracted ELM JSON files "*.json".
            (At least one output directory must be specified)
            """),

        Option<DirectoryInfo>(
            "--csharp-dir",
            """
            C# output directory for extracted C# source code files "*.g.cs".
            (At least one output directory must be specified)
            """),

        Option<DirectoryInfo>(
            "--dll-dir",
            """
            DLL output directory for extracted .NET assembly libraries "*.dll".
            (At least one output directory must be specified)
            """),

        Option<DirectoryInfo>(
            "--pdb-dir",
            """
            PDB output directory for extracted portable debug symbol files "*.pdb".
            (At least one output directory must be specified)
            """)
    ];

    public static Command CreateCommand() =>
        new Command(Name, Description)
            .AddOptions(Options)
            .SetHandler(typeof(LibraryExtractAttachmentsProgram), nameof(LibraryExtractAttachmentsProgram.CommandHandler));

    public IEnumerable<(object? value, string[] sectionPath)> GetConfigMapping() =>
    [
        (LibraryFile, [LibraryExtractAttachmentsOptions.ConfigSection, nameof(LibraryExtractAttachmentsOptions.LibraryFile)]),
        (CqlDir, [LibraryExtractAttachmentsOptions.ConfigSection, nameof(LibraryExtractAttachmentsOptions.CqlOutDir)]),
        (ElmDir, [LibraryExtractAttachmentsOptions.ConfigSection, nameof(LibraryExtractAttachmentsOptions.ElmOutDir)]),
        (CSharpDir, [LibraryExtractAttachmentsOptions.ConfigSection, nameof(LibraryExtractAttachmentsOptions.CSharpOutDir)]),
        (DllDir, [LibraryExtractAttachmentsOptions.ConfigSection, nameof(LibraryExtractAttachmentsOptions.DllOutDir)]),
        (PdbDir, [LibraryExtractAttachmentsOptions.ConfigSection, nameof(LibraryExtractAttachmentsOptions.PdbOutDir)])
    ];
}

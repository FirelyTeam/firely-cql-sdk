/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Packager.Commands.ReplaceLibraryAttachments;

internal record ReplaceLibraryAttachmentsOptions : IBindOptions
{
    public const string ConfigSection = "ReplaceLibraryAttachments";
    static string IBindOptions.ConfigSection => ConfigSection;

    public required FileInfo LibraryFile { get; set; }
    public FileInfo? LibraryBackupFile { get; set; }
    public FileInfo? CqlFile { get; set; }
    public FileInfo? ElmFile { get; set; }
    public FileInfo? CSharpFile { get; set; }
    public FileInfo? DllFile { get; set; }
    public FileInfo? PdbFile { get; set; }
}

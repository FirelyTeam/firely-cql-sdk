/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Packager.Commands.ExtractLibraryAttachments;

internal record ExtractLibraryAttachmentsOptions : IBindOptions
{
    public const string ConfigSection = "ExtractLibraryAttachments";
    static string IBindOptions.ConfigSection => ConfigSection;

    public required FileInfo LibraryFile { get; set; }
    public DirectoryInfo? CqlOutDir { get; set; }
    public DirectoryInfo? ElmOutDir { get; set; }
    public DirectoryInfo? CSharpOutDir { get; set; }
    public DirectoryInfo? DllOutDir { get; set; }
    public DirectoryInfo? PdbOutDir { get; set; }
}

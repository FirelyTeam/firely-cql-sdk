/*
 * Copyright (c) 2024, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Runtime.IO;

namespace Hl7.Cql.CqlToElm.Toolkit;

/// <summary>
/// Options for saving ELM files to a directory.
/// </summary>
public sealed class SaveElmFilesOptions
{
    /// <summary>
    /// Optional function to compute custom output paths.
    /// </summary>
    public ComputeOutputPathDelegate? ComputeOutputPath { get; init; }

    /// <summary>
    /// If set to <c>true</c>, the JSON output will be indented.
    /// </summary>
    public bool WriteIndented { get; init; }

    /// <summary>
    /// The directory preparation strategy.
    /// </summary>
    public DirectoryInfoHandler? DirectoryPreparationStrategy { get; init; }
}

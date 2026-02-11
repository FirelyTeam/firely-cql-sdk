/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Packager.Options;

/// <summary>
/// Specifies which input directory structure should be preserved in output directories.
/// </summary>
public enum MaintainSubdirsSource
{
    /// <summary>
    /// Do not preserve subdirectory structure (default behavior - flatten all outputs).
    /// </summary>
    None = 0,

    /// <summary>
    /// Preserve the subdirectory structure from the CQL input directory.
    /// </summary>
    Cql,

    /// <summary>
    /// Preserve the subdirectory structure from the ELM input directory.
    /// </summary>
    Elm
}

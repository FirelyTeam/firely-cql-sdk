/*
 * Copyright (c) 2025, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Comparers;

/// <summary>
/// Represents the precision for comparing between CQL codes.
/// </summary>
public enum CqlCodePrecision
{
    /// <summary>
    /// Compares only the code.
    /// </summary>
    Code = 1,

    /// <summary>
    /// Compares on code and system.
    /// </summary>
    CodeAndSystem = 3,

    /// <summary>
    /// Compares on code, system, and version.
    /// </summary>
    CodeSystemAndVersion = 7,
}
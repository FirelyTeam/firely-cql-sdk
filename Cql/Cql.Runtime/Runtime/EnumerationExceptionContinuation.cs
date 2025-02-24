/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Runtime;

/// <summary>
/// The continuation policy to use when an exception occurs during enumeration.
/// </summary>
public enum EnumerationExceptionContinuation
{
    /// <summary>
    /// Throw an exception when an error occurs.
    /// </summary>
    Throw = 0,

    /// <summary>
    /// Ignore the exception and continue to the next.
    /// </summary>
    Continue = 1,

    /// <summary>
    /// Ignore the exception and break the process.
    /// </summary>
    Break = 2,
}
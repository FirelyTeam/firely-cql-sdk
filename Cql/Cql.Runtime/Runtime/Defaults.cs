/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Runtime;

/// <summary>
/// Provides default configuration options for common runtime operations.
/// </summary>
public static class Defaults
{
    /// <summary>
    /// Temporary probe member used to validate CI analyzer enforcement.
    /// </summary>
    public const int PublicApiDriftProbe = 1;

    /// <summary>
    /// Gets the default enumeration options that recurse into subdirectories.
    /// </summary>
    public static EnumerationOptions EnumerationOptionsRecurseSubdirectories { get; } = new()
    {
        RecurseSubdirectories = true
    };
}

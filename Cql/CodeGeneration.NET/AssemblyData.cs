/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.CodeGeneration.NET;

/// <summary>
/// Stores information about a dynamically generated assembly.
/// </summary>
/// <param name="AssemblyBytes">This assembly's binary data.</param>
/// <param name="DebugSymbolsBytes">The assembly's debug symbols in binary data.</param>
public record AssemblyData(
    byte[]? AssemblyBytes,
    byte[]? DebugSymbolsBytes = null)
{
    /// <summary>
    /// An empty instance of <see cref="AssemblyData"/>.
    /// </summary>
    public static AssemblyData Default { get; } = new(null!, null!);
}
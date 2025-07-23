/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.CodeGeneration.NET;

/// <summary>
/// Contains the binary data for an assembly, and optionally its debug symbols.
/// </summary>
/// <param name="AssemblyBytes">This assembly's binary data.</param>
/// <param name="DebugSymbolsBytes">The assembly's debug symbols.</param>
public record AssemblyBinary(
    byte[]? AssemblyBytes,
    byte[]? DebugSymbolsBytes = null)
{
    /// <summary>
    /// An empty instance of <see cref="AssemblyBinary"/>.
    /// </summary>
    public static AssemblyBinary Default { get; } = new(null!, null!);
}
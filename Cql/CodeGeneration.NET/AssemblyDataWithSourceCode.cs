/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System.Collections.Generic;

namespace Hl7.Cql.CodeGeneration.NET;

/// <summary>
/// Stores information about a dynamically generated assembly.
/// </summary>
/// <param name="AssemblyBytes">This assembly's binary data.</param>
/// <param name="SourceCode">The collection of source code files that contributed to this assembly.</param>
/// <param name="DebugSymbolsBytes">The assembly's debug symbols in binary data.</param>
internal record AssemblyDataWithSourceCode(
    byte[] AssemblyBytes,
    IDictionary<string, string> SourceCode,
    byte[]? DebugSymbolsBytes = null) : AssemblyData(AssemblyBytes, DebugSymbolsBytes);
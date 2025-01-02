/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System.Collections.Generic;

namespace Hl7.Cql.CodeGeneration.NET
{
    /// <summary>
    /// Stores information about a dynamically generated assembly.
    /// </summary>
    /// <param name="Binary">This assembly's binary data.</param>
    /// <param name="SourceCode">The collection of source code files that contributed to this assembly.</param>
    /// <param name="DebugSymbols">The assembly's debug symbols in binary data.</param>
    internal record AssemblyData
    (
        byte[] Binary,
        IDictionary<string, string> SourceCode,
        byte[]? DebugSymbols = null)
    {
        public void Deconstruct(out byte[] binary, out IDictionary<string, string> sourceCode)
        {
            binary = Binary;
            sourceCode = SourceCode;
        }
    }
}

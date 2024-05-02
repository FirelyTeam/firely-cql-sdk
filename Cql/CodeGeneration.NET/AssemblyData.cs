/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System.Collections.Generic;
using System.Reflection;

namespace Hl7.Cql.CodeGeneration.NET
{
    /// <summary>
    /// Stores information about a dynamically generated assembly.
    /// </summary>
    internal class AssemblyData
    {
        /// <summary>
        /// Creates an instance.
        /// </summary>
        /// <param name="binary">This assembly's binary data.</param>
        /// <param name="sourceCode">The collection of source code files that contributed to this assembly.</param>
        public AssemblyData(byte[] binary, IDictionary<string, string> sourceCode)
        {
            Binary = binary;
            SourceCode = sourceCode;
        }
        /// <summary>
        /// Gets the binary data for the <see cref="Assembly"/>.
        /// </summary>
        public byte[] Binary { get; }

        /// <summary>
        /// Gets the collection of source code files that contributed to this assembly.
        /// </summary>
        public IDictionary<string, string> SourceCode { get; }
    }
}

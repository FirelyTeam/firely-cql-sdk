using System.Collections.Generic;
using System.IO;

namespace Hl7.Cql.Compiler
{
    /// <summary>
    /// Stores information about a dynamically generated assembly.
    /// </summary>
    public class AssemblyData
    {
        /// <summary>
        /// Creates an instance.
        /// </summary>
        /// <param name="location">The location on disk which this assembly's bytes were written.</param>
        /// <param name="sourceCode">The collection of source code files that contributed to this assembly.</param>
        public AssemblyData(byte[] binary, IDictionary<string,string> sourceCode)
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

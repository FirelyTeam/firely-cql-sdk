using System.Collections.Generic;
using System.IO;

namespace Hl7.Cql.CodeGeneration.NET
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
        public AssemblyData(FileInfo location, IDictionary<string,string> sourceCode)
        {
            Location = location;
            SourceCode = sourceCode;
        }
        /// <summary>
        /// Gets the location on disk which this assembly's bytes were written.
        /// </summary>
        public FileInfo Location { get; }

        /// <summary>
        /// Gets the collection of source code files that contributed to this assembly.
        /// </summary>
        public IDictionary<string, string> SourceCode { get; }
    }
}

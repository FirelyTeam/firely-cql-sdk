using System;
using System.Collections.Generic;
using System.Text;

namespace Ncqa.Cql.Runtime.Primitives
{
    /// <summary>
    /// Implements the System CodeSystem type.
    /// </summary>
    /// <see href="https://cql.hl7.org/09-b-cqlreference.html#codesystem"/>
    [CqlPrimitiveType(CqlPrimitiveType.CodeSystem)]
    public class CqlCodeSystem: CqlVocabulary
    {
        /// <summary>
        /// Creates an instance.
        /// </summary>
        /// <param name="id">The canonical URL of the code system.</param>
        /// <param name="version">The version of the code system.</param>
        public CqlCodeSystem(string? id, string? version): base(id, version)
        {
        }
    }
}

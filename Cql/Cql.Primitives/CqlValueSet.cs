using System;
using System.Collections.Generic;
using System.Text;

namespace Ncqa.Cql.Runtime.Primitives
{
    /// <summary>
    /// Implements the System ValueSet type.
    /// </summary>
    /// <see href="https://cql.hl7.org/09-b-cqlreference.html#valueset"/>
    [CqlPrimitiveType(CqlPrimitiveType.ValueSet)]
    public class CqlValueSet: CqlVocabulary
    {
        /// <summary>
        /// Creates an instance.
        /// </summary>
        /// <param name="id">The canonical URL of the value set.</param>
        /// <param name="version">The version of the value set.</param>
        public CqlValueSet(string? id, string? version): base(id, version)
        {
        }
    }
}

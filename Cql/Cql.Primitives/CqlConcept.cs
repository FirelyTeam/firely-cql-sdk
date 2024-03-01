/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System.Collections.Generic;
using System.Linq;

namespace Hl7.Cql.Primitives
{
    /// <summary>
    /// Implements the System Concept type.
    /// </summary>
    /// <see href="https://cql.hl7.org/09-b-cqlreference.html#concept-1"/>
    [CqlPrimitiveType(CqlPrimitiveType.Concept)]
    public class CqlConcept
    {
        /// <summary>
        /// The codes in this concept.
        /// </summary>
        public CqlCode[]? codes { get; set;  }
        /// <summary>
        /// The display name of this concept.
        /// </summary>
        public string? display { get; set;  }

        /// <summary>
        /// Creates an instance.
        /// </summary>
        /// <param name="codes">The codes in this concept.</param>
        /// <param name="display">The display name of this concept.</param>
        public CqlConcept(IEnumerable<CqlCode> codes, string? display)
        {
            if (codes == null)
                this.codes = new CqlCode[0];
            else
                this.codes = codes.ToArray();
            this.display = display;
        }

        /// <summary>
        /// Creates an instance.
        /// </summary>
        public CqlConcept()
        {
        }

    }
}

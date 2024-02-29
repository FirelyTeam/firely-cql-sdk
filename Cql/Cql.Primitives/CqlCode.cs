/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Primitives
{
    /// <summary>
    /// Implements the System Code type.
    /// </summary>
    /// <see href="https://cql.hl7.org/09-b-cqlreference.html#code-1"/>
    [CqlPrimitiveType(CqlPrimitiveType.Code)]
    public class CqlCode
    {
        /// <summary>
        /// Creates an instance.
        /// </summary>
        /// <remarks>
        /// Be careful about superfluously populating <see cref="version"/> and <see cref="display"/>.
        /// CQL equality semantics check these values for operators like In as well as with value set checks.
        /// </remarks>
        /// <param name="code">The value of the code.</param>
        /// <param name="system">The code system.</param>
        /// <param name="version">The code version.</param>
        /// <param name="display">The display value for this code.</param>
        public CqlCode(string? code, string? system, string? version = null, string? display = null)
        {
            this.code = code;
            this.system = system;
            this.version = version;
            this.display = display;
        }

        /// <summary>
        /// Creates an instance.
        /// </summary>
        public CqlCode()
        {
        }

        /// <summary>
        /// The value of the code.
        /// </summary>
        public string? code { get; set; }
        /// <summary>
        /// The display value for this code.
        /// </summary>
        public string? display { get; set;  }
        /// <summary>
        /// The code system.
        /// </summary>
        public string? system { get; set;  }
        /// <summary>
        /// The code version.
        /// </summary>
        public string? version { get; set; }

    }


}

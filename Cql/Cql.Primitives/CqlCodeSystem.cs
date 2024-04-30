/* 
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Primitives
{
    /// <summary>
    /// Implements the System CodeSystem type.
    /// </summary>
    /// <see href="https://cql.hl7.org/09-b-cqlreference.html#codesystem"/>
    [CqlPrimitiveType(CqlPrimitiveType.CodeSystem)]
    public class CqlCodeSystem : CqlVocabulary
    {
        /// <summary>
        /// Creates an instance.
        /// </summary>
        public CqlCodeSystem()
        {
        }

        /// <summary>
        /// Creates an instance.
        /// </summary>
        /// <param name="id">The canonical URL of the code system.</param>
        /// <param name="version">The version of the code system.</param>
        public CqlCodeSystem(string? id, string? version) : base(id, version)
        {
        }
    }
}

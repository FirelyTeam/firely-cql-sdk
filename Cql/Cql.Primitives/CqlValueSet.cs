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
    /// Implements the System ValueSet type.
    /// </summary>
    /// <see href="https://cql.hl7.org/09-b-cqlreference.html#valueset"/>
    [CqlPrimitiveType(CqlPrimitiveType.ValueSet)]
    public class CqlValueSet : CqlVocabulary
    {

        /// <summary>
        /// Creates an instance.
        /// </summary>
        public CqlValueSet()
        {
        }

        /// <summary>
        /// Creates an instance.
        /// </summary>
        /// <param name="id">The canonical URL of the value set.</param>
        /// <param name="version">The version of the value set.</param>
        public CqlValueSet(string? id, string? version) : base(id, version)
        {
        }
    }
}

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
    /// Implements the System Vocabulary type.
    /// </summary>
    /// <see href="https://cql.hl7.org/09-b-cqlreference.html#vocabulary"/>
    [CqlPrimitiveType(CqlPrimitiveType.Vocabulary)]
    public abstract class CqlVocabulary
    {
        /// <summary>
        /// Constructs a new CqlVocabulary instance
        /// </summary>
        protected CqlVocabulary(string? id, string? version)
        {
            this.id = id;
            this.version = version;
        }


        /// <summary>
        /// Constructs a new CqlVocabulary instance with no id or version.
        /// </summary>
        protected CqlVocabulary() : this(null, null)
        {
            // Nothing
        }

        /// <summary>
        /// The canonical URL of the value set.
        /// </summary>
        public string? id { get; init; }
        /// <summary>
        /// The version of the value set.
        /// </summary>
        public string? version { get; init; }


    }
}

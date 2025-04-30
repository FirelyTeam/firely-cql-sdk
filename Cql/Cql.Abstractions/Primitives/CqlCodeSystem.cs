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
    /// Implements the System CodeSystem type.
    /// </summary>
    /// <param name="id">The canonical URL of the code system.</param>
    /// <param name="version">The version of the code system.</param>
    /// <see href="https://cql.hl7.org/09-b-cqlreference.html#codesystem"/>
    [CqlPrimitiveType(CqlPrimitiveType.CodeSystem)]
    public record CqlCodeSystem(string? id, string? version, IReadOnlyList<CqlCode> codes) : CqlVocabulary(id, version)
    {
        /// <summary>
        /// Initializes a new instance of <see cref="CqlCodeSystem"/>.
        /// </summary>
        /// <param name="id">The canonical URL of the code system.</param>
        /// <param name="version">The version of the code system.</param>
        /// <param name="codes">An array of <see cref="CqlCode"/> representing the codes within the code system.</param>
        public CqlCodeSystem(
            string? id,
            string? version,
            params CqlCode[] codes) : this(id, version, (IReadOnlyList<CqlCode>)codes) {}

        public int Length => codes.Count;
        public int Count() => codes.Count;
        public CqlCode First() => codes.First();
    }
}

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
    /// Represents a CQL Vocabulary, which is a named collection of concepts and codes
    /// used to define the semantics of data elements in Clinical Quality Language (CQL).
    /// </summary>
    /// <param name="id">The canonical URL of the vocabulary instance, uniquely identifying it.</param>
    /// <param name="version">The version of the vocabulary instance, which may be null if unspecified.</param>
    /// <remarks>
    /// The <see cref="CqlVocabulary"/> type is defined as a primitive type in CQL, representing
    /// the System Vocabulary type as described in the CQL specification.
    /// </remarks>
    /// <see href="https://cql.hl7.org/09-b-cqlreference.html#vocabulary"/>
    [CqlPrimitiveType(CqlPrimitiveType.Vocabulary)]
    public abstract record CqlVocabulary(string id, string? version);
}

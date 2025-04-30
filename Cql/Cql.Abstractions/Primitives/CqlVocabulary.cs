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
    /// <param name="id">The canonical URL of the instance.</param>
    /// <param name="id">The version of the instance.</param>
    /// <param name="version"></param>
    /// <see href="https://cql.hl7.org/09-b-cqlreference.html#vocabulary"/>
    [CqlPrimitiveType(CqlPrimitiveType.Vocabulary)]
    public abstract record CqlVocabulary(string? id, string? version);
}

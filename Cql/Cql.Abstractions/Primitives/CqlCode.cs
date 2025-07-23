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
    /// <remarks>
    /// Be careful about superfluously populating <see cref="version"/> and <see cref="display"/>.
    /// CQL equality semantics check these values for operators like In as well as with value set checks.
    /// </remarks>
    /// <param name="code">The value of the code.</param>
    /// <param name="system">The code system.</param>
    /// <param name="version">The code version.</param>
    /// <param name="display">The display value for this code.</param>
    /// <see href="https://cql.hl7.org/09-b-cqlreference.html#code-1"/>
    [CqlPrimitiveType(CqlPrimitiveType.Code)]
    public record CqlCode(string? code = null, string? system = null, string? version = null, string? display = null);
}

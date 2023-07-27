/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

using Hl7.Cql.Primitives;
using System.Collections.Generic;

namespace Hl7.Cql.ValueSets
{
    /// <summary>
    /// Acts as a facade for <see cref="IEnumerable{Code}"/> which remembers that this sequence
    /// is from a value set, enabling implementations to use optimized code-in-valueset checks.
    /// </summary>
    /// <remarks>Care should be taken to implement these functions performantly, including using the enumerator.</remarks>
    public interface IValueSetFacade : IEnumerable<CqlCode>
    {
        /// <summary>
        /// Returns <see langword="true"/> if <paramref name="code"/> is in this value set, regardless of system.
        /// </summary>
        /// <param name="code">The code to check.</param>
        /// <returns><see langword="true"/> if the code is in this value set.</returns>
        bool IsCodeInValueSet(string code);

        /// <summary>
        /// Returns <see langword="true"/> if there is a CqlCode with both <paramref name="code"/> 
        /// and <paramref name="system"/> in this value set using equivalence for Cql codes.
        /// </summary>
        bool IsCodeInValueSet(string code, string? system);

        /// <summary>
        /// Returns <see langword="true"/> if <paramref name="code"/> is in this value set, based on 
        /// equality as defined for the Cql Code datatype.
        /// </summary>
        bool IsCodeInValueSet(CqlCode code);
    }
}

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
    /// is from a value set, enabling implementations to use <see cref="IsCodeInValueSet(CqlCode?)"/>
    /// for optimized code-in-valueset checks.
    /// </summary>
    /// <remarks>Care should be taken to implement these functions performantly, including using the enumerator.</remarks>
    public interface IValueSetFacade : IEnumerable<CqlCode>
    {
        /// <summary>
        /// Returns <see langword="true"/> if <paramref name="code"/> is in this value set.
        /// </summary>
        /// <param name="code">The code to check.</param>
        /// <returns><see langword="true"/> if <paramref name="code"/> is in this value set, or <see langword="null"/> if <paramref name="code"/> is <see langword="null"/>.</returns>
        bool? IsCodeInValueSet(CqlCode? code);

        /// <summary>
        /// Returns <see langword="true"/> if <paramref name="code"/> is in this value set.
        /// </summary>
        /// <param name="code">The code to check.</param>
        /// <param name="system">The code system to check.</param>
        /// <returns><see langword="true"/> if the code is in this value set.</returns>
        bool? IsCodeInValueSet(string? code, string? system);
    }
}

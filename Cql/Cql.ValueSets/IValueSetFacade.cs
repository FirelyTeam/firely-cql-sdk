using Ncqa.Cql.Runtime.Primitives;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ncqa.Cql.ValueSets
{
    /// <summary>
    /// Acts as a facade for <see cref="IEnumerable{Code}"/> which remembers that this sequence
    /// is from a value set, enabling implementations to use <see cref="IsCodeInValueSet(CqlCode?)"/>
    /// for optimized code-in-valueset checks.
    /// </summary>
    public interface IValueSetFacade: IEnumerable<CqlCode>
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

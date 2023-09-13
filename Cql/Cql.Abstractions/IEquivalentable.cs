/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System;

namespace Hl7.Cql.Abstractions
{
    /// <summary>
    /// <para>Defines a generalized type-specific comparison method that a value type or class implements to order or sort its instances.</para>
    /// <para>This interface differs from <see cref="IComparable{T}"/> because it includes a precision parameter in its <see cref="IComparable.CompareTo(object?)"/> method.</para>
    /// <para>Where <see cref="ICqlComparable{T}"/> uses CQL equality semantics, this interface implements equivalence semantics.</para>
    /// </summary>
    /// <typeparam name="T">
    /// The type of object to compare.
    /// </typeparam>
    public interface IEquivalentable<T>
        where T : class
    {
        /// <summary>
        /// Compares this object to <paramref name="other"/> for equivalence.
        /// </summary>
        /// <param name="other">The object to compare.</param>
        /// <param name="precision">The precision to use in this comparison, or <see langword="null"/>.</param>
        /// <returns><see langword="true"/> if this object is equivalent to <paramref name="other"/>, else <see langword="false"/>.</returns>
        bool Equivalent(T? other, string? precision);

    }
}

/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Abstractions
{
    /// <summary>
    /// Defines a method that a type implements to compare two objects for equivalence.
    /// See https://cql.hl7.org/09-b-cqlreference.html#equivalent.
    /// </summary>
    public interface IEquivalenceComparer
    {
        /// <summary>
        /// Compares two objects for equivalence.
        /// </summary>
        /// <param name="x">The first object to compare.</param>
        /// <param name="y">The second object to compare.</param>
        /// <param name="precision">The precision to use in this comparison, or <see langword="null"/>.</param>
        /// <returns><see langword="true"/> if the objects are equivalent, and <see langword="false"/> if not. Equivalence computations are never <see langword="null"/> and will return <see langword="false"/> in uncertainty situations.</returns>
        bool Equivalent(object? x, object? y, string? precision);
    }
    /// <summary>
    /// Defines a method that a type implements to compare two objects for equivalence.
    /// See https://cql.hl7.org/09-b-cqlreference.html#equivalent.
    /// </summary>
    /// <typeparam name="T">
    /// The type of object to compare.
    /// </typeparam>
    public interface IEquivalenceComparer<in T>
    {
        /// <summary>
        /// Compares two objects for equivalence.
        /// </summary>
        /// <param name="x">The first object to compare.</param>
        /// <param name="y">The second object to compare.</param>
        /// <param name="precision">The precision to use in this comparison, or <see langword="null"/>.</param>
        /// <returns><see langword="true"/> if the objects are equivalent, and <see langword="false"/> if not.  Equivalence computations are never <see langword="null"/> and will return <see langword="false"/> in uncertainty situations.</returns>
        bool Equivalent(T x, T y, string? precision);
    }
}

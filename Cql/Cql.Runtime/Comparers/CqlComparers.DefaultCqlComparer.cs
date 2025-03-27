/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;

namespace Hl7.Cql.Comparers;

partial class CqlComparers
{
    /// <summary>
    /// Implements comparison through <see cref="Comparer{T}.Default"/>.
    /// </summary>
    /// <typeparam name="T">The type to compare.</typeparam>
    private class DefaultCqlComparer<T> : ICqlComparer<T>
    {
        /// <inheritdoc />
        public int? Compare(T? x, T? y, string? precision = null) => Comparer<T>.Default.Compare(x, y);

        /// <inheritdoc />
        public bool? Equals(T? x, T? y, string? precision = null) => Comparer<T>.Default.Compare(x, y) == 0;

        /// <inheritdoc />
        public bool Equivalent(T? x, T? y, string? precision = null) =>
            EquivalentOnNullsOnly(x, y)
            ?? Compare(x, y, precision) == 0;

        /// <inheritdoc />
        public int GetHashCode(T? x) =>
            x is null
                ? typeof(T).GetHashCode()
                : EqualityComparer<T>.Default.GetHashCode(x);
    }
}

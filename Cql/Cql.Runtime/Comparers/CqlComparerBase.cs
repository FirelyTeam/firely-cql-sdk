/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;

namespace Hl7.Cql.Comparers
{
    /// <summary>
    /// Implements base functionality for <see cref="ICqlComparer"/> and <see cref="IEquivalenceComparer"/>.
    /// </summary>
    /// <typeparam name="T">The type to compare.</typeparam>
    internal abstract class CqlComparerBase<T> :
        ICqlComparer<T>, ICqlComparer/*,
        IEquivalenceComparer<T>, IEquivalenceComparer
        where T : class*/
    {

        /// <inheritdoc />
        public abstract int? Compare(T? x, T? y, string? precision);

        /// <inheritdoc />
        public bool Equivalent(T? x, T? y, string? precision) =>
            CqlComparers.EquivalentOnNullsOnly(x, y)
            ?? EquivalentImpl(x!, y!, precision);

        protected abstract bool EquivalentImpl(T x, T y, string? precision);

        /// <inheritdoc />
        public virtual bool? Equals(T? x, T? y, string? precision)
        {
            bool? res = Compare(x, y, precision) switch
            {
                null  => null,
                var r => r == 0
            };
            return res;
        }

        /// <inheritdoc />
        public int? Compare(object? x, object? y, string? precision) => Compare((T?)x, (T?)y, precision);

        /// <inheritdoc />
        public bool? Equals(object? x, object? y, string? precision) => Equals((T?)x, (T?)y, precision);

        /// <inheritdoc />
        public bool Equivalent(object? x, object? y, string? precision) => Equivalent((T?)x, (T?)y, precision);

        /// <inheritdoc />
        public abstract int GetHashCode(T? x);

        /// <inheritdoc />
        public int GetHashCode(object? x) => GetHashCode((T?)x);
    }
}

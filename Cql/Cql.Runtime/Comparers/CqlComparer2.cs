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
    /*/// <summary>
    /// Base type to implement CQL comparison
    /// </summary>
    /// <typeparam name="T">The type to compare.</typeparam>
    internal abstract class CqlComparerBase<T> :
        ICqlComparer<T>
    {
        /// <inheritdoc />
        public abstract int? Compare(T? left, T? right, string? precision);

        /// <inheritdoc />
        public bool Equivalent(T? left, T? right, string? precision) =>
            EquivalentOnNullsOnly(left, right)
            ?? EquivalentImpl(left!, right!, precision);

        protected abstract bool EquivalentImpl(T x, T y, string? precision);

        /// <inheritdoc />
        public virtual bool? Equals(T? left, T? right, string? precision)
        {
            bool? result = Compare(left, right, precision) switch
            {
                null  => null,
                var r => r == 0
            };
            return result;
        }

        /// <inheritdoc />
        public abstract int GetHashCode(T? value);
    }*/
}

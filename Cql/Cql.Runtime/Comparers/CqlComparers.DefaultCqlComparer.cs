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
    private class DefaultCqlComparer<T> : CqlComparerNew<T>
    {
        /// <inheritdoc />
        public override int? Compare(T? left, T? right, string? precision = null) => Comparer<T>.Default.Compare(left, right);

        /// <inheritdoc />
        public override bool? Equals(T? left, T? right, string? precision = null) => Comparer<T>.Default.Compare(left, right) == 0;

        /// <inheritdoc />
        public override bool Equivalent(T? left, T? right, string? precision = null) =>
            EquivalentOnNullsOnly(left, right)
            ?? Compare(left, right, precision) == 0;

        protected override int GetHashCodeValue([DisallowNull] T value)
        {
            var hash = EqualityComparer<T>.Default.GetHashCode(value);
            var hash2 = value.GetHashCode();
            Trace.Assert(hash == hash2);
            return hash;
        }

        // /// <inheritdoc />
        // public int GetHashCode(T? value) =>
        //     value is null
        //         ? typeof(T).GetHashCode()
        //         : EqualityComparer<T>.Default.GetHashCode(value);
    }
}

/*
 * Copyright (c) 2023, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Comparers;

partial class CqlComparers
{
    /// <summary>
    /// Implements comparison through <see cref="Comparer{T}.Default"/>.
    /// </summary>
    /// <typeparam name="T">The type to compare.</typeparam>
    private class DefaultCqlComparer<T>() : CqlComparer<T>(
        equivalentMethod: CqlComparerEquivalentMethod.Compare)
    {
        /// <inheritdoc />
        public override int? Compare(T? left, T? right, string? precision) =>
            Comparer<T>.Default.Compare(left, right);

        /// <inheritdoc />
        public override bool? Equals(T? left, T? right, string? precision) =>
            Comparer<T>.Default.Compare(left, right) == 0;

        protected override int GetHashCodeValue([DisallowNull] T value) =>
            EqualityComparer<T>.Default.GetHashCode(value);
    }
}

/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;

namespace Hl7.Cql.Comparers;

partial class CqlComparers
{
    internal class KeyValuePairComparer<TKey, TValue>(ICqlComparer<object> cqlComparer) : CqlComparer<KeyValuePair<TKey, TValue>> 
    {
        /// <inheritdoc />
        protected override int? CompareValues(
            KeyValuePair<TKey, TValue> left,
            KeyValuePair<TKey, TValue> right,
            string? precision) =>
            cqlComparer.Compare(left.Key, right.Key, precision) switch
            {
                0     => cqlComparer.Compare(left.Value, right.Value, precision),
                var i => i
            };

        /// <inheritdoc />
        protected override bool? EqualsValues(
            KeyValuePair<TKey, TValue> left,
            KeyValuePair<TKey, TValue> right,
            string? precision) =>
            cqlComparer.Equals(left.Key, right.Key, precision) switch
            {
                true  => cqlComparer.Equals(left.Value, right.Value, precision),
                var b => b
            };

        /// <inheritdoc />
        protected override bool EquivalentValues(
            KeyValuePair<TKey, TValue> left,
            KeyValuePair<TKey, TValue> right,
            string? precision) =>
            EquivalentOnNullsOnly(left, right)
            ?? Compare(left, right, precision) == 0;

        /// <inheritdoc />
        protected override int GetHashCodeValue(KeyValuePair<TKey, TValue> value) =>
            HashCode.Combine(
                cqlComparer.GetHashCode(value.Key),
                cqlComparer.GetHashCode(value.Value));
    }
}
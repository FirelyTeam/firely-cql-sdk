/*
 * Copyright (c) 2024, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Comparers;

partial class CqlComparers
{
    internal class KeyValuePairComparer<TKey, TValue>(CqlComparers keyValueComparer) :
        CqlComparer<KeyValuePair<TKey, TValue>>
    {
        /// <inheritdoc />
        protected internal override int? CompareValues(
            KeyValuePair<TKey, TValue> left,
            KeyValuePair<TKey, TValue> right,
            string? precision) =>
            keyValueComparer.Compare(left.Key, right.Key, precision) switch
            {
                0     => keyValueComparer.Compare(left.Value, right.Value, precision),
                var i => i
            };

        /// <inheritdoc />
        protected override bool? EqualsValues(
            KeyValuePair<TKey, TValue> left,
            KeyValuePair<TKey, TValue> right,
            string? precision) =>
            keyValueComparer.Equals(left.Key, right.Key, precision) switch
            {
                true  => keyValueComparer.Equals(left.Value, right.Value, precision),
                var b => b
            };

        /// <inheritdoc />
        protected override bool EquivalentValues(
            KeyValuePair<TKey, TValue> left,
            KeyValuePair<TKey, TValue> right,
            string? precision) =>
            keyValueComparer.Equivalent(left.Key, right.Key, precision) switch
            {
                true     => keyValueComparer.Equivalent(left.Value, right.Value, precision),
                var b => b
            };

        /// <inheritdoc />
        protected override int GetHashCodeValue(KeyValuePair<TKey, TValue> value) =>
            HashCode.Combine(
                keyValueComparer.GetHashCode(value.Key),
                keyValueComparer.GetHashCode(value.Value));
    }
}
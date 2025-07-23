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
    private class KeyValuePairCqlComparer<TKey, TValue>(CqlComparers keyValueComparer) :
        CqlComparer<KeyValuePair<TKey, TValue>>
    {
        /// <inheritdoc />
        protected override int? CompareValues(
            KeyValuePair<TKey, TValue> x,
            KeyValuePair<TKey, TValue> y,
            string? precision) =>
            keyValueComparer.Compare(x.Key, y.Key, precision) switch
            {
                0     => keyValueComparer.Compare(x.Value, y.Value, precision),
                var i => i
            };

        /// <inheritdoc />
        protected override bool? EqualsValues(
            KeyValuePair<TKey, TValue> x,
            KeyValuePair<TKey, TValue> y,
            string? precision) =>
            keyValueComparer.Equals(x.Key, y.Key, precision) switch
            {
                true  => keyValueComparer.Equals(x.Value, y.Value, precision),
                var b => b
            };

        /// <inheritdoc />
        protected override bool EquivalentValues(
            KeyValuePair<TKey, TValue> x,
            KeyValuePair<TKey, TValue> y,
            string? precision) =>
            keyValueComparer.Equivalent(x.Key, y.Key, precision) switch
            {
                true  => keyValueComparer.Equivalent(x.Value, y.Value, precision),
                var b => b
            };

        /// <inheritdoc />
        protected override int GetHashCodeValue(KeyValuePair<TKey, TValue> value) =>
            HashCode.Combine(
                keyValueComparer.GetHashCode(value.Key),
                keyValueComparer.GetHashCode(value.Value));
    }

}
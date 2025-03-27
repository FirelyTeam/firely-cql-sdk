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
    private class CharCqlComparer(ICqlComparer<string> stringCqlComparer) : CqlComparerNew<char?>
    {
        private ICqlComparer<string> StringCqlComparer { get; } = stringCqlComparer ?? throw new ArgumentNullException(nameof(stringCqlComparer));

        private static string? CharToString(char? c) => c?.ToString();

        protected override int? CompareValues(
            [DisallowNull] char? left,
            [DisallowNull] char? right,
            string? precision)
        {
            return StringCqlComparer.CompareValues(left.Value.ToString(), right.Value.ToString(), precision);
        }

        // public int? Compare(
        //     char? left,
        //     char? right,
        //     string? precision = null) =>
        //     StringCqlComparer.Compare(CharToString(left), CharToString(right), precision);

        protected override bool? EqualsValues(
            [DisallowNull] char? left,
            [DisallowNull] char? right,
            string? precision)
        {
            return StringCqlComparer.EqualsValues(left.Value.ToString(), right.Value.ToString(), precision);
        }

        // public bool? Equals(
        //     char? left,
        //     char? right,
        //     string? precision = null) =>
        //     StringCqlComparer.Equals(CharToString(left), CharToString(right), precision);

        protected override bool EquivalentValues(
            [DisallowNull] char? left,
            [DisallowNull] char? right,
            string? precision)
        {
            return StringCqlComparer.EquivalentValues(left.Value.ToString(), right.Value.ToString(), precision);
        }

        // public bool Equivalent(
        //     char? left,
        //     char? right,
        //     string? precision = null) =>
        //     StringCqlComparer.Equivalent(CharToString(left), CharToString(right), precision);

        protected override int GetHashCodeValue([DisallowNull] char? value)
        {
            return StringCqlComparer.GetHashCodeValue(value.Value.ToString());
        }

        // public int GetHashCode(char? value) =>
        //     StringCqlComparer.GetHashCode(CharToString(value));
    }
}
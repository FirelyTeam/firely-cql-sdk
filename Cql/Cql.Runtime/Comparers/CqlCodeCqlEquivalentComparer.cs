/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using Hl7.Cql.Primitives;

namespace Hl7.Cql.Comparers
{
    /** CQL CODE COMPARER **/

    internal class CqlCodeCqlEquivalentComparer(
        IComparer<string> codeComparer) : ICqlComparer<CqlCode>, ICqlComparer
    {
        private IComparer<string> CqlCodeCodeComparer { get; } = codeComparer ?? throw new ArgumentNullException(nameof(codeComparer));
        private static readonly StringComparer CqlCodeSystemComparer = StringComparer.OrdinalIgnoreCase;

        public int? Compare(CqlCode? x, CqlCode? y, string? precision) =>
            CqlComparerMethods.CqlCodeCompare(x, y, CqlCodeCodeComparer, CqlCodeSystemComparer);

        public int? Compare(object? x, object? y, string? precision) =>
            CqlComparerMethods.CqlCodeCompare(x as CqlCode, y as CqlCode, CqlCodeCodeComparer, CqlCodeSystemComparer);

        public bool? Equals(CqlCode? x, CqlCode? y, string? precision) =>
            CqlComparerMethods.CqlCodeCompare(x, y, CqlCodeCodeComparer, CqlCodeSystemComparer) == 0;

        public bool? Equals(object? x, object? y, string? precision) =>
            CqlComparerMethods.CqlCodeCompare(x as CqlCode, y as CqlCode, CqlCodeCodeComparer, CqlCodeSystemComparer) == 0;

        public bool Equivalent(CqlCode? x, CqlCode? y, string? precision) =>
            CqlComparerMethods.CqlCodeCompare(x, y, CqlCodeCodeComparer, CqlCodeSystemComparer) == 0;

        public bool Equivalent(object? x, object? y, string? precision) =>
            CqlComparerMethods.CqlCodeCompare(x as CqlCode, y as CqlCode, CqlCodeCodeComparer, CqlCodeSystemComparer) == 0;

        public int GetHashCode(CqlCode? x) =>
            CqlComparerMethods.CqlCodeGetHashCode(x);

        public int GetHashCode(object? x) =>
            CqlComparerMethods.CqlCodeGetHashCode(x as CqlCode);
    }
}

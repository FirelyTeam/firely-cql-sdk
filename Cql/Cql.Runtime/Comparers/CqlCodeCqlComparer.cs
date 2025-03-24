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

    internal class CqlCodeCqlComparer(
        IComparer<string>? codeComparer = null) :
        ICqlComparer<CqlCode>,
        ICqlComparer
    {
        public static CqlCodeCqlComparer Default { get; } = new(StringComparer.OrdinalIgnoreCase);

        private static readonly StringComparer CqlCodeSystemComparer = StringComparer.OrdinalIgnoreCase;
        private static readonly StringComparer CqlCodeVersionComparer = StringComparer.OrdinalIgnoreCase;
        private static readonly StringComparer CqlCodeDisplayComparer = StringComparer.OrdinalIgnoreCase;

        private IComparer<string> CqlCodeCodeComparer { get; } = codeComparer ?? StringComparer.OrdinalIgnoreCase;

        public int? Compare(CqlCode? x, CqlCode? y, string? precision) =>
            CqlComparerMethods.CqlCodeCompare(x, y, CqlCodeCodeComparer, CqlCodeSystemComparer, CqlCodeVersionComparer, CqlCodeDisplayComparer);

        public int? Compare(object? x, object? y, string? precision) =>
            CqlComparerMethods.CqlCodeCompare(x as CqlCode, y as CqlCode, CqlCodeCodeComparer, CqlCodeSystemComparer, CqlCodeVersionComparer, CqlCodeDisplayComparer);

        public bool? Equals(CqlCode? x, CqlCode? y, string? precision) =>
            CqlComparerMethods.CqlCodeCompare(x, y, CqlCodeCodeComparer, CqlCodeSystemComparer, CqlCodeVersionComparer, CqlCodeDisplayComparer) == 0;

        public bool? Equals(object? x, object? y, string? precision) =>
            CqlComparerMethods.CqlCodeCompare(x as CqlCode, y as CqlCode, CqlCodeCodeComparer, CqlCodeSystemComparer, CqlCodeVersionComparer, CqlCodeDisplayComparer) == 0;

        public bool Equivalent(CqlCode? x, CqlCode? y, string? precision) =>
            CqlComparerMethods.CqlCodeCompare(x, y, CqlCodeCodeComparer, CqlCodeSystemComparer) == 0;

        public bool Equivalent(object? x, object? y, string? precision) =>
            CqlComparerMethods.CqlCodeCompare(x as CqlCode, y as CqlCode, CqlCodeCodeComparer, CqlCodeSystemComparer) == 0;

        public int GetHashCode(CqlCode? x) =>
            CqlComparerMethods.CqlCodeGetHashCode(x, true);

        public int GetHashCode(object? x) =>
            CqlComparerMethods.CqlCodeGetHashCode(x as CqlCode, true);

        private readonly ConcurrentDictionary<(string? precision, bool useEquivalence), IEqualityComparer<CqlCode>> _equalityComparerCache = new();
    }
}
/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Comparers;

internal static class CqlComparerSharedMethods
{
    public static bool CqlComparisonToEquivalence(int? cqlComparisonResult) => cqlComparisonResult is null or 0;

    public static int? CompareTemporalIntegers(int? x, int? y) =>
        x is null || y is null
            ? null
            : Math.Sign(x.Value - y.Value);

    public static bool CqlEqualityToEquivalence(bool? cqlEqualsResult) => cqlEqualsResult is null or true;

    public static bool? CqlComparisonToEquals(int? compareValues) =>
        compareValues switch
        {
            null => null,
            0    => true,
            _    => false,
        };
}
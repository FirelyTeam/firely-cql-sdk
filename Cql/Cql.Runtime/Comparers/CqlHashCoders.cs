/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Comparers;
using Hl7.Cql.Primitives;
using static System.StringComparer;

internal static class CqlHashCoders
{
    private static readonly int NullHashCode = OrdinalIgnoreCase.GetHashCode("\0");

    public static int CombineHashCodes(int h1, int h2) =>
        //((h1 << 5) + h1) ^ h2;
        HashCode.Combine(h1, h2);

    internal static int GetCqlCodeHashCode(CqlCode? x) =>
        x == null
            ? typeof(CqlCode).GetHashCode()
            : CombineHashCodes(
                x.code is null ? NullHashCode : OrdinalIgnoreCase.GetHashCode(x.code),
                x.system is null ? NullHashCode : OrdinalIgnoreCase.GetHashCode(x.system));
}
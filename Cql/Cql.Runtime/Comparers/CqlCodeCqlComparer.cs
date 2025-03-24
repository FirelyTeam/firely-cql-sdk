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
    internal interface ICqlCodeComparer : ICqlComparer
    {
        CqlCodePrecision Precision { get; }
    }

    internal class CqlCodeCqlComparer :
        ICqlComparer<CqlCode>,
        ICqlComparer,
        ICqlCodeComparer
    {
        private CqlCodeCqlComparer(
            CqlCodePrecision precision = CqlCodePrecision.CodeAndSystem)
        {
            Precision = precision;
        }

        public static CqlCodeCqlComparer ForPrecision(CqlCodePrecision precision) =>
            precision switch
            {
                CqlCodePrecision.Code => Code,
                CqlCodePrecision.CodeAndSystem => CodeAndSystem,
                CqlCodePrecision.CodeSystemAndVersion => CodeSystemAndVersion,
                _ => throw new ArgumentOutOfRangeException(nameof(precision), precision, null)
            };

        public static CqlCodeCqlComparer Code { get; } = new(CqlCodePrecision.Code);
        public static CqlCodeCqlComparer CodeAndSystem { get; } = new(CqlCodePrecision.CodeAndSystem);
        public static CqlCodeCqlComparer CodeSystemAndVersion { get; } = new(CqlCodePrecision.CodeSystemAndVersion);

        public CqlCodePrecision Precision { get; }

        public int? Compare(CqlCode? x, CqlCode? y, string? precision) =>
            CqlComparerMethods.CqlCodeCompare(x, y, Precision);

        public int? Compare(object? x, object? y, string? precision) =>
            CqlComparerMethods.CqlCodeCompare(x as CqlCode, y as CqlCode, Precision);

        public bool? Equals(CqlCode? x, CqlCode? y, string? precision) =>
            CqlComparerMethods.CqlCodeCompare(x, y, Precision) == 0;

        public bool? Equals(object? x, object? y, string? precision) =>
            CqlComparerMethods.CqlCodeCompare(x as CqlCode, y as CqlCode, Precision) == 0;

        public bool Equivalent(CqlCode? x, CqlCode? y, string? precision) =>
            CqlComparerMethods.CqlCodeCompare(x, y, Precision) == 0;

        public bool Equivalent(object? x, object? y, string? precision) =>
            CqlComparerMethods.CqlCodeCompare(x as CqlCode, y as CqlCode, Precision) == 0;

        public int GetHashCode(CqlCode? x) =>
            CqlComparerMethods.CqlCodeGetHashCode(x, Precision);

        public int GetHashCode(object? x) =>
            CqlComparerMethods.CqlCodeGetHashCode(x as CqlCode, Precision);
    }
}
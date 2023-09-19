#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using Hl7.Cql.Primitives;
using System.Linq;

namespace Hl7.Cql.Comparers
{
    /// <summary>
    /// Compares the code and system using the specified comparers.
    /// </summary>
    internal class CqlConceptCqlComparer : ICqlComparer<CqlConcept>, ICqlComparer
    {
        public CqlConceptCqlComparer(ICqlComparer codeComparer)
        {
            CodeComparer = codeComparer;
        }

        public ICqlComparer CodeComparer { get; }

        public int? Compare(object? x, object? y, string? precision = null) => Compare(x as CqlConcept, y as CqlConcept, precision);
        public int? Compare(CqlConcept? x, CqlConcept? y, string? precision = null)
        {
            if (x == null || y == null || x.codes == null || y.codes == null)
                return null;
            var xCodes = x.codes.OrderBy(code => code.code)
                .ToArray();
            var yCodes = y.codes.OrderBy(code => code.code)
                .ToArray();
            if (xCodes.Length != yCodes.Length)
                return xCodes.Length - yCodes.Length;
            for (int i = 0; i < xCodes.Length; i++)
            {
                var xCode = xCodes[i];
                var yCode = yCodes[i];
                var compare = CodeComparer.Compare(xCode, yCode, precision);
                if (compare != 0)
                    return compare;
            }
            return 0;
        }

        public bool? Equals(object? x, object? y, string? precision = null) =>
            Equals(x as CqlConcept, y as CqlConcept, precision);

        public bool? Equals(CqlConcept? x, CqlConcept? y, string? precision = null)
        {
            if (x == null || y == null)
                return null;
            else return Compare(x, y, precision) == 0;
        }

        public bool Equivalent(CqlConcept? x, CqlConcept? y, string? precision = null)
        {
            if (x == null || y == null || x.codes == null || y.codes == null)
                return false;
            var xCodes = x.codes.Select(code => code.code)
                .ToArray();
            var yCodes = y.codes.Select(code => code.code)
                .ToArray();

            for (int i = 0; i < xCodes.Length; i++)
            {
                var xCode = xCodes[i];
                var yCode = yCodes[i];
                var equivalent = CodeComparer.Equivalent(xCode, yCode, precision);
                if (equivalent)
                    return true;
            }
            return false;
        }

        public bool Equivalent(object? x, object? y, string? precision = null) =>
             Equivalent(x as CqlConcept, y as CqlConcept, precision);

        public int GetHashCode(CqlConcept? x)
        {
            int baseCode = typeof(CqlConcept).GetHashCode();
            if (x == null || x.codes == null)
                return baseCode;
            foreach (var code in x.codes)
            {
                var codeHashCode = CodeComparer.GetHashCode(code);
                baseCode ^= codeHashCode;
            }
            return baseCode;
        }
        public int GetHashCode(object? x) => GetHashCode(x as CqlConcept);

    }
}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
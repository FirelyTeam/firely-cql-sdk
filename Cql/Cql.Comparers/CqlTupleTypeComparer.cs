/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */


using Hl7.Cql.Abstractions;
using System.Runtime.CompilerServices;
using Hl7.Cql.Primitives;

namespace Hl7.Cql.Comparers
{
    internal class CqlTupleTypeComparer(ICqlComparer memberComparer) : ICqlComparer<ITuple?>, ICqlComparer
    {
        private static readonly int FallbackHashCode = typeof(ITuple).GetHashCode() ^ 098174506;

        public int? Compare(ITuple? x, ITuple? y, string? precision = null)
        {
            if (x == null || y == null)
                return null;

            // Check the "type" via the metadata
            if (x.Length == 0 || x.Length != y.Length)
                return null;

            var xMetadata = x[0] as CqlTupleMetadata;
            var yMetadata = y[0] as CqlTupleMetadata;
            if (xMetadata == null || xMetadata != yMetadata)
                return null;

            // Compare the items on the tuple
            for (int i = 1; i < x.Length; i++)
            {
                var compare = memberComparer.Compare(x[i], y[i], precision);
                if (compare is null or not 0)
                    return compare;
            }

            return 0;
        }

        public int GetHashCode(ITuple? obj) =>
            obj?.GetHashCode() ?? FallbackHashCode;

        public bool? Equals(ITuple? x, ITuple? y, string? precision = null) =>
            Compare(x, y, precision) == 0;

        public bool Equivalent(ITuple? x, ITuple? y, string? precision = null)
        {
            if (CqlComparers.EquivalentOnNullsOnly(x, y) is { } r)
                return r;

            // Check the "type" via the metadata
            if (x!.Length == 0 || x.Length != y!.Length)
                return false;

            var xMetadata = x[0] as CqlTupleMetadata;
            var yMetadata = y[0] as CqlTupleMetadata;
            if (xMetadata == null || xMetadata != yMetadata)
                return false;

            // Compare the items on the tuple
            for (int i = 1; i < x.Length; i++)
            {
                var equivalent = memberComparer.Equivalent(x[i], y[i], precision);
                if (!equivalent)
                    return false;
            }

            return true;
        }

        int? ICqlComparer.Compare(object? x, object? y, string? precision) =>
            Compare(x as ITuple, y as ITuple, precision);

        bool? ICqlComparer.Equals(object? x, object? y, string? precision) =>
            Equals(x as ITuple, y as ITuple, precision);

        bool IEquivalenceComparer.Equivalent(object? x, object? y, string? precision) =>
            Equivalent(x as ITuple, y as ITuple, precision);

        int ICqlComparer.GetHashCode(object? obj) =>
            GetHashCode(obj as ITuple);
    }
}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

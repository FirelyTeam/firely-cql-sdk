/*
 * Copyright (c) 2023, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */


using Hl7.Cql.Primitives;

namespace Hl7.Cql.Comparers;

partial class CqlComparers
{
    private class CqlTupleTypeComparer(CqlComparers memberComparer) :
        CqlComparer<ITuple?>(CqlComparerEqualsMethod.Compare, CqlComparerNullComparisonStrategy.EitherNullReturnsNull)
    {
        protected internal override int? CompareValues(
            ITuple x,
            ITuple y,
            string? precision)
        {
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

        protected override bool EquivalentValues(
            ITuple x,
            ITuple y,
            string? precision)
        {
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
    }
}

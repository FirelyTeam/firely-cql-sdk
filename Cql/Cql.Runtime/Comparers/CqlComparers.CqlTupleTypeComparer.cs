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
            ITuple left,
            ITuple right,
            string? precision)
        {
            // Check the "type" via the metadata
            if (left.Length == 0 || left.Length != right.Length)
                return null;

            var xMetadata = left[0] as CqlTupleMetadata;
            var yMetadata = right[0] as CqlTupleMetadata;
            if (xMetadata == null || xMetadata != yMetadata)
                return null;

            // Compare the items on the tuple
            for (int i = 1; i < left.Length; i++)
            {
                var compare = memberComparer.Compare(left[i], right[i], precision);
                if (compare is null or not 0)
                    return compare;
            }

            return 0;
        }

        protected internal override bool EquivalentValues(
            ITuple left,
            ITuple right,
            string? precision)
        {
            // Check the "type" via the metadata
            if (left!.Length == 0 || left.Length != right!.Length)
                return false;

            var xMetadata = left[0] as CqlTupleMetadata;
            var yMetadata = right[0] as CqlTupleMetadata;
            if (xMetadata == null || xMetadata != yMetadata)
                return false;

            // Compare the items on the tuple
            for (int i = 1; i < left.Length; i++)
            {
                var equivalent = memberComparer.Equivalent(left[i], right[i], precision);
                if (!equivalent)
                    return false;
            }

            return true;
        }
    }
}

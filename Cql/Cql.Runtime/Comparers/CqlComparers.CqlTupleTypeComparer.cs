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
        CqlComparer<ITuple?>(CqlComparerEqualsImplementation.Compare)
    {
        protected override int? CompareValues(
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

            // Tuple equality is a conjunction (three-valued AND) of element comparisons.
            // CQL spec: equality returns true if and only if the tuples are of the same type,
            // and the values for all elements that have values, by name, are equal,
            // defined as a conjunction of equality comparisons.
            // In three-valued logic: false AND null = false, null AND true = null.
            // Handle null elements explicitly because memberComparer.Compare uses ordering
            // semantics (null < non-null = -1) whereas equality requires null propagation.
            bool hasNull = false;
            for (int i = 1; i < x.Length; i++)
            {
                if (x[i] is null || y[i] is null)
                {
                    if (x[i] is not null || y[i] is not null)
                        hasNull = true; // one null, one non-null → unknown
                    continue;           // both null → equal for this element
                }

                var compare = memberComparer.Compare(x[i], y[i], precision);
                if (compare is null)
                    hasNull = true;
                else if (compare is not 0)
                    return compare;
            }

            return hasNull ? null : 0;
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

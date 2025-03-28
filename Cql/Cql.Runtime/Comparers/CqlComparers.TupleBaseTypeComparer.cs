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
    private class TupleBaseTypeComparer(CqlComparers memberComparer) :
        CqlComparer<TupleBaseType?>(
            CqlComparerEqualsMethod.Compare,
            CqlComparerNullComparisonStrategy.EitherNullReturnsNull,
            CqlComparerEquivalentMethod.Compare)
    {
        protected internal override int? CompareValues(
            TupleBaseType left,
            TupleBaseType right,
            string? precision)
        {
            var xType = left.GetType();
            var yType = right.GetType();
            if (xType != yType)
                return null;

            var joined = from xProp in xType.GetProperties()
                         join yProp in yType.GetProperties() on xProp equals yProp into g
                         from foundY in g.DefaultIfEmpty()
                         select new
                         {
                             Property = xProp,
                             XValue = xProp.GetValue(left),
                             YValue = foundY == null ? null : foundY.GetValue(right)
                         };

            foreach (var prop in joined)
            {
                var compare = memberComparer.Compare(prop.XValue, prop.YValue, precision);
                if (compare is null or not 0)
                    return compare;
            }

            return 0;
        }
    }
}

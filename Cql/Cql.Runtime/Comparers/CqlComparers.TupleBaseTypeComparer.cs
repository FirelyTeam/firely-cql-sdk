/*
* Copyright (c) 2023, NCQA and contributors
* See the file CONTRIBUTORS for details.
*
* This file is licensed under the BSD 3-Clause license
* available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
*/

using Hl7.Cql.Abstractions;
using Hl7.Cql.Primitives;

namespace Hl7.Cql.Comparers;

partial class CqlComparers
{
    private class TupleBaseTypeComparer(CqlComparers memberComparer) : ICqlComparer<TupleBaseType?>
    {
        public int? Compare(TupleBaseType? x, TupleBaseType? y, string? precision = null)
        {
            if (x == null || y == null)
                return null;
            var xType = x.GetType();
            var yType = y.GetType();
            if (xType != yType)
                return null;
            var joined = from xProp in xType.GetProperties()
                         join yProp in yType.GetProperties() on xProp equals yProp into g
                         from foundY in g.DefaultIfEmpty()
                         select new
                         {
                             Property = xProp,
                             XValue = xProp.GetValue(x),
                             YValue = foundY == null ? null : foundY.GetValue(y)
                         };

            foreach (var prop in joined)
            {
                var compare = memberComparer.Compare(prop.XValue, prop.YValue, precision);
                if (compare is null or not 0)
                    return compare;
            }

            return 0;
        }

        public int GetHashCode(TupleBaseType? obj) =>
            obj?.GetHashCode() ?? typeof(TupleBaseType).GetHashCode() ^ 098174506;

        public bool? Equals(TupleBaseType? x, TupleBaseType? y, string? precision = null) =>
            Compare(x, y, null) == 0;

        public bool Equivalent(TupleBaseType? x, TupleBaseType? y, string? precision = null)
        {
            if (EquivalentOnNullsOnly(x, y) is { } r)
                return r;

            var xType = x!.GetType();
            var yType = y!.GetType();
            if (xType != yType)
                return false;
            var joined = from xProp in xType.GetProperties()
                         join yProp in yType.GetProperties() on xProp equals yProp into g
                         from foundY in g.DefaultIfEmpty()
                         select new
                         {
                             Property = xProp,
                             XValue = xProp.GetValue(x),
                             YValue = foundY == null ? null : foundY.GetValue(y)
                         };
            foreach (var prop in joined)
            {
                if (!memberComparer.Equivalent(prop.XValue, prop.YValue, precision))
                    return false;
            }
            return true;
        }
    }
}

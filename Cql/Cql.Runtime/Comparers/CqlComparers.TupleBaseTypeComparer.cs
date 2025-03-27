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
    private class TupleBaseTypeComparer(CqlComparers memberComparer) : CqlComparer<TupleBaseType?>
    {
        protected override int? CompareValues(
            TupleBaseType left,
            TupleBaseType right,
            string? precision = null)
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
        // public int? Compare(TupleBaseType? left, TupleBaseType? right, string? precision = null)
        // {
        //     if (left == null || right == null)
        //         return null;
        //     var xType = left.GetType();
        //     var yType = right.GetType();
        //     if (xType != yType)
        //         return null;
        //     var joined = from xProp in xType.GetProperties()
        //                  join yProp in yType.GetProperties() on xProp equals yProp into g
        //                  from foundY in g.DefaultIfEmpty()
        //                  select new
        //                  {
        //                      Property = xProp,
        //                      XValue = xProp.GetValue(left),
        //                      YValue = foundY == null ? null : foundY.GetValue(right)
        //                  };
        //
        //     foreach (var prop in joined)
        //     {
        //         var compare = memberComparer.Compare(prop.XValue, prop.YValue, precision);
        //         if (compare is null or not 0)
        //             return compare;
        //     }
        //
        //     return 0;
        // }

        // public int GetHashCode(TupleBaseType? value) =>
        //     value?.GetHashCode() ?? typeof(TupleBaseType).GetHashCode() ^ 098174506;

        // public bool? Equals(TupleBaseType? left, TupleBaseType? right, string? precision = null) =>
        //     Compare(left, right, null) == 0;

        protected override bool EquivalentValues(
            TupleBaseType? left,
            TupleBaseType? right,
            string? precision = null)
        {
            var xType = left!.GetType();
            var yType = right!.GetType();
            if (xType != yType)
                return false;
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
                if (!memberComparer.Equivalent(prop.XValue, prop.YValue, precision))
                    return false;
            }
            return true;
        }
        // public bool Equivalent(TupleBaseType? left, TupleBaseType? right, string? precision = null)
        // {
        //     if (EquivalentOnNullsOnly(left, right) is { } r)
        //         return r;
        //
        //     var xType = left!.GetType();
        //     var yType = right!.GetType();
        //     if (xType != yType)
        //         return false;
        //     var joined = from xProp in xType.GetProperties()
        //                  join yProp in yType.GetProperties() on xProp equals yProp into g
        //                  from foundY in g.DefaultIfEmpty()
        //                  select new
        //                  {
        //                      Property = xProp,
        //                      XValue = xProp.GetValue(left),
        //                      YValue = foundY == null ? null : foundY.GetValue(right)
        //                  };
        //     foreach (var prop in joined)
        //     {
        //         if (!memberComparer.Equivalent(prop.XValue, prop.YValue, precision))
        //             return false;
        //     }
        //     return true;
        // }
    }
}

using Ncqa.Cql.Runtime.Primitives;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Ncqa.Cql.Comparers
{
    public class TupleBaseTypeComparer : ICqlComparer<TupleBaseType?>, ICqlComparer
    {
        public TupleBaseTypeComparer(ICqlComparer memberComparer)
        {
            MemberComparer = memberComparer;
        }

        public ICqlComparer MemberComparer { get; }

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
            var result = 0;
            foreach(var prop in joined)
            {
                var compare = MemberComparer.Compare(prop.XValue, prop.YValue, precision);
                if (compare == null)
                    return null;
                result += compare.Value;
            }
            return result;
        }


        public int? Compare(object x, object y, string? precision = null) => 
            Compare(x as TupleBaseType, y as TupleBaseType, null);

        public bool? Equals(TupleBaseType? x, TupleBaseType? y, string? precision = null) => 
            Compare(x, y, null) == 0;

        public bool? Equals(object x, object y, string? precision = null) =>
            Compare(x, y, null) == 0;

        public bool Equivalent(TupleBaseType? x, TupleBaseType? y, string? precision = null)
        {
            if (x == null)
            {
                if (y == null)
                    return true;
                else return false;
            }
            else if (y == null)
                return false;

            var xType = x.GetType();
            var yType = y.GetType();
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
                if (!MemberComparer.Equivalent(prop.XValue, prop.YValue, precision))
                    return false;
            }
            return true;
        }

        public bool Equivalent(object x, object y) =>
            Equivalent(x as TupleBaseType, y as TupleBaseType);

        public bool Equivalent(object x, object y, string? precision = null) =>
            Equivalent(x as TupleBaseType, y as TupleBaseType);

        public int GetHashCode(TupleBaseType? obj) => obj?.GetHashCode() ?? typeof(TupleBaseType).GetHashCode() ^ 098174506;
        public int GetHashCode(object obj) => GetHashCode(obj as TupleBaseType);
    }
}

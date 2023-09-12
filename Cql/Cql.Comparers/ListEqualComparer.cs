#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using System.Collections;

namespace Hl7.Cql.Comparers
{
    internal class ListEqualComparer : ICqlComparer, ICqlComparer<IEnumerable>
    {
        public ListEqualComparer(ICqlComparer elementComparer)
        {
            ElementComparer = elementComparer;
        }

        public ICqlComparer ElementComparer { get; }

        public int? Compare(object? x, object? y, string? precision = null) =>
           Compare(x as IEnumerable, y as IEnumerable, precision);

        public int? Compare(IEnumerable? x, IEnumerable? y, string? precision = null)
        {
            if (x == null)
            {
                if (y == null)
                    return 0;
                else return -1;
            }
            else if (y == null)
                return 1;

            var onlyNull = true;
            var notEmpty = false;
            var lit = x!.GetEnumerator();
            var rit = y!.GetEnumerator();
            while (lit.MoveNext())
            {
                if (!rit.MoveNext())
                    return 1;
                notEmpty = true;
                var lv = lit.Current;
                var rv = rit.Current;
                if (lv == null)
                {
                    if (rv != null) return -1;
                }
                else if (rv == null) return 1;
                else
                {
                    onlyNull = false;
                    var compare = ElementComparer.Compare(lv!, rv!, null);
                    if (compare != 0)
                        return compare;
                }
            }
            if (rit.MoveNext()) // the 2nd list is longer than the 1st.
                return 1;

            if (notEmpty && onlyNull)
                return -1;
            else
                return 0;
        }

        public bool? Equals(object? x, object? y, string? precision = null) =>
            Equals(x as IEnumerable, y as IEnumerable, precision);

        public bool? Equals(IEnumerable? x, IEnumerable? y, string? precision = null)
        {
            if (x == null || y == null)
                return null;

            var onlyNull = true;
            var notEmpty = false;
            var lit = x!.GetEnumerator();
            var rit = y!.GetEnumerator();
            while (lit.MoveNext())
            {
                if (!rit.MoveNext())
                    return false;
                notEmpty = true;
                var lv = lit.Current;
                var rv = rit.Current;
                if (lv == null)
                {
                    if (rv != null) return false;
                }
                else if (rv == null) return false;
                else
                {
                    onlyNull = false;
                    if (Comparer.Default.Compare(lv!, rv!) != 0)
                        return false;
                }
            }
            if (rit.MoveNext()) // the 2nd list is longer than the 1st.
                return false;

            if (notEmpty && onlyNull)
                return null;
            else
                return true;
        }

        public bool Equivalent(object? x, object? y, string? precision = null) =>
            Equivalent(x as IEnumerable, y as IEnumerable, precision);

        public bool Equivalent(IEnumerable? x, IEnumerable? y, string? precision = null)
        {
            if (x == null)
            {
                if (y == null)
                    return true;
                else
                    return false;
            }
            else if (y == null)
                return false;

            var lit = x!.GetEnumerator();
            var rit = y!.GetEnumerator();
            while (lit.MoveNext())
            {
                if (!rit.MoveNext())
                    return false;

                var lv = lit.Current;
                var rv = rit.Current;
                if (lv == null)
                {
                    if (rv != null) return false;
                }
                else if (rv == null) return false;
                else if (ElementComparer.Equivalent(lv!, rv!, null) == false)
                    return false;
            }
            if (rit.MoveNext()) // the 2nd list is longer than the 1st.
                return false;
            return true;
        }

        public int GetHashCode(IEnumerable x) =>
            x == null
            ? typeof(IEnumerable).GetHashCode()
            : x.GetHashCode();

        public int GetHashCode(object x) => GetHashCode((x as IEnumerable)!);
    }
}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
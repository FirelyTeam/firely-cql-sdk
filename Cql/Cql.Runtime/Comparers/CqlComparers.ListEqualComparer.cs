/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;

namespace Hl7.Cql.Comparers;

partial class CqlComparers
{
    private class ListEqualComparer(CqlComparers elementComparer) :
        CqlComparer<IEnumerable>
    {
        protected internal override int? CompareValues(
            IEnumerable left,
            IEnumerable right,
            string? precision)
        {
            var lit = left.GetEnumerator();
            using var litd = lit as IDisposable;

            var rit = right.GetEnumerator();
            using var ritd = rit as IDisposable;

            while (lit.MoveNext())
            {
                if (!rit.MoveNext())
                    return 1;
                var lv = lit.Current;
                var rv = rit.Current;
                if (lv == null)
                {
                    if (rv != null) return -1;
                }
                else if (rv == null) return 1;
                else
                {
                    var compare = elementComparer.Compare(lv, rv, null);
                    if (compare != 0)
                        return compare;
                }
            }
            if (rit.MoveNext()) // the 2nd list is longer than the 1st.
                return 1;

            return 0;
        }

        // public int? Compare(IEnumerable? left, IEnumerable? right, string? precision = null)
        // {
        //     if (left == null)
        //     {
        //         if (right == null)
        //             return 0;
        //         else return -1;
        //     }
        //     else if (right == null)
        //         return 1;
        //
        //     var lit = left!.GetEnumerator();
        //     var rit = right!.GetEnumerator();
        //     while (lit.MoveNext())
        //     {
        //         if (!rit.MoveNext())
        //             return 1;
        //         var lv = lit.Current;
        //         var rv = rit.Current;
        //         if (lv == null)
        //         {
        //             if (rv != null) return -1;
        //         }
        //         else if (rv == null) return 1;
        //         else
        //         {
        //             var compare = elementComparer.Compare(lv!, rv!, null);
        //             if (compare != 0)
        //                 return compare;
        //         }
        //     }
        //     if (rit.MoveNext()) // the 2nd list is longer than the 1st.
        //         return 1;
        //
        //     return 0;
        // }

        protected override bool? EqualsValues(
            IEnumerable left,
            IEnumerable right,
            string? precision)
        {
            var onlyNull = true;
            var notEmpty = false;

            var lit = left.GetEnumerator();
            using var litd = lit as IDisposable;

            var rit = right.GetEnumerator();
            using var ritd = rit as IDisposable;

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
                    if (Comparer.Default.Compare(lv, rv) != 0)
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

        // public bool? Equals(IEnumerable? left, IEnumerable? right, string? precision = null)
        // {
        //     if (left == null || right == null)
        //         return null;
        //
        //     var onlyNull = true;
        //     var notEmpty = false;
        //     var lit = left!.GetEnumerator();
        //     var rit = right!.GetEnumerator();
        //     while (lit.MoveNext())
        //     {
        //         if (!rit.MoveNext())
        //             return false;
        //         notEmpty = true;
        //         var lv = lit.Current;
        //         var rv = rit.Current;
        //         if (lv == null)
        //         {
        //             if (rv != null) return false;
        //         }
        //         else if (rv == null) return false;
        //         else
        //         {
        //             onlyNull = false;
        //             if (Comparer.Default.Compare(lv!, rv!) != 0)
        //                 return false;
        //         }
        //     }
        //     if (rit.MoveNext()) // the 2nd list is longer than the 1st.
        //         return false;
        //
        //     if (notEmpty && onlyNull)
        //         return null;
        //     else
        //         return true;
        // }

        protected internal override bool EquivalentValues(
            IEnumerable left,
            IEnumerable right,
            string? precision)
        {
            var lit = left.GetEnumerator();
            using var litd = lit as IDisposable;

            var rit = right.GetEnumerator();
            using var ritd = rit as IDisposable;

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
                else if (elementComparer.Equivalent(lv, rv, null) == false)
                    return false;
            }
            if (rit.MoveNext()) // the 2nd list is longer than the 1st.
                return false;

            return true;
        }

        // public bool Equivalent(IEnumerable? left, IEnumerable? right, string? precision = null)
        // {
        //     if (EquivalentOnNullsOnly(left, right) is { } r)
        //         return r;
        //
        //     var lit = left!.GetEnumerator();
        //     using var litd = lit as IDisposable;
        //
        //     var rit = right!.GetEnumerator();
        //     using var ritd = rit as IDisposable;
        //
        //     while (lit.MoveNext())
        //     {
        //         if (!rit.MoveNext())
        //             return false;
        //
        //         var lv = lit.Current;
        //         var rv = rit.Current;
        //         if (lv == null)
        //         {
        //             if (rv != null) return false;
        //         }
        //         else if (rv == null) return false;
        //         else if (elementComparer.Equivalent(lv!, rv!, null) == false)
        //             return false;
        //     }
        //     if (rit.MoveNext()) // the 2nd list is longer than the 1st.
        //         return false;
        //     return true;
        // }

        // public int GetHashCode(IEnumerable? value) =>
        //     value?.GetHashCode() ?? typeof(IEnumerable).GetHashCode();
    }
}

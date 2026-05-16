/*
 * Copyright (c) 2023, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Comparers;

partial class CqlComparers
{
    private class ListEqualComparer(CqlComparers elementComparer) :
        CqlComparer<IEnumerable>
    {
        private const int TypeMismatchResult = 1;

        protected override int? CompareValues(
            IEnumerable x,
            IEnumerable y,
            string? precision)
        {
            var lit = x.GetEnumerator();
            using var litd = lit as IDisposable;

            var rit = y.GetEnumerator();
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

        protected override bool? EqualsValues(
            IEnumerable x,
            IEnumerable y,
            string? precision)
        {
            var onlyNull = true;
            var hasUnknown = false;
            var notEmpty = false;

            var lit = x.GetEnumerator();
            using var litd = lit as IDisposable;

            var rit = y.GetEnumerator();
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
                    try
                    {
                        var equals = elementComparer.Equals(lv, rv, null);
                        if (equals == false)
                            return false;

                        if (equals == null)
                            hasUnknown = true;
                    }
                    catch (InvalidCastException)
                    {
                        return false;
                    }
                }
            }
            if (rit.MoveNext()) // the 2nd list is longer than the 1st.
                return false;

            var allElementsNull = notEmpty && onlyNull;
            if (allElementsNull || hasUnknown)
                return null;
            else
                return true;
        }

        protected override bool EquivalentValues(
            IEnumerable x,
            IEnumerable y,
            string? precision)
        {
            var lit = x.GetEnumerator();
            using var litd = lit as IDisposable;

            var rit = y.GetEnumerator();
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
    }
}

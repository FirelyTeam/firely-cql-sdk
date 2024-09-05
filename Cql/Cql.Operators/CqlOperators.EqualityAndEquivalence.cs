using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hl7.Cql.Operators;

namespace Hl7.Cql.Runtime;

internal partial class CqlOperators
{
    #region Equal

    /*
     * Equality : https://cql.hl7.org/04-logicalspecification.html#equal
     *
     * The Equal operator returns:
     * - true if the arguments are equal;
     * - false if the arguments are known unequal,
     * - and null otherwise.
     *
     * Equality semantics are defined to be value-based.
     *
     */

    internal IEqualityComparer<object> EqualityComparer { get; }

    public bool? Equals(object? x, object? y, string? precision) => Comparer.Equals(x, y, precision);

    public bool? Equal(object? x, object? y) => x == null || y == null ? null : Equals(x, y, null);

    public bool? ListEqual<T>(IEnumerable<T>? left, IEnumerable<T>? right)
    {
        if (left == null || right == null)
            return null;

        var onlyNull = true;
        var notEmpty = false;
        var lit = left!.GetEnumerator();
        var rit = right!.GetEnumerator();
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
                if (Compare(lv!, rv!, null) != 0)
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

    #endregion

    #region NotEqual

    public bool? NotEqual(object? left, object? right) =>
        Equal(left, right) switch
        {
            null  => null,
            true  => false,
            false => true
        };

    public bool? ListNotEqual<T>(IEnumerable<T>? left, IEnumerable<T>? right) => !ListEqual(left, right);

    #endregion

    #region Equivalent

    /*
     *
     * Equivalence : https://cql.hl7.org/04-logicalspecification.html#equivalent
     *
     * The Equivalent operator returns:
     * - true if the arguments are the same value, or if they are both null;
     * - and false otherwise.
     *
     * With the exception of null behavior and the semantics for specific types defined below, equivalence is the same as equality.
     */

    internal static bool? NullEquivalent<T>(T? left, T? right) where T : class =>
        (left, right) switch
        {
            (null, null) => true,
            (null, _) => false,
            (_, null) => false,
            _ => null
        };

    public bool Equivalent(object? x, object? y, string? precision) =>
        NullEquivalent(x, y) ?? Comparer.Equivalent(x, y, precision);

    public bool? Equivalent(object? x, object? y) => Equivalent(x!, y!, null);

    public bool? Equivalent<T>(IEnumerable<T>? left, IEnumerable<T>? right) =>
        NullEquivalent(left, right) ??  EquivalentNotNull(left!, right!);

    private bool? EquivalentNotNull<T>(IEnumerable<T> left, IEnumerable<T> right)
    {
        var lit = left!.GetEnumerator();
        var rit = right!.GetEnumerator();
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
            else if (Equivalent(lv!, rv!, null) == false)
                return false;
        }
        if (rit.MoveNext()) // the 2nd list is longer than the 1st.
            return false;
        return true;
    }

    public bool? NotEquivalent(object? left, object? right) => !Equivalent(left, right);

    #endregion
}

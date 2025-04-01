namespace Hl7.Cql.Operators;

internal partial class CqlOperators
{
    #region Equality

    /*
     * Equality : https://cql.hl7.org/04-logicalspecification.html#equal
     *
     * Spec: The Equal operator returns:
     * - true if the arguments are equal;
     * - false if the arguments are known unequal,
     * - and null otherwise.
     *
     * Spec: Equality semantics are defined to be value-based.
     *
     */

    private EqualityComparerBridge EqualityComparer { get; }

    // bool? ICqlComparer<object>.Equals(object? x, object? y, string? precision) => Comparer.Equals(x, y, precision);

    public bool? Equal(object? x, object? y) => x == null || y == null ? null : Comparer.Equals(x, y, null);

    public bool? ListEqual<T>(IEnumerable<T>? left, IEnumerable<T>? right)
    {
        if (left == null || right == null)
            return null;

        var onlyNull = true;
        var notEmpty = false;
        var lit = left!.GetEnumerator();
        using var litd = lit as IDisposable;

        var rit = right!.GetEnumerator();
        using var ritd = lit as IDisposable;

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
                if (Comparer.Compare(lv!, rv!, null) != 0)
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

    public bool? NotEqual(object? left, object? right) => !Equal(left, right);

    public bool? ListNotEqual<T>(IEnumerable<T>? left, IEnumerable<T>? right) => !ListEqual(left, right);

    #endregion

    #region Equivalence

    public bool Equivalent(object? x, object? y, string? precision) =>
        EquivalentNulls(x is null, y is null)
            .OrValue(() => Comparer.Equivalent(x, y, precision));

    public bool? Equivalent(object? x, object? y) => Equivalent(x!, y!, null);

    public bool? Equivalent(string? x, string? y) => Equivalent(x!, y!, null);

    public bool? Equivalent<T>(IEnumerable<T>? left, IEnumerable<T>? right)
    {
        // Spec: For list types, this means that two lists are equivalent if and only if the lists contain elements of the same type, have the same number of elements, and for each element in the lists, in order, the elements are equivalent.

        if (EquivalentNulls(left is null, right is null) is { HasValue: true } r)
            return r.Value;

        if ((left, right) is (string sLeft, string sRight))
            return Equivalent(sLeft, sRight);

        var lit = left!.GetEnumerator();
        using var litd = lit as IDisposable;

        var rit = right!.GetEnumerator();
        using var ritd = lit as IDisposable;

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

    public bool? ListNotEquivalent<T>(IEnumerable<T>? left, IEnumerable<T>? right) => !Equivalent(left, right);

    #endregion
}

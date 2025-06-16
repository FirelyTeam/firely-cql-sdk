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

    public bool? Equal(object? left, object? right)
    {
        // https://cql.hl7.org/09-b-cqlreference.html#equal
        // Spec:If either argument is null, the result is null.
        if (left is null || right is null)
            return null;

        return Comparer.EqualsValues(left!, right!, null);
    }

    public bool? ListEqual<T>(IEnumerable<T>? left, IEnumerable<T>? right)
    {
        if (left is null || right is null)
            return null;

        // If their sizes are different, they are not equal.
        if (left.TryGetNonEnumeratedCount(out var leftCount)
            && right.TryGetNonEnumeratedCount(out var rightCount)
            && leftCount != rightCount)
            return false;

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
            switch ((lv, rv))
            {
                case (null, null):
                    continue;

                case (null, not null)
                    or (not null, null):
                    return false;

                case (not null, not null) when Comparer.Equals(lv!, rv!, null) is false:
                    onlyNull = false;
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

    public bool? NotEqual(object? left, object? right)
    {
        // https://cql.hl7.org/09-b-cqlreference.html#not-equal

        return !Equal(left, right);
    }

    public bool? ListNotEqual<T>(IEnumerable<T>? left, IEnumerable<T>? right) => !ListEqual(left, right);

    #endregion

    #region Equivalence

    public bool Equivalent(object? left, object? right, string? precision)
    {
        // https://cql.hl7.org/09-b-cqlreference.html#equivalent
        // Spec: The equivalent (~) operator returns true if the arguments are equivalent in value, or if they are both null; and false otherwise.
        return (left, right) switch
        {
            (null, null)           => true,
            (null, _) or (_, null) => false,
            _                      => Comparer.EquivalentValues(left, right, precision)
        };
    }

    public bool? Equivalent(object? left, object? right) =>
        Equivalent(left!, right!, null);

    public bool? Equivalent<T>(IEnumerable<T>? left, IEnumerable<T>? right)
    {
        // https://cql.hl7.org/09-b-cqlreference.html#equivalent
        // Spec: The equivalent (~) operator returns true if the arguments are equivalent in value, or if they are both null; and false otherwise.
        // Spec: For list types, this means that two lists are equivalent if and only if the lists contain elements of the same type, have the same number of elements, and for each element in the lists, in order, the elements are equivalent.
        return (left, right) switch
        {
            (null, null)                  => true,
            (null, _) or (_, null)        => false,
            (string, string) => Comparer.EquivalentValues(left, right, null),
            _                             => ListEquivalent(left, right)
        };
    }

    private bool? ListEquivalent<T>(IEnumerable<T> left, IEnumerable<T> right)
    {
        // If their sizes are different, they are not equivalent.
        if (left.TryGetNonEnumeratedCount(out var leftCount)
            && right.TryGetNonEnumeratedCount(out var rightCount)
            && leftCount != rightCount)
            return false;

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
            switch ((lv, rv))
            {
                case (null, null):
                    continue;

                case (null, not null)
                    or (not null, null):
                    return false;

                case (not null, not null) when Comparer.Equivalent(lv!, rv!, null) is false:
                    return false;
            }
        }

        if (rit.MoveNext()) // the 2nd list is longer than the 1st.
            return false;

        return true;
    }

    public bool? NotEquivalent(object? left, object? right)
    {
        // https://cql.hl7.org/09-b-cqlreference.html#not-equivalent
        return !Equivalent(left, right);
    }

    public bool? ListNotEquivalent<T>(IEnumerable<T>? left, IEnumerable<T>? right) => !Equivalent(left, right);

    #endregion
}

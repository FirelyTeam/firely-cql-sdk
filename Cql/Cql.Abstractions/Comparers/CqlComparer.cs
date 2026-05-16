/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Comparers;

internal enum CqlComparerEquivalentImplementation
{
    Equivalent = 0,
    Compare = 1,
    Equals = 2
}

internal enum CqlComparerEqualsImplementation
{
    Equals = 0,
    Compare = 1,
}

internal abstract class CqlComparer<T>(
    CqlComparerEqualsImplementation equalsImplementation = CqlComparerEqualsImplementation.Equals,
    CqlComparerEquivalentImplementation equivalentImplementation = CqlComparerEquivalentImplementation.Equivalent)
    : ICqlComparer<T>, ICqlComparer
{
    public CqlComparerEqualsImplementation EqualsImplementation { get; } = equalsImplementation;

    public CqlComparerEquivalentImplementation EquivalentImplementation { get; } = equivalentImplementation;

    #region Equality

    public bool? Equals(
        T? x,
        T? y,
        string? precision)
    {
        // https://cql.hl7.org/04-logicalspecification.html#equal
        // Spec:If either argument is null, the result is null.
        return x is null || y is null || IsNull(x) || IsNull(y)
                   ? null
                   : EqualsValuesShared(x!, y!, precision);
    }

    protected virtual bool? EqualsValues(
        [DisallowNull] T x,
        [DisallowNull] T y,
        string? precision) =>
        throw new NotImplementedException();

    bool? ICqlComparer.Equals(
        object? x,
        object? y,
        string? precision) =>
            x is null || y is null
            ? null
            : x is T tx && y is T ty
                ? Equals(tx, ty, precision)
                : false;

    bool? ICqlComparer.EqualsValues(
        object x,
        object y,
        string? precision) =>
        x is T tx && y is T ty
            ? EqualsValuesShared(tx, ty, precision)
            : false;

    private bool? EqualsValuesShared(
        [DisallowNull] T x,
        [DisallowNull] T y,
        string? precision)
    {
        // Do a quick check for equality
        if (Equals(x, y))
           return true;

        switch (EqualsImplementation)
        {
            case CqlComparerEqualsImplementation.Compare:
                int? compareValues = CompareValues(x, y, precision);
                bool? equalsFromCompare = CqlComparisonToEquals(compareValues);
                return equalsFromCompare;

            case CqlComparerEqualsImplementation.Equals:
                bool? equalsValues = EqualsValues(x, y, precision);
                return equalsValues;

            default:
                throw new ArgumentOutOfRangeException();
        }
    }

    #endregion

    #region Equivalence

    public virtual bool Equivalent(
        T? x,
        T? y,
        string? precision)
    {
        // https://cql.hl7.org/04-logicalspecification.html#equivalent
        // Spec:The Equivalent operator returns true if the arguments are the same value, or if they are both null; and false otherwise.
        return (x is null || IsNull(x), y is null || IsNull(y)) switch
        {
            (true, true)           => true,
            (true, _) or (_, true) => false,
            _                      => EquivalentValuesShared(x!, y!, precision)
        };
    }

    protected virtual bool EquivalentValues(
        [DisallowNull] T x,
        [DisallowNull] T y,
        string? precision) =>
        throw new NotImplementedException();

    bool IEquivalenceComparer.Equivalent(
        object? x,
        object? y,
        string? precision) =>
        x is null || y is null
            ? x is null && y is null
            : x is T tx && y is T ty
                ? Equivalent(tx, ty, precision)
                : false;

    bool IEquivalenceComparer.EquivalentValues(
        object x,
        object y,
        string? precision) =>
        x is T tx && y is T ty
            ? EquivalentValuesShared(tx, ty, precision)
            : false;

    private bool EquivalentValuesShared(
        T x,
        T y,
        string? precision)
    {
        // Do a quick check for equality
        if (Equals(x, y))
            return true;

        switch (EquivalentImplementation)
        {
            case CqlComparerEquivalentImplementation.Compare:
                int? compareValues = CompareValues(x!, y!, precision);
                var equivalenceFromCompare = CqlComparisonToEquivalence(compareValues);
                return equivalenceFromCompare;

            case CqlComparerEquivalentImplementation.Equals:
                bool? equalsValues = EqualsValues(x!, y!, precision);
                var equivalenceFromEquals = CqlEqualityToEquivalence(equalsValues);

                return equivalenceFromEquals;

            case CqlComparerEquivalentImplementation.Equivalent:
                var equivalentValues = EquivalentValues(x!, y!, precision);
                return equivalentValues;

            default:
                throw new ArgumentOutOfRangeException();
        }
    }

    #endregion

    #region Comparison

    public virtual int? Compare(
        T? x,
        T? y,
        string? precision) =>
        (x is null || IsNull(x), y is null || IsNull(y)) switch
        {
            (true, true) => 0,
            (true, _)    => 1,
            (_, true)    => -1,
            _            => CompareValuesShared(x!, y!, precision)
        };

    protected virtual int? CompareValues(
        [DisallowNull] T x,
        [DisallowNull] T y,
        string? precision) =>
        throw new NotImplementedException();

    int? ICqlComparer.Compare(
        object? x,
        object? y,
        string? precision) =>
        x is null
            ? y is null
                ? 0
                : 1
            : y is null
                ? -1
                : x is T tx && y is T ty
                    ? Compare(tx, ty, precision)
                    : 1;

    int? ICqlComparer.CompareValues(
        object x,
        object y,
        string? precision) =>
        x is T tx && y is T ty
            ? CompareValuesShared(tx, ty, precision)
            : 1;

    private int? CompareValuesShared(
        T x,
        T y,
        string? precision)
    {
        // Do a quick check for equality
        if (Equals(x, y))
            return 0;

        return CompareValues(x!, y!, precision);
    }

    #endregion

    #region HashCoding

    public virtual int GetHashCode(T? value) =>
        value is null || IsNull(value)
            ? GetHashCodeForNull()
            : GetHashCodeValue(value);

    protected virtual int GetHashCodeValue([DisallowNull] T value) =>
        value.GetHashCode();

    protected static int GetHashCodeForNull() => typeof(T).GetHashCode();

    int ICqlComparer.GetHashCode(object? value) =>
        value is null
            ? GetHashCodeForNull()
            : GetHashCode((T?)value);

    int ICqlComparer.GetHashCodeValue(object value) =>
        GetHashCodeValue((T)value);

    #endregion

    #region Nullability

    protected virtual bool IsNull([NotNullWhen(false)] T? value) =>
        value is null;

    #endregion
}
/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using Hl7.Cql.Abstractions.Infrastructure;

namespace Hl7.Cql.Comparers;

internal enum CqlComparerEquivalentMethod
{
    Equivalent = 0,
    Compare = 1,
    Equals = 2
}

internal enum CqlComparerEqualsMethod
{
    Equals = 0,
    Compare = 1,
}

internal abstract class CqlComparer<T>(
    CqlComparerEqualsMethod equalsMethod = CqlComparerEqualsMethod.Equals,
    CqlComparerEquivalentMethod equivalentMethod = CqlComparerEquivalentMethod.Equivalent)
    : ICqlComparer<T>, ICqlComparer
{
    public CqlComparerEqualsMethod EqualsMethod { get; } = equalsMethod;

    public CqlComparerEquivalentMethod EquivalentMethod { get; } = equivalentMethod;

    #region Equality

    public bool? Equals(
        T? x,
        T? y,
        string? precision)
    {
        // https://cql.hl7.org/04-logicalspecification.html#equal
        // Spec:If either argument is null, the result is null.
        return IsNull(x) || IsNull(y)
                   ? null
                   : EqualsValuesSwitch(x!, y!, precision);
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
        Equals((T?)x, (T?)y, precision);

    bool? ICqlComparer.EqualsValues(
        object x,
        object y,
        string? precision) =>
        EqualsValuesSwitch((T)x, (T)y, precision);

    private bool? EqualsValuesSwitch(
        [DisallowNull] T x,
        [DisallowNull] T y,
        string? precision)
    {
        if (Equals(x, y))
           return true;

        switch (EqualsMethod)
        {
            case CqlComparerEqualsMethod.Compare:
                int? compareValues = CompareValues(x, y, precision);
                bool? equalsFromCompare = compareValues switch
                {
                    null => null,
                    0    => true,
                    _    => false,
                };
                return equalsFromCompare;

            case CqlComparerEqualsMethod.Equals:
                bool? equalsValues = EqualsValues(x, y, precision);
                return equalsValues;

            default:
                throw new ArgumentOutOfRangeException();
        }
    }

    #endregion

    #region Equivalence

    public virtual bool Equivalent(
        T? left,
        T? right,
        string? precision)
    {
        // https://cql.hl7.org/04-logicalspecification.html#equivalent
        // Spec:The Equivalent operator returns true if the arguments are the same value, or if they are both null; and false otherwise.
        return (IsNull(left), IsNull(right)) switch
        {
            (true, true)           => true,
            (true, _) or (_, true) => false,
            _                      => EquivalentValuesSwitch(left!, right!, precision)
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
        Equivalent((T?)x, (T?)y, precision);

    bool IEquivalenceComparer.EquivalentValues(
        object x,
        object y,
        string? precision) =>
        EquivalentValuesSwitch((T)x, (T)y, precision);

    private bool EquivalentValuesSwitch(
        T x,
        T y,
        string? precision)
    {
        if (Equals(x, y))
            return true;

        switch (EquivalentMethod)
        {
            case CqlComparerEquivalentMethod.Compare:
                int? compareValues = CompareValues(x!, y!, precision);
                var equivalenceFromCompare = compareValues is null or 0;
                return equivalenceFromCompare;

            case CqlComparerEquivalentMethod.Equals:
                bool? equalsValues = EqualsValues(x!, y!, precision);
                var equivalenceFromEquals = equalsValues is null or true;

                return equivalenceFromEquals;

            case CqlComparerEquivalentMethod.Equivalent:
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
        (IsNull(x), IsNull(y)) switch
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
        Compare((T?)x, (T?)y, precision);

    int? ICqlComparer.CompareValues(
        object x,
        object y,
        string? precision) =>
        CompareValuesShared((T)x, (T)y, precision);

    private int? CompareValuesShared(
        T x,
        T y,
        string? precision) =>
        Equals(x, y)
            ? 0
            : CompareValues(x!, y!, precision);

    #endregion

    #region HashCoding

    public virtual int GetHashCode(T? value) =>
        IsNull(value)
            ? GetHashCodeForNull()
            : GetHashCodeValue(value);

    protected virtual int GetHashCodeValue([DisallowNull] T value) =>
        value.GetHashCode();

    protected static int GetHashCodeForNull() => typeof(T).GetHashCode();

    int ICqlComparer.GetHashCode(object? value) =>
        GetHashCode((T?)value);

    int ICqlComparer.GetHashCodeValue(object value) =>
        GetHashCodeValue((T)value);

    #endregion


    #region Nullability

    protected virtual bool IsNull([NotNullWhen(false)] T? value) =>
        value is null;

    #endregion
}
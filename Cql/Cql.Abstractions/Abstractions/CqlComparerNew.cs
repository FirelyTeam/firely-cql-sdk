/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Abstractions;

internal abstract class CqlComparerNew<T> : ICqlComparer<T>
{
    protected const int EQUIVALENT_VIA_DEFAULT = 0;
    protected const int EQUIVALENT_VIA_COMPARE = 1;
    protected const int EQUIVALENT_VIA_EQUALS = 2;
    protected virtual int GetEquivalentStrategy() => EQUIVALENT_VIA_DEFAULT;

    protected const int EQUALS_VIA_DEFAULT = 0;
    protected const int EQUALS_VIA_COMPARE = 1;
    protected virtual int GetEqualsStrategy() => EQUALS_VIA_DEFAULT;


    public virtual bool Equivalent(
        T? left,
        T? right,
        string? precision)
    {
        switch (GetEquivalentStrategy())
        {
            case EQUIVALENT_VIA_COMPARE:
                return EquivalentViaCompare(left, right, precision);

            case EQUIVALENT_VIA_EQUALS:
                return EquivalentViaEquals(left, right, precision);

            case EQUALS_VIA_DEFAULT:
                var result = EquivalentNulls(left, right)
                    .GetValueOr(EquivalentValues(left!, right!, precision));
                return result;

            default:
                throw new ArgumentOutOfRangeException();
        }
    }

    protected virtual Maybe<bool> EquivalentNulls(
        T? left,
        T? right)
    {
        var result = (IsNull(left), IsNull(right)) switch
        {
            (true, true) => true,
            (true, _)    => false,
            (_, true)    => false,
            _            => NoValueOf<bool>(),
        };
        return result;
    }

    bool IEquivalenceComparer<T>.EquivalentValues(
        [DisallowNull] T left,
        [DisallowNull] T right,
        string? precision) =>
        EquivalentValues(left, right, precision);

    protected virtual bool EquivalentValues(
        [DisallowNull] T left,
        [DisallowNull] T right,
        string? precision)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// <code>
    /// bool (bool? Equals) switch
    /// {
    ///   true or null => true
    ///   false => false
    /// }
    /// </code>
    /// </summary>
    protected bool EquivalentViaEquals(
        T? left,
        T? right,
        string? precision)
    {
        return Equals(left, right, precision) is true or null;
    }

    public virtual bool? Equals(
        T? left,
        T? right,
        string? precision)
    {
        switch (GetEqualsStrategy())
        {
            case EQUALS_VIA_COMPARE:
                return EqualsViaCompare(left, right, precision);

            case EQUALS_VIA_DEFAULT:
                var result =
                    EqualsNulls(left, right)
                        .GetValueOr(() => EqualsValues(left!, right!, precision));
                return result;

            default:
                throw new ArgumentOutOfRangeException();
        }
    }

    private Maybe<bool?> EqualsNulls(
        T? left,
        T? right)
    {
        var result = (IsNull(left), IsNull(right)) switch
        {
            (true, true) => true,
            (true, _)    => false,
            (_, true)    => false,
            _            => Maybe.NoValueOf<bool?>(),
        };
        return result;
    }

    // protected virtual bool? EqualsLeftNull() => false;
    //
    // protected virtual bool? EqualsRightNull() => false;

    protected virtual bool? EqualsValues(
        [DisallowNull] T left,
        [DisallowNull] T right,
        string? precision) =>
        throw new NotImplementedException();

    bool? ICqlComparer<T>.EqualsValues(
        [DisallowNull] T left,
        [DisallowNull] T right,
        string? precision) =>
        EqualsValues(left, right, precision);

    private bool? EqualsViaCompare(
        T? left,
        T? right,
        string? precision)
    {
        bool? result = Compare(left, right, precision) switch
        {
            null  => null,
            var r => r is 0
        };

        // var result2 = EqualsNulls(left, right)
        //     .Match(val => val, () => EqualsValuesViaCompare(left!, right!, precision));
        //
        // Trace.Assert(result == result2);

        return result;
    }

    private bool EquivalentViaCompare(
        T? left,
        T? right,
        string? precision)
    {
        // From old CqlComparerBase<T>.Equals
        bool result = Compare(left, right, precision) is 0;
        return result;
    }

    // /// <summary>
    // /// <code>
    // /// bool? (int?) switch
    // /// {
    // ///   null => null
    // ///   i => i == 0
    // /// }
    // /// </code>
    // /// </summary>
    // private bool? EqualsValuesViaCompare(
    //     [DisallowNull] T left,
    //     [DisallowNull] T right,
    //     string? precision)
    // {
    //     // From old CqlComparerBase<T>.Equals
    //     bool? result = CompareValues(left, right, precision) switch
    //     {
    //         null  => null,
    //         var r => r is 0
    //     };
    //     return result;
    // }

    public virtual int? Compare(
        T? left,
        T? right,
        string? precision)
    {
        var result =
            CompareNulls(left, right)
            .GetValueOr(() => CompareValues(left!, right!, precision));
        return result;
    }

    private Maybe<int?> CompareNulls(
        T? left,
        T? right)
    {
        var result = (IsNull(left), IsNull(right)) switch
        {
            (true, true) => 0,
            (true, _)    => CompareReturnNullOnAnyNull() ? null : 1,
            (_, true)    => CompareReturnNullOnAnyNull() ? null : -1,
            _            => NoValueOf<int?>(),
        };
        return result;
    }

    protected virtual bool CompareReturnNullOnAnyNull() => false;

    protected virtual int? CompareValues(
        [DisallowNull] T left,
        [DisallowNull] T right,
        string? precision) =>
        throw new NotImplementedException();

    int? ICqlComparer<T>.CompareValues(
        [DisallowNull] T left,
        [DisallowNull] T right,
        string? precision) =>
        CompareValues(left, right, precision);

    public virtual int GetHashCode(T? value)
    {
        var result = IsNull(value)
                         ? GetHashCodeNull()
                         : GetHashCodeValue(value);
        return result;
    }

    protected virtual bool IsNull([NotNullWhen(false)]T? value) =>
        value is null;

    protected static int GetHashCodeNull() => typeof(T).GetHashCode();

    protected virtual int GetHashCodeValue([DisallowNull]T value) =>
        value.GetHashCode();

    int ICqlComparer<T>.GetHashCodeValue([DisallowNull] T value) =>
        GetHashCodeValue(value);
}
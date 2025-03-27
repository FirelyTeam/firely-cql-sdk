/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Abstractions;

internal enum CqlComparerEquivalentMethod
{
    Equivalent = 0,
    Compare = 1,
    Equals = 2
}

internal enum CqlComparerEqualsMethod
{
    Equal = 0,
    Compare = 1
}

internal enum CqlComparerNullComparisonStrategy
{
    /// <summary>
    /// Comparison is null when both left and right are null.
    /// </summary>
    EitherNullReturnsValue = 0,

    /// <summary>
    /// Comparison is null when either/both left or right are null.
    /// </summary>
    EitherNullReturnsNull = 1,
}

internal abstract class CqlComparer<T>(
    CqlComparerEqualsMethod equalsMethod = CqlComparerEqualsMethod.Equal,
    CqlComparerNullComparisonStrategy nullComparisonStrategy = CqlComparerNullComparisonStrategy.EitherNullReturnsValue,
    CqlComparerEquivalentMethod equivalentMethod = CqlComparerEquivalentMethod.Equivalent) : ICqlComparer<T>
{
    public CqlComparerNullComparisonStrategy NullComparisonStrategy { get; } = nullComparisonStrategy;
    public CqlComparerEqualsMethod EqualsMethod { get; } = equalsMethod;
    public CqlComparerEquivalentMethod EquivalentMethod { get; } = equivalentMethod;

    public virtual bool Equivalent(
        T? left,
        T? right,
        string? precision)
    {
        switch (EquivalentMethod)
        {
            case CqlComparerEquivalentMethod.Compare:
                return Compare(left, right, precision) is 0;

            case CqlComparerEquivalentMethod.Equals:
                return Equals(left, right, precision) is true or null;

            case CqlComparerEquivalentMethod.Equivalent:
                var result = EquivalentNulls(left, right)
                    .GetValueOr(() => EquivalentValues(left!, right!, precision));
                return result;

            default:
                throw new ArgumentOutOfRangeException();
        }
    }

    private Maybe<bool> EquivalentNulls(
        T? left,
        T? right)
    {
        var result = (IsNull(left), IsNull(right)) switch
        {
            (true, true) => true,
            (true, _) => false,
            (_, true) => false,
            _ => NoValueOf<bool>(),
        };
        return result;
    }

    protected internal virtual bool EquivalentValues(
        [DisallowNull] T left,
        [DisallowNull] T right,
        string? precision)
    {
        throw new NotImplementedException();
    }

    public virtual bool? Equals(
        T? left,
        T? right,
        string? precision)
    {
        switch (EqualsMethod)
        {
            case CqlComparerEqualsMethod.Compare:
                return EqualsViaCompare(left, right, precision);

            case CqlComparerEqualsMethod.Equal:
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
            (true, _) => false,
            (_, true) => false,
            _ => Maybe.NoValueOf<bool?>(),
        };
        return result;
    }

    protected virtual bool? EqualsValues(
        [DisallowNull] T left,
        [DisallowNull] T right,
        string? precision) =>
        throw new NotImplementedException();

    private bool? EqualsViaCompare(
        T? left,
        T? right,
        string? precision)
    {
        bool? result = Compare(left, right, precision) switch
        {
            null => null,
            var r => r is 0
        };

        return result;
    }

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
            (true, _) => NullComparisonStrategy switch
            {
                CqlComparerNullComparisonStrategy.EitherNullReturnsValue => 1,
                CqlComparerNullComparisonStrategy.EitherNullReturnsNull => null,
                _ => throw new ArgumentOutOfRangeException(),
            },
            (_, true) => NullComparisonStrategy switch
            {
                CqlComparerNullComparisonStrategy.EitherNullReturnsValue => -1,
                CqlComparerNullComparisonStrategy.EitherNullReturnsNull  => null,
                _                       => throw new ArgumentOutOfRangeException(),
            },
            _ => NoValueOf<int?>(),
        };
        return result;
    }

    protected internal virtual int? CompareValues(
        [DisallowNull] T left,
        [DisallowNull] T right,
        string? precision) =>
        throw new NotImplementedException();

    public virtual int GetHashCode(T? value)
    {
        var result = IsNull(value)
                         ? GetHashCodeForNull()
                         : GetHashCodeValue(value);
        return result;
    }

    protected virtual bool IsNull([NotNullWhen(false)] T? value) =>
        value is null;

    protected static int GetHashCodeForNull() => typeof(T).GetHashCode();

    protected virtual int GetHashCodeValue([DisallowNull] T value) =>
        value.GetHashCode();
}

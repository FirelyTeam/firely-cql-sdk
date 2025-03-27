/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Abstractions;

internal enum CqlComparerEquivalentStrategy
{
    Equivalent = 0,
    Compare = 1,
    Equals = 2
}

internal enum CqlComparerEqualsStrategy
{
    Equal = 0,
    Compare = 1
}

internal enum CqlComparerNullComparisonStrategy
{
    /// <summary>
    /// Comparison is null when both left and right are null.
    /// </summary>
    And = 0,

    /// <summary>
    /// Comparison is null when either/both left or right are null.
    /// </summary>
    Or = 1
}

internal abstract class CqlComparer<T>(
    CqlComparerEqualsStrategy equalsStrategy = CqlComparerEqualsStrategy.Equal,
    CqlComparerNullComparisonStrategy nullComparisonStrategy = CqlComparerNullComparisonStrategy.And,
    CqlComparerEquivalentStrategy equivalentStrategy = CqlComparerEquivalentStrategy.Equivalent) : ICqlComparer<T>
{
    public CqlComparerNullComparisonStrategy NullComparisonStrategy { get; } = nullComparisonStrategy;
    public CqlComparerEqualsStrategy EqualsStrategy { get; } = equalsStrategy;
    public CqlComparerEquivalentStrategy EquivalentStrategy { get; } = equivalentStrategy;

    public virtual bool Equivalent(
        T? left,
        T? right,
        string? precision)
    {
        switch (EquivalentStrategy)
        {
            case CqlComparerEquivalentStrategy.Compare:
                return Compare(left, right, precision) is 0;

            case CqlComparerEquivalentStrategy.Equals:
                return Equals(left, right, precision) is true or null;

            case CqlComparerEquivalentStrategy.Equivalent:
                var result = EquivalentNulls(left, right)
                    .GetValueOr(EquivalentValues(left!, right!, precision));
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
        switch (EqualsStrategy)
        {
            case CqlComparerEqualsStrategy.Compare:
                return EqualsViaCompare(left, right, precision);

            case CqlComparerEqualsStrategy.Equal:
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
                CqlComparerNullComparisonStrategy.And => 1,
                CqlComparerNullComparisonStrategy.Or => null,
                _ => throw new ArgumentOutOfRangeException(),
            },
            (_, true) => NullComparisonStrategy switch
            {
                CqlComparerNullComparisonStrategy.And => -1,
                CqlComparerNullComparisonStrategy.Or  => null,
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

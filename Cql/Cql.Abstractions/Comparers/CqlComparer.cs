/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

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

internal abstract class CqlComparer<T> : ICqlComparer<T>, ICqlComparer
{
    protected CqlComparer(
        CqlComparerEqualsMethod equalsMethod = CqlComparerEqualsMethod.Equals,
        CqlComparerNullComparisonStrategy nullComparisonStrategy = CqlComparerNullComparisonStrategy.EitherNullReturnsValue,
        CqlComparerEquivalentMethod equivalentMethod = CqlComparerEquivalentMethod.Equivalent)
    {
        //NullComparisonStrategy = nullComparisonStrategy;
        EqualsMethod = equalsMethod;
        EquivalentMethod = equivalentMethod;
        //Dump();
    }

    public CqlComparerNullComparisonStrategy NullComparisonStrategy { get; }

    public CqlComparerEqualsMethod EqualsMethod { get; }

    public CqlComparerEquivalentMethod EquivalentMethod { get; }

    #region Debug Dumping ##REVIEW: Remove before merging

    private static readonly TypeCSharpFormat TypeCSharpFormat = TypeCSharpFormat.Default with
    {
        UseKeywords = true,
        NoNamespaces = true,
    };

    private void Dump()
    {
        var comparerType = GetType();
            // UnwrapAdapters(this)
            // // Skip runtime generated types e.g. <CqlComparerSharedMethods>F0099A10EF23C2A25539B874EADF672CDBD24D153A61E14DA4AEE655EBD616BB6__NonGenericAdapterCqlComparer<int>
            // .First(t => !t.Name.Contains("__"));

        string line = $"{EqualsMethod}, {NullComparisonStrategy}, {EquivalentMethod}, {comparerType.ToCSharpString(TypeCSharpFormat)}";

    Again:
        try
        {
            File.AppendAllLines(@"c:\temp\comparers.csv", [line]);
        }
        catch
        {
            goto Again;
        }

        // static IEnumerable<Type> UnwrapAdapters(object instance)
        // {
        //     Type type = instance.GetType();
        //     yield return type;
        //
        //     while (type.IsImplementingInterface(typeof(IWrapper)))
        //     {
        //         // var typeName = type.ToCSharpString(TypeCSharpFormat);
        //         //
        //         // // Skip runtime generated types e.g. <CqlComparerSharedMethods>F0099A10EF23C2A25539B874EADF672CDBD24D153A61E14DA4AEE655EBD616BB6__NonGenericAdapterCqlComparer<int>
        //         // if (typeName.Contains("__"))
        //         // {
        //         //     continue;
        //         //     // typeName = typeName.Split("__").Last();
        //         //     // comparerType.Append(typeName).Append(" -> ");
        //         // }
        //
        //         var interfaceMapping = type.GetInterfaceMap(typeof(IWrapper));
        //         instance = interfaceMapping
        //                    .InterfaceMethods
        //                    .First(m => m.Name == $"get_{nameof(IWrapper.Inner)}")
        //                    .Invoke(instance, [])!;
        //         type = instance.GetType();
        //         yield return type;
        //     }
        // }
    }

    #endregion

    #region Equality

    public bool? Equals(
        T? x,
        T? y,
        string? precision)
    {
        if (EqualsNulls(IsNull(x), IsNull(y)) is { HasValue: true } m)
            return m.Value;

        if (Object.Equals(x, y))
            return true;

        return EqualsValuesSwitch(x!, y!, precision);
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
        string? precision)
    {
        if (Object.Equals(x, y))
            return true;

        return EqualsValuesSwitch((T)x, (T)y, precision);
    }

    private bool? EqualsValuesSwitch(
        [DisallowNull] T x,
        [DisallowNull] T y,
        string? precision)
    {
        switch (EqualsMethod)
        {
            case CqlComparerEqualsMethod.Compare:
                int? compareValues = CompareValues(x, y, precision);
                bool? equalsFromCompare = EqualsFromCompare(compareValues);
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
        string? precision) =>
        EquivalentNulls(IsNull(left), IsNull(right)) is { HasValue: true } m
            ? m.Value
            : EquivalentValuesSwitch(left!, right!, precision);

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
                var equivalenceFromCompare = EquivalenceFromCompare(compareValues);

                return equivalenceFromCompare;

            case CqlComparerEquivalentMethod.Equals:
                bool? equalsValues = EqualsValues(x!, y!, precision);
                var equivalenceFromEquals = EquivalenceFromEquals(equalsValues);

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
        string? precision)
    {
        var compareNulls = NullComparisonStrategy switch
        {
            CqlComparerNullComparisonStrategy.EitherNullReturnsValue => CompareEitherNullReturnsValue(IsNull(x), IsNull(y)),
            CqlComparerNullComparisonStrategy.EitherNullReturnsNull  => CompareEitherNullReturnsNull(IsNull(x), IsNull(y)),
            _                                                        => throw new ArgumentOutOfRangeException(),
        };

        if (compareNulls is { HasValue: true } m)
            return m.Value;

        return CompareValuesShared(x!, y!, precision);
    }

    protected internal virtual int? CompareValues(
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
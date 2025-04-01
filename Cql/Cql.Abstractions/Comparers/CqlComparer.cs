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
    Equivalent = 2,
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
    private static readonly TypeCSharpFormat TypeCSharpFormat = TypeCSharpFormat.Default with
    {
        UseKeywords = true,
        NoNamespaces = true,
    };

    protected CqlComparer(
        CqlComparerEqualsMethod equalsMethod = CqlComparerEqualsMethod.Equals,
        CqlComparerNullComparisonStrategy nullComparisonStrategy = CqlComparerNullComparisonStrategy.EitherNullReturnsValue,
        CqlComparerEquivalentMethod equivalentMethod = CqlComparerEquivalentMethod.Equivalent)
    {
        NullComparisonStrategy = nullComparisonStrategy;
        EqualsMethod = equalsMethod;
        EquivalentMethod = equivalentMethod;
        //Dump();
    }

    private void Dump()
    {
        var comparerType = UnwrapAdapters(this)
            // Skip runtime generated types e.g. <CqlComparerSharedMethods>F0099A10EF23C2A25539B874EADF672CDBD24D153A61E14DA4AEE655EBD616BB6__NonGenericAdapterCqlComparer<int>
            .First(t => !t.Name.Contains("__"));

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

        static IEnumerable<Type> UnwrapAdapters(object instance)
        {
            Type type = instance.GetType();
            yield return type;

            while (type.IsImplementingInterface(typeof(IWrapper)))
            {
                // var typeName = type.ToCSharpString(TypeCSharpFormat);
                //
                // // Skip runtime generated types e.g. <CqlComparerSharedMethods>F0099A10EF23C2A25539B874EADF672CDBD24D153A61E14DA4AEE655EBD616BB6__NonGenericAdapterCqlComparer<int>
                // if (typeName.Contains("__"))
                // {
                //     continue;
                //     // typeName = typeName.Split("__").Last();
                //     // comparerType.Append(typeName).Append(" -> ");
                // }

                var interfaceMapping = type.GetInterfaceMap(typeof(IWrapper));
                instance = interfaceMapping
                           .InterfaceMethods
                           .First(m => m.Name == $"get_{nameof(IWrapper.Inner)}")
                           .Invoke(instance, [])!;
                type = instance.GetType();
                yield return type;
            }
        }
    }

    public CqlComparerNullComparisonStrategy NullComparisonStrategy { get; }
    public CqlComparerEqualsMethod EqualsMethod { get; }
    public CqlComparerEquivalentMethod EquivalentMethod { get; }

    public virtual bool Equivalent(
        T? left,
        T? right,
        string? precision) =>
        EquivalentNulls(IsNull(left), IsNull(right))
            .OrValue(() =>
            {
                if (Equals(left, right))
                    return true;

                switch (EquivalentMethod)
                {
                    case CqlComparerEquivalentMethod.Compare:
                        int? compareValues = CompareValues(left!, right!, precision);
                        var equivalenceFromCompare = EquivalenceFromCompare(compareValues);

                        return equivalenceFromCompare;

                    case CqlComparerEquivalentMethod.Equals:
                        bool? equalsValues = EqualsValues(left!, right!, precision);
                        var equivalenceFromEquals = EquivalenceFromEquals(equalsValues);

                        return equivalenceFromEquals;

                    case CqlComparerEquivalentMethod.Equivalent:
                        var equivalentValues = EquivalentValues(left!, right!, precision);

                        return equivalentValues;

                    default:
                        throw new ArgumentOutOfRangeException();
                }
            });

    protected virtual bool EquivalentValues(
        [DisallowNull] T left,
        [DisallowNull] T right,
        string? precision) =>
        throw new NotImplementedException();

    public bool? Equals(
        T? left,
        T? right,
        string? precision)
    {
        return EqualsNulls(IsNull(left), IsNull(right))
            .OrValue(() =>
            {
                if (Object.Equals(left, right))
                    return true;

                switch (EqualsMethod)
                {
                    case CqlComparerEqualsMethod.Compare:
                        int? compareValues = CompareValues(left!, right!, precision);
                        bool? equalsFromCompare = EqualsFromCompare(compareValues);
                        return equalsFromCompare;

                    case CqlComparerEqualsMethod.Equals:
                        bool? equalsValues = EqualsValues(left!, right!, precision);
                        return equalsValues;

                    case CqlComparerEqualsMethod.Equivalent:
                        bool equivalentValues = EquivalentValues(left!, right!, precision);
                        return equivalentValues;

                    default:
                        throw new ArgumentOutOfRangeException();
                }
            });
    }

    protected virtual bool? EqualsValues(
        [DisallowNull] T left,
        [DisallowNull] T right,
        string? precision) =>
        throw new NotImplementedException();

    public virtual int? Compare(
        T? left,
        T? right,
        string? precision)
    {
        var compareNulls = NullComparisonStrategy switch
        {
            CqlComparerNullComparisonStrategy.EitherNullReturnsValue => CompareEitherNullReturnsValue(IsNull(left), IsNull(right)),
            CqlComparerNullComparisonStrategy.EitherNullReturnsNull  => CompareEitherNullReturnsNull(IsNull(left), IsNull(right)),
            _                                                        => throw new ArgumentOutOfRangeException(),
        };
        return compareNulls
            .OrValue(() =>
            {
                if (Equals(left, right))
                    return 0;

                return CompareValues(left!, right!, precision);
            });
    }

    protected internal virtual int? CompareValues(
        [DisallowNull] T left,
        [DisallowNull] T right,
        string? precision) =>
        throw new NotImplementedException();

    public virtual int GetHashCode(T? value) =>
        IsNull(value)
            ? GetHashCodeForNull()
            : GetHashCodeValue(value);

    protected virtual bool IsNull([NotNullWhen(false)] T? value) =>
        value is null;

    protected static int GetHashCodeForNull() => typeof(T).GetHashCode();

    protected virtual int GetHashCodeValue([DisallowNull] T value) =>
        value.GetHashCode();

    bool IEquivalenceComparer.Equivalent(
        object? left,
        object? right,
        string? precision) =>
        Equivalent((T?)left, (T?)right, precision);

    bool? ICqlComparer.Equals(
        object? left,
        object? right,
        string? precision) =>
        Equals((T?)left, (T?)right, precision);

    int? ICqlComparer.Compare(
        object? left,
        object? right,
        string? precision) =>
        Compare((T?)left, (T?)right, precision);

    int ICqlComparer.GetHashCode(object? value) =>
        GetHashCode((T?)value);
}
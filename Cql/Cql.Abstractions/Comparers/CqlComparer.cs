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

internal abstract class CqlComparer<T> : ICqlComparer<T>
{
    private static readonly TypeCSharpFormat TypeCSharpFormat = TypeCSharpFormat.Default with
    {
        UseKeywords = true,
        NoNamespaces = true,
    };

    protected CqlComparer(
        CqlComparerEqualsMethod equalsMethod = CqlComparerEqualsMethod.Equal,
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

            while (type.IsImplementingInterface(typeof(IAdapter)))
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

                var interfaceMapping = type.GetInterfaceMap(typeof(IAdapter));
                instance = interfaceMapping
                           .InterfaceMethods
                           .First(m => m.Name == $"get_{nameof(IAdapter.Inner)}")
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
        string? precision)
    {
        switch (EquivalentMethod)
        {
            case CqlComparerEquivalentMethod.Compare:
                return Compare(left, right, precision) is 0;

            case CqlComparerEquivalentMethod.Equals:
                return Equals(left, right, precision) is true or null;

            case CqlComparerEquivalentMethod.Equivalent:
                var result =
                    EquivalentNulls(IsNull(left), IsNull(right))
                        .OrValue(() => EquivalentValues(left!, right!, precision));
                return result;

            default:
                throw new ArgumentOutOfRangeException();
        }
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
                var result = EqualsNulls(IsNull(left), IsNull(right))
                    .OrValue(() => EqualsValues(left!, right!, precision));
                return result;

            default:
                throw new ArgumentOutOfRangeException();
        }
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
            null  => null,
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
                .OrValue(() => CompareValues(left!, right!, precision));
        return result;
    }

    private Maybe<int?> CompareNulls(
        T? left,
        T? right)
    {
        var leftIsNull = IsNull(left);
        var rightIsNull = IsNull(right);
        var result = NullComparisonStrategy switch
        {
            CqlComparerNullComparisonStrategy.EitherNullReturnsNull  => CompareEitherNullReturnsNull(leftIsNull, rightIsNull),
            CqlComparerNullComparisonStrategy.EitherNullReturnsValue => CompareEitherNullReturnsValue(leftIsNull, rightIsNull),
            _                                                        => throw new ArgumentOutOfRangeException(),
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
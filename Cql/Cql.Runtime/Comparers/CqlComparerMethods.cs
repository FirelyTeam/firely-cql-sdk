using Hl7.Cql.Abstractions;
using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.Primitives;
using static System.StringComparer;

namespace Hl7.Cql.Comparers;

internal static class CqlComparerMethods
{
    /*
     *
     * Equivalence : https://cql.hl7.org/04-logicalspecification.html#equivalent
     *
     * The Equivalent operator returns:
     * - true if the arguments are the same value, or if they are both null;
     * - and false otherwise.
     *
     * With the exception of null behavior and the semantics for specific types defined below, equivalence is the same as equality.
     */

    public static bool? EquivalentOnNullsOnly<T>(
        [NoEnumeration, NotNullWhen(true)] T? left,
        [NoEnumeration, NotNullWhen(true)] T? right)
    {
        bool? result = (left, right) switch
        {
            (null, null) => true,
            (null, _)    => false,
            (_, null)    => false,
            _            => null
        };
        return result;
    }

    /// <summary>
    /// Collapses derived types to their bases, since this makes it easier to find the comparer by the exact type.
    /// </summary>
    public static Type GetKeyTypeForComparers(object? x)
    {
        var type = x switch
        {
            TupleBaseType => typeof(TupleBaseType), // Tuple types generated in the LINQ expressions by the TupleBuilderCache
            ITuple        => typeof(ITuple),        // .NET tuples (e.g. System.ValueTuple<...>) used in generated libraries
            _             => x!.GetType()
        };
        return type;
    }

    public static int? CqlCodeCompare(
        CqlCode? x,
        CqlCode? y,
        CqlCodePrecision precision)
    {
        if (x == null || y == null)
            return null;

        if (x.code == null || y.code == null)
            return null;

        return CqlCodeComparerImpl(x, y, precision);
    }

    private static int? CqlCodeComparerImpl(
        CqlCode x,
        CqlCode y,
        CqlCodePrecision precision)
    {
        if (precision > CqlCodePrecision.CodeAndSystem)
        {
            Debug.Assert(false, "Precision too high");
            precision = CqlCodePrecision.CodeAndSystem;
        }

        var res = CodeComparer.Compare(x.code, y.code);
        if (res != 0)
            return res;

        if (precision >= CqlCodePrecision.CodeAndSystem)
        {
            if ((x.system == null) ^ (y.system == null))
                return null;

            res = OtherComparer.Compare(x.system, y.system);
            if (res != 0)
                return res;
        }

        if (precision == CqlCodePrecision.CodeSystemAndVersion)
        {
            if ((x.version == null) ^ (y.version == null))
                return null;

            res = OtherComparer.Compare(x.version, y.version);
            if (res != 0)
                return res;
        }

        // if (displayComparer is not null)
        // {
        //     if ((x.display == null) ^ (y.display == null))
        //         return null;
        //
        //     res = displayComparer.Compare(x.display, y.display);
        //     return res;
        // }

        return res;
    }

    public static int CqlCodeGetHashCode(
        CqlCode? x,
        CqlCodePrecision precision = CqlCodePrecision.CodeAndSystem)
    {
        if (x == null)
            return typeof(CqlCode).GetHashCode();

        var res = CqlCodeGetHashCodeImpl(x, precision);
        return res;
    }

    private static int CqlCodeGetHashCodeImpl(
        CqlCode x,
        CqlCodePrecision precision = CqlCodePrecision.CodeAndSystem)
    {
        if (precision > CqlCodePrecision.CodeAndSystem)
        {
            Debug.Assert(false, "Precision too high");
            precision = CqlCodePrecision.CodeAndSystem;
        }

        return precision switch
        {
            CqlCodePrecision.Code                 => HashCode.Combine(ForCode(x.code)),
            CqlCodePrecision.CodeAndSystem        => HashCode.Combine(ForCode(x.code), ForOther(x.system)),
            CqlCodePrecision.CodeSystemAndVersion => HashCode.Combine(ForCode(x.code), ForOther(x.system), ForOther(x.version)),
            _                                     => throw new ArgumentOutOfRangeException(nameof(precision), precision, "Invalid precision")
        };

        static int ForOther(string? other) => OtherComparer.GetHashCode(other ?? "\0");

        static int ForCode(string? code) => CodeComparer.GetHashCode(code ?? "\0");
    }

    private static readonly ConcurrentDictionary<(Type typeArg, string? precision, bool useEquivalance), object> EqualityComparers = new();
    private static readonly StringComparer CodeComparer = Ordinal;
    private static readonly StringComparer OtherComparer = OrdinalIgnoreCase;

    public static IEqualityComparer<T> ToEqualityComparer<T>(
        this ICqlComparer<T> cqlComparer,
        string? precision = null,
        bool useEquivalence = false) =>
        (IEqualityComparer<T>)EqualityComparers.GetOrAdd(
            (typeof(T), precision, useEquivalence),
            key => EqualityComparerFactory.For<T>.Create(
                key.useEquivalance
                    ? (a, b) => cqlComparer.Equivalent(a, b, key.precision)
                    : (a, b) => cqlComparer.Equals(a, b, key.precision) == true,
                cqlComparer.GetHashCode));
}
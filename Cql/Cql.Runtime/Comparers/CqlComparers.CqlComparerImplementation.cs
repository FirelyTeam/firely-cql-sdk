/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;

namespace Hl7.Cql.Comparers;

partial class CqlComparers : CqlComparer<object>
{
    private ImmutableList<(string Name, Func<Type, Type, bool> ShouldSwap)> _shouldTypeSwapPredicates =
    [
        // Any type in the System namespace is considered less than any type not in the System namespace.
        ("SystemTypesLowestPriority", (xType, yType) => xType.Namespace == "System" && yType.Namespace != "System"),
    ];

    internal CqlComparers ConfigureTypeSwapPredicates(
        Mutator<ImmutableList<(string Name, Func<Type, Type, bool> ShouldSwap)>> configure)
    {
        _shouldTypeSwapPredicates = configure(_shouldTypeSwapPredicates);
        return this;
    }

    protected override int? CompareValues(
        object x,
        object y,
        string? precision)
    {
        bool xySwapped = false;
        var xType = GetKeyTypeForComparers(x);
        {
            var yType = GetKeyTypeForComparers(y);
            if (xType != yType)
            {
                if (ShouldSwapTypes(xType, yType))
                {
                    xySwapped = true;
                    (x, y) = (y, x);
                    xType = yType; // yType won't be used again
                }
            }
        }

        var comparer = SelectComparer(x, xType);

        if (comparer != null)
        {
            var result = comparer.Compare(x, y, precision);
            if (xySwapped) result = -result;
            return result;
        }

        throw new ArgumentException($"Cannot compare type {xType.Name}");
    }

    private ICqlComparer? SelectComparer(object x, Type xType)
    {
        if (Comparers.TryGetValue(xType, out var c)) return c;

        var comparer = SelectComparerUncached(x, xType);

        // Memoize a comparer resolved via the BaseType walk (below) onto the originally-queried
        // type, so later comparisons of this exact type hit the dictionary directly instead of
        // re-walking the inheritance chain every time.
        if (comparer is not null)
            Comparers.TryAdd(xType, comparer);

        return comparer;
    }

    private ICqlComparer? SelectComparerUncached(object x, Type xType)
    {
        ICqlComparer? comparer = null;

        if (xType.IsGenericType)
        {
            var gtd = xType.GetGenericTypeDefinition();
            if (ComparerFactories.TryGetValue(gtd, out var factory))
            {
                var gc = factory(xType, this);
                Comparers.TryAdd(xType, gc);
                comparer = gc;
            }
            else if (x is IEnumerable && Comparers.TryGetValue(typeof(IEnumerable), out ICqlComparer? enumerableComparer))
            {
                comparer = enumerableComparer;
            }
        }
        else if (x is IEnumerable && Comparers.TryGetValue(typeof(IEnumerable), out ICqlComparer? listComparer))
        {
            comparer = listComparer;
        }

        if (comparer is null && xType.BaseType is not null)
            comparer = SelectComparer(x, xType.BaseType);

        return comparer;
    }

    private bool ShouldSwapTypes(Type xType, Type yType)
    {
        Debug.Assert(xType != yType, "xType and yType must not be the same.");
        foreach (var p in _shouldTypeSwapPredicates)
        {
            if (p.ShouldSwap(xType, yType))
                return true;
        }
        return false;
    }

    protected override bool EquivalentValues(
        object x,
        object y,
        string? precision)
    {
        var xType = GetKeyTypeForComparers(x);
        {
            var yType = GetKeyTypeForComparers(y);
            if (xType != yType)
            {
                if (ShouldSwapTypes(xType, yType))
                {
                    (x, y) = (y, x);
                    xType = yType; // yType won't be used again
                }
            }
        }

        if (Comparers.TryGetValue(xType, out var comparer))
        {
            return comparer.Equivalent(x, y, precision);
        }

        if (xType.IsGenericType)
        {
            var gtd = xType.GetGenericTypeDefinition();
            if (ComparerFactories.TryGetValue(gtd, out var factory))
            {
                var gc = factory(xType, this);
                Comparers.TryAdd(xType, gc);
                return gc.Equivalent(x, y, precision);
            }
        }

        throw new ArgumentException($"Cannot check equivalence for type {xType.Name}");
    }

    protected override bool? EqualsValues(
        object x,
        object y,
        string? precision)
    {
        var xType = GetKeyTypeForComparers(x);
        {
            var yType = GetKeyTypeForComparers(y);
            if (xType != yType)
            {
                if (ShouldSwapTypes(xType, yType))
                {
                    (x, y) = (y, x);
                    xType = yType; // yType won't be used again
                }
            }
        }

        if (Comparers.TryGetValue(xType, out var comparer))
        {
            return comparer.Equals(x, y, precision);
        }

        if (xType.IsGenericType)
        {
            var gtd = xType.GetGenericTypeDefinition();
            if (ComparerFactories.TryGetValue(gtd, out var factory))
            {
                var gc = factory(xType, this);
                Comparers.TryAdd(xType, gc);
                return gc.Equals(x, y, precision);
            }
        }

        throw new ArgumentException($"Cannot check equivalence for type {xType.Name}");
    }

    protected override int GetHashCodeValue(object value)
    {
        var xType = GetKeyTypeForComparers(value);

        // Always resolve through SelectComparer -- the exact same resolution Compare/Equals/
        // Equivalent use (direct registration, generic-factory registrations like KeyValuePair<,>,
        // and the BaseType walk), memoized the same way. Deliberately NOT special-cased with a
        // direct Comparers.TryGetValue check here first: SelectComparer's Compare-path memoization
        // can populate Comparers[xType] with ListEqualComparer for any IEnumerable type (e.g.
        // List<int>) the first time it's merely Compared/Equals-checked, before it's ever hashed --
        // a direct-hit fast path here would then serve that memoized entry for GetHashCode too,
        // which only works correctly if the resolved comparer's own GetHashCodeValue is consistent
        // with its Equals (true for ListEqualComparer, which computes a structural hash -- but this
        // single, unconditional call site is what guarantees that invariant instead of relying on
        // callers to special-case IEnumerable before it can be poisoned by memoization).
        if (SelectComparer(value, xType) is { } resolvedComparer)
        {
            return resolvedComparer.GetHashCode(value);
        }

        throw new ArgumentException($"Cannot generate a hash code for {xType.Name}", nameof(value));
    }
}
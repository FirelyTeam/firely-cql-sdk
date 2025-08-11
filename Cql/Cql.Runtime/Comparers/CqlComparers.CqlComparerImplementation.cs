/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using System.Collections.Immutable;

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

        ICqlComparer? comparer = null;
        if (Comparers.TryGetValue(xType, out var c))
        {
            comparer = c;
        }
        else if (xType.IsGenericType)
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

        if (comparer != null)
        {
            var result = comparer.Compare(x, y, precision);
            if (xySwapped) result = -result;
            return result;
        }

        throw new ArgumentException($"Cannot compare type {xType.Name}");
    }

    private bool ShouldSwapTypes(Type xType, Type yType)
    {
        Debug.Assert(xType != yType, "xType and yType must not be the same.");
        var shouldSwapTypes = _shouldTypeSwapPredicates.Any(p => p.ShouldSwap(xType, yType));
        return shouldSwapTypes;
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

        if (Comparers.TryGetValue(xType, out var comparer))
        {
            return comparer.GetHashCode(value);
        }

        if (value is IEnumerable<object> enumerable)
        {
            int hash = typeof(IEnumerable).GetHashCode();
            var i = 1;
            foreach (var x in enumerable)
            {
                hash ^= i ^ GetHashCode(x);
            }

            return hash;
        }

        throw new ArgumentException($"Cannot generate a hash code for {xType.Name}", nameof(value));
    }
}
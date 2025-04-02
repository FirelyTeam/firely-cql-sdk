/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Comparers;

partial class CqlComparers : CqlComparer<object>
{
    public override int? Compare(
        object? x,
        object? y,
        string? precision)
    {
        // if x or y is null it must return null and if both are null then it's a match
        // if we return 1 or -1 when only 1 side is null then we hit a lot of issues with Stratification: Race - Two or More Races on a lot of measures
        // because it expects null/false but gets true because 1 was returned (x null, y = 2) so 2 > null => return 1
        switch (x, y)
        {
            case (null, null):         return 0;
            case (not null, not null): return ((ICqlComparer)this).CompareValues(x, y, precision);
            default:                   return null;
        }
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
                // if x and y are not the same type, we prioritize them based on the following order:
                // 1. If only one type is in the System namespace, we prioritize the other type
                if (xType.Namespace == "System" && yType.Namespace != "System")
                {
                    xySwapped = true;
                    (x, y) = (y, x);
                    xType = yType; // yType won't be used again, so no need to swap it
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

    protected override bool EquivalentValues(
        object x,
        object y,
        string? precision)
    {
        var xType = GetKeyTypeForComparers(x);

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
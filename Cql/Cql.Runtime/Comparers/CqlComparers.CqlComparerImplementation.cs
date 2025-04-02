namespace Hl7.Cql.Comparers;

partial class CqlComparers : CqlComparer<object>
{
    protected internal override int? CompareValues(
        object left,
        object right,
        string? precision)
    {
    // public override int? Compare(
    //     object? left,
    //     object? right,
    //     string? precision)
    // {
    //     if (left == null || right == null)
    //         return null;

        bool xySwapped = false;
        var xType = GetKeyTypeForComparers(left);
        {
            var yType = GetKeyTypeForComparers(right);
            if (xType != yType)
            {
                // if x and y are not the same type, we prioritize them based on the following order:
                // 1. If only one type is in the System namespace, we prioritize the other type
                if (xType.Namespace == "System" && yType.Namespace != "System")
                {
                    xySwapped = true;
                    (left, right) = (right, left);
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
            else if (left is IEnumerable && Comparers.TryGetValue(typeof(IEnumerable), out ICqlComparer? enumerableComparer))
            {
                comparer = enumerableComparer;
            }
        }
        else if (left is IEnumerable && Comparers.TryGetValue(typeof(IEnumerable), out ICqlComparer? listComparer))
        {
            comparer = listComparer;
        }

        if (comparer != null)
        {
            var result = comparer.Compare(left, right, precision);
            if (xySwapped) result = -result;
            return result;
        }

        throw new ArgumentException($"Cannot compare type {xType.Name}");
    }

    protected override bool EquivalentValues(
        object left,
        object right,
        string? precision)
    {
        var xType = GetKeyTypeForComparers(left);

        if (Comparers.TryGetValue(xType, out var comparer))
        {
            return comparer.Equivalent(left, right, precision);
        }

        if (xType.IsGenericType)
        {
            var gtd = xType.GetGenericTypeDefinition();
            if (ComparerFactories.TryGetValue(gtd, out var factory))
            {
                var gc = factory(xType, this);
                Comparers.TryAdd(xType, gc);
                return gc.Equivalent(left, right, precision);
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
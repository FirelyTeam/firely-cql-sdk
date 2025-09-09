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
                // Try to handle IValue<T> vs T comparison before doing type swapping
                var iValueResult = TryHandleIValueComparison(x, y, precision, (a, b, p) => {
                    var compareResult = CompareValues(a, b, p);
                    return compareResult ?? 0; // Convert nullable int to int for generic constraint
                });
                
                // Check if this was actually an IValue comparison that should return a result
                var xIValueInterface = GetIValueInterface(x.GetType());
                var yIValueInterface = GetIValueInterface(y.GetType());
                if ((xIValueInterface != null && yIValueInterface == null) ||
                    (yIValueInterface != null && xIValueInterface == null))
                {
                    return iValueResult == 0 ? 0 : iValueResult; // Convert back to nullable
                }

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
                // Try to handle IValue<T> vs T comparison before doing type swapping
                var iValueResult = TryHandleIValueEquivalence(x, y, precision);
                if (iValueResult.HasValue)
                {
                    return iValueResult.Value;
                }

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
                // Try to handle IValue<T> vs T comparison before doing type swapping
                var iValueResult = TryHandleIValueComparison(x, y, precision, (a, b, p) => {
                    var equalsResult = EqualsValues(a, b, p);
                    return equalsResult ?? false; // Convert nullable bool to bool for generic constraint
                });
                
                // Check if this was actually an IValue comparison that should return a result
                var xIValueInterface = GetIValueInterface(x.GetType());
                var yIValueInterface = GetIValueInterface(y.GetType());
                if ((xIValueInterface != null && yIValueInterface == null) ||
                    (yIValueInterface != null && xIValueInterface == null))
                {
                    return iValueResult ? true : (bool?)false; // Convert back to nullable
                }

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

    /// <summary>
    /// Attempts to handle comparison between an IValue&lt;T&gt; type and its underlying type T.
    /// </summary>
    /// <param name="x">First operand</param>
    /// <param name="y">Second operand</param>
    /// <param name="precision">Precision for comparison</param>
    /// <param name="comparisonMethod">The comparison method to call</param>
    /// <returns>The comparison result, or null if this is not an IValue vs T comparison</returns>
    private TResult? TryHandleIValueComparison<TResult>(
        object x, 
        object y, 
        string? precision,
        Func<object, object, string?, TResult> comparisonMethod)
    {
        // Check if one is an IValue<T> and the other is T
        var xType = x.GetType();
        var yType = y.GetType();
        
        // Look for IValue<T> interface
        var xIValueInterface = GetIValueInterface(xType);
        var yIValueInterface = GetIValueInterface(yType);
        
        if (xIValueInterface != null && yIValueInterface == null)
        {
            // x is IValue<T>, y might be T
            var valueType = xIValueInterface.GetGenericArguments()[0];
            if (valueType == yType || (valueType.IsAssignableFrom(yType)))
            {
                // Extract value from IValue<T>
                var valueProperty = xIValueInterface.GetProperty("Value");
                if (valueProperty != null)
                {
                    var xValue = valueProperty.GetValue(x);
                    if (xValue != null)
                    {
                        return comparisonMethod(xValue, y, precision);
                    }
                }
            }
        }
        else if (yIValueInterface != null && xIValueInterface == null)
        {
            // y is IValue<T>, x might be T
            var valueType = yIValueInterface.GetGenericArguments()[0];
            if (valueType == xType || (valueType.IsAssignableFrom(xType)))
            {
                // Extract value from IValue<T>
                var valueProperty = yIValueInterface.GetProperty("Value");
                if (valueProperty != null)
                {
                    var yValue = valueProperty.GetValue(y);
                    if (yValue != null)
                    {
                        return comparisonMethod(x, yValue, precision);
                    }
                }
            }
        }
        
        return default(TResult);
    }

    /// <summary>
    /// Attempts to handle equivalence comparison between an IValue&lt;T&gt; type and its underlying type T.
    /// </summary>
    private bool? TryHandleIValueEquivalence(object x, object y, string? precision)
    {
        // For equivalence, we need to handle the nullable bool specially since TResult can't be nullable with generic constraints
        var result = TryHandleIValueComparison<bool>(x, y, precision, (a, b, p) => {
            var equivResult = EquivalentValues(a, b, p);
            return equivResult; // Convert bool to bool (removing nullable in this context)
        });
        
        // Check if we got a meaningful result (not default value)
        var xType = x.GetType();
        var yType = y.GetType();
        var xIValueInterface = GetIValueInterface(xType);
        var yIValueInterface = GetIValueInterface(yType);
        
        if ((xIValueInterface != null && yIValueInterface == null) ||
            (yIValueInterface != null && xIValueInterface == null))
        {
            return result;
        }
        
        return null;
    }

    /// <summary>
    /// Gets the IValue&lt;T&gt; interface from a type, if it implements one.
    /// Excludes Code&lt;T&gt; types since they have specialized comparers.
    /// </summary>
    private static Type? GetIValueInterface(Type type)
    {
        // Exclude Code<T> types as they have specialized comparison logic
        if (type.IsGenericType && type.GetGenericTypeDefinition().Name == "Code`1")
        {
            return null;
        }
        
        return type.GetInterfaces()
            .FirstOrDefault(i => i.IsGenericType && 
                                i.GetGenericTypeDefinition().Name == "IValue`1");
    }
}
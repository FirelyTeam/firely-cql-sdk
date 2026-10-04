#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Fhir.Metrics;
using Hl7.Cql.Primitives;
using System.Numerics;

namespace Hl7.Cql.Operators
{
    internal partial class CqlOperators
    {
        /// <summary>
        /// Reports quantities whose units the aggregate does not bring to a common unit, and answers null: "a CQL
        /// implementation must respect units and return null if it is not capable of normalizing the quantities
        /// involved in a given expression to a common unit. Implementations should issue a run-time warning in these
        /// cases as well" (CQL 1.5.3 Errata 2, Chapter 2 - Author's Guide, section "Clinical Operators", "Quantity
        /// Operators").
        /// </summary>
        private CqlQuantity? InconsistentUnits(object source, string code, string operation)
        {
            Message(source, code, "Warning", $"Ignored inconsistent units errors from {operation}, returned null.");
            return null;
        }

        #region AllTrue
        public bool? AllTrue(IEnumerable<bool?> argument)
        {
            if (argument == null)
                return true;
            else
            {
                foreach (bool? val in argument)
                {
                    if (val == false) return false;
                }
                return true;
            }
        }

        public bool? AllTrue(IEnumerable<Lazy<bool?>> argument)
        {
            if (argument == null) return true;
            else
            {
                foreach (Lazy<bool?> val in argument)
                {
                    if (val.Value == false) return false;
                }
                return true;
            }
        }

        #endregion

        #region AnyTrue

        public bool? AnyTrue(IEnumerable<bool?> argument)
        {
            if (argument == null)
                return false;
            foreach (var value in argument)
                if (value == true)
                    return true;
            return false;
        }

        public bool? AnyTrue(IEnumerable<Lazy<bool?>> argument)
        {
            if (argument == null) return false;
            foreach (Lazy<bool?> value in argument)
                if (value.Value == true) return true;
            return false;
        }

        #endregion

        #region Avg

        public decimal? Avg(IEnumerable<decimal?>? argument)
        {
            if (argument == null)
                return null;
            else
            {
                // One walk of the source: the emptiness test, the total and the count all come out of the same
                // pass, where the Where/Select query behind them was walked three times.
                decimal total = 0;
                var count = 0;
                foreach (var value in argument)
                {
                    if (value.HasValue)
                    {
                        if (OverflowGuard.Add(total, value.Value) is not { } next)
                            return Overflowed<decimal?>(new { argument }, "CqlOperators.AggregateFunctions.Avg", "type decimal average");
                        total = next;
                        count++;
                    }
                }

                // The quotient of a total by a count of at least one is no larger than the total.
                return count == 0 ? null : total / count;
            }
        }

        #endregion

        #region Count

        public int? Count<T>(IEnumerable<T>? source) =>
            source == null ? null : source.Where(t => t != null).Count();

        #endregion

        #region GeometricMean

        public decimal? GeometricMean(IEnumerable<decimal?> argument)
        {
            if (argument == null) return null;
            else
            {
                // Seeding with the multiplicative identity keeps a genuine 0 element in the product. The previous
                // "product == 0 means uninitialized" idiom dropped such an element while still counting it, so a
                // list containing a zero got a non-zero geometric mean.
                decimal product = 1m;
                var nonNullCount = 0;
                foreach (decimal? d in argument)
                {
                    if (d != null)
                    {
                        // A product outside Decimal's range, or a product of nonzero values too small in magnitude to
                        // represent, means Product(X) cannot be represented and neither can Power of it. Per the spec (§9.B) Power: if the result cannot be represented, the result is
                        // null. The geometric mean of such a list can still be representable - the product is
                        // accumulated in Decimal - so the warning keeps the null visible in the evaluation log rather
                        // than letting it pass as an ordinary result.
                        if (OverflowGuard.Multiply(product, d.Value) is not { } next)
                            return Overflowed<decimal?>(new { argument }, "CqlOperators.AggregateFunctions.GeometricMean", "decimal geometric mean product");
                        product = next;
                        nonNullCount++;
                    }
                }
                if (nonNullCount == 0) return null;
                else
                {
                    // The spec (§9.B) defines this as Power(Product(X), 1 / Count(X)), and CQL's Count is the number
                    // of non-null elements - which the loop above already has, where reading argument.Count() here
                    // both walked the source a second time and counted the nulls the product skipped.
                    double count = 1.0 / nonNullCount;
                    double result = Math.Pow((double)product, count);
                    // Per the spec (§9.B) Power: if the result cannot be represented, the result is null. A negative
                    // product under a fractional root has no real value (Math.Pow gives NaN), and a result outside
                    // Decimal's range is not representable either; both are null rather than an OverflowException
                    // out of the cast.
                    return OverflowGuard.ToDecimal(result)
                        ?? Overflowed<decimal?>(new { argument, product, result }, "CqlOperators.AggregateFunctions.GeometricMean", "decimal geometric mean result");
                }
            }
        }

        #endregion

        #region Max
        public T Max<T>(IEnumerable<T>? items)
        {
            if (items == null)
                return default!;
            var notNull = items.Cast<object>()
                .Where(i => i != null)
                .ToList();
            if (notNull.Count == 0)
                return default!;
            else
            {
                var max = notNull[0];
                for (int i = 1; i < notNull.Count; i++)
                {
                    if (Comparer.Compare(notNull[i], max, null) > 0)
                        max = notNull[i];
                }
                return (T)max;
            }
        }

        #endregion

        #region Min

        public T Min<T>(IEnumerable<T>? items)
        {
            if (items == null)
                return default!;
            var notNull = items.Cast<object>()
                .Where(i => i != null)
                .ToList();
            if (notNull.Count == 0)
                return default!;
            else
            {
                var min = notNull[0];
                for (int i = 1; i < notNull.Count; i++)
                {
                    if (Comparer.Compare(notNull[i], min, null) < 0)
                        min = notNull[i];
                }
                return (T)min;
            }
        }


        #endregion

        #region Median



        // The three overloads share one shape: collect the non-null values in a single pass, sort them into a new
        // list, and read the middle out of that sorted list by index. Reading the odd-length median out of the
        // original source instead - as this used to - walks the source a second time and indexes into a sequence
        // that is neither sorted nor stripped of its nulls, so it returns an arbitrary element rather than the
        // median. The even-count midpoint of the Integer and Long overloads is taken in a wider type: summing the
        // two middle values first overflows for values near the type's maximum, which wraps silently in C#'s
        // default unchecked context and turns the median of two large values into a negative one.

        public decimal? Median(IEnumerable<decimal?> source)
        {
            if (source == null)
                return null;

            var sorted = SortedNonNullValues(source);
            if (sorted.Count == 0)
                return null;

            // check if the 1 bit is set or not.  if not, number is even
            var isEven = (sorted.Count & 1) == 0;
            // shift by 1 to divide by 2
            var middle = sorted.Count >> 1;
            return isEven ? Midpoint(sorted[middle - 1], sorted[middle]) : sorted[middle];
        }

        /// <summary>
        /// The midpoint of two decimals, <paramref name="low"/> not above <paramref name="high"/>. Two values whose sum
        /// leaves the Decimal range have the same sign, so their difference fits, and the midpoint is taken from the lower
        /// value instead; it lies between the two values and so is always representable.
        /// </summary>
        private static decimal Midpoint(decimal low, decimal high) =>
            OverflowGuard.Add(low, high) is { } sum ? sum / 2m : low + (high - low) / 2m;

        public int? Median(IEnumerable<int?> source)
        {
            if (source == null)
                return null;

            var sorted = SortedNonNullValues(source);
            if (sorted.Count == 0)
                return null;

            var isEven = (sorted.Count & 1) == 0;
            var middle = sorted.Count >> 1;
            // long holds the sum of any two int values, so the midpoint truncates towards zero exactly as an int
            // division of a non-overflowing sum does.
            return isEven ? (int)(((long)sorted[middle] + sorted[middle - 1]) / 2L) : sorted[middle];
        }

        public long? Median(IEnumerable<long?> source)
        {
            if (source == null)
                return null;

            var sorted = SortedNonNullValues(source);
            if (sorted.Count == 0)
                return null;

            var isEven = (sorted.Count & 1) == 0;
            var middle = sorted.Count >> 1;
            // decimal holds the sum of any two long values exactly, and the cast back truncates towards zero exactly
            // as a long division of a non-overflowing sum does.
            return isEven ? (long)(((decimal)sorted[middle] + sorted[middle - 1]) / 2m) : sorted[middle];
        }

        private static List<T> SortedNonNullValues<T>(IEnumerable<T?> source)
            where T : struct, IComparable<T>
        {
            var values = new List<T>();
            foreach (var value in source)
            {
                if (value.HasValue)
                    values.Add(value.Value);
            }

            // OrderBy rather than List<T>.Sort: the in-place sort is unstable, and for decimals two equal values
            // can differ in scale (1.0m vs 1.000m), so an unstable sort could change which representation the
            // median reports depending on input size and layout.
            return values.OrderBy(static v => v).ToList();
        }


        #endregion

        #region Mode

        public T Mode<T>(IEnumerable<T>? typedSource)
        {
            var source = typedSource?.Cast<object?>();
            if (source == null)
            {
                return (T)(object)null!;
            }
            else
            {
                var nonNull = source
                    .Where(o => o != null)
                    .ToList();
                if (nonNull.Count == 0)
                {
                    return (T)(object)null!;
                }
                else
                {
                    var sizes = new Dictionary<object, int>(EqualityComparer);
                    object? modeObject = null;
                    var modeCount = 0;
                    foreach (var o in nonNull)
                    {
                        if (!sizes.TryGetValue(o!, out int i))
                            i = 0;
                        i += 1;
                        sizes[o!] = i;
                        if (i > modeCount)
                        {
                            modeObject = o;
                            modeCount = i;
                        }
                    }
                    return (T)modeObject!;
                }
            }
        }



        #endregion

        #region Population StdDev


        public decimal? PopulationStdDev(IEnumerable<decimal?>? source)
        {
            if (source == null)
            {
                return null;
            }
            else
            {
                var nonNull = source
                    .Where(d => d.HasValue)
                    .Select(d => d!.Value)
                    .ToList();
                if (nonNull.Count == 0)
                {
                    return null;
                }
                else
                {
                    // Formula: Sqrt( summation(each value from population - population mean)^2 / size of population)
                    if (PopulationVarianceOf(nonNull) is not { } overCount)
                        return Overflowed<decimal?>(new { source }, "CqlOperators.AggregateFunctions.PopulationStdDev", "type decimal population standard deviation");
                    // The root of a value in the Decimal range is within that range.
                    var result = (decimal)Math.Sqrt((double)overCount);
                    return result;
                }

            }
        }


        public CqlQuantity? PopulationStdDev(IEnumerable<CqlQuantity?>? source)
        {
            if (source == null)
            {
                return null;
            }
            else
            {
                var nonNull = source
                    .Where(d => d != null && d.value.HasValue)
                    .ToList();
                if (nonNull.Count == 0)
                {
                    return null;
                }
                else
                {
                    var unit = nonNull.Select(q => q!.unit).FirstOrDefault() ?? "1";
                    // Formula: Sqrt( summation(each value from population - population mean)^2 / size of population)
                    if (PopulationVarianceOf(nonNull.Select(q => q!.value!.Value).ToList()) is not { } overCount)
                        return Overflowed<CqlQuantity>(new { source }, "CqlOperators.AggregateFunctions.PopulationStdDev", "type CqlQuantity population standard deviation");
                    // The root of a value in the Decimal range is within that range.
                    var result = (decimal)Math.Sqrt((double)overCount);
                    return new CqlQuantity(result, unit);
                }
            }
        }

        /// <summary>
        /// The mean of the squared deviations of <paramref name="values"/> from their mean, or <see langword="null"/>
        /// when their total, a deviation, its square or the sum of the squares cannot be represented.
        /// </summary>
        private static decimal? PopulationVarianceOf(List<decimal> values)
        {
            decimal total = 0;
            foreach (var value in values)
            {
                if (OverflowGuard.Add(total, value) is not { } nextTotal)
                    return null;
                total = nextTotal;
            }

            var mean = total / values.Count;
            decimal summation = 0;
            foreach (var value in values)
            {
                if (OverflowGuard.Subtract(value, mean) is not { } deviation
                    || Square(deviation) is not { } square
                    || OverflowGuard.Add(summation, square) is not { } nextSummation)
                    return null;
                summation = nextSummation;
            }

            return summation / values.Count;
        }

        /// <summary>
        /// The square of a deviation, or <see langword="null"/> when it is outside the Decimal range. A deviation below
        /// one in magnitude cannot overflow, and a square too small to represent adds nothing to the sum of squares, so
        /// it counts as zero.
        /// </summary>
        private static decimal? Square(decimal deviation) =>
            Math.Abs(deviation) < 1m ? deviation * deviation : OverflowGuard.Multiply(deviation, deviation);

        #endregion

        #region Population Variance

        public decimal? PopulationVariance(IEnumerable<decimal?>? source)
        {
            if (source == null)
            {
                return null;
            }
            else
            {
                var nonNull = source
                    .Where(d => d.HasValue)
                    .Select(d => d!.Value)
                    .ToList();
                if (nonNull.Count == 0)
                {
                    return null;
                }
                else
                {
                    // Formula: summation(each value from population - population mean)^2 / size of population
                    return PopulationVarianceOf(nonNull)
                        ?? Overflowed<decimal?>(new { source }, "CqlOperators.AggregateFunctions.PopulationVariance", "type decimal population variance");
                }
            }
        }


        public CqlQuantity? PopulationVariance(IEnumerable<CqlQuantity?>? source)
        {
            if (source == null)
            {
                return null;
            }
            else
            {
                var nonNull = source
                    .Where(d => d != null && d.value.HasValue)
                    .ToList();
                if (nonNull.Count == 0)
                {
                    return null;
                }
                else
                {
                    var unit = nonNull.Select(q => q!.unit).FirstOrDefault() ?? "1";

                    if (PopulationVarianceOf(nonNull.Select(q => q!.value!.Value).ToList()) is not { } result)
                        return Overflowed<CqlQuantity>(new { source }, "CqlOperators.AggregateFunctions.PopulationVariance", "type CqlQuantity population variance");
                    return new CqlQuantity(result, unit);
                }
            }
        }

        #endregion

        #region Product

        public int? Product(IEnumerable<int?>? argument) => Multiplied(argument, "type integer product");

        public long? Product(IEnumerable<long?>? argument) => Multiplied(argument, "type long product");

        public decimal? Product(IEnumerable<decimal?>? argument) => Multiplied(argument, "type decimal product");

        public CqlQuantity? Product(IEnumerable<CqlQuantity?>? argument)
        {
            if (argument == null)
                return null;
            var nonNull = argument
                .Where(q => q != null && q.value != null)
                .ToArray();
            if (nonNull.Length == 0)
                return null;
            decimal product = 1;
            string? unit = null;
            foreach (var v in nonNull)
            {
                var quantityUnit = v!.unit ?? "1";
                unit ??= quantityUnit;
                if (unit != quantityUnit)
                    return InconsistentUnits(new { argument }, "CqlOperators.AggregateFunctions.Product", "type CqlQuantity product");
                if (OverflowGuard.Multiply(product, v.value!.Value) is not { } next)
                    return Overflowed<CqlQuantity>(new { argument }, "CqlOperators.AggregateFunctions.Product", "type CqlQuantity product");
                product = next;
            }
            return new CqlQuantity(product, unit ?? "1");
        }

        /// <summary>
        /// The product of the values that are not null, or <see langword="null"/> when there are none or when a partial
        /// product cannot be represented.
        /// </summary>
        private T? Multiplied<T>(IEnumerable<T?>? values, string operation) where T : struct, INumberBase<T>
        {
            if (values == null)
                return null;

            T? product = null;
            foreach (var value in values)
            {
                if (value is not { } factor)
                    continue;

                if (OverflowGuard.Multiply(product ?? T.One, factor) is not { } next)
                    return Overflowed<T?>(new { values }, "CqlOperators.AggregateFunctions.Product", operation);
                product = next;
            }

            return product;
        }

        #endregion

        #region StdDev

        public decimal? StdDev(IEnumerable<decimal?>? argument)
        {
            if (argument is null) return null;

            var nonNull = argument
                .Where(d => d != null)
                .Select(d => (double)d!.Value)
                .ToArray();
            if (nonNull.Length == 0)
                return null;
            if (SampleStdDev(nonNull) is not { } result)
                return null;
            return OverflowGuard.ToDecimal(result)
                ?? Overflowed<decimal?>(new { argument }, "CqlOperators.AggregateFunctions.StdDev", "type decimal standard deviation");
        }

        public CqlQuantity? StdDev(IEnumerable<CqlQuantity?>? argument)
        {
            if (argument is null) return null;

            if (QuantityValues(argument, "CqlOperators.AggregateFunctions.StdDev", "type CqlQuantity standard deviation") is not var (values, unit))
                return null;
            if (SampleStdDev(values) is not { } result)
                return null;
            return OverflowGuard.ToDecimal(result) is { } value
                ? new CqlQuantity(value, unit)
                : Overflowed<CqlQuantity>(new { argument }, "CqlOperators.AggregateFunctions.StdDev", "type CqlQuantity standard deviation");
        }

        /// <summary>
        /// The sample standard deviation, or <see langword="null"/> for fewer than two values: it divides by one less
        /// than the number of values, and "operations that cause arithmetic overflow or underflow, or otherwise cannot
        /// be performed (such as division by 0) will result in null" (CQL 1.5.3 Errata 2, Appendix B - CQL Reference,
        /// section "Arithmetic Operators").
        /// </summary>
        private static double? SampleStdDev(double[] values)
        {
            if (values.Length < 2)
                return null;

            var average = values.Average();
            var sum = values.Sum(d => Math.Pow(d - average, 2));
            return Math.Sqrt(sum / (values.Length - 1));
        }

        /// <summary>
        /// The values of the quantities that have one, as doubles, and their common unit; or <see langword="null"/>
        /// when there are none, or when their units differ, which is reported as a warning.
        /// </summary>
        private (double[] Values, string Unit)? QuantityValues(IEnumerable<CqlQuantity?> argument, string code, string operation)
        {
            var nonNull = argument
                .Where(d => d != null && d.value != null)
                .ToArray();
            if (nonNull.Length == 0)
                return null;
            var units = nonNull
                .Select(q => q!.unit ?? "1")
                .Distinct(StringComparer.OrdinalIgnoreCase)
                .ToArray();
            if (units.Length != 1)
            {
                InconsistentUnits(new { argument }, code, operation);
                return null;
            }

            return (nonNull.Select(q => (double)q!.value!.Value).ToArray(), units[0]);
        }

        #endregion

        #region Sum

        public int? Sum(IEnumerable<int?>? values) => Total(values, "type integer summation");

        public long? Sum(IEnumerable<long?>? values) => Total(values, "type long summation");

        public decimal? Sum(IEnumerable<decimal?>? values) => Total(values, "type decimal summation");

        public CqlQuantity? Sum(IEnumerable<CqlQuantity?>? values)
        {
            if (values == null)
                return null;

            string? unit = null;
            decimal? sum = null;
            foreach (var quantity in values)
            {
                if (quantity is not { value: { } value, unit: var quantityUnit })
                    continue;

                quantityUnit ??= "1"; // default unit if none specified
                unit ??= quantityUnit; // set the unit once, if not already set
                if (unit != quantityUnit)
                    return InconsistentUnits(new { values }, "CqlOperators.AggregateFunctions.Sum", "type CqlQuantity summation");

                if (OverflowGuard.Add(sum ?? 0m, value) is not { } next)
                    return Overflowed<CqlQuantity>(new { values }, "CqlOperators.AggregateFunctions.Sum", "type CqlQuantity summation");
                sum = next;
            }

            return sum is { } total ? new CqlQuantity(total, unit ?? "1") : null;
        }

        /// <summary>
        /// The sum of the values that are not null, or <see langword="null"/> when there are none or when a partial sum
        /// cannot be represented.
        /// </summary>
        private T? Total<T>(IEnumerable<T?>? values, string operation) where T : struct, INumberBase<T>
        {
            if (values == null)
                return null;

            T? sum = null;
            foreach (var value in values)
            {
                if (value is not { } addend)
                    continue;

                if (OverflowGuard.Add(sum ?? T.Zero, addend) is not { } next)
                    return Overflowed<T?>(new { values }, "CqlOperators.AggregateFunctions.Sum", operation);
                sum = next;
            }

            return sum;
        }

        #endregion

        #region Variance

        public decimal? Variance(IEnumerable<decimal?>? argument)
        {
            if (argument is null) return null;

            var nonNull = argument
                .Where(d => d != null)
                .Select(d => (double)d!.Value)
                .ToArray();
            if (nonNull.Length == 0 || SampleStdDev(nonNull) is not { } stdDev)
                return null;
            return SquareOfStdDev(stdDev)
                ?? Overflowed<decimal?>(new { argument }, "CqlOperators.AggregateFunctions.Variance", "type decimal variance");
        }

        public CqlQuantity? Variance(IEnumerable<CqlQuantity?>? argument)
        {
            if (argument is null) return null;

            if (QuantityValues(argument, "CqlOperators.AggregateFunctions.Variance", "type CqlQuantity variance") is not var (values, unit)
                || SampleStdDev(values) is not { } stdDev)
                return null;
            return SquareOfStdDev(stdDev) is { } varianceVal
                ? new CqlQuantity(varianceVal, unit)
                : Overflowed<CqlQuantity>(new { argument }, "CqlOperators.AggregateFunctions.Variance", "type CqlQuantity variance");
        }

        /// <summary>
        /// The square of a standard deviation taken to Decimal, or <see langword="null"/> when the standard deviation or
        /// its square is outside the Decimal range.
        /// </summary>
        private static decimal? SquareOfStdDev(double stdDev) =>
            OverflowGuard.ToDecimal(stdDev) is { } value ? OverflowGuard.ToDecimal(Math.Pow((double)value, 2)) : null;

        #endregion
    }
}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
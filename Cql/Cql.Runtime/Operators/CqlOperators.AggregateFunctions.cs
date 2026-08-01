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
                        total += value.Value;
                        count++;
                    }
                }

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
                        product *= d.Value;
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
                    return (decimal)Math.Pow((double)product, count);
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



        // The three overloads share one shape: collect the non-null values in a single pass, sort them in place,
        // and read the middle out of that sorted list by index. Reading the odd-length median out of the original
        // source instead - as this used to - walks the source a second time and indexes into a sequence that is
        // neither sorted nor stripped of its nulls, so it returns an arbitrary element rather than the median.

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
            // can't shift decimals so use division
            return isEven ? (sorted[middle] + sorted[middle - 1]) / 2m : sorted[middle];
        }

        public int? Median(IEnumerable<int?> source)
        {
            if (source == null)
                return null;

            var sorted = SortedNonNullValues(source);
            if (sorted.Count == 0)
                return null;

            var isEven = (sorted.Count & 1) == 0;
            var middle = sorted.Count >> 1;
            return isEven ? (sorted[middle] + sorted[middle - 1]) / 2 : sorted[middle];
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
            return isEven ? (sorted[middle] + sorted[middle - 1]) / 2L : sorted[middle];
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
                    .ToList();
                if (nonNull.Count == 0)
                {
                    return null;
                }
                else
                {
                    // Formula: Sqrt( summation(each value from population - population mean)^2 / size of population)
                    var mean = Avg(nonNull)!.Value;
                    var summation = nonNull
                        .Select(d => d!.Value)
                        .Sum(d =>
                        {
                            var a = d - mean;
                            return a * a;
                        });
                    var overCount = (double)(summation / nonNull.Count);
                    var result = (decimal)Math.Sqrt(overCount);
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
                    var mean = Avg(nonNull.Select(q => q!.value));
                    var summation = nonNull
                        .Select(q => q!.value)
                        .Sum(d =>
                        {
                            var a = d - mean;
                            return a * a;
                        });
                    var overCount = (double)(summation! / nonNull.Count);
                    var result = (decimal)Math.Sqrt(overCount);
                    return new CqlQuantity(result, unit);
                }
            }
        }



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
                    .ToList();
                if (nonNull.Count == 0)
                {
                    return null;
                }
                else
                {
                    // Formula: Sqrt( summation(each value from population - population mean)^2 / size of population)
                    var mean = Avg(nonNull)!.Value;
                    var summation = nonNull
                        .Select(d => d!.Value)
                        .Sum(d =>
                        {
                            var a = d - mean;
                            return a * a;
                        });
                    decimal result = summation / nonNull.Count;
                    return result;
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

                    decimal mean = Avg(nonNull.Select(q => q!.value))!.Value;
                    var summation = nonNull
                        .Sum(d =>
                        {
                            decimal a = d!.value!.Value - mean;
                            return a * a;
                        });
                    var result = summation / nonNull!.Count;
                    return new CqlQuantity(result, unit);
                }
            }
        }

        #endregion

        #region Product

        public int? Product(IEnumerable<int?>? argument)
        {
            if (argument == null)
                return null;
            int product = 1;

            bool @null = true;
            foreach (var v in argument)
            {
                if (v.HasValue)
                {
                    @null = false;
                    product *= v.Value;
                }
            }
            if (@null)
                return null;
            return product;
        }

        public long? Product(IEnumerable<long?>? argument)
        {
            if (argument == null)
                return null;
            long product = 1;

            bool @null = true;
            foreach (var v in argument)
            {
                if (v.HasValue)
                {
                    @null = false;
                    product *= v.Value;
                }
            }
            if (@null)
                return null;
            return product;
        }

        public decimal? Product(IEnumerable<decimal?>? argument)
        {
            if (argument == null)
                return null;
            decimal product = 1m;

            bool @null = true;
            foreach (var v in argument)
            {
                if (v.HasValue)
                {
                    @null = false;
                    product *= v.Value;
                }
            }
            if (@null)
                return null;
            return product;
        }

        public CqlQuantity? Product(IEnumerable<CqlQuantity?>? argument)
        {
            if (argument == null)
                return null;
            var nonNull = argument
                .Where(q => q != null && q.value != null)
                .ToArray();
            if (nonNull.Length == 0)
                return null;
            decimal? product = 1;
            string? unit = null;
            foreach (var v in nonNull)
            {
                unit ??= (v!.unit ?? "1");
                if (unit != v!.unit)
                    throw new NotSupportedException("Unlike units are not supported.");
                product *= v.value!.Value;
            }
            return new CqlQuantity(product, unit ?? "1");
        }

        #endregion

        #region StdDev

        public decimal? StdDev(IEnumerable<decimal?>? argument)
        {
            if (argument is null) return null;

            double result = 0;
            var nonNull = argument
                .Where(d => d != null)
                .Select(d => (double)d!.Value)
                .ToArray();
            if (nonNull.Length == 0)
                return null;
            double average = nonNull.Average();
            var sum = nonNull.Sum(d => Math.Pow(d - average, 2));
            result = Math.Sqrt((sum) / (nonNull.Count() - 1));
            return (decimal)result;
        }

        public CqlQuantity? StdDev(IEnumerable<CqlQuantity?>? argument)
        {
            if (argument is null) return null;

            var nonNull = argument
                .Where(d => d != null && d.value != null)
                .ToArray();
            if (nonNull.Length == 0)
                return null;
            var values = nonNull
                .Select(q => (double)q!.value!.Value);
            var units = nonNull
                .Select(q => q!.unit ?? "1")
                .Distinct(StringComparer.OrdinalIgnoreCase)
                .ToArray();
            if (units.Length != 1)
                throw new NotSupportedException("Mixed units are not supported.");

            var average = values.Average();
            var sum = values.Sum(d => Math.Pow(d - average, 2));
            var result = (decimal)Math.Sqrt((sum) / (nonNull.Count() - 1));
            return new CqlQuantity(result, units[0]);
        }

        #endregion

        #region Sum

        public int? Sum(IEnumerable<int?>? values)
        {
            try
            {
                return values.CqlSum();
            }
            catch (OverflowException e)
            {
                Message(new { values, e }, "CqlOperators.AggregateFunctions.Sum", "Warning", "Ignored overflow errors from type integer summation, returned null.");
                return null;
            }
        }

        public long? Sum(IEnumerable<long?>? values)
        {
            try
            {
                return values.CqlSum();
            }
            catch (OverflowException e)
            {
                Message(new { values, e }, "CqlOperators.AggregateFunctions.Sum", "Warning", "Ignored overflow errors from type long summation, returned null.");
                return null;
            }
        }

        public decimal? Sum(IEnumerable<decimal?>? values)
        {
            try
            {
                return values.CqlSum();
            }
            catch (OverflowException e)
            {
                Message(new { values, e }, "CqlOperators.AggregateFunctions.Sum", "Warning", "Ignored overflow errors from type decimal summation, returned null.");
                return null;
            }
        }

        public CqlQuantity? Sum(IEnumerable<CqlQuantity?>? values)
        {
            string? unit = null;

            (bool hasValue, decimal value) GetValueAndCheckUnit(CqlQuantity? quantity)
            {
                switch (quantity)
                {
                    case { value: { } v, unit: var u }:
                        u ??= "1"; // default unit if none specified
                        unit ??= u; // set the unit once, if not already set
                        if (unit != u)
                            throw new NotSupportedException("Inconsistent units are not supported.");

                        return (true, value: v);

                    default:
                        return default;
                }
            }

            decimal? Aggregate(decimal? quantityAcc, decimal quantityValue)
            {
                checked
                {
                    return (quantityAcc ?? 0m) + quantityValue;
                }
            }

            try
            {
                decimal? initialAccumulate = null;
                return values.CqlAggregate(GetValueAndCheckUnit, Aggregate, initialAccumulate) switch
                {
                    null    => null,
                    { } sum => new CqlQuantity(sum, unit ?? "1")
                };
            }
            catch (NotSupportedException e)
            {
                Message(new { values, e }, "CqlOperators.AggregateFunctions.Sum", "Warning", "Ignored inconsistent units errors from type CqlQuantity summation, returned null.");
                return null;
            }
            catch (OverflowException e)
            {
                Message(new { values, e }, "CqlOperators.AggregateFunctions.Sum", "Warning", "Ignored overflow errors from type CqlQuantity summation, returned null.");
                return null;
            }
        }

        #endregion

        #region Variance

        public decimal? Variance(IEnumerable<decimal?>? argument)
        {
            var stdDev = StdDev(argument);
            if (stdDev == null) return null;
            return (decimal)Math.Pow((double)stdDev.Value, 2);
        }

        public CqlQuantity? Variance(IEnumerable<CqlQuantity?>? argument)
        {
            var stdDev = StdDev(argument);
            if (stdDev == null || stdDev.value == null)
                return null;

            var varianceVal = (decimal)Math.Pow((double)stdDev!.value!.Value, 2);
            return new CqlQuantity(varianceVal, stdDev.unit);
        }

        #endregion
    }
}


file static class CqlMath
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static TNumber? CqlSum<TNumber>(
        this IEnumerable<TNumber?>? values)
        where TNumber : struct, INumberBase<TNumber> =>
        CqlAggregate<TNumber?, TNumber, TNumber?>(
            values,
            v => v.HasValue ? (true, v.Value) : default,
            (acc, value) => checked((acc ?? TNumber.Zero) + value));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static TAccumulate? CqlAggregate<TSource, TValue, TAccumulate>(
        this IEnumerable<TSource?>? values,
        Func<TSource?, (bool hasValue, TValue value)> hasValue,
        Func<TAccumulate?, TValue, TAccumulate> aggregator,
        TAccumulate? initialAccumulate = default)
    {
        if (values == null)
            return default;

        bool any = false;
        TAccumulate? acc = initialAccumulate;

        foreach (var v in values)
        {
            if (hasValue(v) is (true, var value))
            {
                any = true;
                acc = aggregator(acc, value);
            }
        }

        return any ? acc : default;
    }
}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
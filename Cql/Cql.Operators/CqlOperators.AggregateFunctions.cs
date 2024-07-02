/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Hl7.Cql.Runtime
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
                var noNulls = argument
                    .Where(x => x.HasValue)
                    .Select(x => x!.Value);

                if (!noNulls.Any())
                    return null;

                decimal total = 0;
                foreach (decimal val in noNulls)
                    total += val;
                return total / noNulls.Count();
            }
        }

        #endregion

        #region Count

        public int? CountOrNull<T>(IEnumerable<T>? source) =>
            source == null ? null : source.Where(t => t != null).Count();

        #endregion

        #region GeometricMean

        public decimal? GeometricMean(IEnumerable<decimal?> argument)
        {
            if (argument == null) return null;
            else
            {
                decimal product = 0;
                bool AllNull = true;
                foreach (decimal? d in argument)
                {
                    if (d != null)
                    {
                        if (product == 0) product = d.Value;
                        else product *= d.Value;
                        AllNull = false;
                    }
                }
                if (AllNull == true) return null;
                else
                {
                    double count = 1.0 / argument.Count();
                    return (decimal)Math.Pow((double)product, count);
                }
            }
        }

        #endregion

        #region Max
        public T MaxOrNull<T>(IEnumerable<T>? items)
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
                    if (Compare(notNull[i], max, null) > 0)
                        max = notNull[i];
                }
                return (T)max;
            }
        }

        #endregion

        #region Min

        public T MinOrNull<T>(IEnumerable<T>? items)
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
                    if (Compare(notNull[i], min, null) < 0)
                        min = notNull[i];
                }
                return (T)min;
            }
        }


        #endregion

        #region Median



        public decimal? Median(IEnumerable<decimal?> source)
        {
            if (source == null)
            {
                return null;
            }
            else
            {
                var nonNull = source.Where(d => d.HasValue).ToList();
                if (nonNull.Count == 0)
                {
                    return null;
                }
                else
                {
                    var sortedList = nonNull
                        .Select(d => d!.Value)
                        .OrderBy(d => d)
                        .ToList();
                    // check if the 1 bit is set or not.  if not, number is even
                    var isEven = (sortedList.Count & 1) == 0;
                    // shift by 1 to divide by 2
                    var middle = sortedList.Count() >> 1;
                    if (isEven)
                    {
                        var a = sortedList.ElementAt(middle);
                        var b = sortedList.ElementAt(middle - 1);
                        // can't shift decimals so use division
                        return (a + b) / 2m;
                    }
                    else
                    {
                        return source.ElementAt(middle);
                    }

                }
            }
        }

        public int? Median(IEnumerable<int?> source)
        {
            if (source == null)
            {
                return null;
            }
            else
            {
                var nonNull = source.Where(d => d.HasValue).ToList();
                if (nonNull.Count == 0)
                {
                    return null;
                }
                else
                {
                    var sortedList = nonNull
                        .Select(d => d!.Value)
                        .OrderBy(d => d)
                        .ToList();
                    // check if the 1 bit is set or not.  if not, number is even
                    var isEven = (sortedList.Count & 1) == 0;
                    // shift by 1 to divide by 2
                    var middle = sortedList.Count() >> 1;
                    if (isEven)
                    {
                        var a = sortedList.ElementAt(middle);
                        var b = sortedList.ElementAt(middle - 1);
                        // can't shift decimals so use division
                        return (a + b) / 2;
                    }
                    else
                    {
                        return source.ElementAt(middle);
                    }

                }
            }
        }

        public long? Median(IEnumerable<long?> source)
        {
            if (source == null)
            {
                return null;
            }
            else
            {
                var nonNull = source.Where(d => d.HasValue).ToList();
                if (nonNull.Count == 0)
                {
                    return null;
                }
                else
                {
                    var sortedList = nonNull
                        .Select(d => d!.Value)
                        .OrderBy(d => d)
                        .ToList();
                    // check if the 1 bit is set or not.  if not, number is even
                    var isEven = (sortedList.Count & 1) == 0;
                    // shift by 1 to divide by 2
                    var middle = sortedList.Count() >> 1;
                    if (isEven)
                    {
                        var a = sortedList.ElementAt(middle);
                        var b = sortedList.ElementAt(middle - 1);
                        // can't shift decimals so use division
                        return (a + b) / 2L;
                    }
                    else
                    {
                        return source.ElementAt(middle);
                    }

                }
            }
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

        public int? Sum(IEnumerable<int?> values) => values?.Sum();
        public long? Sum(IEnumerable<long?> values) => values?.Sum();
        public decimal? Sum(IEnumerable<decimal?> values) => values?.Sum();

        public CqlQuantity? Sum(IEnumerable<CqlQuantity?>? argument)
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
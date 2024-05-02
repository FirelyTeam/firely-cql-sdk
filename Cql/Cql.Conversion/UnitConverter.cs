/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using Hl7.Cql.Primitives;
using System;
using System.Collections.Generic;

namespace Hl7.Cql.Conversion
{
    /// <summary>
    /// Provides a base implementation of <see cref="IUnitConverter"/>.
    /// </summary>
    internal class UnitConverter : IUnitConverter
    {
        private readonly object SyncRoot = new();
        private IDictionary<string, IDictionary<string, Func<decimal, decimal>>> Conversions { get; } = new Dictionary<string, IDictionary<string, Func<decimal, decimal>>>();
        private decimal Self(decimal d) => d;

        /// <summary>
        /// Gets a function that converts a quantity value from <paramref name="fromUnits"/> to <paramref name="toUnits"/>.
        /// </summary>
        /// <param name="fromUnits">The source units.</param>
        /// <param name="toUnits">The desired units.</param>
        /// <returns>The value conversion function.</returns>
        public Func<decimal, decimal>? ConversionFunctionFor(string fromUnits, string toUnits)
        {
            lock (SyncRoot)
            {
                if (fromUnits == "1" || toUnits == "1" || string.Equals(fromUnits, toUnits, StringComparison.Ordinal))
                    return Self;
                if (Conversions.TryGetValue(fromUnits, out var fromDictionary))
                {
                    if (fromDictionary.TryGetValue(toUnits, out var function))
                        return function;
                }
            }
            return null;
        }

        /// <summary>
        /// Defines a conversion function from <paramref name="fromUnits"/> to <paramref name="toUnits"/>.
        /// </summary>
        /// <param name="fromUnits">The source units.</param>
        /// <param name="toUnits">The desired units.</param>
        /// <param name="function">The value conversion function.</param>
        public void UseConversion(string fromUnits, string toUnits, Func<decimal, decimal> function)
        {
            lock (SyncRoot)
            {
                if (!Conversions.TryGetValue(fromUnits, out var fromDictionary))
                {
                    fromDictionary = new Dictionary<string, Func<decimal, decimal>>();
                    Conversions.Add(fromUnits, fromDictionary);
                }
                fromDictionary[toUnits] = function;
            }
        }

        /// <summary>
        /// Performs the conversion using <see cref="ConversionFunctionFor(string, string)"/>.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <param name="fromUnit">The source unit.</param>
        /// <param name="toUnit">The desired unit.</param>
        /// <returns>The converted value.</returns>
        /// <exception cref="ArgumentException">If this conversion has not yet been added to this converter via <see cref="UseConversion(string, string, Func{decimal, decimal})"/></exception>
        public decimal ChangeUnits(decimal value, string fromUnit, string toUnit)
        {
            var function = ConversionFunctionFor(fromUnit, toUnit);
            if (function != null)
                return function(value);
            else
            {
                // Fast built-in method failed, call the slower UCUM library
                var q = new CqlQuantity(value, fromUnit);
                if (q.TryConvert(toUnit, out var converted))
                    return converted!.value!.Value;
                else
                    throw new ArgumentException($"Conversion for {fromUnit} to {toUnit} is not provided.  You can add your own using ${nameof(UseConversion)}");
            }
        }

        /// <summary>
        /// Performs the conversion using <see cref="ConversionFunctionFor(string, string)"/>.
        /// </summary>
        /// <param name="source">The quantity to convert.</param>
        /// <param name="ucumUnits">The desired units.</param>
        /// <returns>The converted quantity.</returns>
        /// <exception cref="ArgumentException">If this conversion has not yet been added to this converter via <see cref="UseConversion(string, string, Func{decimal, decimal})"/></exception>
        public CqlQuantity? ChangeUnits(CqlQuantity source, string ucumUnits)
        {
            if (source == null || source.value == null)
                return null;

            string fromUnit = source.unit ?? "1";
            if (Units.CqlUnitsToUCUM.TryGetValue(fromUnit, out var ucumUnit))
                fromUnit = ucumUnit;

            var newValue = ChangeUnits(source.value.Value, fromUnit, ucumUnits);
            var newQuanitty = new CqlQuantity(newValue, ucumUnits);
            return newQuanitty;
        }

        /// <summary>
        /// Creates an instance.
        /// </summary>
        public UnitConverter()
        {
            InitialzeDateConversions();
            InitializeLengthUnits();
        }

        private void InitialzeDateConversions()
        {
            var year = new Dictionary<string, Func<decimal, decimal>>
            {
                {  UCUMUnits.Day, (decimal value) => value * ConversionConstants.DaysPerYear },
                {  UCUMUnits.Month, (decimal value) => value / 12m },
                {  UCUMUnits.Week, (decimal value) => (value* ConversionConstants.DaysPerYear) * 0.14285714285m /* 1/7 */ },
            };
            Conversions.Add(UCUMUnits.Year, year);

            var month = new Dictionary<string, Func<decimal, decimal>>
            {
                {  UCUMUnits.Day, (decimal value) => value * ConversionConstants.DaysPerMonth },
                {  UCUMUnits.Year, (decimal value) => value * 12m },
                {  UCUMUnits.Week, (decimal value) => (value * ConversionConstants.DaysPerMonth) * 0.14285714285m /* 1/7 */ },
            };
            Conversions.Add(UCUMUnits.Month, month);

            var day = new Dictionary<string, Func<decimal, decimal>>
            {
                {  UCUMUnits.Month, (decimal value) => value * ConversionConstants.MonthsPerDay },
                {  UCUMUnits.Year, (decimal value) => value * ConversionConstants.YearsPerDay },
                {  UCUMUnits.Week, (decimal value) => value * 0.14285714285m /* 1/7 */ },
            };
            Conversions.Add(UCUMUnits.Day, day);

            var week = new Dictionary<string, Func<decimal, decimal>>
            {
                {  UCUMUnits.Day, (decimal value) => value * 7m },
                {  UCUMUnits.Month, (decimal value) => value * 7m * ConversionConstants.MonthsPerDay },
                {  UCUMUnits.Year, (decimal value) => value * 7m * ConversionConstants.YearsPerDay },
            };
            Conversions.Add(UCUMUnits.Week, week);

        }
        private void InitializeLengthUnits()
        {
            var inches = new Dictionary<string, Func<decimal, decimal>>
            {
                {  UCUMUnits.Foot, (value) => value * ConversionConstants.FeetPerInch },
                {  UCUMUnits.Yard, (value) => value * ConversionConstants.YardsPerInch },
                {  UCUMUnits.Centimeter, (value) => value * ConversionConstants.CentimetersPerInch },
            };
            Conversions.Add(UCUMUnits.Inch, inches);

            var feet = new Dictionary<string, Func<decimal, decimal>>
            {
                {  UCUMUnits.Inch, (value) => value * ConversionConstants.InchesPerFoot },
                {  UCUMUnits.Yard, (value) =>  value * ConversionConstants.InchesPerFoot * ConversionConstants.YardsPerInch },
                {  UCUMUnits.Centimeter, (value) => value * ConversionConstants.InchesPerFoot * ConversionConstants.CentimetersPerInch },
            };
            Conversions.Add(UCUMUnits.Foot, feet);

            var yards = new Dictionary<string, Func<decimal, decimal>>
            {
                {  UCUMUnits.Inch, (value) => value * ConversionConstants.InchesPerYard },
                {  UCUMUnits.Foot, (value) =>  value * ConversionConstants.InchesPerYard * ConversionConstants.FeetPerInch },
                {  UCUMUnits.Centimeter, (value) => value * ConversionConstants.InchesPerYard * ConversionConstants.CentimetersPerInch },
            };
            Conversions.Add(UCUMUnits.Yard, yards);

            var meters = new Dictionary<string, Func<decimal, decimal>>
            {
                {  UCUMUnits.Centimeter, (value) => value * 100m },
            };
            Conversions.Add(UCUMUnits.Meter, meters);

            var centimeters = new Dictionary<string, Func<decimal, decimal>>
            {
                {  UCUMUnits.Meter, (value) => value * 0.01m },
                {  UCUMUnits.Inch, (value) => value * ConversionConstants.InchesPerCentimeter },

            };
            Conversions.Add(UCUMUnits.Centimeter, centimeters);
        }



    }
}

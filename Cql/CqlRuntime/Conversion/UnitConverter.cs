using Ncqa.Cql.Runtime.Primitives;
using System;
using System.Collections.Generic;


namespace Ncqa.Cql.Runtime.Conversion
{
    public class UnitConverter : IUnitConverter
    {
        private object SyncRoot = new object();

        private IDictionary<string, IDictionary<string, Func<decimal, decimal>>> Conversions { get; } = new Dictionary<string, IDictionary<string, Func<decimal, decimal>>>();
        public decimal Self(decimal d) => d;

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

        public decimal ChangeUnits(decimal value, string fromUnit, string toUnit)
        {
            var function = ConversionFunctionFor(fromUnit, toUnit);
            if (function != null)
                return function(value);
            else throw new NotImplementedException($"Conversion for {fromUnit} to {toUnit} is not yet implemented.  You can add your own using ${nameof(UseConversion)}");
        }

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

    }
}

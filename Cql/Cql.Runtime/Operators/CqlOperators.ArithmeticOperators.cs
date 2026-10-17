#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Fhir.Metrics;
using Hl7.Cql.Abstractions;
using Hl7.Cql.Comparers;
using Hl7.Cql.Conversion;
using Hl7.Cql.Primitives;

namespace Hl7.Cql.Operators
{
    internal partial class CqlOperators
    {
        /// <summary>
        /// The minimum precision value for the Decimal type (10^-8), which <see cref="Successor(decimal?)"/> adds to,
        /// and <see cref="Predecessor(decimal?)"/> subtracts from, its argument (CQL spec §9.B).
        /// </summary>
        internal const decimal MinDecimalPrecisionValue = 0.00000001m;

        // HighBoundary and LowBoundary use the greatest precision of the input's type when no precision is given.
        // CQL spec §9.B, sections "HighBoundary" and "LowBoundary": "If no precision is specified, the greatest
        // precision of the type of the input value is used (i.e. at least 8 for Decimal, 4 for Date, at least 17
        // for DateTime, and at least 9 for Time)." The greatest precision of a Date is its day (8 digits, YYYYMMDD);
        // DateTime and Time hold milliseconds at most (17 and 9 digits). At that greatest precision the boundary
        // keeps every component the input has and fills only the missing ones: "The HighBoundary function returns
        // the greatest possible value of the input to the specified precision", and LowBoundary the least.
        private const int MaxDecimalBoundaryPrecision = 8;
        private const int MaxDateBoundaryPrecision = 8;
        private const int MaxDateTimeBoundaryPrecision = 17;
        private const int MaxTimeBoundaryPrecision = 9;

        /// <summary>
        /// The null result of an operation whose result cannot be represented, reported as a warning in the evaluation
        /// log. <paramref name="operation"/> names what overflowed, as in "type integer addition".
        /// </summary>
        private T? Overflowed<T>(object source, string code, string operation)
        {
            Message(source, code, "Warning", $"Ignored overflow errors from {operation}, returned null.");
            return default;
        }

        /// <summary>A quantity of <paramref name="value"/>, or <see langword="null"/> when the value could not be computed.</summary>
        private static CqlQuantity? QuantityOrNull(decimal? value, string? unit) =>
            value is null ? null : new CqlQuantity(value, unit);

        #region Abs

        public int? Abs(int? argument)
        {
            if (argument == null) return null;
            else if (argument > 0) return argument;
            else return OverflowGuard.Negate(argument.Value) ?? Overflowed<int?>(new { argument }, "CqlOperators.ArithmeticOperators.Abs", "type integer absolute value");
        }

        public long? Abs(long? argument)
        {
            if (argument == null) return null;
            else if (argument > 0) return argument;
            else return OverflowGuard.Negate(argument.Value) ?? Overflowed<long?>(new { argument }, "CqlOperators.ArithmeticOperators.Abs", "type long absolute value");
        }

        public decimal? Abs(decimal? argument)
        {
            if (argument == null) return null;
            else if (argument > 0) return argument;
            else return argument * -1;
        }

        public CqlQuantity? Abs(CqlQuantity? argument)
        {
            if (argument == null)
                return null;
            else if (argument.value == null)
                return null;
            else
                return new CqlQuantity(Abs(argument.value), argument.unit);
        }

        #endregion

        #region Add

        public int? Add(int? left, int? right)
        {
            if (left == null || right == null) return null;
            return OverflowGuard.Add(left.Value, right.Value) ?? Overflowed<int?>(new { left, right }, "CqlOperators.ArithmeticOperators.Add", "type integer addition");
        }

        public long? Add(long? left, long? right)
        {
            if (left == null || right == null) return null;
            return OverflowGuard.Add(left.Value, right.Value) ?? Overflowed<long?>(new { left, right }, "CqlOperators.ArithmeticOperators.Add", "type long addition");
        }
        public decimal? Add(decimal? left, decimal? right)
        {
            if (left == null || right == null) return null;
            return OverflowGuard.Add(left.Value, right.Value) ?? Overflowed<decimal?>(new { left, right }, "CqlOperators.ArithmeticOperators.Add", "type decimal addition");
        }

        public CqlQuantity? Add(CqlQuantity? left, CqlQuantity? right)
        {
            if (left == null || right == null)
                return null;
            else if (left.value == null || right.value == null)
                return null;
            else if (left.unit != right.unit)
            {
                string leftUnit = left.unit ?? string.Empty;
                string rightUnit = right.unit ?? string.Empty;

                // CQL treats singular/plural calendar duration units as equivalent (e.g. day/days)
                if (UcumConversionExtensions.AreSameCqlCalendarUnit(leftUnit, rightUnit))
                    return QuantityOrNull(Add(left.value, right.value), left.unit);

                return TryUcumBinaryOp(
                    left.value.Value,
                    leftUnit,
                    right.value.Value,
                    rightUnit,
                    MetricServiceExtensions.TryAdd,
                    "Add",
                    preferMostGranularResultUnit: true);
            }
            else
                return QuantityOrNull(Add(left.value, right.value), left.unit);
        }

        #endregion

        #region Ceiling

        public int? Ceiling(decimal? argument) =>
            argument == null ? null : OverflowGuard.ToInt32(Math.Ceiling(argument.Value)) ?? Overflowed<int?>(new { argument }, "CqlOperators.ArithmeticOperators.Ceiling", "type integer ceiling");
        public int? Ceiling(int? argument) => argument;
        public long? Ceiling(long? argument) => argument;

        #endregion

        #region Divide

        public decimal? Divide(decimal? left, decimal? right)
        {
            if (left == null || right == null) return null;
            if (right == 0m)
                return null;
            else return OverflowGuard.Divide(left.Value, right.Value) ?? Overflowed<decimal?>(new { left, right }, "CqlOperators.ArithmeticOperators.Divide", "type decimal division");
        }

        public CqlQuantity? Divide(CqlQuantity? left, CqlQuantity? right)
        {
            if (left == null || right == null) return null;
            else if (left.value == null || right.value == null) return null;
            else if (right.value == 0m) return null;
            else if (left.unit == null || right.unit == null) return null;
            else if (left.unit == right.unit)
                return QuantityOrNull(Divide(left.value, right.value), UCUMUnits.Default);
            else if (right.unit == UCUMUnits.Default)
                return QuantityOrNull(Divide(left.value, right.value), left.unit);
            else
            {
                return TryUcumBinaryOp(left.value.Value, left.unit, right.value.Value, right.unit, MetricServiceExtensions.TryDivide, "Divide");
            }
        }

        #endregion

        #region Floor

        public int? Floor(decimal? argument) =>
            argument == null ? null : OverflowGuard.ToInt32(Math.Floor(argument.Value)) ?? Overflowed<int?>(new { argument }, "CqlOperators.ArithmeticOperators.Floor", "type integer floor");

        public int? Floor(int? argument) => argument;
        public long? Floor(long? argument) => argument;

        #endregion

        #region Exp

        public decimal? Exp(decimal? argument)
        {
            if (argument == null) return null;
            else return OverflowGuard.ToDecimal(Math.Exp((double)argument)) ?? Overflowed<decimal?>(new { argument }, "CqlOperators.ArithmeticOperators.Exp", "type decimal exponentiation");
        }

        #endregion

        #region HighBoundary

        public decimal? HighBoundary(decimal? input, int? precision) => DecimalBoundary(input, precision, greatest: true);

        /// <summary>
        /// The greatest or least Decimal value the input can stand for at the requested number of decimals.
        /// A Decimal with <c>s</c> decimals stands for every value that shares those digits; at a finer precision the
        /// missing decimals are completed with 9s for the greatest value and 0s for the least, at a coarser one the
        /// surplus decimals are dropped. The digits are those of the magnitude, so for a negative value the greatest
        /// completion is the least magnitude and the other way round. The greatest precision a Decimal has is
        /// <see cref="MaxDecimalBoundaryPrecision"/> decimals; a precision beyond it has no answer.
        /// </summary>
        private decimal? DecimalBoundary(decimal? input, int? precision, bool greatest)
        {
            if (input is not { } value)
                return null;
            var requested = precision ?? MaxDecimalBoundaryPrecision;
            if (requested is < 0 or > MaxDecimalBoundaryPrecision)
                return null;
            var scale = (byte)requested;

            var negative = value < 0;
            var magnitude = Math.Abs(value);
            var kept = magnitude.Scale <= scale ? magnitude : decimal.Round(magnitude, scale, MidpointRounding.ToZero);
            // Only the completion asked for is computed, so the other one cannot overflow on its behalf. A completion of
            // a value at the edge of the decimal range cannot be represented.
            var completed = OverflowGuard.Add(kept, greatest != negative ? UnitAtScale(kept.Scale) - UnitAtScale(scale) : ZeroAtScale(scale));
            if (completed is not { } completion)
                return Overflowed<decimal?>(new { input, precision, greatest }, "CqlOperators.ArithmeticOperators.DecimalBoundary", "a decimal boundary");
            // Decimal keeps at most 28 to 29 significant digits. Where the completion needs more, the addition
            // rounds and drops decimals instead of throwing, so a result that lost the requested scale is not
            // the boundary; only values beyond the CQL Decimal range (whose whole part has at most 20 digits) get here.
            if (completion.Scale != scale)
                return null;
            return negative ? -completion : completion;
        }

        /// <summary>The value 1 at the given number of decimals (10 to the power of minus <paramref name="scale"/>).</summary>
        private static decimal UnitAtScale(byte scale) => new(1, 0, 0, false, scale);

        /// <summary>The value 0 at the given number of decimals; adding it sets a result's scale.</summary>
        private static decimal ZeroAtScale(byte scale) => new(0, 0, 0, false, scale);

        public CqlDate? HighBoundary(CqlDate? input, int? precision)
        {
            if (input == null)
                return null;
            precision ??= MaxDateBoundaryPrecision;
            switch (precision)
            {
                case 4: return new CqlDate(9999, null, null);
                case 6: return new CqlDate(input.Value.Year, 12, null);
                case 8:
                    {
                        var month = input.Value.Month ?? 12;
                        var day = input.Value.Day ?? System.DateTime.DaysInMonth(input.Value.Year, month);
                        return new CqlDate(input.Value.Year, month, day);
                    }
                default:
                    return null;
            }
        }

        public CqlDateTime? HighBoundary(CqlDateTime? input, int? precision)
        {
            if (input == null)
                return null;
            precision ??= MaxDateTimeBoundaryPrecision;
            var offsetHour = input.Value.OffsetHour;
            var offsetMinute = input.Value.OffsetMinute;

            switch (precision)
            {
                case 4: return new CqlDateTime(9999, null, null, null, null, null, null, null, null);
                case 6: return new CqlDateTime(input.Value.Year, 12, null, null, null, null, null, null, null);
                case 8:
                    {
                        var month = input.Value.Month ?? 12;
                        switch (month)
                        {
                            case 1:
                            case 3:
                            case 5:
                            case 7:
                            case 8:
                            case 10:
                            case 12:
                                return new CqlDateTime(input.Value.Year, month, 31, null, null, null, null, null, null);
                            case 4:
                            case 6:
                            case 9:
                            case 11:
                                return new CqlDateTime(input.Value.Year, month, 30, null, null, null, null, null, null);
                            case 2:
                                return System.DateTime.IsLeapYear(input.Value.Year)
                                    ? new CqlDateTime(input.Value.Year, month, 29, null, null, null, null, null, null)
                                    : new CqlDateTime(input.Value.Year, month, 28, null, null, null, null, null, null);
                            default:
                                return null;
                        }
                    }
                case 10: return new CqlDateTime(input.Value.Year, input.Value.Month ?? 12, input.Value.Day ?? 31, 23, null, null, null, offsetHour, offsetMinute);
                case 12: return new CqlDateTime(input.Value.Year, input.Value.Month ?? 12, input.Value.Day ?? 31, input.Value.Hour ?? 23, 59, null, null, offsetHour, offsetMinute);
                case 14: return new CqlDateTime(input.Value.Year, input.Value.Month ?? 12, input.Value.Day ?? 31, input.Value.Hour ?? 23, input.Value.Minute ?? 59, 59, null, offsetHour, offsetMinute);
                case 17:
                    {
                        var month = input.Value.Month ?? 12;
                        var day = input.Value.Day ?? System.DateTime.DaysInMonth(input.Value.Year, month);
                        return new CqlDateTime(input.Value.Year, month, day, input.Value.Hour ?? 23, input.Value.Minute ?? 59, input.Value.Second ?? 59, input.Value.Millisecond ?? 999, offsetHour, offsetMinute);
                    }
                default:
                    return null;
            }
        }

        public CqlTime? HighBoundary(CqlTime? input, int? precision)
        {
            if (input == null)
                return null;
            precision ??= MaxTimeBoundaryPrecision;
            var offsetHour = input.Value.OffsetHour;
            var offsetMinute = input.Value.OffsetMinute;
            switch (precision)
            {
                case 2: return new CqlTime(23, null, null, null, offsetHour, offsetMinute);
                case 4: return new CqlTime(input.Value.Hour, 59, null, null, offsetHour, offsetMinute);
                case 6: return new CqlTime(input.Value.Hour, input.Value.Minute ?? 59, 59, null, offsetHour, offsetMinute);
                case 9: return new CqlTime(input.Value.Hour, input.Value.Minute ?? 59, input.Value.Second ?? 59, input.Value.Millisecond ?? 999, offsetHour, offsetMinute);
                default:
                    return null;
            }
        }

        #endregion

        #region Log

        public decimal? Log(decimal? argument, decimal? @base)
        {
            if (argument == null || @base == null)
                return null;
            else
            {
                if (argument == 1m && @base == 1m)
                    return null;
                var result = Math.Log((double)argument, (double)@base);
                if (double.IsNaN(result) || double.IsInfinity(result))
                    return null;
                return (decimal?)result;
            }
        }

        #endregion

        #region LowBoundary

        public decimal? LowBoundary(decimal? input, int? precision) => DecimalBoundary(input, precision, greatest: false);

        public CqlDate? LowBoundary(CqlDate? input, int? precision)
        {
            if (input == null)
                return null;
            precision ??= MaxDateBoundaryPrecision;
            switch (precision)
            {
                case 4: return new CqlDate(1, null, null);
                case 6: return new CqlDate(input.Value.Year, 1, null);
                case 8: return new CqlDate(input.Value.Year, input.Value.Month ?? 1, input.Value.Day ?? 1);
                default:
                    return null;
            }
        }

        public CqlDateTime? LowBoundary(CqlDateTime? input, int? precision)
        {
            if (input == null)
                return null;
            precision ??= MaxDateTimeBoundaryPrecision;
            var offsetHour = input.Value.OffsetHour;
            var offsetMinute = input.Value.OffsetMinute;

            switch (precision)
            {
                case 4: return new CqlDateTime(9999, null, null, null, null, null, null, null, null);
                case 6: return new CqlDateTime(input.Value.Year, 1, null, null, null, null, null, null, null);
                case 8: return new CqlDateTime(input.Value.Year, input.Value.Month ?? 1, 1, null, null, null, null, null, null);
                case 10: return new CqlDateTime(input.Value.Year, input.Value.Month ?? 1, input.Value.Day ?? 1, 0, null, null, null, offsetHour, offsetMinute);
                case 12: return new CqlDateTime(input.Value.Year, input.Value.Month ?? 1, input.Value.Day ?? 1, input.Value.Hour ?? 0, 0, null, null, offsetHour, offsetMinute);
                case 14: return new CqlDateTime(input.Value.Year, input.Value.Month ?? 1, input.Value.Day ?? 1, input.Value.Hour ?? 0, input.Value.Minute ?? 0, 0, null, offsetHour, offsetMinute);
                case 17: return new CqlDateTime(input.Value.Year, input.Value.Month ?? 1, input.Value.Day ?? 1, input.Value.Hour ?? 0, input.Value.Minute ?? 0, input.Value.Second ?? 0, input.Value.Millisecond ?? 0, offsetHour, offsetMinute);
                default:
                    return null;
            }
        }

        public CqlTime? LowBoundary(CqlTime? input, int? precision)
        {
            if (input == null)
                return null;
            precision ??= MaxTimeBoundaryPrecision;
            var offsetHour = input.Value.OffsetHour;
            var offsetMinute = input.Value.OffsetMinute;
            switch (precision)
            {
                case 2: return new CqlTime(0, null, null, null, offsetHour, offsetMinute);
                case 4: return new CqlTime(input.Value.Hour, 0, null, null, offsetHour, offsetMinute);
                case 6: return new CqlTime(input.Value.Hour, input.Value.Minute ?? 0, 0, null, offsetHour, offsetMinute);
                case 9: return new CqlTime(input.Value.Hour, input.Value.Minute ?? 0, input.Value.Second ?? 0, input.Value.Millisecond ?? 0, offsetHour, offsetMinute);
                default:
                    return null;
            }
        }

        #endregion

        #region Ln

        public decimal? Ln(decimal? argument)
        {
            if (argument == null) return null;
            if (argument < 0)
                return null;
            else
                return OverflowGuard.ToDecimal(Math.Log10((double)argument) / 0.4342944819) ?? Overflowed<decimal?>(new { argument }, "CqlOperators.ArithmeticOperators.Ln", "type decimal natural logarithm");
        }

        #endregion

        #region MaxValue

        protected readonly Dictionary<Type, object> MaxValues = new()
        {
            { typeof(int?), int.MaxValue },
            { typeof(int), int.MaxValue },
            { typeof(long?), long.MaxValue },
            { typeof(long), long.MaxValue },
            { typeof(decimal), decimal.MaxValue },
            { typeof(decimal?), decimal.MaxValue },
            { typeof(CqlQuantity), new CqlQuantity(decimal.MaxValue, "1") },
            { typeof(CqlDate), CqlDate.MaxValue },
            { typeof(CqlDateTime), CqlDateTime.MaxValue },
            { typeof(CqlTime), CqlTime.MaxValue },
        };
        public T MaxValue<T>() =>
            MaxValues.TryGetValue(typeof(T), out var value) ? (T)value
            : typeof(T) == typeof(object) ? (T)(object)AnyExtreme.Maximum
            : throw new KeyNotFoundException($"The type {typeof(T)} has no maximum value.");

        #endregion

        #region MinValue

        protected readonly Dictionary<Type, object> MinValues = new()
        {
            { typeof(int), int.MinValue },
            { typeof(int?), int.MinValue },
            { typeof(long), long.MinValue },
            { typeof(long?), long.MinValue },
            { typeof(decimal), decimal.MinValue },
            { typeof(decimal?), decimal.MinValue },
            { typeof(CqlQuantity), new CqlQuantity(decimal.MinValue, "1")},
            { typeof(CqlDate), CqlDate.MinValue },
            { typeof(CqlDateTime), CqlDateTime.MinValue },
            { typeof(CqlTime), CqlTime.MinValue },
        };

        // An interval over Any carries only null boundaries, so the extremes of Any stand in for its Start and End.
        public T MinValue<T>() =>
            MinValues.TryGetValue(typeof(T), out var value) ? (T)value
            : typeof(T) == typeof(object) ? (T)(object)AnyExtreme.Minimum
            : throw new KeyNotFoundException($"The type {typeof(T)} has no minimum value.");

        #endregion

        #region Modulo

        // Every value is a whole multiple of -1, so the remainder is 0; the remainder instruction itself overflows
        // for the minimum value, whose quotient by -1 cannot be represented.
        public int? Modulo(int? left, int? right)
        {
            if (left == null || right == null) return null;
            else if (right.Value == 0) return null;
            else if (right.Value == -1) return 0;
            else return left.Value % right.Value;
        }

        public long? Modulo(long? left, long? right)
        {
            if (left == null || right == null) return null;
            else if (right.Value == 0) return null;
            else if (right.Value == -1) return 0;
            else return left.Value % right.Value;
        }

        public decimal? Modulo(decimal? left, decimal? right)
        {
            if (left == null || right == null) return null;
            else if (right.Value == 0) return null;
            else return left.Value % right.Value;
        }

        public CqlQuantity? Modulo(CqlQuantity left, CqlQuantity right)
        {
            if (left == null || right == null)
                return null;
            else if (left.value == null || right.value == null)
                return null;
            else if (right.value == 0m)
                return null;
            else if (left.unit != right.unit)
            {
                string leftUnit = left.unit ?? string.Empty;
                string rightUnit = right.unit ?? string.Empty;
                if (UcumConversionExtensions.AreSameCqlCalendarUnit(leftUnit, rightUnit))
                    return new CqlQuantity(Modulo(left.value, right.value), left.unit);

                if (right.TryConvert(leftUnit, MetricService, out var rightInLeftUnit)
                    && rightInLeftUnit?.value is { } rightValue)
                {
                    return new CqlQuantity(Modulo(left.value, rightValue), left.unit);
                }

                return null;
            }
            else
                return new CqlQuantity(Modulo(left.value, right.value), left.unit);
        }
        #endregion

        #region Multiply
        public int? Multiply(int? left, int? right)
        {
            if (left == null || right == null) return null;
            else return OverflowGuard.Multiply(left.Value, right.Value) ?? Overflowed<int?>(new { left, right }, "CqlOperators.ArithmeticOperators.Multiply", "type integer multiplication");
        }

        public long? Multiply(long? left, long? right)
        {
            if (left == null || right == null) return null;
            else return OverflowGuard.Multiply(left.Value, right.Value) ?? Overflowed<long?>(new { left, right }, "CqlOperators.ArithmeticOperators.Multiply", "type long multiplication");
        }
        public decimal? Multiply(decimal? left, decimal? right)
        {
            if (left == null || right == null) return null;
            else return OverflowGuard.Multiply(left.Value, right.Value) ?? Overflowed<decimal?>(new { left, right }, "CqlOperators.ArithmeticOperators.Multiply", "type decimal multiplication");
        }

        public CqlQuantity? Multiply(CqlQuantity? left, CqlQuantity? right)
        {
            if (left == null || right == null)
                return null;
            else if (left.value == null || right.value == null)
                return null;
            else if (left.unit == null || right.unit == null)
                return null;
            else if (left.unit == UCUMUnits.Default && right.unit == UCUMUnits.Default)
                return QuantityOrNull(Multiply(left.value, right.value), UCUMUnits.Default);
            else if (left.unit == UCUMUnits.Default)
                return QuantityOrNull(Multiply(left.value, right.value), right.unit);
            else if (right.unit == UCUMUnits.Default)
                return QuantityOrNull(Multiply(left.value, right.value), left.unit);
            else
                return TryUcumBinaryOp(left.value.Value, left.unit, right.value.Value, right.unit, MetricServiceExtensions.TryMultiply, "Multiply");
        }
        #endregion

        #region Negate

        public int? Negate(int? argument)
        {
            if (argument == null)
                return null;
            return OverflowGuard.Negate(argument.Value) ?? Overflowed<int?>(new { argument }, "CqlOperators.ArithmeticOperators.Negate", "type integer negation");
        }

        public long? Negate(long? argument)
        {
            if (argument == null)
                return null;
            return OverflowGuard.Negate(argument.Value) ?? Overflowed<long?>(new { argument }, "CqlOperators.ArithmeticOperators.Negate", "type long negation");
        }
        public decimal? Negate(decimal? argument)
        {
            if (argument == null) return null;
            return argument.Value * -1;
        }

        public CqlQuantity? Negate(CqlQuantity? argument)
        {
            if (argument == null)
                return null;
            else if (argument.value == null)
                return null;
            else
                return new CqlQuantity(Negate(argument.value), argument.unit);
        }
        #endregion

        #region Precision

        public int? Precision(decimal? argument)
        {
            if (argument == null) return null;
            else
            {
                string val = argument.Value.ToString(CultureInfo.InvariantCulture);
                int ret = val.Length - (val.IndexOf(".") + 1);
                if (ret <= 0) return 0;
                else return ret;
            }
        }

        public int? Precision(CqlDate? argument)
        {
            if (argument == null)
                return null;
            switch (argument.Value.Precision)
            {

                case Iso8601.DateTimePrecision.Year:
                    return 4;
                case Iso8601.DateTimePrecision.Month:
                    return 6;
                case Iso8601.DateTimePrecision.Day:
                    return 8;
                case Iso8601.DateTimePrecision.Unknown:
                default:
                    return null;

            }
        }
        public int? Precision(CqlDateTime? argument)
        {
            if (argument == null)
                return null;
            switch (argument.Value.Precision)
            {
                case Iso8601.DateTimePrecision.Year:
                    return 4;
                case Iso8601.DateTimePrecision.Month:
                    return 6;
                case Iso8601.DateTimePrecision.Day:
                    return 8;
                case Iso8601.DateTimePrecision.Hour:
                    return 10;
                case Iso8601.DateTimePrecision.Minute:
                    return 12;
                case Iso8601.DateTimePrecision.Second:
                    return 14;
                case Iso8601.DateTimePrecision.Millisecond:
                    return 17;
                case Iso8601.DateTimePrecision.Unknown:
                default:
                    return null;

            }
        }
        public int? Precision(CqlTime? argument)
        {
            if (argument == null)
                return null;
            switch (argument.Value.Precision)
            {

                case Iso8601.DateTimePrecision.Hour:
                    return 2;
                case Iso8601.DateTimePrecision.Minute:
                    return 4;
                case Iso8601.DateTimePrecision.Second:
                    return 6;
                case Iso8601.DateTimePrecision.Millisecond:
                    return 9;
                case Iso8601.DateTimePrecision.Unknown:
                case Iso8601.DateTimePrecision.Year:
                case Iso8601.DateTimePrecision.Month:
                case Iso8601.DateTimePrecision.Day:
                default:
                    return null;
            }
        }

        #endregion

        #region Predecessor

        public int? Predecessor(int? argument)
        {
            // The predecessor of the minimum value cannot be represented, so it is null.
            if (argument == null || argument == int.MinValue)
                return null;
            else return argument - 1;
        }

        public long? Predecessor(long? argument)
        {
            if (argument == null || argument == long.MinValue)
                return null;
            else return argument - 1;
        }
        public decimal? Predecessor(decimal? argument)
        {
            if (argument == null || argument == decimal.MinValue)
                return null;
            else return argument - MinDecimalPrecisionValue;
        }
        public CqlQuantity? Predecessor(CqlQuantity? argument)
        {
            if (argument == null)
                return null;
            else if (argument.value == null)
                return null;
            else
                // A null value means the predecessor cannot be represented, so the quantity is null too.
                return Predecessor(argument.value) is { } value ? new CqlQuantity(value, argument.unit) : null;
        }

        public CqlDate? Predecessor(CqlDate? argument) => argument == null ? null : argument!.Predecessor();

        public CqlDateTime? Predecessor(CqlDateTime? argument) => argument == null ? null : argument!.Predecessor();

        public CqlTime? Predecessor(CqlTime? argument) => argument == null ? null : argument!.Predecessor();

        #endregion

        #region Power

        public decimal? Power(int? argument, int? exponent)
        {
            if (argument == null || exponent == null) return null;
            var result = Math.Pow((double)argument, (double)exponent);
            return OverflowGuard.ToDecimal(result) ?? Overflowed<decimal?>(new { argument, exponent, result }, "CqlOperators.ArithmeticOperators.Power", "type integer power");
        }

        public decimal? Power(long? argument, long? exponent)
        {
            if (argument == null || exponent == null) return null;
            var result = Math.Pow((double)argument, (double)exponent);
            return OverflowGuard.ToDecimal(result) ?? Overflowed<decimal?>(new { argument, exponent, result }, "CqlOperators.ArithmeticOperators.Power", "type long power");
        }

        public decimal? Power(decimal? argument, decimal? exponent)
        {
            if (argument == null || exponent == null) return null;
            var result = Math.Pow((double)argument, (double)exponent);
            return OverflowGuard.ToDecimal(result) ?? Overflowed<decimal?>(new { argument, exponent, result }, "CqlOperators.ArithmeticOperators.Power", "type decimal power");
        }

        #endregion

        #region Round

        /// <summary>The most decimals a <see cref="decimal"/> holds; rounding to more leaves every value unchanged.</summary>
        private const int MaxDecimalScale = 28;

        public decimal? Round(decimal? argument, int? precision)
        {
            if (argument == null) return null;
            var decimals = precision ?? 0;
            // A negative number of decimals has no rounding defined for it, so the operation cannot be performed.
            if (decimals < 0) return null;
            if (decimals > MaxDecimalScale) return argument;
            return Math.Round(argument.Value, decimals, MidpointRounding.AwayFromZero);
        }

        #endregion

        #region Subtract

        public int? Subtract(int? left, int? right)
        {
            if (left == null || right == null) return null;
            return OverflowGuard.Subtract(left.Value, right.Value) ?? Overflowed<int?>(new { left, right }, "CqlOperators.ArithmeticOperators.Subtract", "type integer subtraction");
        }

        public long? Subtract(long? left, long? right)
        {
            if (left == null || right == null) return null;
            return OverflowGuard.Subtract(left.Value, right.Value) ?? Overflowed<long?>(new { left, right }, "CqlOperators.ArithmeticOperators.Subtract", "type long subtraction");
        }
        public decimal? Subtract(decimal? left, decimal? right)
        {
            if (left == null || right == null) return null;
            return OverflowGuard.Subtract(left.Value, right.Value) ?? Overflowed<decimal?>(new { left, right }, "CqlOperators.ArithmeticOperators.Subtract", "type decimal subtraction");
        }

        public CqlQuantity? Subtract(CqlQuantity? left, CqlQuantity? right)
        {
            if (left == null || right == null)
                return null;
            else if (left.value == null || right.value == null)
                return null;
            else if (left.unit != right.unit)
            {
                string leftUnit = left.unit ?? string.Empty;
                string rightUnit = right.unit ?? string.Empty;

                // CQL treats singular/plural calendar duration units as equivalent (e.g. day/days)
                if (UcumConversionExtensions.AreSameCqlCalendarUnit(leftUnit, rightUnit))
                    return QuantityOrNull(Subtract(left.value, right.value), left.unit);

                return TryUcumBinaryOp(
                    left.value.Value,
                    leftUnit,
                    right.value.Value,
                    rightUnit,
                    MetricServiceExtensions.TrySubtract,
                    "Subtract",
                    preferMostGranularResultUnit: true);
            }
            else return QuantityOrNull(Subtract(left.value, right.value), left.unit);
        }

        private delegate bool MetricBinaryOp(
            IMetricService service,
            (decimal value, string unit, string? codesystem) q1,
            (decimal value, string unit, string? codesystem) q2,
            out (decimal value, string unit, string? codesystem)? result);

        private CqlQuantity? TryUcumBinaryOp(
            decimal leftValue, string leftUnit,
            decimal rightValue, string rightUnit,
            MetricBinaryOp tryOp,
            string opName,
            bool preferMostGranularResultUnit = false)
        {
            try
            {
                if (tryOp(MetricService,
                        (leftValue, leftUnit, UcumConversionExtensions.UcumSystemUrl),
                        (rightValue, rightUnit, UcumConversionExtensions.UcumSystemUrl),
                        out var result))
                {
                    if (preferMostGranularResultUnit
                        && TryExpressResultInMostGranularUnit(result!.Value, leftUnit, rightUnit, out var granularResult))
                    {
                        result = granularResult;
                    }

                    return new CqlQuantity(result!.Value.Item1, result.Value.Item2);
                }
            }
            catch (NotImplementedException)
            {
                throw new NotSupportedException(
                    $"The configured IMetricService does not implement {opName} for units {leftUnit} and {rightUnit}. Inject a full IMetricService implementation to enable cross-unit arithmetic.");
            }
            catch (OverflowException)
            {
                // The metric service scales each value to its unit's base, which can leave the range of Decimal; the
                // overflow happens inside the service, so it cannot be ruled out up front.
                return Overflowed<CqlQuantity>(new { leftValue, leftUnit, rightValue, rightUnit }, $"CqlOperators.ArithmeticOperators.{opName}", "type quantity unit conversion");
            }

            return null;
        }

        private bool TryExpressResultInMostGranularUnit(
            (decimal value, string unit, string? codesystem) result,
            string leftUnit,
            string rightUnit,
            out (decimal value, string unit, string? codesystem) convertedResult)
        {
            convertedResult = result;

            if (leftUnit == rightUnit)
                return false;

            if (!MetricServiceExtensions.TryCanonicalize(MetricService, (1m, leftUnit, UcumConversionExtensions.UcumSystemUrl), out var canonicalLeft)
                || !MetricServiceExtensions.TryCanonicalize(MetricService, (1m, rightUnit, UcumConversionExtensions.UcumSystemUrl), out var canonicalRight)
                || canonicalLeft!.Value.Item2 != canonicalRight!.Value.Item2)
            {
                return false;
            }

            string targetUnit = canonicalLeft.Value.Item1 <= canonicalRight.Value.Item1 ? leftUnit : rightUnit;
            if (MetricServiceExtensions.TryConvertTo(MetricService, result, targetUnit, out var converted))
            {
                convertedResult = converted!.Value;
                return true;
            }

            return false;
        }

        #endregion

        #region Successor

        public int? Successor(int? argument)
        {
            // The successor of the maximum value cannot be represented, so it is null.
            if (argument == null || argument == int.MaxValue)
                return null;
            else return argument + 1;
        }

        public long? Successor(long? argument)
        {
            if (argument == null || argument == long.MaxValue)
                return null;
            else return argument + 1;
        }
        public decimal? Successor(decimal? argument)
        {
            if (argument == null || argument == decimal.MaxValue)
                return null;
            else return argument + MinDecimalPrecisionValue;
        }
        public CqlQuantity? Successor(CqlQuantity? argument)
        {
            if (argument == null)
                return null;
            else if (argument.value == null)
                return null;
            else
                // A null value means the successor cannot be represented, so the quantity is null too.
                return Successor(argument.value) is { } value ? new CqlQuantity(value, argument.unit) : null;
        }

        public CqlDate? Successor(CqlDate? argument) => argument == null ? null : argument.Successor();

        public CqlDateTime? Successor(CqlDateTime? argument) => argument == null ? null : argument.Successor();

        public CqlTime? Successor(CqlTime? argument) => argument == null ? null : argument.Successor();

        #endregion

        #region Truncate

        public int? Truncate(int? argument) => argument;
        public long? Truncate(long? argument) => argument;

        public int? Truncate(decimal? argument)
        {
            if (argument == null)
                return null;
            else
                return OverflowGuard.ToInt32(argument.Value) ?? Overflowed<int?>(new { argument }, "CqlOperators.ArithmeticOperators.Truncate", "type integer truncation");
        }

        #endregion

        #region Truncated Divide

        public int? TruncatedDivide(int? left, int? right)
        {
            if (left == null || right == null || right == 0)
                return null;
            else
                return OverflowGuard.TruncatedDivide(left.Value, right.Value) ?? Overflowed<int?>(new { left, right }, "CqlOperators.ArithmeticOperators.TruncatedDivide", "type integer division");
        }
        public long? TruncatedDivide(long? left, long? right)
        {
            if (left == null || right == null || right == 0)
                return null;
            else
                return OverflowGuard.TruncatedDivide(left.Value, right.Value) ?? Overflowed<long?>(new { left, right }, "CqlOperators.ArithmeticOperators.TruncatedDivide", "type long division");
        }
        public decimal? TruncatedDivide(decimal? left, decimal? right)
        {
            if (left == null || right == null || right == 0m)
                return null;
            else if (Math.Abs(left.Value) < Math.Abs(right.Value))
            {
                // A quotient below one in magnitude truncates to zero, also when it is too small to represent.
                return 0m;
            }
            else
                return OverflowGuard.Divide(left.Value, right.Value) is { } quotient
                    ? Math.Truncate(quotient)
                    : Overflowed<decimal?>(new { left, right }, "CqlOperators.ArithmeticOperators.TruncatedDivide", "type decimal division");
        }
        public CqlQuantity? TruncatedDivide(CqlQuantity? left, CqlQuantity? right)
        {
            if (left == null || right == null)
                return null;
            else if (left.value == null || right.value == null || right.value == 0m)
                return null;
            else if (left.unit == null || right.unit == null)
                return null;
            else if (left.unit == right.unit)
                return QuantityOrNull(TruncatedDivide(left.value.Value, right.value.Value), UCUMUnits.Default);
            else if (right.unit == UCUMUnits.Default)
                return QuantityOrNull(TruncatedDivide(left.value.Value, right.value.Value), left.unit);
            else
            {
                var divided = TryUcumBinaryOp(left.value.Value, left.unit, right.value.Value, right.unit, MetricServiceExtensions.TryDivide, "TruncatedDivide");
                if (divided?.value == null)
                    return null;

                return new CqlQuantity(Math.Truncate(divided.value.Value), divided.unit);
            }
        }
        #endregion
    }
}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

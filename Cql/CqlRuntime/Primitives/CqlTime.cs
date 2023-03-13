using Ncqa.Cql.Runtime.Comparers;
using Ncqa.Cql.Runtime.Conversion;
using Ncqa.Iso8601;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ncqa.Cql.Runtime.Primitives
{
    [CqlPrimitiveType(CqlPrimitiveType.Time)]
    public class CqlTime : ICqlComparable<CqlTime>, IEquivalentable<CqlTime>
    {
        public static readonly CqlTime MinValue = new CqlTime(0, 0, 0, 0, 0, 0);
        public static readonly CqlTime MaxValue = new CqlTime(23, 59, 59, 999, 0, 0);

        public TimeIso8601 Value { get; }
        public TimeIso8601 InUtc { get; }
        public DateTimePrecision Precision => Value.Precision;

        public static CqlTime TimeOfDay(DateTimeOffset now) => new CqlTime(now.Hour, now.Minute, now.Second, now.Millisecond, now.Offset.Hours, now.Offset.Minutes);

        public CqlTime(int hour, int? minute, int? second, int? millisecond, int? offsetHour, int? offsetMinute) :
            this(new TimeIso8601(hour, minute, second, millisecond, offsetHour, offsetMinute))
        {
        }
        public CqlTime(TimeIso8601 time)
        {
            Value = time;
            if (Value.RationalOffset.HasValue)
                InUtc = new TimeIso8601(time.TimeSpan.Add(time.Offset), 0, 0, time.Precision);
            else
                InUtc = new TimeIso8601(time.TimeSpan, 0, 0, time.Precision);
        }

        public static bool TryParse(string s, out CqlTime? time)
        {
            if (TimeIso8601.TryParse(s, out var isoTime))
            {
                time = new CqlTime(isoTime!);
                return true;
            }
            else
            {
                time = null;
                return false;
            }
        }


        public CqlTime? Add(CqlQuantity quantity)
        {
            if (quantity == null || quantity.value == null || quantity.unit == null)
                return null;

            var value = quantity!.value.Value;
            var span = Value.TimeSpan;
            switch (quantity.unit[0])
            {
                case 'm':
                    if (quantity.unit.Length > 1)
                    {
                        switch (quantity.unit[1])
                        {
                            case 'i':
                                span = span.Add(TimeSpan.FromMinutes(Math.Truncate((double)value)));
                                break;
                            case 's':
                                span = span.Add(TimeSpan.FromMilliseconds(Math.Truncate((double)value)));
                                break;
                            default: throw new ArgumentException($"Unknown date unit {quantity.unit} supplied");
                        }
                    }
                    break;
                case 'd':
                    span = span.Add(TimeSpan.FromDays(Math.Truncate((double)value)));
                    break;
                case 'w':
                    span = span.Add(TimeSpan.FromDays(Math.Truncate((double)value) * ConversionConstants.DaysPerWeekAsDouble));
                    break;
                case 'h':
                    span = span.Add(TimeSpan.FromHours(Math.Truncate((double)value)));
                    break;
                case 's':
                    span = span.Add(TimeSpan.FromSeconds(Math.Truncate((double)value)));
                    break;
                default: throw new ArgumentException($"Unknown date unit {quantity.unit} supplied");
            }

            var newIsoTime = new TimeIso8601(span, Value.OffsetHour, Value.OffsetMinute, Value.Precision);
            var result = new CqlTime(newIsoTime);
            return result;
        }

        public CqlTime? Subtract(CqlQuantity quantity)
        {
            if (quantity == null || quantity.value == null || quantity.unit == null)
                return null;

            var value = quantity!.value.Value;
            var span = Value.TimeSpan;
            switch (quantity.unit[0])
            {
                case 'm':
                    if (quantity.unit.Length > 1)
                    {
                        switch (quantity.unit[1])
                        {
                            case 'i':
                                span = span.Subtract(TimeSpan.FromMinutes(Math.Truncate((double)value)));
                                break;
                            case 's':
                                span = span.Subtract(TimeSpan.FromMilliseconds(Math.Truncate((double)value)));
                                break;
                            default: throw new ArgumentException($"Unknown date unit {quantity.unit} supplied");
                        }
                    }
                    break;
                case 'd':
                    span = span.Subtract(TimeSpan.FromDays(Math.Truncate((double)value)));
                    break;
                case 'w':
                    span = span.Subtract(TimeSpan.FromDays(Math.Truncate((double)value) * ConversionConstants.DaysPerWeekAsDouble));
                    break;
                case 'h':
                    span = span.Subtract(TimeSpan.FromHours(Math.Truncate((double)value)));
                    break;
                case 's':
                    span = span.Subtract(TimeSpan.FromSeconds(Math.Truncate((double)value)));
                    break;
                default: throw new ArgumentException($"Unknown date unit {quantity.unit} supplied");
            }

            var newIsoTime = new TimeIso8601(span, Value.OffsetHour, Value.OffsetMinute, Value.Precision);
            var result = new CqlTime(newIsoTime);
            return result;
        }

        public int? Component(string precision)
        {
            if (Units.CqlUnitsToUCUM.TryGetValue(precision, out var converted))
                precision = converted;
            switch (precision)
            {
                case UCUMUnits.Hour:
                    return Value.Hour;
                case UCUMUnits.Minute:
                    return Value.Minute;
                case UCUMUnits.Second:
                    return Value.Second;
                case UCUMUnits.Millisecond:
                    return Value.Millisecond;
                default:
                    return null;
            }
        }

        /// <summary>
        /// Returns the number of boundaries crossed for the specified precision between this and the argument.
        /// If this is after the second argument, the result is negative. 
        /// The result of this operation is always an integer; any fractional boundaries are dropped.
        /// </summary>
        public int? BoundariesBetween(CqlTime high, string precision) => CqlDateTimeMath.BoundariesBetween(Value.DateTimeOffset, high.Value.DateTimeOffset, precision);

        public CqlTime Predecessor() => Subtract(CqlDateTimeMath.UnitDateTimeQuantity[Value.Precision])!;
        public CqlTime Successor() => Add(CqlDateTimeMath.UnitDateTimeQuantity[Value.Precision])!;

        /// <summary>
        /// Returns the number of whole calendar periods for the specified precision between this and the argument.
        /// If this is after the argument, the result is negative. 
        /// The result of this operation is always an integer; any fractional periods are dropped.
        /// </summary>
        public int? WholeCalendarPointsBetween(CqlTime high, string precision) => CqlDateTimeMath.WholeCalendarPeriodsBetween(Value.DateTimeOffset, high.Value.DateTimeOffset, precision);

        public int? CompareTo(CqlTime? other, string? precision = null)
        {
            if (other == null)
                return null;
            DateTimePrecision dtp = DateTimePrecision.Unknown;
            if (precision == null)
                dtp = (DateTimePrecision)Math.Max((byte)Value.Precision, (byte)other.Value.Precision);
            else
            {
                if (Units.CqlUnitsToUCUM.TryGetValue(precision, out var converted))
                    precision = converted;
                dtp = precision.ToDateTimePrecision() ?? DateTimePrecision.Unknown;
            }
            if (dtp == DateTimePrecision.Unknown)
                throw new ArgumentException($"Invalid UCUM precision {precision}", nameof(precision));
            switch (dtp)
            {

                case DateTimePrecision.Hour:
                    {
                        var left = InUtc;
                        var right = other.InUtc;
                        if (Value.RationalOffset.HasValue ^ other.Value.RationalOffset.HasValue)
                        {
                            left = Value;
                            right = other.Value;
                        }
                        var hourComparison = Compare(left.Hour, right.Hour);
                        return hourComparison;
                    }
                case DateTimePrecision.Minute:
                    {
                        var left = InUtc;
                        var right = other.InUtc;
                        if (Value.RationalOffset.HasValue ^ other.Value.RationalOffset.HasValue)
                        {
                            left = Value;
                            right = other.Value;
                        }

                        var hourComparison = Compare(left.Hour, right.Hour);
                        if (hourComparison == 0)
                        {
                            var minuteComparison = Compare(left.Minute, right.Minute);
                            return minuteComparison;
                        }
                        else return hourComparison;
                    }
                case DateTimePrecision.Second:
                    {
                        var left = InUtc;
                        var right = other.InUtc;
                        if (Value.RationalOffset.HasValue ^ other.Value.RationalOffset.HasValue)
                        {
                            left = Value;
                            right = other.Value;
                        }
                        var hourComparison = Compare(left.Hour, right.Hour);
                        if (hourComparison == 0)
                        {
                            var minuteComparison = Compare(left.Minute, right.Minute);
                            if (minuteComparison == 0)
                            {
                                var secondComparison = Compare(left.Second, right.Second);
                                return secondComparison;
                            }
                            else return minuteComparison;
                        }
                        else return hourComparison;

                    }
                case DateTimePrecision.Millisecond:
                    {
                        var left = InUtc;
                        var right = other.InUtc;
                        if (Value.RationalOffset.HasValue ^ other.Value.RationalOffset.HasValue)
                        {
                            left = Value;
                            right = other.Value;
                        }
                        var hourComparison = Compare(left.Hour, right.Hour);
                        if (hourComparison == 0)
                        {
                            var minuteComparison = Compare(left.Minute, right.Minute);
                            if (minuteComparison == 0)
                            {
                                var secondComparison = Compare(left.Second, right.Second);
                                if (secondComparison == 0)
                                {
                                    var milliComparison = Compare(left.Millisecond, right.Millisecond);
                                    return milliComparison;
                                }
                                return secondComparison;
                            }
                            else return minuteComparison;
                        }
                        else return hourComparison;
                    }
                case DateTimePrecision.Unknown:
                case DateTimePrecision.Year:
                case DateTimePrecision.Month:
                case DateTimePrecision.Day:
                default:
                    throw new ArgumentException($"Invalid UCUM precision {precision}", nameof(precision));
            }
        }

        private int? Compare(int? x, int? y) => x == null || y == null ? null : Comparer<int>.Default.Compare(x.Value, y.Value);

        public bool Equivalent(CqlTime? other, string? precision) => (CompareTo(other, precision) ?? 0) == 0;

        public override string ToString() => Value.ToString();
        public override bool Equals(object obj) => Value.Equals((obj as CqlTime)?.Value!);
        public override int GetHashCode() => Value.GetHashCode();
    }
}

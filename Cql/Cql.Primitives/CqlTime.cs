/* 
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using Hl7.Cql.Iso8601;
using System;
using System.Collections.Generic;

namespace Hl7.Cql.Primitives
{
    /// <summary>
    /// Implements the System Time type.
    /// </summary>
    /// <see href="https://cql.hl7.org/09-b-cqlreference.html#time"/>
    [CqlPrimitiveType(CqlPrimitiveType.Time)]
    public class CqlTime : ICqlComparable<CqlTime>, IEquivalentable<CqlTime>
    {
        /// <summary>
        /// Defines the minimum value for System times (00:00:00.000Z)
        /// </summary>
        public static readonly CqlTime MinValue = new(0, 0, 0, 0, 0, 0);
        /// <summary>
        /// Defines the maximum value for System times (23:59:59.999Z)
        /// </summary>
        public static readonly CqlTime MaxValue = new(23, 59, 59, 999, 0, 0);

        /// <summary>
        /// Gets the value of this time.
        /// </summary>
        public TimeIso8601 Value { get; }
        /// <summary>
        /// Gets the value of this time in UTC.
        /// </summary>
        public TimeIso8601 InUtc { get; }
        /// <summary>
        /// Gets the precision in which this time is specified.
        /// </summary>
        public DateTimePrecision Precision => Value.Precision;

        /// <summary>
        /// Creates an instance.
        /// </summary>
        /// <param name="hour">The hour component, or <see langword="null"/> to indicate hour precision.</param>
        /// <param name="minute">The minute component, or <see langword="null"/> to indicate minute precision.</param>
        /// <param name="second">The second component, or <see langword="null"/> to indicate second precision.</param>
        /// <param name="millisecond">The day component, or <see langword="null"/> to indicate millisecond precision.</param>
        /// <param name="offsetHour">The time zone offset hours component, or <see langword="null"/> to indicate UTC.</param>
        /// <param name="offsetMinute">The time zone offset minutes component, or <see langword="null"/> to indicate UTC.</param>
        public CqlTime(int hour, int? minute, int? second, int? millisecond, int? offsetHour, int? offsetMinute) :
            this(new TimeIso8601(hour, minute, second, millisecond, offsetHour, offsetMinute))
        {
        }

        /// <summary>
        /// Creates an instance for the given ISO time.
        /// </summary>
        /// <param name="time">The time value.</param>
        public CqlTime(TimeIso8601 time)
        {
            Value = time;
            if (Value.RationalOffset.HasValue)
                InUtc = new TimeIso8601(time.TimeSpan.Add(time.Offset), 0, 0, time.Precision);
            else
                InUtc = new TimeIso8601(time.TimeSpan, 0, 0, time.Precision);
        }

        /// <summary>
        /// Tries to parse an ISO 8601 string as a time.
        /// </summary>
        /// <param name="s">The string value</param>
        /// <param name="time">The resulting time.</param>
        /// <returns><see langword="true"/> if successfully parsed; otherwise, <see langword="false"/>.</returns>
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

        /// <summary>
        /// Adds the given quantity to this time.
        /// </summary>
        /// <param name="quantity">The quantity to add.</param>
        /// <returns>A new time with <paramref name="quantity"/> added to it.</returns>
        /// <exception cref="ArgumentException">If the quantity is not expressed in supported units, or an overflow occurs.</exception>
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
                    span = span.Add(TimeSpan.FromDays(Math.Truncate((double)value) * CqlDateTimeMath.DaysPerWeekDouble));
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

        /// <summary>
        /// Subtracts the given quantity from this time.
        /// </summary>
        /// <param name="quantity">The quantity to subtract.</param>
        /// <returns>A new time with <paramref name="quantity"/> subtracted from it.</returns>
        /// <exception cref="ArgumentException">If the quantity is not expressed in supported units, or an overflow occurs.</exception>
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
                    span = span.Subtract(TimeSpan.FromDays(Math.Truncate((double)value) * CqlDateTimeMath.DaysPerWeekDouble));
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

        /// <summary>
        /// Gets the component of this time.
        /// </summary>
        /// <param name="precision">The CQL or UCUM unit precision.</param>
        /// <returns>The individual component at the specified precision, or <see langword="null"/> if this date is not expressed in those units.</returns>
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
        /// Gets the number of distinct boundaries in <paramref name="precision"/> between this time and <paramref name="high"/>.
        /// </summary>
        /// <param name="high">The high time bound against which to calculate.</param>
        /// <param name="precision">The boundary precision to count.</param>
        /// <returns>The number of <paramref name="precision"/> boundaries crossed between this time and <paramref name="high"/>.</returns>
        public int? BoundariesBetween(CqlTime high, string precision) => CqlDateTimeMath.BoundariesBetween(Value.DateTimeOffset, high.Value.DateTimeOffset, precision);

        /// <summary>
        /// Gets the number of whole calendar periods in <paramref name="precision"/> between this time and <paramref name="high"/>.
        /// </summary>
        /// <param name="high">The high time bound against which to calculate.</param>
        /// <param name="precision">The calendar precision to count.</param>
        /// <returns>The number of <paramref name="precision"/> whole calendar periods between this time and <paramref name="high"/>.</returns>
        public int? WholeCalendarPointsBetween(CqlTime high, string precision) => CqlDateTimeMath.WholeCalendarPeriodsBetween(Value.DateTimeOffset, high.Value.DateTimeOffset, precision);

        /// <summary>
        /// Gets the immediate predecessor of this value in its precision.
        /// </summary>
        /// <remarks>
        /// For example, if <see cref="Precision"/> is in <see cref="DateTimePrecision.Year"/>, this method will return the preceding year.
        /// </remarks>
        /// <returns>The immediate predecessor value.</returns>
        public CqlTime Predecessor() => Subtract(CqlDateTimeMath.UnitDateTimeQuantity[Value.Precision])!;

        /// <summary>
        /// Gets the immediate successor of this value in its precision.
        /// </summary>
        /// <remarks>
        /// For example, if <see cref="Precision"/> is in <see cref="DateTimePrecision.Year"/>, this method will return the following year.
        /// </remarks>
        /// <returns>The immediate predecessor value.</returns>
        public CqlTime Successor() => Add(CqlDateTimeMath.UnitDateTimeQuantity[Value.Precision])!;

        /// <summary>
        /// Compares the current instance with another object of the same type and returns an integer that indicates whether the current instance precedes, follows, or occurs in the same position in the sort order as the other object.
        /// </summary>
        /// <param name="other">An object to compare with this instance.</param>
        /// <param name="precision">The specified precision, or <see langword="null"/>.</param>
        /// <returns>
        /// A value that indicates the relative order of the objects being compared.  
        /// If the value is less than zero, this object is less than <paramref name="other"/>.  
        /// If the value is zero, this object is equal to <paramref name="other"/>.  
        /// If the value is greater than zero, this object is greater than <paramref name="other"/>.
        /// If the value is <see langword="null"/>, this comparison is uncertain because of <paramref name="precision"/>.
        /// </returns>
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

        /// <summary>
        /// Compares this object to <paramref name="other"/> for equivalence.
        /// </summary>
        /// <param name="other">The object to compare.</param>
        /// <param name="precision">The precision to use in this comparison, or <see langword="null"/>.</param>
        /// <returns><see langword="true"/> if this object is equivalent to <paramref name="other"/>, else <see langword="false"/>.</returns>
        public bool Equivalent(CqlTime? other, string? precision) => (CompareTo(other, precision) ?? 0) == 0;

        /// <summary>
        /// Returns <see cref="DateTimeIso8601.ToString"/> for <see cref="Value"/>.
        /// </summary>
        public override string ToString() => Value.ToString();
        /// <summary>
        /// Compares this object to <paramref name="obj"/> for equality.
        /// </summary>
        /// <param name="obj">The object to compare against this value.</param>
        /// <returns><see langword="true"/> if equal.</returns>
        public override bool Equals(object? obj) => Value.Equals((obj as CqlTime)?.Value!);
        /// <summary>
        /// Gets the value of <see cref="DateTimeIso8601.GetHashCode"/> for <see cref="Value"/>.
        /// </summary>
        public override int GetHashCode() => Value.GetHashCode();
    }
}

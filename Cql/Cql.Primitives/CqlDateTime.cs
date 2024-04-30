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
    /// Implements the System DateTime type.
    /// </summary>
    /// <see href="https://cql.hl7.org/09-b-cqlreference.html#datetime"/>
    [CqlPrimitiveType(CqlPrimitiveType.DateTime)]
    public class CqlDateTime : ICqlComparable<CqlDateTime>, IEquivalentable<CqlDateTime>
    {
        /// <summary>
        /// Defines the minimum value for System date times (@0001-01-01T00:00:00.000Z).
        /// </summary>
        public static readonly CqlDateTime MinValue = new(1, 1, 1, 0, 0, 0, 0, 0, 0);
        /// <summary>
        /// Defines the maximum value for System date times (@9999-12-31T23:59:59.999Z).
        /// </summary>
        public static readonly CqlDateTime MaxValue = new(9999, 12, 31, 23, 59, 59, 999, 0, 0);

        /// <summary>
        /// Gets the value of this date time.
        /// </summary>
        public DateTimeIso8601 Value { get; }
        /// <summary>
        /// Gets the value of this date time in UTC time.
        /// </summary>
        public DateTimeIso8601 InUtc { get; }
        /// <summary>
        /// Gets the precision in which this date time is specified.
        /// </summary>
        public DateTimePrecision Precision => Value.Precision;

        /// <summary>
        /// Gets the <see cref="CqlDate"/> component of this date time.
        /// </summary>
        public CqlDate DateOnly { get; }

        /// <summary>
        /// Gets the <see cref="CqlTime"/> component of this date time.
        /// </summary>
        public CqlTime? TimeOnly { get; }

        /// <summary>
        /// Creates an instance in at most <see cref="DateTimePrecision.Day"/> precision from the provided value.
        /// </summary>
        /// <param name="date">The date value.</param>
        public CqlDateTime(CqlDate date) :
            this(date.Value.Year, date.Value.Month, date.Value.Day, null, null, null, null, null, null)
        {
        }

        /// <summary>
        /// Creates an instance.
        /// </summary>
        /// <param name="year">The year component.</param>
        /// <param name="month">The month component, or <see langword="null"/> to indicate year precision.</param>
        /// <param name="day">The day component, or <see langword="null"/> to indicate month precision.</param>
        /// <param name="hour">The hour component, or <see langword="null"/> to indicate hour precision.</param>
        /// <param name="minute">The minute component, or <see langword="null"/> to indicate minute precision.</param>
        /// <param name="second">The second component, or <see langword="null"/> to indicate second precision.</param>
        /// <param name="millisecond">The day component, or <see langword="null"/> to indicate millisecond precision.</param>
        /// <param name="offsetHours">The time zone offset hours component, or <see langword="null"/> to indicate UTC.</param>
        /// <param name="offsetMinutes">The time zone offset minutes component, or <see langword="null"/> to indicate UTC.</param>
        public CqlDateTime(int year, int? month, int? day, int? hour, int? minute, int? second, int? millisecond, int? offsetHours, int? offsetMinutes) :
            this(new DateTimeIso8601(year, month, day, hour, minute, second, millisecond, offsetHours, offsetMinutes, true))
        {
        }

        /// <summary>
        /// Creates an instance for the given ISO date time.
        /// </summary>
        /// <param name="dateTime">The date time value.</param>
        public CqlDateTime(DateTimeIso8601 dateTime)
        {
            Value = dateTime;
            DateOnly = new CqlDate(new DateIso8601(dateTime.Year, dateTime.Month, dateTime.Day));
            if (dateTime.Precision > DateTimePrecision.Day)
            {
                TimeOnly = new CqlTime(new TimeIso8601(dateTime.Hour!.Value, dateTime.Minute, dateTime.Second, dateTime.Millisecond, dateTime.OffsetHour, dateTime.OffsetMinute));
                if (Value.RationalOffset == 0m)
                    InUtc = Value;
                else
                    InUtc = new DateTimeIso8601(Value.DateTimeOffsetUtc, Value.Precision);
            }
            else
                InUtc = Value;
        }

        /// <summary>
        /// Creates an instance with the given date time offset in the given precision.
        /// </summary>
        /// <param name="dto">The date time offset.</param>
        /// <param name="precision">The precision in which to store this date time.</param>
        public CqlDateTime(DateTimeOffset dto, DateTimePrecision precision) : this(new DateTimeIso8601(dto, precision))
        {
        }

        /// <summary>
        /// Implicitly converts a <see cref="DateTimeIso8601"/> to a <see cref="CqlDateTime"/>.
        /// </summary>
        /// <param name="dateTime">The date time to convert.</param>
        public static implicit operator CqlDateTime(DateTimeIso8601 dateTime) => new(dateTime);
        /// <summary>
        /// Implicitly converts a <see cref="CqlDateTime"/> to a <see cref="DateTimeIso8601"/>.
        /// </summary>
        /// <param name="dateTime">The date time to convert.</param>
        public static implicit operator DateTimeIso8601(CqlDateTime dateTime) => dateTime.Value;

        /// <summary>
        /// Tries to parse an ISO 8601 string as a date time.
        /// </summary>
        /// <param name="s">The string value</param>
        /// <param name="cqlDateTime">The resulting date time.</param>
        /// <returns><see langword="true"/> if successfully parsed; otherwise, <see langword="false"/>.</returns>
        public static bool TryParse(string s, out CqlDateTime? cqlDateTime)
        {
            if (DateTimeIso8601.TryParse(s, out var isoDateTime))
            {
                cqlDateTime = new CqlDateTime(isoDateTime!);
                return true;
            }
            else
            {
                cqlDateTime = null;
                return false;
            }
        }

        /// <summary>
        /// Adds the given quantity to this date time.
        /// </summary>
        /// <param name="quantity">The quantity to add.</param>
        /// <returns>A new date time with <paramref name="quantity"/> added to it.</returns>
        /// <exception cref="ArgumentException">If the quantity is not expressed in supported units, or an overflow occurs.</exception>
        public CqlDateTime? Add(CqlQuantity? quantity)
        {
            if (quantity == null || quantity.value == null || quantity.unit == null)
                return null;

            var value = quantity!.value.Value;
            var dto = Value.DateTimeOffset;
            switch (quantity.unit[0])
            {
                case 'a':
                    dto = dto.AddYears((int)value);
                    break;
                case 'm':
                    if (quantity.unit.Length > 1)
                    {
                        switch (quantity.unit[1])
                        {
                            case 'o':
                                dto = dto.AddMonths((int)value);
                                break;
                            case 'i':
                                dto = dto.AddMinutes(Math.Truncate((double)value));
                                break;
                            case 's':
                                dto = dto.AddMilliseconds(Math.Truncate((double)value));
                                break;
                            default: throw new ArgumentException($"Unknown date unit {quantity.unit} supplied");
                        }
                    }
                    break;
                case 'd':
                    dto = dto.AddDays((int)value!);
                    break;
                case 'w':
                    dto = dto.AddDays((int)(value! * CqlDateTimeMath.DaysPerWeek));
                    break;
                case 'h':
                    dto = dto.AddHours(Math.Truncate((double)value));
                    break;
                case 's':
                    dto = dto.AddSeconds(Math.Truncate((double)value));
                    break;
                default: throw new ArgumentException($"Unknown date unit {quantity.unit} supplied");
            }

            var newIsoDate = new DateTimeIso8601(dto, Value.Precision);
            var result = new CqlDateTime(newIsoDate);
            return result;
        }

        /// <summary>
        /// Subtracts the given quantity from this date time.
        /// </summary>
        /// <param name="quantity">The quantity to subtract.</param>
        /// <returns>A new date time with <paramref name="quantity"/> subtracted from it.</returns>
        /// <exception cref="ArgumentException">If the quantity is not expressed in supported units, or an overflow occurs.</exception>
        public CqlDateTime? Subtract(CqlQuantity quantity)
        {
            if (quantity == null || quantity.value == null || quantity.unit == null)
                return null;

            var value = -1 * quantity!.value.Value;
            var dto = Value.DateTimeOffset;
            switch (quantity.unit[0])
            {
                case 'a':
                    dto = dto.AddYears((int)value);
                    break;
                case 'm':
                    if (quantity.unit.Length > 1)
                    {
                        switch (quantity.unit[1])
                        {
                            case 'o':
                                dto = dto.AddMonths((int)value);
                                break;
                            case 'i':
                                dto = dto.AddMinutes(Math.Truncate((double)value));
                                break;
                            case 's':
                                dto = dto.AddMilliseconds(Math.Truncate((double)value));
                                break;
                            default: throw new ArgumentException($"Unknown date unit {quantity.unit} supplied");
                        }
                    }
                    break;
                case 'd':
                    dto = dto.AddDays((int)value!);
                    break;
                case 'w':
                    dto = dto.AddDays((int)(value! * CqlDateTimeMath.DaysPerWeek));
                    break;
                case 'h':
                    dto = dto.AddHours(Math.Truncate((double)value));
                    break;
                case 's':
                    dto = dto.AddSeconds(Math.Truncate((double)value));
                    break;
                default: throw new ArgumentException($"Unknown date unit {quantity.unit} supplied");
            }

            var newIsoDate = new DateTimeIso8601(dto, Value.Precision);
            var result = new CqlDateTime(newIsoDate);
            return result;
        }

        /// <summary>
        /// Gets the component of this date time.
        /// </summary>
        /// <param name="precision">The CQL or UCUM unit precision.</param>
        /// <returns>The individual component at the specified precision, or <see langword="null"/> if this date is not expressed in those units.</returns>
        public int? Component(string precision)
        {
            if (Units.CqlUnitsToUCUM.TryGetValue(precision, out var converted))
                precision = converted;
            switch (precision)
            {
                case UCUMUnits.Year:
                    return Value.Year;
                case UCUMUnits.Month:
                    return Value.Month;
                case UCUMUnits.Day:
                    return Value.Day;
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
        /// Gets the number of distinct boundaries in <paramref name="precision"/> between this date time and <paramref name="high"/>.
        /// </summary>
        /// <param name="high">The high date time bound against which to calculate.</param>
        /// <param name="precision">The boundary precision to count.</param>
        /// <returns>The number of <paramref name="precision"/> boundaries crossed between this date time and <paramref name="high"/>.</returns>
        public int? BoundariesBetween(CqlDateTime? high, string? precision) => CqlDateTimeMath.BoundariesBetween(Value.DateTimeOffsetUtc, high?.Value?.DateTimeOffsetUtc, precision);

        /// <summary>
        /// Gets the number of whole calendar periods in <paramref name="precision"/> between this date time and <paramref name="high"/>.
        /// </summary>
        /// <param name="high">The high date time bound against which to calculate.</param>
        /// <param name="precision">The calendar precision to count.</param>
        /// <returns>The number of <paramref name="precision"/> whole calendar periods between this date time and <paramref name="high"/>.</returns>
        public int? WholeCalendarPeriodsBetween(CqlDateTime high, string precision) => CqlDateTimeMath.WholeCalendarPeriodsBetween(Value.DateTimeOffset, high?.Value?.DateTimeOffset, precision);

        /// <summary>
        /// Gets the immediate predecessor of this value in its precision.
        /// </summary>
        /// <remarks>
        /// For example, if <see cref="Precision"/> is in <see cref="DateTimePrecision.Year"/>, this method will return the preceding year.
        /// </remarks>
        /// <returns>The immediate predecessor value.</returns>
        public CqlDateTime Predecessor() => Subtract(CqlDateTimeMath.UnitDateTimeQuantity[Value.Precision])!;

        /// <summary>
        /// Gets the immediate successor of this value in its precision.
        /// </summary>
        /// <remarks>
        /// For example, if <see cref="Precision"/> is in <see cref="DateTimePrecision.Year"/>, this method will return the following year.
        /// </remarks>
        /// <returns>The immediate predecessor value.</returns>
        public CqlDateTime Successor() => Add(CqlDateTimeMath.UnitDateTimeQuantity[Value.Precision])!;



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
        public int? CompareTo(CqlDateTime? other, string? precision)
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
                // weeks isn't part of the precision enumeration
                if (precision[0] == 'w')
                {
                    var yearComparison = Compare(Value.Year, other.Value.Year);
                    if (yearComparison == 0)
                    {
                        var monthComparison = Compare(Value.Month, other.Value.Month);
                        if (monthComparison == 0)
                        {
                            if (Value.Day != null && other.Value.Day != null)
                            {
                                var thisWeeks = (int)(Value.Day / CqlDateTimeMath.DaysPerWeek);
                                var otherWeeks = (int)(other.Value.Day / CqlDateTimeMath.DaysPerWeek);
                                return Compare(thisWeeks, otherWeeks);
                            }
                            else return 1;
                        }
                        else return monthComparison;
                    }
                    else return yearComparison;
                }
                dtp = precision.ToDateTimePrecision() ?? DateTimePrecision.Unknown;
            }
            if (dtp == DateTimePrecision.Unknown)
                throw new ArgumentException($"Invalid UCUM precision {precision}", nameof(precision));
            switch (dtp)
            {
                default:
                case DateTimePrecision.Unknown:
                    throw new ArgumentException($"Invalid UCUM precision {precision}", nameof(precision));
                case DateTimePrecision.Year:
                    return Compare(Value.Year, other.Value.Year);
                case DateTimePrecision.Month:
                    {
                        var yearComparison = Compare(Value.Year, other.Value.Year);
                        if (yearComparison == 0)
                        {
                            var monthComparison = Compare(Value.Month, other.Value.Month);
                            return monthComparison;
                        }
                        else return yearComparison;
                    }
                case DateTimePrecision.Day:
                    {
                        var yearComparison = Compare(Value.Year, other.Value.Year);
                        if (yearComparison == 0)
                        {
                            var monthComparison = Compare(Value.Month, other.Value.Month);
                            if (monthComparison == 0)
                            {
                                var dayComparison = Compare(Value.Day, other.Value.Day);
                                return dayComparison;
                            }
                            else return monthComparison;
                        }
                        else return yearComparison;
                    }
                // When comparing DateTime values with different timezone offsets, implementations should normalize
                // to the timezone offset of the evaluation request timestamp, but only when the comparison precision is hours, minutes, seconds, or milliseconds.               
                // https://cql.hl7.org/09-b-cqlreference.html#before
                // It doesn't actually have to be the request timezone; the dates just have to be in the same (any) timezone.
                // Tests demonstrate that when one datetime has a timezone specified and the other does not,
                // the timezone should be ignored.  Functionally, this means don't normalize.
                case DateTimePrecision.Hour:
                    {
                        var left = InUtc;
                        var right = other.InUtc;
                        if (Value.RationalOffset.HasValue ^ other.Value.RationalOffset.HasValue)
                        {
                            left = Value;
                            right = other.Value;
                        }
                        var yearComparison = Compare(left.Year, right.Year);
                        if (yearComparison == 0)
                        {
                            var monthComparison = Compare(left.Month, right.Month);

                            if (monthComparison == 0)
                            {
                                var dayComparison = Compare(left.Day, right.Day);

                                if (dayComparison == 0)
                                {
                                    var hourComparison = Compare(left.Hour, right.Hour);
                                    return hourComparison;
                                }
                                else return dayComparison;
                            }
                            else return monthComparison;
                        }
                        else return yearComparison;
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
                        var yearComparison = Compare(left.Year, right.Year);
                        if (yearComparison == 0)
                        {
                            var monthComparison = Compare(left.Month, right.Month);
                            if (monthComparison == 0)
                            {
                                var dayComparison = Compare(left.Day, right.Day);
                                if (dayComparison == 0)
                                {
                                    var hourComparison = Compare(left.Hour, right.Hour);
                                    if (hourComparison == 0)
                                    {
                                        var minuteComparison = Compare(left.Minute, right.Minute);
                                        return minuteComparison;
                                    }
                                    else return hourComparison;
                                }
                                else return dayComparison;
                            }
                            else return monthComparison;
                        }
                        else return yearComparison;
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
                        var yearComparison = Compare(left.Year, right.Year);
                        if (yearComparison == 0)
                        {
                            var monthComparison = Compare(left.Month, right.Month);

                            if (monthComparison == 0)
                            {
                                var dayComparison = Compare(left.Day, right.Day);

                                if (dayComparison == 0)
                                {
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
                                else return dayComparison;
                            }
                            else return monthComparison;
                        }
                        else return yearComparison;
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
                        var yearComparison = Compare(left.Year, right.Year);
                        if (yearComparison == 0)
                        {
                            var monthComparison = Compare(left.Month, right.Month);

                            if (monthComparison == 0)
                            {
                                var dayComparison = Compare(left.Day, right.Day);

                                if (dayComparison == 0)
                                {
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
                                else return dayComparison;
                            }
                            else return monthComparison;
                        }
                        else return yearComparison;
                    }
            }
        }
        private int? Compare(int? x, int? y) => x == null || y == null ? null : Comparer<int>.Default.Compare(x.Value, y.Value);

        /// <summary>
        /// Compares this object to <paramref name="other"/> for equivalence.
        /// </summary>
        /// <param name="other">The object to compare.</param>
        /// <param name="precision">The precision to use in this comparison, or <see langword="null"/>.</param>
        /// <returns><see langword="true"/> if this object is equivalent to <paramref name="other"/>, else <see langword="false"/>.</returns>
        public bool Equivalent(CqlDateTime? other, string? precision) => (CompareTo(other, precision) ?? 0) == 0;

        /// <summary>
        /// Returns <see cref="DateTimeIso8601.ToString"/> for <see cref="Value"/>.
        /// </summary>
        public override string ToString() => Value.ToString();
        /// <summary>
        /// Compares this object to <paramref name="obj"/> for equality.
        /// </summary>
        /// <param name="obj">The object to compare against this value.</param>
        /// <returns><see langword="true"/> if equal.</returns>
        public override bool Equals(object? obj) => Value.Equals((obj as CqlDateTime)?.Value!);
        /// <summary>
        /// Gets the value of <see cref="DateTimeIso8601.GetHashCode"/> for <see cref="Value"/>.
        /// </summary>
        public override int GetHashCode() => Value.GetHashCode();
    }
}

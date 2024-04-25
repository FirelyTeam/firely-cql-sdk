/* 
 * Copyright (c) 2023, NCQA and contributors
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
    /// Implements the System Date type.
    /// </summary>
    /// <see href="https://cql.hl7.org/09-b-cqlreference.html#date"/>
    [CqlPrimitiveType(CqlPrimitiveType.Date)]
    public class CqlDate : ICqlComparable<CqlDate>, IEquivalentable<CqlDate>
    {
        /// <summary>
        /// Defines the minimum value for System dates (@0001-01-01).
        /// </summary>
        public static readonly CqlDate MinValue = new(1, 1, 1);
        /// <summary>
        /// Defines the maximum value for System dates (@9999-12-31).
        /// </summary>
        public static readonly CqlDate MaxValue = new(9999, 12, 31);

        /// <summary>
        /// Gets the value of this date.
        /// </summary>
        public DateIso8601 Value { get; }
        /// <summary>
        /// Gets the precision in which this date is specified.
        /// </summary>
        public DateTimePrecision Precision => Value.Precision;

        /// <summary>
        /// Creates the date component of the given date time.
        /// </summary>
        /// <param name="dateTime">The date time whose date component to represent.</param>
        public CqlDate(CqlDateTime dateTime) :
            this(dateTime.Value.Year, dateTime.Value.Month, dateTime.Value.Day)
        {

        }
        /// <summary>
        /// Creates an instance.
        /// </summary>
        /// <param name="year">The year component.</param>
        /// <param name="month">The month component, or <see langword="null"/> to indicate year precision.</param>
        /// <param name="day">The day component, or <see langword="null"/> to indicate month precision.</param>
        public CqlDate(int year, int? month, int? day)
            : this(new DateIso8601(year, month, day))
        {
        }
        /// <summary>
        /// Creates an instance for the given ISO date.
        /// </summary>
        /// <param name="isoDate">The date value.</param>
        public CqlDate(DateIso8601 isoDate)
        {
            Value = isoDate;
        }

        /// <summary>
        /// Tries to parse an ISO 8601 string as a date.
        /// </summary>
        /// <param name="s">The string value</param>
        /// <param name="cqlDate">The resulting date.</param>
        /// <returns><see langword="true"/> if successfully parsed; otherwise, <see langword="false"/>.</returns>
        public static bool TryParse(string s, out CqlDate? cqlDate)
        {
            if (DateIso8601.TryParse(s, out var isoDate))
            {
                cqlDate = new CqlDate(isoDate!);
                return true;
            }
            else
            {
                cqlDate = null;
                return false;
            }
        }
        /// <summary>
        /// Adds the given quantity to this date.
        /// </summary>
        /// <param name="quantity">The quantity to add.</param>
        /// <returns>A new date with <paramref name="quantity"/> added to it.</returns>
        /// <exception cref="ArgumentException">If the quantity is not expressed in supported units, or an overflow occurs.</exception>
        public CqlDate? Add(CqlQuantity? quantity)
        {
            if (quantity == null || quantity.value == null || quantity.unit == null)
                return null;
            quantity = quantity.NormalizeTo(Precision);
            var value = quantity.value!.Value;
            var dto = Value.DateTimeOffset;
            switch (quantity.unit![0])
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

            var newIsoDate = new DateIso8601(dto, Value.Precision);
            var result = new CqlDate(newIsoDate);
            return result;
        }

        /// <summary>
        /// Subtracts the given quantity from this date.
        /// </summary>
        /// <param name="quantity">The quantity to subtract.</param>
        /// <returns>A new date with <paramref name="quantity"/> subtracted from it.</returns>
        /// <exception cref="ArgumentException">If the quantity is not expressed in supported units, or an overflow occurs.</exception>
        public CqlDate? Subtract(CqlQuantity? quantity)
        {
            if (quantity == null || quantity.value == null || quantity.unit == null)
                return null;
            quantity = quantity.NormalizeTo(Precision);
            var value = -1 * quantity.value!.Value;
            var dto = Value.DateTimeOffset;
            try
            {
                switch (quantity.unit![0])
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
            }
            catch (ArgumentOutOfRangeException)
            {
                // In cases where e.g. Predecessor is called on minimum Date.
                return null;
            }

            var newIsoDate = new DateIso8601(dto, Value.Precision);
            var result = new CqlDate(newIsoDate);
            return result;
        }

        /// <summary>
        /// Gets the component of this date.
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
                default:
                    return null;
            }
        }

        /// <summary>
        /// Gets the number of distinct boundaries in <paramref name="precision"/> between this date and <paramref name="high"/>.
        /// </summary>
        /// <param name="high">The high date bound against which to calculate.</param>
        /// <param name="precision">The boundary precision to count.</param>
        /// <returns>The number of <paramref name="precision"/> boundaries crossed between this date and <paramref name="high"/>.</returns>
        public int? BoundariesBetween(CqlDate? high, string? precision) => CqlDateTimeMath.BoundariesBetween(Value.DateTimeOffset, high?.Value?.DateTimeOffset, precision);

        /// <summary>
        /// Gets the number of whole calendar periods in <paramref name="precision"/> between this date and <paramref name="high"/>.
        /// </summary>
        /// <param name="high">The high date bound against which to calculate.</param>
        /// <param name="precision">The calendar precision to count.</param>
        /// <returns>The number of <paramref name="precision"/> whole calendar periods between this date and <paramref name="high"/>.</returns>
        public int? WholeCalendarPeriodsBetween(CqlDate high, string precision) => CqlDateTimeMath.WholeCalendarPeriodsBetween(Value.DateTimeOffset, high?.Value?.DateTimeOffset, precision);

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
        public int? CompareTo(CqlDate? other, string? precision)
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
                case DateTimePrecision.Hour:
                case DateTimePrecision.Minute:
                case DateTimePrecision.Second:
                case DateTimePrecision.Millisecond:
                case DateTimePrecision.Unknown:
                default:
                    throw new ArgumentException($"Invalid UCUM precision {precision}", nameof(precision));
            }
        }

        /// <summary>
        /// Gets the immediate predecessor of this value in its precision.
        /// </summary>
        /// <remarks>
        /// For example, if <see cref="Precision"/> is in <see cref="DateTimePrecision.Year"/>, this method will return the preceding year.
        /// </remarks>
        /// <returns>The immediate predecessor value.</returns>
        public CqlDate Predecessor() => Subtract(CqlDateTimeMath.UnitDateTimeQuantity[Value.Precision])!;

        /// <summary>
        /// Gets the immediate successor of this value in its precision.
        /// </summary>
        /// <remarks>
        /// For example, if <see cref="Precision"/> is in <see cref="DateTimePrecision.Year"/>, this method will return the following year.
        /// </remarks>
        /// <returns>The immediate predecessor value.</returns>
        public CqlDate Successor() => Add(CqlDateTimeMath.UnitDateTimeQuantity[Value.Precision])!;

        private int? Compare(int? x, int? y) => x == null || y == null ? null : Comparer<int>.Default.Compare(x.Value, y.Value);


        /// <summary>
        /// Compares this object to <paramref name="other"/> for equivalence.
        /// </summary>
        /// <param name="other">The object to compare.</param>
        /// <param name="precision">The precision to use in this comparison, or <see langword="null"/>.</param>
        /// <returns><see langword="true"/> if this object is equivalent to <paramref name="other"/>, else <see langword="false"/>.</returns>
        public bool Equivalent(CqlDate? other, string? precision) => (CompareTo(other, precision) ?? 0) == 0;

        /// <summary>
        /// Returns <see cref="DateIso8601.ToString"/> for <see cref="Value"/>.
        /// </summary>
        public override string ToString() => Value.ToString();
        /// <summary>
        /// Compares this object to <paramref name="obj"/> for equality.
        /// </summary>
        /// <param name="obj">The object to compare against this value.</param>
        /// <returns><see langword="true"/> if equal.</returns>
        public override bool Equals(object? obj) => Value.Equals((obj as CqlDate)?.Value!);
        /// <summary>
        /// Gets the value of <see cref="DateIso8601.GetHashCode"/> for <see cref="Value"/>.
        /// </summary>
        public override int GetHashCode() => Value.GetHashCode();
    }
}

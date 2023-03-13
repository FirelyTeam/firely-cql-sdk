using Ncqa.Cql.Runtime.Comparers;
using Ncqa.Cql.Runtime.Conversion;
using Ncqa.Iso8601;
using System;
using System.Collections.Generic;

namespace Ncqa.Cql.Runtime.Primitives
{
    [CqlPrimitiveType(CqlPrimitiveType.DateTime)]
    public class CqlDateTime : ICqlComparable<CqlDateTime>, IEquivalentable<CqlDateTime>
    {
        public static readonly CqlDateTime MinValue = new CqlDateTime(1, 1, 1, 0, 0, 0, 0, 0, 0);
        public static readonly CqlDateTime MaxValue = new CqlDateTime(9999, 12, 31, 23, 59, 59, 999, 0, 0);

        public DateTimeIso8601 Value { get; }
        public DateTimeIso8601 InUtc { get; }
        public DateTimePrecision Precision => Value.Precision;

        public CqlDate DateOnly { get; }
        public CqlTime? TimeOnly { get; }

        public CqlDateTime(CqlDate date) :
            this(date.Value.Year, date.Value.Month, date.Value.Day, null, null, null, null, null, null)
        {
        }

        public CqlDateTime(int year, int? month, int? day, int? hour, int? minute, int? second, int? millisecond, int? offsetHours, int? offsetMinutes) :
            this(new DateTimeIso8601(year, month, day, hour, minute, second, millisecond, offsetHours, offsetMinutes, true))
        {
        }

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

        public CqlDateTime(DateTimeOffset dto, DateTimePrecision precision) : this(new DateTimeIso8601(dto, precision))
        {
        }

        public static implicit operator CqlDateTime(DateTimeIso8601 dateTime) => new CqlDateTime(dateTime);
        public static implicit operator DateTimeIso8601(CqlDateTime dateTime) => dateTime.Value;

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
                    dto = dto.AddDays((int)(value! * ConversionConstants.DaysPerWeek));
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
                    dto = dto.AddDays((int)(value! * ConversionConstants.DaysPerWeek));
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


        public int? BoundariesBetween(CqlDateTime? high, string? precision) => CqlDateTimeMath.BoundariesBetween(Value.DateTimeOffsetUtc, high?.Value?.DateTimeOffsetUtc, precision);

        public int? WholeCalendarPeriodsBetween(CqlDateTime high, string precision) => CqlDateTimeMath.WholeCalendarPeriodsBetween(Value.DateTimeOffset, high?.Value?.DateTimeOffset, precision);

        public CqlDateTime Predecessor() => Subtract(CqlDateTimeMath.UnitDateTimeQuantity[Value.Precision])!;
        public CqlDateTime Successor() => Add(CqlDateTimeMath.UnitDateTimeQuantity[Value.Precision])!;


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
                                var thisWeeks = (int)(Value.Day / ConversionConstants.DaysPerWeek);
                                var otherWeeks = (int)(other.Value.Day / ConversionConstants.DaysPerWeek);
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

        public bool Equivalent(CqlDateTime? other, string? precision) => (CompareTo(other, precision) ?? 0) == 0;

        public override string ToString() => Value.ToString();
        public override bool Equals(object obj) => Value.Equals((obj as CqlDateTime)?.Value!);
        public override int GetHashCode() => Value.GetHashCode();
    }
}

using Ncqa.Cql.Runtime.Comparers;
using Ncqa.Cql.Runtime.Conversion;
using Ncqa.Iso8601;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ncqa.Cql.Runtime.Primitives
{
    [CqlPrimitiveType(CqlPrimitiveType.Date)]
    public class CqlDate : ICqlComparable<CqlDate>, IEquivalentable<CqlDate>
    {
        public static readonly CqlDate MinValue = new CqlDate(1, 1, 1);
        public static readonly CqlDate MaxValue = new CqlDate(9999, 12, 31);


        public static CqlDate Today(DateTimeOffset now) => new CqlDate(new DateIso8601(now, DateTimePrecision.Day));

        public DateIso8601 Value { get; }
        public DateTimePrecision Precision => Value.Precision;


        public CqlDate(CqlDateTime dateTime) :
            this(dateTime.Value.Year, dateTime.Value.Month, dateTime.Value.Day)
        {

        }
        public CqlDate(int year, int? month, int? day)
            : this(new DateIso8601(year, month, day))
        {
        }
        public CqlDate(DateIso8601 isoDate)
        {
            Value = isoDate;
        }

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
        public CqlDate? Add(CqlQuantity? quantity)
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

            var newIsoDate = new DateIso8601(dto, Value.Precision);
            var result = new CqlDate(newIsoDate);
            return result;
        }
        public CqlDate? Subtract(CqlQuantity? quantity)
        {
            if (quantity == null || quantity.value == null || quantity.unit == null)
                return null;

            var value = -1 * quantity!.value.Value;
            var dto = Value.DateTimeOffset;
            try
            {
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
            }
            catch(ArgumentOutOfRangeException)
            {
                // In cases where e.g. Predecessor is called on minimum Date.
                return null;
            }

            var newIsoDate = new DateIso8601(dto, Value.Precision);
            var result = new CqlDate(newIsoDate);
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
                default:
                    return null;
            }
        }

        public int? BoundariesBetween(CqlDate? high, string? precision) => CqlDateTimeMath.BoundariesBetween(Value.DateTimeOffset, high?.Value?.DateTimeOffset, precision);

        public int? WholeCalendarPeriodsBetween(CqlDate high, string precision) => CqlDateTimeMath.WholeCalendarPeriodsBetween(Value.DateTimeOffset, high?.Value?.DateTimeOffset, precision);

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
        public CqlDate Predecessor() => Subtract(CqlDateTimeMath.UnitDateTimeQuantity[Value.Precision])!;
        public CqlDate Successor() => Add(CqlDateTimeMath.UnitDateTimeQuantity[Value.Precision])!;

        private int? Compare(int? x, int? y) => x == null || y == null ? null : Comparer<int>.Default.Compare(x.Value, y.Value);
        public bool Equivalent(CqlDate? other, string? precision) => (CompareTo(other, precision) ?? 0) == 0;

        public override string ToString() => Value.ToString();
        public override bool Equals(object obj) => Value.Equals((obj as CqlDate)?.Value!);
        public override int GetHashCode() => Value.GetHashCode();
    }
}

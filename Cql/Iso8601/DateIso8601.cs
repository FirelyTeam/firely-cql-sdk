using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Ncqa.Iso8601
{
    public class DateIso8601
    {

        // Note: integer types used here because C# promotes smaller types to 4 byte ints for all math.
        // That conversion ad nauseum is more expensive than superfluous memory use.
        public int Year { get; }
        public int? Month { get; }
        public int? Day { get; }
        public DateTimePrecision Precision { get; }
        public DateTimeOffset DateTimeOffset { get; }
        private readonly string String;

        public static readonly Regex Expression = new Regex(@"(?'year'\d\d\d\d)(-(?'month'\d\d)(-(?'day'\d\d))?)?", RegexOptions.Compiled);

        public DateIso8601(int year, int? month, int? day, bool strict = false) :
            this(Format(year, month, day, DateTimePrecision.Day),
                year, month, day, strict)
        {
        }

        /// <summary>
        /// Creates a new instance, initializing fields from the values specified in <paramref name="dto"/>
        /// up to and including <paramref name="precision"/>, leaving all others <see langword="null"/>.
        /// </summary>
        public DateIso8601(DateTimeOffset dto, DateTimePrecision precision, bool strict = false) :
            this(Format(dto.Year, dto.Month, dto.Day, precision),
                dto.Year, dto.Month, dto.Day, strict, precision)
        {
        }

        internal DateIso8601(string @string, int year, int? month, int? day,
            bool strict = false, DateTimePrecision precision = DateTimePrecision.Unknown)
        {
            if (year == 0)
            {
                throw new ArgumentException("Year 0 is not valid.", nameof(year));
            }
            if (strict)
            {
                if (month.HasValue)
                {
                    if (month.Value < 1 || month.Value > 12)
                        throw new ArgumentException("Month must between [1,12]", nameof(month));
                    if (day.HasValue)
                    {
                        if (day.Value < 1 || day.Value > 31)
                            throw new ArgumentException("Day must between [1,31]", nameof(day));
                        else if ((month.Value == 4 || month.Value == 6 || month.Value == 9 || month.Value == 11)
                            && day.Value > 30)
                            throw new ArgumentException("This month has only 30 days", nameof(day));
                        else if (month.Value == 2)
                        {
                            if (day > 28 && (year % 4) != 0)
                                throw new ArgumentException("Only leap years have 29 days in February", nameof(day));
                            else if (day > 30)
                                throw new ArgumentException("February only has 29 days during leap years", nameof(day));
                        }                        
                        else
                            Precision = DateTimePrecision.Day;
                    }
                    else
                        Precision = DateTimePrecision.Month;

                }
                else if (day.HasValue)
                    throw new ArgumentException("If month is not specified, then all following values must also not be specified.", nameof(day));
                else
                    Precision = DateTimePrecision.Year;
            }
            else if (precision == DateTimePrecision.Unknown)
            {
                if (day.HasValue)
                    Precision = DateTimePrecision.Day;
                else if (month.HasValue)
                    Precision = DateTimePrecision.Month;
                else
                    Precision = DateTimePrecision.Year;
            }
            else
            {
                Precision = precision;
            }
            if (Precision > DateTimePrecision.Unknown)
            {
                Year = year;
                if (Precision > DateTimePrecision.Year)
                {
                    Month = month;
                    if (Precision > DateTimePrecision.Month)
                    {
                        Day = day;
                    }
                }
            }
            else throw new ArgumentException("Unknown precision is not supported", nameof(precision));

            DateTimeOffset = new DateTimeOffset(Year,
                Month ?? 1,
                Day ?? 1,
                default,
                default,
                default,
                default,
                default);
            String = @string;
        }

        public DateIso8601 InPrecision(DateTimePrecision precision) => new DateIso8601(DateTimeOffset, precision);

        public override string ToString() => String;
        public override bool Equals(object obj) => Equals(String, obj?.ToString());
        public override int GetHashCode() => String.GetHashCode();

        public static bool TryParse(string stringValue, out DateIso8601? dateTimeValue)
        {
            var parts = Expression.Match(stringValue);
            if (!parts.Success || parts.Captures.Count != 1 || parts.Captures[0].Length != stringValue.Length)
            {
                dateTimeValue = null;
                return false;
            }
            else
            {
                dateTimeValue = stringValue;
                return true;
            }

        }

        public static implicit operator DateIso8601(string stringValue)
        {
            var parts = Expression.Match(stringValue);
            if (!parts.Success || parts.Captures.Count != 1 || parts.Captures[0].Length != stringValue.Length)
                throw new ArgumentException($"Invalid ISO 8601 date: {stringValue}", nameof(stringValue));

            int? year = null, month = null, day = null;

            var yearGroup = parts.Groups["year"];
            var monthGroup = parts.Groups["month"];
            var dayGroup = parts.Groups["day"];

            if (yearGroup.Success)
            {
                year = int.Parse(yearGroup.Value);
                if (monthGroup.Success)
                {
                    month = int.Parse(monthGroup.Value);
                    if (dayGroup.Success)
                    {
                        day = int.Parse(dayGroup.Value);
                    }
                }
            }
            else throw new ArgumentException($"Dates must have at least year specified.", nameof(stringValue));

            var isoDate = new DateIso8601(stringValue, year!.Value, month, day);
            return isoDate;
        }

        private static string Format(int year, int? month, int? day, DateTimePrecision precision)
        {
            var sb = new StringBuilder();
            sb.Append(year.ToString("D4"));
            if (month.HasValue && precision > DateTimePrecision.Year)
            {
                sb.Append('-');
                sb.Append(month.Value.ToString("D2"));
                if (day.HasValue && precision > DateTimePrecision.Month)
                {
                    sb.Append('-');
                    sb.Append(day.Value.ToString("D2"));                    
                }
            }
            return sb.ToString();
        }

    }
}

/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

using System;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace Hl7.Cql.Iso8601
{
    /// <summary>
    /// Represents a date in time according to ISO 8601, with year, month and day components isolated and with supplied precision level retained.
    /// </summary>
    public class DateIso8601
    {

        // Note: integer types used here because C# promotes smaller types to 4 byte ints for all math.
        // That conversion ad nauseum is more expensive than superfluous memory use.

        /// <summary>
        /// Gets the year component of this date.
        /// </summary>
        public int Year { get; }
        /// <summary>
        /// Gets the month component of this date.
        /// </summary>
        public int? Month { get; }
        /// <summary>
        /// Gets the day component of this date.
        /// </summary>
        public int? Day { get; }
        /// <summary>
        /// Gets the precision of this date.
        /// </summary>
        public DateTimePrecision Precision { get; }
        /// <summary>
        /// Gets this date represented as a <see cref="DateTimeOffset"/>.
        /// </summary>
        public DateTimeOffset DateTimeOffset { get; }

        private readonly string String;

        /// <summary>
        /// The regular expression used to parse ISO 8601 dates.
        /// </summary>
        public static readonly Regex Expression = new(@"(?'year'\d\d\d\d)(-(?'month'\d\d)(-(?'day'\d\d))?)?", RegexOptions.Compiled);

        /// <summary>
        /// Creates an instance.
        /// </summary>
        /// <param name="year">The year component of the date.</param>
        /// <param name="month">The month component of the date, or <see langword ="null"/>.</param>
        /// <param name="day">The day component of the date, or <see langword ="null"/>.</param>
        /// <param name="strict">If <see langword ="true"/>, validates the ranges of all parameters to ensure only real dates.</param>
        public DateIso8601(int year, int? month, int? day, bool strict = false) :
            this(Format(year, month, day, DateTimePrecision.Day),
                year, month, day, strict)
        {
        }

        /// <summary>
        /// Creates a new instance, initializing fields from the values specified in <paramref name="dto"/>
        /// up to and including <paramref name="precision"/>, leaving all others <see langword="null"/>.
        /// </summary>
        /// <param name="dto">The date represented by a <see cref="DateTimeOffset"/>.</param>
        /// <param name="precision">The desired precision for this ISO date.</param>
        /// <param name="strict">If <see langword ="true"/>, validates the ranges of all parameters to ensure only real dates.</param>
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

        public override string ToString() => String;
        public override bool Equals(object? obj) => Equals(String, obj?.ToString());
        public override int GetHashCode() => String.GetHashCode();

        /// <summary>
        /// Tries to parse <paramref name="stringValue"/> as an ISO 8601 date.
        /// </summary>
        /// <param name="stringValue">The string to parse</param>
        /// <param name="dateValue">The parsed result, or <see langword ="null"/> if unparseable.</param>
        /// <returns><see langword ="true"/> if the string is a valid ISO 8601 date and parsing is successful; otherwise <see langword ="false"/>.</returns>
        public static bool TryParse(string stringValue, out DateIso8601? dateValue)
        {
            var parts = Expression.Match(stringValue);
            if (!parts.Success || parts.Captures.Count != 1 || parts.Captures[0].Length != stringValue.Length)
            {
                dateValue = null;
                return false;
            }
            else
            {
                dateValue = stringValue;
                return true;
            }

        }

        /// <summary>
        /// Converts a string to an ISO 8601 date, or throws.
        /// </summary>
        /// <param name="stringValue">The string to convert.</param>
        /// <exception cref="ArgumentException">When <paramref name="stringValue"/> cannot be parsed.</exception>
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
                year = int.Parse(yearGroup.Value, CultureInfo.InvariantCulture);
                if (monthGroup.Success)
                {
                    month = int.Parse(monthGroup.Value, CultureInfo.InvariantCulture);
                    if (dayGroup.Success)
                    {
                        day = int.Parse(dayGroup.Value, CultureInfo.InvariantCulture);
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
            sb.Append(year.ToString("D4", CultureInfo.InvariantCulture));
            if (month.HasValue && precision > DateTimePrecision.Year)
            {
                sb.Append('-');
                sb.Append(month.Value.ToString("D2", CultureInfo.InvariantCulture));
                if (day.HasValue && precision > DateTimePrecision.Month)
                {
                    sb.Append('-');
                    sb.Append(day.Value.ToString("D2", CultureInfo.InvariantCulture));
                }
            }
            return sb.ToString();
        }

    }
}

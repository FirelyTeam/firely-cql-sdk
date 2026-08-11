#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Iso8601
{
    /// <summary>
    /// Represents an instant in time according to ISO 8601, with components isolated and with supplied precision level retained.
    /// </summary>
    public class DateTimeIso8601
    {

        // Note: integer types used here because C# promotes smaller types to 4 byte ints for all math.
        // That conversion ad nauseum is more expensive than superfluous memory use.

        /// <summary>
        /// Gets the year component of this date time.
        /// </summary>
        public int Year { get; }
        /// <summary>
        /// Gets the month component of this date time.
        /// </summary>
        public int? Month { get; }
        /// <summary>
        /// Gets the day component of this date time.
        /// </summary>
        public int? Day { get; }
        /// <summary>
        /// Gets the hour component of this date time.
        /// </summary>
        public int? Hour { get; }
        /// <summary>
        /// Gets the minute component of this date time.
        /// </summary>
        public int? Minute { get; }
        /// <summary>
        /// Gets the second component of this date time.
        /// </summary>
        public int? Second { get; }
        /// <summary>
        /// Gets the millisecond component of this date time.
        /// </summary>
        public int? Millisecond { get; }
        /// <summary>
        /// Gets the offset hour component of this date time.
        /// </summary>
        public int? OffsetHour { get; }
        /// <summary>
        /// Gets the offset minute component of this date time.
        /// </summary>
        public int? OffsetMinute { get; }
        /// <summary>
        /// Gets the offset component expressed as rational hours, for example an offset of 01:30 would be expressed as 1.5.
        /// </summary>
        public decimal? RationalOffset { get; }

        /// <summary>
        /// Gets the precision of this date time.
        /// </summary>
        public DateTimePrecision Precision { get; }

        /// <summary>
        /// Gets this date time represented as a <see cref="DateTimeOffset"/>.
        /// </summary>
        public DateTimeOffset DateTimeOffset { get; }

        /// <summary>
        /// Gets this date time represented as a <see cref="DateTimeOffset"/> in UTC.
        /// </summary>
        public DateTimeOffset DateTimeOffsetUtc { get; set; }

        // Formatted lazily: most instances - the intermediates of date arithmetic, comparisons and
        // FHIR-to-CQL conversions - are never rendered as text, and eager formatting (a StringBuilder and
        // one small string per component) dominated construction cost. Parsing still stores the original
        // literal, keeping parse/format roundtrips byte-identical. The ??= race is benign: both threads
        // compute the same string.
        private string? _string;

        // The precision the eager implementation passed to Format(...) from whichever constructor ran.
        // This is deliberately NOT the same thing as Precision: under strict validation, or with an
        // explicit DateTimePrecision.Unknown, the eager code formatted at the precision *argument* while
        // Precision was derived from which components have values. Reproducing the argument exactly is
        // what keeps ToString()/Equals/GetHashCode byte-identical to the eager implementation. Whether that
        // divergence is the intended contract is tracked separately, in issue #1524. The parse
        // path leaves this at its default: it stores the original literal in _string, so Format never runs.
        private readonly DateTimePrecision _stringPrecision;

        private string String => _string ??=
            Format(Year, Month, Day, Hour, Minute, Second, Millisecond, OffsetHour, OffsetMinute, _stringPrecision);

        /// <summary>
        /// The regular expression used to parse ISO 8601 date times.
        /// </summary>
        public static readonly Regex Expression = new(@"(?'year'\d\d\d\d)(-(?'month'\d\d)(-(?'day'\d\d)(T(?'hour'\d\d)?(:(?'minute'\d\d)?(:(?'second'\d\d)(\.(?'ms'\d{1,3}))?)?)?(?'timezone'([\+\-]?(?'tzhour'\d\d)(:(?'tzminute'\d\d))?)|Z)?)?)?)?", RegexOptions.Compiled);

        /// <summary>
        /// Local now expressed as a <see cref="DateTimeOffset"/>.
        /// </summary>
        public static DateTimeIso8601 Now => new(DateTimeOffset.Now, DateTimePrecision.Millisecond);
        /// <summary>
        /// UTC now expressed as a <see cref="DateTimeOffset"/>.
        /// </summary>
        public static DateTimeIso8601 UtcNow => new(DateTimeOffset.UtcNow, DateTimePrecision.Millisecond);

        /// <summary>
        /// Creates an instance.
        /// </summary>
        /// <param name="year">The year component of the date.</param>
        /// <param name="month">The month component of the date, or <see langword ="null"/>.</param>
        /// <param name="day">The day component of the date, or <see langword ="null"/>.</param>
        /// <param name="hour">The hour component of the date, or <see langword ="null"/>.</param>
        /// <param name="minute">The minute component of the date, or <see langword ="null"/>.</param>
        /// <param name="second">The second component of the date, or <see langword ="null"/>.</param>
        /// <param name="ms">The millisecond component of the date, or <see langword ="null"/>.</param>
        /// <param name="osHour">The hour component of the date, or <see langword ="null"/>.</param>
        /// <param name="osMinute">The minute component of the date, or <see langword ="null"/>.</param>
        /// <param name="strict">If <see langword ="true"/>, validates the ranges of all parameters to ensure only real dates.</param>
        public DateTimeIso8601(int year, int? month, int? day, int? hour, int? minute, int? second, int? ms, int? osHour, int? osMinute, bool strict = false) :
            this(null,
                year, month, day, hour, minute, second, ms, osHour, NormalizeOffsetMinute(osHour, osMinute), strict)
        {
            _stringPrecision = DateTimePrecision.Millisecond;
        }

        /// <summary>
        /// Creates a new instance, initializing fields from the values specified in <paramref name="dto"/>
        /// up to and including <paramref name="precision"/>, leaving all others <see langword="null"/>.
        /// </summary>
        /// <param name="dto">The date time represented by a <see cref="DateTimeOffset"/>.</param>
        /// <param name="precision">The desired precision for this ISO date time.</param>
        /// <param name="strict">If <see langword ="true"/>, validates the ranges of all parameters to ensure only real date times.</param>
        public DateTimeIso8601(DateTimeOffset dto, DateTimePrecision precision, bool strict = false) :
            this(null,
                dto.Year, dto.Month, dto.Day, dto.Hour, dto.Minute, dto.Second, dto.Millisecond, dto.Offset.Hours, NormalizeOffsetMinute(dto.Offset.Hours, dto.Offset.Minutes), strict, precision)
        {
            _stringPrecision = precision;
        }

        /// <summary>
        /// Creates a new instance, initializing fields from the values specified in <paramref name="date"/>
        /// and <paramref name="time"/>.
        /// </summary>
        /// <param name="date">The date portion of the date time represented by a <see cref="DateIso8601"/>.</param>
        /// <param name="time">The time portion represented by a <see cref="TimeIso8601"/>.</param>
        /// <param name="strict">If <see langword ="true"/>, validates the ranges of all parameters to ensure only real date times.</param>
        public DateTimeIso8601(DateIso8601 date, TimeIso8601? time = null, bool strict = false) :
            this(date.Year, date.Month, date.Day, time?.Hour, time?.Minute, time?.Second, time?.Millisecond, time?.OffsetHour, time?.OffsetMinute, strict)
        {
            // _stringPrecision is set to Millisecond by the constructor chained to above, which is
            // the precision the eager implementation formatted this overload at.
        }

        internal DateTimeIso8601(string? @string, int year, int? month, int? day, int? hour, int? minute, int? second, int? ms, int? osHour, int? osMinute,
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
                        if (hour.HasValue)
                        {
                            if (hour.Value < 0 || hour.Value > 23)
                                throw new ArgumentException("Hour must between [0,23]", nameof(hour));
                            if (minute.HasValue)
                            {
                                if (minute.Value < 0 || minute.Value > 59)
                                    throw new ArgumentException("Minute must between [0,59]", nameof(minute));

                                if (second.HasValue)
                                {
                                    if (second.Value < 0 || second.Value > 59)
                                        throw new ArgumentException("Second must between [0,59]", nameof(second));
                                    if (ms.HasValue)
                                    {
                                        if (ms.Value < 0 || ms.Value > 999)
                                            throw new ArgumentException("Millsecond must between [0,999]", nameof(ms));
                                        Precision = DateTimePrecision.Millisecond;
                                    }
                                    else
                                        Precision = DateTimePrecision.Second;

                                }
                                else if (ms.HasValue)
                                    throw new ArgumentException("If second is not specified, then all following values must also not be specified.", nameof(day));
                                else
                                    Precision = DateTimePrecision.Minute;

                            }
                            else if (second.HasValue || ms.HasValue)
                                throw new ArgumentException("If minute is not specified, then all following values must also not be specified.", nameof(day));
                            else
                                Precision = DateTimePrecision.Hour;

                            if (osHour.HasValue)
                            {
                                if (osHour.Value < -14 || osHour.Value > 14)
                                    throw new ArgumentException("Offset hours must between [-14,14]", nameof(osHour));
                                if (osMinute.HasValue)
                                {
                                    var abs = Math.Abs(osMinute.Value);
                                    if (abs > 59)
                                        throw new ArgumentException("Offset minutes must between [-59,59]", nameof(osMinute));
                                }
                            }
                            else if (osMinute.HasValue)
                                throw new ArgumentException("If offset hour is not specified, then all following values must also not be specified.", nameof(day));
                        }
                        else if (minute.HasValue || second.HasValue || ms.HasValue)
                            throw new ArgumentException("If hour is not specified, then all following values must also not be specified.", nameof(day));
                        else
                            Precision = DateTimePrecision.Day;

                    }
                    else if (hour.HasValue || minute.HasValue || second.HasValue || ms.HasValue || osHour.HasValue || osMinute.HasValue)
                        throw new ArgumentException("If day is not specified, then all following values must also not be specified.", nameof(day));
                    else
                        Precision = DateTimePrecision.Month;

                }
                else if (day.HasValue || hour.HasValue || minute.HasValue || second.HasValue || ms.HasValue || osHour.HasValue || osMinute.HasValue)
                    throw new ArgumentException("If month is not specified, then all following values must also not be specified.", nameof(day));
                else
                    Precision = DateTimePrecision.Year;

            }
            else if (precision == DateTimePrecision.Unknown)
            {
                if (ms.HasValue)
                    Precision = DateTimePrecision.Millisecond;
                else if (second.HasValue)
                    Precision = DateTimePrecision.Second;
                else if (minute.HasValue)
                    Precision = DateTimePrecision.Minute;
                else if (hour.HasValue)
                    Precision = DateTimePrecision.Hour;
                else if (day.HasValue)
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
                        if (Precision > DateTimePrecision.Day)
                        {
                            Hour = hour;
                            if (Precision > DateTimePrecision.Hour)
                            {
                                Minute = minute;
                                if (Precision > DateTimePrecision.Minute)
                                {
                                    Second = second;
                                    if (Precision > DateTimePrecision.Second)
                                    {
                                        Millisecond = ms;
                                    }
                                }
                            }
                            // set the timezone if time precision is desired
                            OffsetHour = osHour;
                            osMinute = NormalizeOffsetMinute(osHour, osMinute);
                            OffsetMinute = osMinute;

                        }
                    }
                }
            }
            else throw new ArgumentException("Unknown precision is not supported", nameof(precision));

            var offset = new TimeSpan(OffsetHour ?? 0, OffsetMinute ?? 0, 0);
            DateTimeOffset = new DateTimeOffset(Year,
                Month ?? 1,
                Day ?? 1,
                Hour ?? 0,
                Minute ?? 0,
                Second ?? 0,
                Millisecond ?? 0,
                new TimeSpan(OffsetHour ?? 0, OffsetMinute ?? 0, 0));
            DateTimeOffsetUtc = DateTimeOffset.ToUniversalTime();
            if (OffsetHour != null)
                RationalOffset = (decimal)offset.TotalHours;
            _string = @string;
        }

        private static int? NormalizeOffsetMinute(int? offsetHour, int? offsetMinute) =>
            (offsetHour, offsetMinute) switch
            {
                (< 0, > 0) => -offsetMinute,
                (> 0, < 0) => -offsetMinute,
                _ => offsetMinute
            };

        public override string ToString() => String;
        public override bool Equals(object? obj) => Equals(String, obj?.ToString());
        public override int GetHashCode() => String.GetHashCode();

        internal static DateTimeIso8601 Parse(string stringValue)
        {
            if (TryParse(stringValue, out var dateTime))
                return dateTime!;
            else throw new ArgumentException($"Unable to parse value {stringValue} as an ISO 8601 datetime");
        }

        /// <summary>
        /// Tries to parse <paramref name="stringValue"/> as an ISO 8601 date time.
        /// </summary>
        /// <param name="stringValue">The string to parse</param>
        /// <param name="dateTimeValue">The parsed result, or <see langword ="null"/> if unparseable.</param>
        /// <returns><see langword ="true"/> if the string is a valid ISO 8601 date and parsing is successful; otherwise <see langword ="false"/>.</returns>

        public static bool TryParse(string stringValue, out DateTimeIso8601? dateTimeValue)
        {
            var parts = Expression.Match(stringValue);
            if (!parts.Success || parts.Captures.Count != 1 || parts.Captures[0].Length != stringValue.Length)
            {
                dateTimeValue = null;
                return false;
            }


            int? year, month = null, day = null, hour = null, minute = null, second = null, ms = null, osMinute = null;
            int? osHour = null;

            var timezone = parts.Groups["timezone"];
            var tzh = parts.Groups["tzhour"];
            var tzm = parts.Groups["tzminute"];
            if (timezone.Success)
            {
                if (string.Equals(timezone.Value, "Z", StringComparison.OrdinalIgnoreCase))
                {
                    osHour = 0;
                    osMinute = 0;
                }
                else
                {
                    if (tzh.Success)
                    {
                        int hourValue = int.Parse(tzh.Value, CultureInfo.InvariantCulture);
                        if (timezone.Value[0] == '-')
                            osHour = -hourValue;
                        else osHour = hourValue;
                    }

                    if (tzm.Success)
                    {
                        var minuteValue = int.Parse(tzm.Value, CultureInfo.InvariantCulture);
                        // Carry the sign on the minutes as well; for offsets like -00:30 the hour
                        // component is zero and cannot hold it.
                        osMinute = timezone.Value[0] == '-' ? -minuteValue : minuteValue;
                    }
                }
            }

            var yearGroup = parts.Groups["year"];
            var monthGroup = parts.Groups["month"];
            var dayGroup = parts.Groups["day"];

            // Default year is 0001-01-01:00:00:00.000, so subtract 1 from year/day/month
            // but not from hour/min/sec/ms
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
            else
            {
                dateTimeValue = null;
                return false;
            }

            var hourGroup = parts.Groups["hour"];
            var minuteGroup = parts.Groups["minute"];
            var secondGroup = parts.Groups["second"];
            var millisecondGroup = parts.Groups["ms"];
            if (hourGroup.Success)
            {
                hour = int.Parse(hourGroup.Value, CultureInfo.InvariantCulture);
                if (minuteGroup.Success)
                {
                    minute = int.Parse(minuteGroup.Value, CultureInfo.InvariantCulture);
                    if (secondGroup.Success)
                    {
                        second = int.Parse(secondGroup.Value, CultureInfo.InvariantCulture);
                        if (millisecondGroup.Success)
                        {
                            ms = int.Parse(millisecondGroup.Value, CultureInfo.InvariantCulture);
                            if (millisecondGroup.Value.Length == 1)
                                ms *= 100;
                            else if (millisecondGroup.Value.Length == 2)
                                ms *= 10;
                        }
                    }
                }
            }

            dateTimeValue = new DateTimeIso8601(stringValue, year!.Value, month, day, hour, minute, second, ms, osHour, osMinute);
            return true;
        }

        private static string Format(int year, int? month, int? day, int? hour, int? minute, int? second, int? ms, int? osHour, int? osMinute, DateTimePrecision precision)
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
                    if (hour.HasValue && precision > DateTimePrecision.Day)
                    {
                        sb.Append('T');
                        sb.Append(hour.Value.ToString("D2", CultureInfo.InvariantCulture));
                        if (minute.HasValue && precision > DateTimePrecision.Hour)
                        {
                            sb.Append(':');
                            sb.Append(minute.Value.ToString("D2", CultureInfo.InvariantCulture));
                            if (second.HasValue && precision > DateTimePrecision.Minute)
                            {
                                sb.Append(':');
                                sb.Append(second.Value.ToString("D2", CultureInfo.InvariantCulture));
                                if (ms.HasValue && precision > DateTimePrecision.Second)
                                {
                                    sb.Append('.');
                                    sb.Append(ms.Value.ToString("D3", CultureInfo.InvariantCulture));
                                }
                            }
                        }
                        if (osHour.HasValue)
                            sb.Append(FormatKnownOffset(osHour.Value, osMinute ?? 0));
                    }
                }
            }
            return sb.ToString();
        }

        /// <summary>
        /// Formats a known (non-null) timezone offset as an ISO 8601 offset string, rendering a
        /// zero offset as <c>Z</c> and a non-zero offset as <c>±hh:mm</c>. Either component can
        /// carry the sign; the offset is signed as a whole.
        /// </summary>
        internal static string FormatKnownOffset(int offsetHour, int offsetMinute)
        {
            if (offsetHour == 0 && offsetMinute == 0)
                return "Z";
            return FormattableString.Invariant(
                $"{(offsetHour < 0 || offsetMinute < 0 ? '-' : '+')}{Math.Abs(offsetHour):D2}:{Math.Abs(offsetMinute):D2}");
        }

    }
}

/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Hl7.Cql.Iso8601
{
    /// <summary>
    /// Represents a time according to ISO 8601, with components isolated and with supplied precision level retained.
    /// </summary>
    public class TimeIso8601
    {
        // Note: integer types used here because C# promotes smaller types to 4 byte ints for all math.
        // That conversion ad nauseum is more expensive than superfluous memory use.

        /// <summary>
        /// Gets the hour component of this date time.
        /// </summary>
        public int Hour { get; }
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
        /// Gets the precision of this time.
        /// </summary>
        public DateTimePrecision Precision { get; }

        /// <summary>
        /// Gets this time represented as a <see cref="TimeSpan"/>.
        /// </summary>
        public TimeSpan TimeSpan { get; }
        /// <summary>
        /// Gets this time's offset represented as a <see cref="TimeSpan"/>.
        /// </summary>
        public TimeSpan Offset { get; }

        /// <summary>
        /// Gets this time represented as a <see cref="DateTimeOffset"/>.
        /// This value is the result of adding <see cref="TimeSpan"/> to <see cref="BaseDateTime"/>.        
        /// </summary>
        /// <remarks>
        /// <para>
        /// The rationale for using <see cref="BaseDateTime"/> instead of <see cref="DateTimeOffset.MinValue"/> (<langword cref="default"/>) is that
        /// underflow exceptions would be thrown by subtracting quantities from this time.
        /// </para>
        /// <para>
        /// <see cref="BaseDateTime"/> is expressed in local time.
        /// </para>
        /// <para>
        /// If this value isn't useful, you can produce a new offset value by adding <see cref="TimeSpan"/> to the date of your choice.
        /// </para>
        /// </remarks>
        public DateTimeOffset DateTimeOffset { get; }

        /// <summary>
        /// Gets this time represented as a <see cref="DateTimeOffset"/ in UTC.
        /// </summary>
        /// <remarks>
        /// This value is produced by converting <see cref="DateTimeOffset"/> to UTC, which is different than
        /// expressing <see cref="BaseDateTime"/> as UTC (rather than converting from) and then adding <see cref="TimeSpan"/>.
        /// For example, if <see cref="DateTimeOffset"/> is 08:00:00 EDT, then this value will be 13:00:00 UTC.
        /// </remarks>
        /// <seealso cref="DateTimeOffset"/>
        public DateTimeOffset DateTimeOffsetUtc { get; set; }

        /// <summary>
        /// Gets the base date to which <see cref="TimeSpan"/> is added to produce <see cref="DateTimeOffset"/> and <see cref="DateTimeOffsetUtc"/>/
        /// <para>
        /// This value is 1000-01-01T00:00:00.000 in offset time (as specified in <see cref="Offset"/>.
        /// </para>
        /// </summary>
        public DateTimeOffset BaseDateTime { get; }

        private readonly string String;

        /// <summary>
        /// The regular expression used to parse ISO 8601 date times.
        /// </summary>
        public static readonly Regex Expression = new(@"T?(?'hour'\d\d)?(:(?'minute'\d\d)?(:(?'second'\d\d)(\.(?'ms'\d{1,3}))?)?)?(?'timezone'([\+\-]?(?'tzhour'\d\d)(:(?'tzminute'\d\d))?)|Z)?", RegexOptions.Compiled);

        /// <summary>
        /// Creates an instance.
        /// </summary>
        /// <param name="hour">The hour component of the time</param>
        /// <param name="minute">The minute component of the time, or <see langword ="null"/>.</param>
        /// <param name="second">The second component of the time, or <see langword ="null"/>.</param>
        /// <param name="ms">The millisecond component of the time, or <see langword ="null"/>.</param>
        /// <param name="osHour">The hour component of the time, or <see langword ="null"/>.</param>
        /// <param name="osMinute">The minute component of the time, or <see langword ="null"/>.</param>
        /// <param name="strict">If <see langword ="true"/>, validates the ranges of all parameters to ensure only real dates.</param>
        public TimeIso8601(int hour, int? minute, int? second, int? ms, int? osHours, int? osMinutes, bool strict = false) :
            this(Format(hour, minute, second, ms, osHours, osMinutes, DateTimePrecision.Millisecond),
               hour, minute, second, ms, osHours, osMinutes, strict)
        {
        }

        /// <summary>
        /// Creates a new instance, initializing fields from the values specified in <paramref name="span"/>
        /// up to and including <paramref name="precision"/>, leaving all others <see langword="null"/>.
        /// </summary>
        /// <param name="span">The span to represent in ISO 8601.</param>
        /// <param name="offsetHours">The timezone offset in hours, or <see langword="null"/>.</param>
        /// <param name="offsetMinutes">The timezone offset in minutes, or <see langword="null"/>.</param>
        /// <param name="precision">The desired precision for this ISO time.</param>
        /// <param name="strict">If <see langword ="true"/>, validates the ranges of all parameters to ensure only real date times.</param>
        public TimeIso8601(TimeSpan span, int? offsetHours, int? offsetMinutes, DateTimePrecision precision, bool strict = false) :
            this(Format(span.Hours, span.Minutes, span.Seconds, span.Milliseconds,
                offsetHours,
                offsetMinutes,
                precision),
                span.Hours, span.Minutes, span.Seconds, span.Milliseconds, offsetHours, offsetMinutes, strict, precision)
        {
        }

        internal TimeIso8601(string @string, int hour, int? minute, int? second, int? ms, int? osHour, int? osMinute,
            bool strict = false, DateTimePrecision precision = DateTimePrecision.Unknown)
        {
            if (strict)
            {
                if (hour < 0 || hour > 23)
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
                        throw new ArgumentException("If second is not specified, then all following values must also not be specified.", nameof(ms));
                    else
                        Precision = DateTimePrecision.Minute;

                }
                else if (second.HasValue || ms.HasValue)
                    throw new ArgumentException("If minute is not specified, then all following values must also not be specified.", nameof(second));
                else
                    Precision = DateTimePrecision.Hour;
                if (osHour.HasValue)
                {
                    if (osHour.Value < -14 || osHour.Value > 14)
                        throw new ArgumentException("Offset hours must between [-14,14]", nameof(osHour));
                    if (osMinute.HasValue)
                    {
                        if (osMinute.Value < 0 || osMinute.Value > 59)
                            throw new ArgumentException("Offset minutes must between [0,59]", nameof(osMinute));
                    }
                }
                else if (osMinute.HasValue)
                    throw new ArgumentException("If offset hour is not specified, then all following values must also not be specified.", nameof(minute));

            }
            else if (precision == DateTimePrecision.Unknown)
            {
                if (ms.HasValue)
                    Precision = DateTimePrecision.Millisecond;
                else if (second.HasValue)
                    Precision = DateTimePrecision.Second;
                else if (minute.HasValue)
                    Precision = DateTimePrecision.Minute;
                else
                    Precision = DateTimePrecision.Hour;
            }
            else
            {
                Precision = precision;
            }
            if (Precision > DateTimePrecision.Unknown)
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
            }
            else throw new ArgumentException("Unknown precision is not supported", nameof(precision));

            TimeSpan = new TimeSpan(days: 0,
                hours: hour,
                minutes: minute ?? 0,
                seconds: second ?? 0,
                milliseconds: ms ?? 0);
            OffsetHour = osHour;
            OffsetMinute = osMinute;
            Offset = new TimeSpan(OffsetHour ?? 0, OffsetMinute ?? 0, 0);

            if (OffsetHour != null)
                RationalOffset = (decimal)Offset.TotalHours;
            BaseDateTime = new DateTimeOffset(1000, 1, 1, 0, 0, 0, Offset);

            DateTimeOffset = BaseDateTime.Add(TimeSpan);
            DateTimeOffsetUtc = DateTimeOffset.ToUniversalTime();

            String = @string;
        }

        public override string ToString() => String;
        public override bool Equals(object obj) => Equals(String, obj?.ToString());
        public override int GetHashCode() => String.GetHashCode();

        /// <summary>
        /// Tries to parse <paramref name="stringValue"/> as an ISO 8601 time.
        /// </summary>
        /// <param name="stringValue">The string to parse</param>
        /// <param name="dateTimeValue">The parsed result, or <see langword ="null"/> if unparseable.</param>
        /// <returns><see langword ="true"/> if the string is a valid ISO 8601 time and parsing is successful; otherwise <see langword ="false"/>.</returns>
        public static bool TryParse(string stringValue, out TimeIso8601? timeValue)
        {
            var parts = Expression.Match(stringValue);
            if (!parts.Success || parts.Captures.Count != 1 || parts.Captures[0].Length != stringValue.Length)
            {
                timeValue = null;
                return false;
            }
            else
            {
                timeValue = stringValue;
                return true;
            }

        }

        /// <summary>
        /// Converts a string to an ISO 8601 time, or throws.
        /// </summary>
        /// <param name="stringValue">The string to convert.</param>
        /// <exception cref="ArgumentException">When <paramref name="stringValue"/> cannot be parsed.</exception>
        public static implicit operator TimeIso8601(string stringValue)
        {
            var parts = Expression.Match(stringValue);
            if (!parts.Success || parts.Captures.Count != 1 || parts.Captures[0].Length != stringValue.Length)
                throw new ArgumentException($"Invalid ISO 8601 date time: {stringValue}", nameof(stringValue));


            int hour;
            int? minute = null, second = null, ms = null, osHour = null, osMinute = null;

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
                        int hourValue = int.Parse(tzh.Value);
                        if (timezone.Value[0] == '-')
                            osHour = -hourValue;
                        else osHour = hourValue;
                    }

                    if (tzm.Success)
                        osMinute = int.Parse(tzm.Value);
                }
            }

            var hourGroup = parts.Groups["hour"];
            var minuteGroup = parts.Groups["minute"];
            var secondGroup = parts.Groups["second"];
            var millisecondGroup = parts.Groups["ms"];
            if (hourGroup.Success)
            {
                hour = int.Parse(hourGroup.Value);
                if (minuteGroup.Success)
                {
                    minute = int.Parse(minuteGroup.Value);
                    if (secondGroup.Success)
                    {
                        second = int.Parse(secondGroup.Value);
                        if (millisecondGroup.Success)
                        {
                            ms = int.Parse(millisecondGroup.Value);
                            if (millisecondGroup.Value.Length == 1)
                                ms *= 100;
                            else if (millisecondGroup.Value.Length == 2)
                                ms *= 10;
                        }
                    }
                }
            }
            else throw new ArgumentException("At least hour must be specified", nameof(stringValue));
            var isoTime = new TimeIso8601(hour, minute, second, ms, osHour, osMinute);
            return isoTime;
        }

        private static string Format(int hour, int? minute, int? second, int? ms, int? osHour, int? osMinute, DateTimePrecision precision)
        {
            var sb = new StringBuilder();
            sb.Append(hour.ToString("D2"));
            if (minute.HasValue && precision > DateTimePrecision.Hour)
            {
                sb.Append(':');
                sb.Append(minute.Value.ToString("D2"));
                if (second.HasValue && precision > DateTimePrecision.Minute)
                {
                    sb.Append(':');
                    sb.Append(second.Value.ToString("D2"));
                    if (ms.HasValue && precision > DateTimePrecision.Second)
                    {
                        sb.Append('.');
                        sb.Append(ms.Value.ToString("D3"));
                    }
                }
            }
            if (osHour.HasValue)
            {
                if (osHour == 0 && osMinute == 0)
                    sb.Append('Z');
                else
                {
                    if (osHour > 0)
                        sb.Append('+');
                    sb.Append(osHour.Value.ToString("D2"));
                    sb.Append(':');
                    sb.Append((osMinute ?? 0).ToString("D2"));
                }
            }
            return sb.ToString();
        }

    }
}

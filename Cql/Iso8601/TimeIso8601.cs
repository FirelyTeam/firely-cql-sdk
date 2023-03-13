using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Ncqa.Iso8601
{
    public class TimeIso8601
    {

        // Note: integer types used here because C# promotes smaller types to 4 byte ints for all math.
        // That conversion ad nauseum is more expensive than superfluous memory use.

        public int Hour { get; }
        public int? Minute { get; }
        public int? Second { get; }
        public int? Millisecond { get; }
        public int? OffsetHour { get; }
        public int? OffsetMinute { get; }
        public decimal? RationalOffset { get; }

        public DateTimePrecision Precision { get; }

        public TimeSpan TimeSpan { get; }
        public TimeSpan Offset { get; }

        /// <summary>
        /// This value is the result of adding <see cref="TimeSpan"/> to 1000-01-01:00:00:00.
        /// This date is picked to allow times in both negative and positive offsets to be represented.
        /// This is a convenience for algorithms (e.g., difference, duration) that use DateTimeOffsets.
        /// </summary>
        public DateTimeOffset DateTimeOffset { get; }
        public DateTimeOffset DateTimeOffsetUtc { get; }

        private readonly string String;

        public static readonly Regex Expression = new Regex(@"T?(?'hour'\d\d)?(:(?'minute'\d\d)?(:(?'second'\d\d)(\.(?'ms'\d{1,3}))?)?)?(?'timezone'([\+\-]?(?'tzhour'\d\d)(:(?'tzminute'\d\d))?)|Z)?", RegexOptions.Compiled);

        public TimeIso8601(int hour, int? minute, int? second, int? ms, int? osHours, int? osMinutes, bool strict = false) :
            this(Format(hour, minute, second, ms, osHours, osMinutes, DateTimePrecision.Millisecond),
               hour, minute, second, ms, osHours, osMinutes, strict)
        {
        }

        /// <summary>
        /// Creates a new instance, initializing fields from the values specified in <paramref name="span"/>
        /// up to and including <paramref name="precision"/>, leaving all others <see langword="null"/>.
        /// </summary>
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

            DateTimeOffset = new DateTimeOffset(1000, 1, 1, 0, 0, 0, Offset)
                .Add(TimeSpan);
            DateTimeOffsetUtc = DateTimeOffset.ToUniversalTime();

            String = @string;
        }

        public TimeIso8601 InPrecision(DateTimePrecision precision) => new TimeIso8601(TimeSpan, OffsetHour, OffsetMinute, precision);

        public override string ToString() => String;
        public override bool Equals(object obj) => Equals(String, obj?.ToString());
        public override int GetHashCode() => String.GetHashCode();

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

/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using Hl7.Cql.Iso8601;

namespace Hl7.Cql.Primitives
{
    internal static class CqlDateTimeMath
    {
        public const int DaysPerWeek = 7;
        public const double DaysPerWeekDouble = 7.0d;

        // The conversions below are the ones the "Equivalent" section of "Comparison Operators"
        // (CQL Appendix B – Reference) lists after: "calendar-time duration unit conversions shall be
        // performed according to calendar duration semantics:", each quoted on its constant.

        /// <summary>The number of months in a calendar year: "1 year ~ 12 months".</summary>
        public const int MonthsPerYear = 12;

        /// <summary>The number of days in a calendar year: "1 year ~ 365 days".</summary>
        public const int DaysPerYear = 365;

        /// <summary>The number of days in a calendar month: "1 month ~ 30 days".</summary>
        public const int DaysPerMonth = 30;

        /// <summary>The number of hours in a day: "1 day = 24 hours".</summary>
        public const int HoursPerDay = 24;

        /// <summary>The number of minutes in an hour: "1 hour = 60 minutes".</summary>
        public const int MinutesPerHour = 60;

        /// <summary>The number of seconds in a minute: "1 minute = 60 seconds".</summary>
        public const int SecondsPerMinute = 60;

        /// <summary>The number of milliseconds in a second: "1 second = 1000 milliseconds".</summary>
        public const int MillisecondsPerSecond = 1000;

        private const long MillisecondsPerMinute = (long)SecondsPerMinute * MillisecondsPerSecond;
        private const long MillisecondsPerHour = MinutesPerHour * MillisecondsPerMinute;
        private const long MillisecondsPerDay = HoursPerDay * MillisecondsPerHour;


        /// <summary>
        /// Returns the number of boundaries crossed for the specified precision between this and the argument.
        /// If this is after the second argument, the result is negative.
        /// The result of this operation is always an integer; any fractional boundaries are dropped.
        /// </summary>
        /// <remarks>
        /// This method is primarily used by the "difference betweeen" operator, which counts boundaries crossed.
        /// </remarks>
        /// <seealso href="https://cql.hl7.org/09-b-cqlreference.html#difference"/>
        internal static int? BoundariesBetween(DateTimeOffset? low, DateTimeOffset? high, string? precision)
        {
            if (low is not {} firstDto || high is not {} secondDto || precision is null)
                return null;

            switch (precision)
            {
                // https://cql.hl7.org/09-b-cqlreference.html#difference
                // UCUM units not supported here

                case "year":
                    var yearDiff = (secondDto.Year - firstDto.Year);
                    return yearDiff;

                case "month":
                    var monthDiff = (12 * (secondDto.Year - firstDto.Year) + secondDto.Month - firstDto.Month);
                    return monthDiff;

                case "week":
                    {
                        var span = secondDto.Subtract(firstDto);
                        var weeks = span.TotalDays / 7d;
                        var asInt = (int)weeks;
                        var decimalPortion = weeks - asInt;
                        var dayOfWeekAsInt = (int)firstDto.DayOfWeek + (decimalPortion * 7d);
                        if (dayOfWeekAsInt > 6) // if the partial week rolls over Sunday, add 1
                            return asInt + 1;
                        else return asInt;
                    }

                case "day":
                    {
                        var span = secondDto.Subtract(firstDto);
                        var asInt = (int)span.TotalDays;
                        var decimalPortion = span.TotalDays - asInt;
                        var possiblyNextDay = firstDto.AddDays(decimalPortion);
                        if (possiblyNextDay.Day != firstDto.Day)
                        {
                            return asInt + 1;
                        }
                        else return asInt;
                    }

                case "hour":
                    {
                        var span = secondDto.Subtract(firstDto);
                        var asInt = (int)span.TotalHours;
                        var decimalPortion = span.TotalHours - asInt;
                        var possiblyNextHour = firstDto.AddHours(decimalPortion);
                        if (possiblyNextHour.Hour != firstDto.Hour)
                        {
                            return asInt + 1;
                        }
                        else return asInt;
                    }

                case "minute":
                    {
                        var span = secondDto.Subtract(firstDto);
                        var asInt = (int)span.TotalMinutes;
                        var decimalPortion = span.TotalMinutes - asInt;
                        var possiblyNextMinute = firstDto.AddMinutes(decimalPortion);
                        if (possiblyNextMinute.Minute != firstDto.Minute)
                        {
                            return asInt + 1;
                        }
                        else return asInt;
                    }

                case "second":
                    {
                        var span = secondDto.Subtract(firstDto);
                        var asInt = (int)span.TotalSeconds;
                        var decimalPortion = span.TotalSeconds - asInt;
                        var possiblyNextSecond = firstDto.AddSeconds(decimalPortion);
                        if (possiblyNextSecond.Second != firstDto.Second)
                        {
                            return asInt + 1;
                        }
                        else return asInt;
                    }

                case "millisecond":
                    {
                        var span = secondDto.Subtract(firstDto);
                        var asInt = (int)span.TotalMilliseconds;
                        var decimalPortion = span.TotalMilliseconds - asInt;
                        var possiblyNextSecond = firstDto.AddMilliseconds(decimalPortion);
                        if (possiblyNextSecond.Millisecond != firstDto.Millisecond)
                        {
                            return asInt + 1;
                        }
                        else return asInt;
                    }

                default: throw new ArgumentException($"Unit '{precision}' is not supported.");
            }
        }

        internal static int? WholeCalendarPeriodsBetween(DateTimeOffset? low, DateTimeOffset? high, string? precision)
        {
            if (low is not {} firstDto || high is not {} secondDto  || precision == null)
                return null;

            var calendar = new GregorianCalendar();
            switch (precision)
            {
                // https://cql.hl7.org/09-b-cqlreference.html#difference
                // UCUM units not supported here

                case "year":
                    var yearDiff = secondDto.Year - firstDto.Year;
                    var firstDayInYear = firstDto.DayOfYear;
                    var secondDayInYear = secondDto.DayOfYear;

                    var firstIsLeapDay = calendar.IsLeapDay(firstDto.Year, firstDto.Month, firstDto.Day);
                    var secondIsLeapDay = calendar.IsLeapDay(secondDto.Year, secondDto.Month, secondDto.Day);

                    // born on leap day
                    if (firstIsLeapDay)
                    {
                        if (DateTime.IsLeapYear(secondDto.Year))
                        {
                            // born 2-29-2020
                            // age as of 2-28-2024 = 3
                            // day is before 2/29
                            if (secondDto.DayOfYear < 60)
                                return yearDiff - 1;

                            // equals or is after
                            return yearDiff;
                        }

                        // In a year without a leap day the anniversary of 29 February is 28 February, the year's 59th day,
                        // which is also where adding a year to the leap day lands. On the anniversary date itself the
                        // year is whole once the start's time of day has been reached.
                        // born 2-29-2020
                        // age as of 2-28-2025 = 5
                        if (secondDayInYear > 59)
                            return yearDiff;
                        if (secondDayInYear == 59 && (yearDiff < 0 || secondDto.TimeOfDay >= firstDto.TimeOfDay))
                            return yearDiff;

                        return yearDiff - 1;
                    }

                    // born on 3/1/2015
                    // as of 2/29/2024
                    if (secondIsLeapDay)
                    {
                        if (DateTime.IsLeapYear(firstDto.Year))
                        {
                            // first date is leap year (not leap day)
                            // first date is not leap day per the logic but if after leap day then year-1
                            if (firstDto.DayOfYear > 59)
                                return yearDiff - 1;

                            return yearDiff;
                        }

                        if (firstDayInYear < 60)
                            return yearDiff;

                        return yearDiff - 1;
                    }

                    // In 2020 (leap year), 2-29 is day 60 and 3-1 is day 61.
                    // In 2021 (non-leap )year, 3-1 is day 60.
                    // Subtract 2-29 out of the equation for leap years
                    // for leap years, this normalizes 3-1 from being day 61 back to day 60.
                    if (DateTime.IsLeapYear(firstDto.Year) && firstDayInYear > 60)
                        firstDayInYear -= 1;
                    if (DateTime.IsLeapYear(secondDto.Year) && secondDayInYear > 60)
                        secondDayInYear -= 1;

                    if (yearDiff > 0 && secondDayInYear < firstDayInYear)
                        yearDiff -= 1;
                    else if (yearDiff < 0 && firstDayInYear < secondDayInYear)
                        yearDiff += 1;
                    return yearDiff;

                case "month":
                    var monthDiff = (12 * (secondDto.Year - firstDto.Year) + secondDto.Month - firstDto.Month);
                    if (monthDiff > 0 && secondDto.Day < firstDto.Day)
                        monthDiff -= 1;
                    else if (monthDiff < 0 && firstDto.Day < secondDto.Day)
                        monthDiff += 1;
                    return monthDiff;

                case "week":        return (int)(secondDto.Subtract(firstDto).TotalDays / DaysPerWeekDouble);
                case "day":
                                    return (int)secondDto.Subtract(firstDto).TotalDays;
                case "hour":        return (int)secondDto.Subtract(firstDto).TotalHours;
                case "minute":      return (int)secondDto.Subtract(firstDto).TotalMinutes;
                case "second":      return (int)secondDto.Subtract(firstDto).TotalSeconds;
                case "millisecond": return (int)secondDto.Subtract(firstDto).TotalMilliseconds;
                default:            throw new ArgumentException($"Unit '{precision}' is not supported.");
            }
        }

        internal static readonly IDictionary<DateTimePrecision, CqlQuantity> UnitDateTimeQuantity = new Dictionary<DateTimePrecision, CqlQuantity>
        {
            { DateTimePrecision.Day, new CqlQuantity(1m, "day") },
            { DateTimePrecision.Hour, new CqlQuantity(1m, "hour") },
            { DateTimePrecision.Millisecond, new CqlQuantity(1m, "millisecond") },
            { DateTimePrecision.Minute, new CqlQuantity(1m, "minute") },
            { DateTimePrecision.Month, new CqlQuantity(1m, "month") },
            { DateTimePrecision.Second, new CqlQuantity(1m, "second") },
            { DateTimePrecision.Year, new CqlQuantity(1m, "year") },
        };

        /// <summary>
        /// Converts a time-valued quantity that is more precise than <paramref name="precision"/> to the unit of
        /// <paramref name="precision"/>, truncating any resulting decimal portion toward zero.
        /// A quantity at or above <paramref name="precision"/> is returned unchanged.
        /// </summary>
        /// <remarks>
        /// The "Add" section of "Date and Time Operators" (CQL Appendix B – Reference) states:
        /// "For partial date/time values where the time-valued quantity is more precise than the partial date/time,
        /// the operation is performed by converting the time-based quantity to the most precise value specified in
        /// first argument (truncating any resulting decimal portion) and then adding it to the first argument."
        /// The "Subtract" section of the same chapter states the same rule for subtraction.
        /// <para>
        /// A conversion through more than one unit composes the calendar duration conversions: months convert to
        /// years by <see cref="MonthsPerYear"/>; weeks and finer units convert through days, and from days to years
        /// and months by <see cref="DaysPerYear"/> and <see cref="DaysPerMonth"/>.
        /// </para>
        /// </remarks>
        /// <param name="value">The quantity value.</param>
        /// <param name="unit">The quantity unit.</param>
        /// <param name="precision">The precision of the date or date time the quantity is applied to.</param>
        /// <param name="finestSupportedUnit">
        /// The finest unit the caller supports. A quantity in a finer unit, or in a unit that is not a calendar
        /// duration finer than a year, is returned unchanged so that the caller can reject it.
        /// </param>
        /// <returns>The value and unit to apply.</returns>
        internal static (decimal Value, string Unit) ConvertToPrecision(
            decimal value,
            string unit,
            DateTimePrecision precision,
            DateTimePrecision finestSupportedUnit)
        {
            // A week is coarser than a day but finer than a month, so it compares as a day here.
            var (unitPrecision, unitMilliseconds) = unit switch
            {
                "month" or "months"                     => (DateTimePrecision.Month, 0L),
                "wk" or "week" or "weeks"               => (DateTimePrecision.Day, DaysPerWeek * MillisecondsPerDay),
                "d" or "day" or "days"                  => (DateTimePrecision.Day, MillisecondsPerDay),
                "h" or "hour" or "hours"                => (DateTimePrecision.Hour, MillisecondsPerHour),
                "min" or "minute" or "minutes"          => (DateTimePrecision.Minute, MillisecondsPerMinute),
                "s" or "second" or "seconds"            => (DateTimePrecision.Second, (long)MillisecondsPerSecond),
                "ms" or "millisecond" or "milliseconds" => (DateTimePrecision.Millisecond, 1L),
                _                                       => (DateTimePrecision.Unknown, 0L),
            };

            if (precision == DateTimePrecision.Unknown || unitPrecision <= precision || unitPrecision > finestSupportedUnit)
                return (value, unit);

            // Here precision is coarser than unitPrecision, which is at most Millisecond, so precision is at most Second.
            var (precisionUnit, precisionMilliseconds) = precision switch
            {
                DateTimePrecision.Year   => ("years", DaysPerYear * MillisecondsPerDay),
                DateTimePrecision.Month  => ("months", DaysPerMonth * MillisecondsPerDay),
                DateTimePrecision.Day    => ("days", MillisecondsPerDay),
                DateTimePrecision.Hour   => ("hours", MillisecondsPerHour),
                DateTimePrecision.Minute => ("minutes", MillisecondsPerMinute),
                _                        => ("seconds", (long)MillisecondsPerSecond),
            };

            // Months are only more precise than years.
            var converted = unitPrecision == DateTimePrecision.Month
                ? value / MonthsPerYear
                : value * unitMilliseconds / precisionMilliseconds;

            return (decimal.Truncate(converted), precisionUnit);
        }
    }
}

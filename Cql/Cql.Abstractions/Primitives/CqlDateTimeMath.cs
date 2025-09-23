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

                        // born 2-29-2020
                        // age as of 2-28-2025 = 5
                        // 59th day is Feb 28 so don't count as birthday
                        if (secondDayInYear > 59)
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
                case "day":         return (int)secondDto.Subtract(firstDto).TotalDays;
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

        // /// <summary>
        // /// For datetime addition and subtraction, when quantity is more precise than the datetime,
        // /// the quantity has to be normalized to the lesser precision and truncated.
        // /// </summary>
        // /// <see href="https://cql.hl7.org/09-b-cqlreference.html#add-1" />
        // internal static CqlQuantity NormalizeTo(this CqlQuantity quantity, DateTimePrecision target)
        // {
        //     // using the table found here:
        //     // https://cql.hl7.org/09-b-cqlreference.html#equivalent
        //     return (quantity.unit, target) switch
        //     {
        //         (null, _) => quantity,
        //         ("mo", DateTimePrecision.Year) =>
        //             new CqlQuantity(Math.Truncate((quantity.value ?? 0) / 12)!, UCUMUnits.Year),
        //
        //         ("d", DateTimePrecision.Year) =>
        //             new CqlQuantity(Math.Truncate((quantity.value ?? 0) / 365)!, UCUMUnits.Year),
        //         ("d", DateTimePrecision.Month) =>
        //             new CqlQuantity(Math.Truncate((quantity.value ?? 0) / 30)!, UCUMUnits.Month),
        //
        //         ("h", DateTimePrecision.Year) =>
        //             new CqlQuantity(Math.Truncate(((quantity.value ?? 0) / 24) / 365)!, UCUMUnits.Year),
        //         ("h", DateTimePrecision.Month) =>
        //             new CqlQuantity(Math.Truncate(((quantity.value ?? 0) / 24) / 30)!, UCUMUnits.Month),
        //         ("h", DateTimePrecision.Day) =>
        //             new CqlQuantity(Math.Truncate((quantity.value ?? 0) / 24)!, UCUMUnits.Day),
        //
        //         ("mi", DateTimePrecision.Year) =>
        //             new CqlQuantity(Math.Truncate((((quantity.value ?? 0) / 60) / 24) / 365)!, UCUMUnits.Year),
        //         ("mi", DateTimePrecision.Month) =>
        //             new CqlQuantity(Math.Truncate((((quantity.value ?? 0) / 60) / 24) / 30)!, UCUMUnits.Month),
        //         ("mi", DateTimePrecision.Day) =>
        //             new CqlQuantity(Math.Truncate(((quantity.value ?? 0) / 60) / 24)!, UCUMUnits.Day),
        //         ("mi", DateTimePrecision.Hour) =>
        //             new CqlQuantity(Math.Truncate((quantity.value ?? 0) / 60)!, UCUMUnits.Hour),
        //
        //         ("s", DateTimePrecision.Year) =>
        //             new CqlQuantity(Math.Truncate(((((quantity.value ?? 0) / 60) / 60) / 24) / 365)!, UCUMUnits.Year),
        //         ("s", DateTimePrecision.Month) =>
        //             new CqlQuantity(Math.Truncate(((((quantity.value ?? 0) / 60) / 60) / 24) / 30)!, UCUMUnits.Month),
        //         ("s", DateTimePrecision.Day) =>
        //             new CqlQuantity(Math.Truncate((((quantity.value ?? 0) / 60) / 60) / 24)!, UCUMUnits.Day),
        //         ("s", DateTimePrecision.Hour) =>
        //             new CqlQuantity(Math.Truncate(((quantity.value ?? 0) / 60) / 60)!, UCUMUnits.Hour),
        //         ("s", DateTimePrecision.Minute) =>
        //             new CqlQuantity(Math.Truncate((quantity.value ?? 0) / 60)!, UCUMUnits.Minute),
        //
        //         ("ms", DateTimePrecision.Year) =>
        //             new CqlQuantity(Math.Truncate((((((quantity.value ?? 0) / 1000) / 60) / 60) / 24) / 365)!, UCUMUnits.Year),
        //         ("ms", DateTimePrecision.Month) =>
        //             new CqlQuantity(Math.Truncate((((((quantity.value ?? 0) / 1000) / 60) / 60) / 24) / 30)!, UCUMUnits.Month),
        //         ("ms", DateTimePrecision.Day) =>
        //             new CqlQuantity(Math.Truncate(((((quantity.value ?? 0) / 1000) / 60) / 60) / 24)!, UCUMUnits.Day),
        //         ("ms", DateTimePrecision.Hour) =>
        //             new CqlQuantity(Math.Truncate((((quantity.value ?? 0) / 1000) / 60) / 60)!, UCUMUnits.Hour),
        //         ("ms", DateTimePrecision.Minute) =>
        //             new CqlQuantity(Math.Truncate(((quantity.value ?? 0) / 1000) / 60)!, UCUMUnits.Minute),
        //         ("ms", DateTimePrecision.Second) =>
        //             new CqlQuantity(Math.Truncate((quantity.value ?? 0) / 1000)!, UCUMUnits.Second),
        //         (_,_) => quantity
        //     };
        // }
    }
}

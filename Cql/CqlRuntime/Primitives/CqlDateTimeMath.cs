using Ncqa.Cql.Runtime.Conversion;
using Ncqa.Iso8601;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ncqa.Cql.Runtime.Primitives
{
    public static class CqlDateTimeMath
    {
        /// <summary>
        /// Returns the number of boundaries crossed for the specified precision between this and the argument.
        /// If this is after the second argument, the result is negative. 
        /// The result of this operation is always an integer; any fractional boundaries are dropped.
        /// </summary>
        /// <remarks>
        /// This method is primarily used by the "difference betweeen" operator, which counts boundaries crossed.
        /// </remarks>
        /// <seealso href="https://cql.hl7.org/09-b-cqlreference.html#difference"/>
        public static int? BoundariesBetween(DateTimeOffset? low, DateTimeOffset? high, string? precision)
        {
            if (low == null || high == null || precision == null)
                return null;
            if (Units.CqlUnitsToUCUM.TryGetValue(precision, out var converted))
                precision = converted;

            var firstDto = low.Value;
            var secondDto = high.Value;
            switch (precision)
            {
                case "a":
                    var yearDiff = (secondDto.Year - firstDto.Year);
                    return yearDiff;
                case "mo":
                    var monthDiff = (12 * (secondDto.Year - firstDto.Year) + secondDto.Month - firstDto.Month);
                    return monthDiff;
                case "wk":
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
                case "d":
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
                case "h":
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
                case "min":
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
                case "s":
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
                case "ms":
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
                default: throw new ArgumentException($"Unit {precision} is not supported");
            };
        }

        public static int? WholeCalendarPeriodsBetween(DateTimeOffset? low, DateTimeOffset? high, string precision)
        {
            if (low == null || high == null || precision == null)
                return null;
            if (Units.CqlUnitsToUCUM.TryGetValue(precision, out var converted))
                precision = converted;

            var firstDto = low.Value;
            var secondDto = high.Value;
            switch (precision)
            {
                case "a":
                    var yearDiff = secondDto.Year - firstDto.Year;
                    var firstDayInYear = firstDto.DayOfYear;
                    var secondDayInYear = secondDto.DayOfYear;

                    // In 2020 (leap year), 2-29 is day 60 and 3-1 is day 61.
                    // In 2021 (non-leap )year, 3-1 is day 60.
                    // Subtract 2-29 out of the equation for leap years
                    // for leap years, this normalizes 3-1 from being day 61 back to day 60.
                    if (DateTime.IsLeapYear(firstDto.Year) && firstDayInYear > 60)
                        firstDayInYear -= 1;
                    else if (DateTime.IsLeapYear(secondDto.Year) && secondDayInYear > 60)
                        secondDayInYear -= 1;

                    if (yearDiff > 0 && secondDayInYear < firstDayInYear)
                        yearDiff -= 1;
                    else if (yearDiff < 0 && firstDayInYear < secondDayInYear)
                        yearDiff += 1;
                    return yearDiff;
                case "mo":
                    var monthDiff = (12 * (secondDto.Year - firstDto.Year) + secondDto.Month - firstDto.Month);
                    if (monthDiff > 0 && secondDto.Day < firstDto.Day)
                        monthDiff -= 1;
                    else if (monthDiff < 0 && firstDto.Day < secondDto.Day)
                        monthDiff += 1;
                    return monthDiff;
                case "wk": return (int)(secondDto.Subtract(firstDto).TotalDays / ConversionConstants.DaysPerWeekAsDouble);
                case "d": return (int)secondDto.Subtract(firstDto).TotalDays;
                case "h": return (int)secondDto.Subtract(firstDto).TotalHours;
                case "min": return (int)secondDto.Subtract(firstDto).TotalMinutes;
                case "s": return (int)secondDto.Subtract(firstDto).TotalSeconds;
                case "ms": return (int)secondDto.Subtract(firstDto).TotalMilliseconds;
                default: throw new ArgumentException($"Unit {precision} is not supported");
            };
        }

        public static readonly IDictionary<DateTimePrecision, CqlQuantity> UnitDateTimeQuantity = new Dictionary<DateTimePrecision, CqlQuantity>
        {
            { DateTimePrecision.Day, new CqlQuantity(1m, UCUMUnits.Day) },
            { DateTimePrecision.Hour, new CqlQuantity(1m, UCUMUnits.Hour) },
            { DateTimePrecision.Millisecond, new CqlQuantity(1m, UCUMUnits.Millisecond) },
            { DateTimePrecision.Minute, new CqlQuantity(1m, UCUMUnits.Minute) },
            { DateTimePrecision.Month, new CqlQuantity(1m, UCUMUnits.Month) },
            { DateTimePrecision.Second, new CqlQuantity(1m, UCUMUnits.Second) },
            { DateTimePrecision.Year, new CqlQuantity(1m, UCUMUnits.Year) },

        };
    }
}

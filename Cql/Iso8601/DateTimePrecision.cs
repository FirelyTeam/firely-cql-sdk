#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System;

namespace Hl7.Cql.Iso8601
{
    public static class DateTimePrecisionExtensions
    {
        public static DateTimePrecision? ToDateTimePrecision(this string? ucumUnit)
        {
            if (ucumUnit == null)
                return null;
            else switch (ucumUnit[0])
                {
                    case 'a': // year
                        return DateTimePrecision.Year;
                    case 'm': // month
                        switch (ucumUnit[1])
                        {
                            case 'o': // mo = month
                                return DateTimePrecision.Month;
                            case 'i': // min = minute
                                return DateTimePrecision.Minute;
                            case 's':
                                return DateTimePrecision.Millisecond;
                            default: break;
                        }
                        break;
                    case 'd':
                        return DateTimePrecision.Day;
                    case 'h':
                        return DateTimePrecision.Hour;
                    case 's':
                        return DateTimePrecision.Second;
                    default:
                        break;
                }
            return DateTimePrecision.Unknown;
        }

        public static string ToUCUMUnit(this DateTimePrecision precision) =>
            precision switch
            {
                DateTimePrecision.Year => "a",
                DateTimePrecision.Month => "mo",
                DateTimePrecision.Day => "d",
                DateTimePrecision.Hour => "h",
                DateTimePrecision.Minute => "mi",
                DateTimePrecision.Second => "s",
                DateTimePrecision.Millisecond => "ms",
                _ => throw new ArgumentException($"Unit {Enum.GetName<DateTimePrecision>(precision)} is not convertible to a UCUM unit.")
            };

        public static string? ToUCUMUnit(this DateTimePrecision? precision)
        {
            if (precision == null)
                return null;
            else return ToUCUMUnit(precision.Value);
        }
    }

    public enum DateTimePrecision
    {
        Unknown = 0,
        Year,
        Month,
        Day,
        Hour,
        Minute,
        Second,
        Millisecond
    }
}

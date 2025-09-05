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
    public static class DateTimePrecisionExtensions
    {
        public static DateTimePrecision? ToDateTimePrecision(this string? unit)
        {
            if (unit == null)
                return null;
            else switch (unit)
                {
                    case "year":
                    case "years":
                        return DateTimePrecision.Year;
                    case "month":
                    case "months":
                        return DateTimePrecision.Month;
                    case "minute":
                    case "minutes":
                        return DateTimePrecision.Minute;
                    case "millisecond":
                    case "milliseconds":
                        return DateTimePrecision.Millisecond;
                    case "day":
                    case "days":
                        return DateTimePrecision.Day;
                    case "hour":
                    case "hours":
                        return DateTimePrecision.Hour;
                    case "second":
                    case "seconds":
                        return DateTimePrecision.Second;
                    default:
                        break;
                }
            return DateTimePrecision.Unknown;
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

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
        public static DateTimePrecision? ToDateTimePrecision(this string? unit) =>
            unit switch
            {
                null                            => null,
                "year" or "years"               => DateTimePrecision.Year,
                "month" or "months"             => DateTimePrecision.Month,
                "minute" or "minutes"           => DateTimePrecision.Minute,
                "millisecond" or "milliseconds" => DateTimePrecision.Millisecond,
                "day" or "days"                 => DateTimePrecision.Day,
                "hour" or "hours"               => DateTimePrecision.Hour,
                "second" or "seconds"           => DateTimePrecision.Second,
                _                               => DateTimePrecision.Unknown
            };
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

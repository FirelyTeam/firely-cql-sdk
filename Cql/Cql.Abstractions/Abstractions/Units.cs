/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Abstractions
{
    /// <summary>
    /// Utilities for converting precision to cql units
    /// </summary>
    public static class Units
    {
        /// <summary>
        /// Maps DateTime Precisions to their corresponding CQL units.
        /// </summary>
        public static readonly IDictionary<string, string> DatePrecisionToCqlUnits = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            { "Year",           "year" },
            { "Month",          "month" },
            { "Day",            "day" },
            { "Week",           "week" },
            { "Hour",           "hour" },
            { "Minute",         "minute" },
            { "Second",         "second" },
            { "Millisecond",    "millisecond" }
        };

    }
}

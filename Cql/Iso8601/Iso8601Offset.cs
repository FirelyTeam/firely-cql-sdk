/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

namespace Hl7.Cql.Iso8601
{
    /// <summary>
    /// Helpers for the UTC offset component shared by <see cref="DateTimeIso8601"/> and <see cref="TimeIso8601"/>.
    /// </summary>
    internal static class Iso8601Offset
    {
        /// <summary>
        /// Gives the offset minute the sign of the offset hour, so that an offset such as <c>-05:30</c>
        /// becomes hour -5 and minute -30, matching how <see cref="System.TimeSpan"/> represents it.
        /// </summary>
        internal static int? NormalizeMinute(int? offsetHour, int? offsetMinute) =>
            (offsetHour, offsetMinute) switch
            {
                (< 0, > 0) => -offsetMinute,
                (> 0, < 0) => -offsetMinute,
                _ => offsetMinute
            };
    }
}

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
    /// Defines UCUM unit constants.
    /// </summary>
    /// <see href="https://ucum.org/"/>
    public static class UCUMUnits
    {
        /// <summary>
        /// <see cref="Unary" />
        /// </summary>
        public const string Default = Unary;

        /// <summary>
        /// The unit code to represent unary, or "no units".
        /// Use this unit when expressing integers or decimals as quantities.
        /// </summary>
        public const string Unary = "1";

        /// <summary>
        /// Years ("Annos" in Latin).
        /// </summary>
        /// <remarks>
        /// Note that this unit is the same as the value of <see cref="DaysPerYearDouble"/> which is 365.25 days.
        /// </remarks>
        public const string Year = "a";

        /// <summary>
        /// Defines days per year
        /// </summary>
        /// <remarks>
        /// Used when specifying <see cref="Year"/>.
        /// </remarks>
        public const double DaysPerYearDouble = 365.25d;

        /// <summary>
        /// Months
        /// </summary>
        /// <remarks>
        /// Note that this unit is the same as the value of <see cref="DaysPerMonthDouble"/> which is 30.4375 days.
        /// </remarks>
        public const string Month = "mo";

        /// <summary>
        /// Defines days per month
        /// </summary>
        /// <remarks>
        /// Used when specifying <see cref="Month"/>.
        /// </remarks>
        public const double DaysPerMonthDouble = 30.4375d;

        /// <summary>
        /// Days
        /// </summary>
        public const string Day = "d";

        /// <summary>
        /// Hours
        /// </summary>
        public const string Hour = "h";

        /// <summary>
        /// Minutes
        /// </summary>
        public const string Minute = "min";

        /// <summary>
        /// Seconds
        /// </summary>
        public const string Second = "s";

        /// <summary>
        /// Milliseconds
        /// </summary>
        public const string Millisecond = "ms";

        /// <summary>
        /// Weeks, equal to 7 <see cref="Day"/>.
        /// </summary>
        public const string Week = "wk";

        /// <summary>
        /// Imperial inches
        /// </summary>
        public const string Inch = "[in_i]";

        /// <summary>
        /// Imperial feet
        /// </summary>
        public const string Foot = "[ft_i]";

        /// <summary>
        /// Imperial yards
        /// </summary>
        public const string Yard = "[yd_i]";

        /// <summary>
        /// Meters
        /// </summary>
        public const string Meter = "m";

        /// <summary>
        /// Centimeters
        /// </summary>
        public const string Centimeter = "cm";
    }
}

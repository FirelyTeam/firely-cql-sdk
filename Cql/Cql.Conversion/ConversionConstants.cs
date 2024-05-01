/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Conversion
{
    /// <summary>
    /// Conversions according to https://cql.hl7.org/09-b-cqlreference.html#quantity
    /// 1 year = 12 months
    /// 1 week = 7 days
    /// 1 day = 24 hours
    /// 1 hour = 60 minutes
    /// 1 minute = 60 seconds
    /// 1 second = 1000 milliseconds
    /// </summary>
    internal static class ConversionConstants
    {
        /// <summary>
        /// Defines 365 days per year in <see cref="System.Decimal"/> precision.
        /// </summary>
        public const decimal DaysPerYear = 365m;

        /// <summary>
        /// Defines 365 days per year in <see cref="System.Double"/> precision.
        /// </summary>
        public const double DaysPerYearAsDouble = 365d;


        /// <summary>
        /// Defines years per day, equal to 1 over <see cref="DaysPerYear"/>.
        /// </summary>
        public const decimal YearsPerDay = 1 / DaysPerYear;
        /// <summary>
        /// Defines 12 months per year in <see cref="System.Decimal"/> precision.
        /// </summary>
        public const decimal MonthsPerYear = 12m;
        /// <summary>
        /// Defines 12 months per year in <see cref="System.Double"/> precision.
        /// </summary>
        public const double MonthsPerYearAsDouble = 12d;
        /// <summary>
        /// Defines 12 months per year in <see cref="System.Int32"/> precision.
        /// </summary>
        public const double MonthsPerYearAsInteger = 12;

        /// <summary>
        /// Days per month, defined as 30.4375 in <see cref="System.Decimal"/> precision.
        /// </summary>
        public const decimal DaysPerMonth = 30.4375m;

        /// <summary>
        /// Days per month, defined as 30.4375 in <see cref="System.Double"/> precision.
        /// </summary>
        public const double DaysPerMonthAsDouble = 30.4375d;

        /// <summary>
        /// Defines years per day, equal to 1 over <see cref="DaysPerMonth"/>.
        /// </summary>
        public const decimal MonthsPerDay = 1 / DaysPerMonth;


        /// <summary>
        /// Defines 7 days per week.
        /// </summary>
        public const decimal DaysPerWeek = 7m;

        /// <summary>
        /// Defines 7 days per week in <see cref="System.Double"/> precision.
        /// </summary>
        public const double DaysPerWeekAsDouble = 7d;

        /// <summary>
        /// Defines 12 inches per foot.
        /// </summary>
        public const decimal InchesPerFoot = 12m;

        /// <summary>
        /// Defines imperial feet per imperial inch, equal to 1 over <see cref="InchesPerFoot"/>.
        /// </summary>
        public const decimal FeetPerInch = 1 / InchesPerFoot;

        /// <summary>
        /// Defines 36 imperial inches per imperial yard.
        /// </summary>
        public const decimal InchesPerYard = 36m;
        /// <summary>
        /// Defines imperial yards per imperial inch, equal to 1 over <see cref="InchesPerYard"/>.
        /// </summary>
        public const decimal YardsPerInch = 1 / InchesPerYard;

        /// <summary>
        /// Defines 2.54 centimeters per imperial inch.
        /// </summary>
        public const decimal CentimetersPerInch = 2.54m;

        /// <summary>
        /// Defines imperial inches per centimeter inch, equal to 1 over <see cref="CentimetersPerInch"/>.
        /// </summary>
        public const decimal InchesPerCentimeter = 1 / CentimetersPerInch;



    }
}

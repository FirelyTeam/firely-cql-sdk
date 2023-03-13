namespace Ncqa.Cql.Runtime.Conversion
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
    public static class ConversionConstants
    {
        public const decimal DaysPerYear = 365m;
        public const decimal YearsPerDay = 1/DaysPerYear;
        public const decimal MonthsPerYear = 12m;
        public const double MonthsPerYearAsDouble = 12d;
        public const double MonthsPerYearAsInteger = 12;

        public const double DaysPerYearAsDouble = 365d;
        public const decimal DaysPerMonth = 30.4375m;
        public const decimal MonthsPerDay = 1/ DaysPerMonth;

        public const double DaysPerMonthAsDouble = 30.4375d;

        public const decimal DaysPerWeek = 7m;
        public const double DaysPerWeekAsDouble = 7d;

        public const decimal InchesPerFoot = 12m;
        public const decimal FeetPerInch = 1/ InchesPerFoot;

        public const decimal InchesPerYard = 36m;
        public const decimal YardsPerInch = 1/ InchesPerYard;

        public const decimal CentimetersPerInch = 2.54m;
        public const decimal InchesPerCentimeter = 1/ CentimetersPerInch;



    }
}

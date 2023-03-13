using Ncqa.Iso8601;

namespace Ncqa.Cql.Runtime.Conversion
{
    public static class UCUMUnits
    {
        public const string Default = "1";

        public const string Year = "a";
        public const string Month = "mo";
        public const string Day = "d";
        public const string Hour = "h";
        public const string Minute = "min";
        public const string Second = "s";
        public const string Millisecond = "ms";
        public const string Week = "wk";
        public const string Inch = "[in_i]";
        public const string Foot = "[ft_i]";
        public const string Yard = "[yd_i]";
        public const string Meter = "m";
        public const string Centimeter = "cm";

        public static string? FromDateTimePrecision(DateTimePrecision dtp)
        {
            switch (dtp)
            {

                case DateTimePrecision.Year:
                    return Year;
                case DateTimePrecision.Month:
                    return Month;
                case DateTimePrecision.Day:
                    return Day;
                case DateTimePrecision.Hour:
                    return Hour;
                case DateTimePrecision.Minute:
                    return Minute;
                case DateTimePrecision.Second:
                    return Second;
                case DateTimePrecision.Millisecond:
                    return Millisecond;
                case DateTimePrecision.Unknown:
                default:
                    return null;
            }
        }
    }


}

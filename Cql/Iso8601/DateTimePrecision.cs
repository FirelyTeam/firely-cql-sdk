using System;
using System.Collections.Generic;
using System.Text;

namespace Ncqa.Iso8601
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

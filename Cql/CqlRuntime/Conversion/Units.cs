using System;
using System.Collections.Generic;
using System.Text;

namespace Ncqa.Cql.Runtime.Conversion
{
    public static class Units
    {
        /// <summary>
        /// https://www.hl7.org/fhir/valueset-ucum-units.html
        /// </summary>
        public static readonly IDictionary<string, string> CqlUnitsToUCUM = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            { "year", "a" },
            { "years", "a" },
            { "month", "mo" },
            { "months", "mo" },
            { "days", "d" },
            { "day", "d" },
            { "week", "wk" },
            { "weeks", "wk" },
            { "hour", "h" },
            { "hours", "h" },
            { "minute", "min" },
            { "minutes", "min" },
            { "second", "s" },
            { "seconds", "s" },
            { "millisecond", "ms" },
            { "milliseconds", "ms" },
        };

        public static readonly IDictionary<string, string> UCUMUnitsToCql = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            { "a", "year" },
            { "mo", "month" },
            { "wk", "week" },
            { "d", "day" },
            { "h", "hour" },
            { "min", "minute" },
            { "s", "second" },
            { "ms", "millisecond" },
        };

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Ncqa.Cql
{
    /// <summary>
    /// Utilities for converting between CQL and UCUM units.
    /// </summary>
    public static class Units
    {
        /// <summary>
        /// Maps CQL unit keywords (singular or plural) to their corresponding UCUM unit codes.
        /// </summary>
        /// <see href="https://www.hl7.org/fhir/valueset-ucum-units.html"/>
        public static readonly IDictionary<string, string> CqlUnitsToUCUM = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            { "year",           UCUMUnits.Year },
            { "years",          UCUMUnits.Year },
            { "month",          UCUMUnits.Month },
            { "months",         UCUMUnits.Month },
            { "days",           UCUMUnits.Day },
            { "day",            UCUMUnits.Day },
            { "week",           UCUMUnits.Week },
            { "weeks",          UCUMUnits.Week },
            { "hour",           UCUMUnits.Hour },
            { "hours",          UCUMUnits.Hour },
            { "minute",         UCUMUnits.Minute },
            { "minutes",        UCUMUnits.Minute },
            { "second",         UCUMUnits.Second },
            { "seconds",        UCUMUnits.Second },
            { "millisecond",    UCUMUnits.Millisecond },
            { "milliseconds",   UCUMUnits.Millisecond },
        };

        /// <summary>
        /// Maps UCUM unit codes to their corresponding CQL keywords, singular.
        /// </summary>
        public static readonly IDictionary<string, string> UCUMUnitsToCql = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            { UCUMUnits.Year,           "year" },
            { UCUMUnits.Month,          "month" },
            { UCUMUnits.Week,           "week" },
            { UCUMUnits.Day,            "day" },
            { UCUMUnits.Hour,           "hour" },
            { UCUMUnits.Minute,         "minute" },
            { UCUMUnits.Second,         "second" },
            { UCUMUnits.Millisecond,    "millisecond" },
        };

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CqlToElm2Tests;
internal class CanonicalTypeMap : Dictionary<string, string>
{
    public static readonly CanonicalTypeMap Postgres = new()
    {
        { "http://hl7.org/fhir/StructureDefinition/date", "date" },
        { "http://hl7.org/fhir/StructureDefinition/dateTime", "timestamptz" },
        { "http://hl7.org/fhir/StructureDefinition/boolean", "boolean" },
        { "http://hl7.org/fhir/StructureDefinition/Period", "tstzrange" },
        { "http://hl7.org/fhir/StructureDefinition/string", "text" },
        { "http://hl7.org/fhir/StructureDefinition/Age", "interval" },
        { "http://hl7.org/fhir/StructureDefinition/Range", "numrange" }, 
        { "http://hl7.org/fhir/StructureDefinition/Timing", "jsonb" }, // Complex structure best stored as JSON
        { "http://hl7.org/fhir/StructureDefinition/instant", "timestamptz" }, // Precise timestamp with timezone
        { "http://hl7.org/fhir/StructureDefinition/Quantity", "jsonb" }, // Contains value, unit, system, and code
        { "http://hl7.org/fhir/StructureDefinition/CodeableConcept", "jsonb" }, // Multiple codes, text, and extensions
        { "http://hl7.org/fhir/StructureDefinition/integer", "integer" }, // Standard integer
        { "http://hl7.org/fhir/StructureDefinition/Ratio", "jsonb" }, // Two Quantities (numerator and denominator)
        { "http://hl7.org/fhir/StructureDefinition/SampledData", "jsonb" }, // Complex structure best stored as JSON
        { "http://hl7.org/fhir/StructureDefinition/time", "time" }, // Time-of-day without date
        { "http://hl7.org/fhir/StructureDefinition/Reference", "text" } // Typically a URL or an identifier
    };
}

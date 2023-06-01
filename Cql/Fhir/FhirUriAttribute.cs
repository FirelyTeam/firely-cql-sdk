using System;

namespace Hl7.Cql.Poco.Fhir
{
    /// <summary>
    /// Structure definition URI in the form of http://hl7.org/fhir/StructureDefinition/{Resource}
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = false)]
    public class FhirUriAttribute: Attribute
    {
        public FhirUriAttribute(string Uri)
        {
            this.Uri = Uri;
        }
        public string Uri { get; }
    }
}

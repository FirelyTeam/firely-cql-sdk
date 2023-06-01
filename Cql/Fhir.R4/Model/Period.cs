using Hl7.Cql.Poco.Fhir;

namespace Hl7.Cql.Poco.Fhir.R4.Model
{
    [FhirUri("http://hl7.org/fhir/StructureDefinition/Period")]
	public partial class Period : Element
	{

		public DateTimeElement start { get; set; }

		public DateTimeElement end { get; set; }
	}
}

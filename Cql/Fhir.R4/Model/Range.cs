using Hl7.Cql.Poco.Fhir;

namespace Hl7.Cql.Poco.Fhir.R4.Model
{
    [FhirUri("http://hl7.org/fhir/StructureDefinition/Range")]
	public partial class Range : Element
	{

		public Quantity low { get; set; }

		public Quantity high { get; set; }
	}
}

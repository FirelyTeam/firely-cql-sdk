using Hl7.Cql.Poco.Fhir;

namespace Hl7.Cql.Poco.Fhir.R4.Model
{
    [FhirUri("http://hl7.org/fhir/StructureDefinition/Ratio")]
	public partial class Ratio : Element
	{

		public Quantity numerator { get; set; }

		public Quantity denominator { get; set; }
	}
}

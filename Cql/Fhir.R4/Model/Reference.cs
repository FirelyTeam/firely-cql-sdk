using Hl7.Cql.Poco.Fhir;

namespace Hl7.Cql.Poco.Fhir.R4.Model
{
    [FhirUri("http://hl7.org/fhir/StructureDefinition/Reference")]
	public partial class Reference : Element
	{

		public StringElement reference { get; set; }

		[ValueSetBinding("FHIRResourceTypeExt", "http://hl7.org/fhir/ValueSet/resource-types", false)]
		public UriElement type { get; set; }

		public Identifier identifier { get; set; }

		public StringElement display { get; set; }
	}
}

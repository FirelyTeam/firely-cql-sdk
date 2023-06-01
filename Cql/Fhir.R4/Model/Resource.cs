using Hl7.Cql.Poco.Fhir;

namespace Hl7.Cql.Poco.Fhir.R4.Model
{
    [FhirUri("http://hl7.org/fhir/StructureDefinition/Resource")]
	public partial class Resource
	{

		public IdElement id { get; set; }

		public Meta meta { get; set; }

		public UriElement implicitRules { get; set; }

		[ValueSetBinding("Language", "http://hl7.org/fhir/ValueSet/languages", false)]
		public CodeElement language { get; set; }
	}
}

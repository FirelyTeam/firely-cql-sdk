using Hl7.Cql.Poco.Fhir;

namespace Hl7.Cql.Poco.Fhir.R4.Model
{
    [FhirUri("http://hl7.org/fhir/StructureDefinition/Coding")]
	public partial class Coding : Element
	{

		public UriElement system { get; set; }

		public StringElement version { get; set; }

		public CodeElement code { get; set; }

		public StringElement display { get; set; }

		public BooleanElement userSelected { get; set; }
	}
}

using Hl7.Cql.Poco.Fhir;
using System.Diagnostics;

namespace Hl7.Cql.Poco.Fhir.R4.Model
{
    [DebuggerDisplay("{value}")]
	[FhirUri("http://hl7.org/fhir/StructureDefinition/string")]
	public partial class StringElement : Element
	{

		public string value { get; set; }
	}
}

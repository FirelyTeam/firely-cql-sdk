using Hl7.Cql.Poco.Fhir;
using System.Diagnostics;

namespace Hl7.Cql.Poco.Fhir.R4.Model
{
    [DebuggerDisplay("{value}")]
	[FhirUri("http://hl7.org/fhir/StructureDefinition/Money")]
	public partial class Money : Element
	{

		public DecimalElement value { get; set; }

		[ValueSetBinding("CurrencyCode", "http://hl7.org/fhir/ValueSet/currencies%7C4.0.1", true)]
		public CodeElement currency { get; set; }
	}
}

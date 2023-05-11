using Hl7.Cql.Poco.Fhir;
using System.Diagnostics;

namespace Hl7.Cql.Poco.Fhir.R4.Model
{
    [DebuggerDisplay("{value}")]
	[FhirUri("http://hl7.org/fhir/StructureDefinition/Quantity")]
	public partial class Quantity : Element
	{

		public DecimalElement value { get; set; }

		[ValueSetBinding("QuantityComparator", "http://hl7.org/fhir/ValueSet/quantity-comparator%7C4.0.1", true)]
		public CodeElement comparator { get; set; }

		public StringElement unit { get; set; }

		public UriElement system { get; set; }

		public CodeElement code { get; set; }
	}
}

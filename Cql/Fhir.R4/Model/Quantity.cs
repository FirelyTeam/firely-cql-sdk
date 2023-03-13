using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
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

using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[FhirUri("http://hl7.org/fhir/StructureDefinition/Address")]
	public partial class Address : Element
	{

		[ValueSetBinding("AddressUse", "http://hl7.org/fhir/ValueSet/address-use%7C4.0.1", true)]
		public CodeElement use { get; set; }

		[ValueSetBinding("AddressType", "http://hl7.org/fhir/ValueSet/address-type%7C4.0.1", true)]
		public CodeElement type { get; set; }

		public StringElement text { get; set; }

		public ICollection<StringElement> line { get; set; }

		public StringElement city { get; set; }

		public StringElement district { get; set; }

		public StringElement state { get; set; }

		public StringElement postalCode { get; set; }

		public StringElement country { get; set; }

		public Period period { get; set; }
	}
}

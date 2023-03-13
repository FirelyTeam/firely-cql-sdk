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
	[FhirUri("http://hl7.org/fhir/StructureDefinition/Identifier")]
	public partial class Identifier : Element
	{

		public StringElement value { get; set; }

		[ValueSetBinding("IdentifierUse", "http://hl7.org/fhir/ValueSet/identifier-use%7C4.0.1", true)]
		public CodeElement use { get; set; }

		[ValueSetBinding("IdentifierType", "http://hl7.org/fhir/ValueSet/identifier-type", false)]
		public CodeableConcept type { get; set; }

		public UriElement system { get; set; }

		public Period period { get; set; }

		public Reference assigner { get; set; }
	}
}

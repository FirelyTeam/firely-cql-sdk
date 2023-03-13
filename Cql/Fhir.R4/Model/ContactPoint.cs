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
	[FhirUri("http://hl7.org/fhir/StructureDefinition/ContactPoint")]
	public partial class ContactPoint : Element
	{

		public StringElement value { get; set; }

		[ValueSetBinding("ContactPointSystem", "http://hl7.org/fhir/ValueSet/contact-point-system%7C4.0.1", true)]
		public CodeElement system { get; set; }

		[ValueSetBinding("ContactPointUse", "http://hl7.org/fhir/ValueSet/contact-point-use%7C4.0.1", true)]
		public CodeElement use { get; set; }

		public PositiveIntElement rank { get; set; }

		public Period period { get; set; }
	}
}

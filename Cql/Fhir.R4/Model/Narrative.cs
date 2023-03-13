using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[FhirUri("http://hl7.org/fhir/StructureDefinition/Narrative")]
	public partial class Narrative : Element
	{

		[NotNull]
		[ValueSetBinding("NarrativeStatus", "http://hl7.org/fhir/ValueSet/narrative-status%7C4.0.1", true)]
		public CodeElement status { get; set; }

		[NotNull]
		public XhtmlElement div { get; set; }
	}
}

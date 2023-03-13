using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[FhirUri("http://hl7.org/fhir/StructureDefinition/CodeableConcept")]
	public partial class CodeableConcept : Element
	{

		public ICollection<Coding> coding { get; set; }

		public StringElement text { get; set; }
	}
}

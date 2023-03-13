using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[FhirUri("http://hl7.org/fhir/StructureDefinition/Population")]
	public partial class Population : BackboneElement
	{

		[Choice(typeof(Range))]
		[Choice(typeof(CodeableConcept))]
		[JsonIgnore]
		public Element age { get; set; }
		public Range ageRange { get => ChoiceAttribute.AsExactly<Range>(age); set { age = value; } }
		public CodeableConcept ageCodeableConcept { get => ChoiceAttribute.AsExactly<CodeableConcept>(age); set { age = value; } }

		public CodeableConcept gender { get; set; }

		public CodeableConcept race { get; set; }

		public CodeableConcept physiologicalCondition { get; set; }
	}
}

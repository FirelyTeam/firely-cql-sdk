using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[FhirUri("http://hl7.org/fhir/StructureDefinition/MedicinalProductUndesirableEffect")]
	public partial class MedicinalProductUndesirableEffect : DomainResource
	{

		public ICollection<Reference> subject { get; set; }

		public CodeableConcept symptomConditionEffect { get; set; }

		public CodeableConcept classification { get; set; }

		public CodeableConcept frequencyOfOccurrence { get; set; }

		public ICollection<Population> population { get; set; }
	}
}

using Hl7.Cql.Poco.Fhir;
using System.Collections.Generic;

namespace Hl7.Cql.Poco.Fhir.R4.Model
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

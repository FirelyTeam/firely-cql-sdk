using Hl7.Cql.Poco.Fhir;
using System.Collections.Generic;

namespace Hl7.Cql.Poco.Fhir.R4.Model
{
    [FhirUri("http://hl7.org/fhir/StructureDefinition/Schedule")]
	public partial class Schedule : DomainResource
	{

		public ICollection<Identifier> identifier { get; set; }

		public BooleanElement active { get; set; }

		[ValueSetBinding("service-category", "http://hl7.org/fhir/ValueSet/service-category", false)]
		public ICollection<CodeableConcept> serviceCategory { get; set; }

		[ValueSetBinding("service-type", "http://hl7.org/fhir/ValueSet/service-type", false)]
		public ICollection<CodeableConcept> serviceType { get; set; }

		[ValueSetBinding("specialty", "http://hl7.org/fhir/ValueSet/c80-practice-codes", false)]
		public ICollection<CodeableConcept> specialty { get; set; }

		public ICollection<Reference> actor { get; set; }

		public Period planningHorizon { get; set; }

		public StringElement comment { get; set; }
	}
}

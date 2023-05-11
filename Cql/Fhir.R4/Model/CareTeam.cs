using Hl7.Cql.Poco.Fhir;
using System.Collections.Generic;

namespace Hl7.Cql.Poco.Fhir.R4.Model
{
    [FhirUri("http://hl7.org/fhir/StructureDefinition/CareTeam")]
	public partial class CareTeam : DomainResource
	{

		public ICollection<Identifier> identifier { get; set; }

		[ValueSetBinding("CareTeamStatus", "http://hl7.org/fhir/ValueSet/care-team-status%7C4.0.1", true)]
		public CodeElement status { get; set; }

		[ValueSetBinding("CareTeamCategory", "http://hl7.org/fhir/ValueSet/care-team-category", false)]
		public ICollection<CodeableConcept> category { get; set; }

		public StringElement name { get; set; }

		public Reference subject { get; set; }

		public Reference encounter { get; set; }

		public Period period { get; set; }

		public ICollection<ParticipantComponent> participant { get; set; }

		[ValueSetBinding("CareTeamReason", "http://hl7.org/fhir/ValueSet/clinical-findings", false)]
		public ICollection<CodeableConcept> reasonCode { get; set; }

		public ICollection<Reference> reasonReference { get; set; }

		public ICollection<Reference> managingOrganization { get; set; }

		public ICollection<ContactPoint> telecom { get; set; }

		public ICollection<Annotation> note { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/CareTeam.participant")]
		public partial class ParticipantComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[ValueSetBinding("CareTeamParticipantRole", "http://hl7.org/fhir/ValueSet/participant-role", false)]
			public ICollection<CodeableConcept> role { get; set; }

			public Reference member { get; set; }

			public Reference onBehalfOf { get; set; }

			public Period period { get; set; }
		}
	}
}

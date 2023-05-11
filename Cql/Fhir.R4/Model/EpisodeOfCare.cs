using Hl7.Cql.Poco.Fhir;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Hl7.Cql.Poco.Fhir.R4.Model
{
    [FhirUri("http://hl7.org/fhir/StructureDefinition/EpisodeOfCare")]
	public partial class EpisodeOfCare : DomainResource
	{

		public ICollection<Identifier> identifier { get; set; }

		[NotNull]
		[ValueSetBinding("EpisodeOfCareStatus", "http://hl7.org/fhir/ValueSet/episode-of-care-status%7C4.0.1", true)]
		public CodeElement status { get; set; }

		public ICollection<StatusHistoryComponent> statusHistory { get; set; }

		[ValueSetBinding("EpisodeOfCareType", "http://hl7.org/fhir/ValueSet/episodeofcare-type", false)]
		public ICollection<CodeableConcept> type { get; set; }

		public ICollection<DiagnosisComponent> diagnosis { get; set; }

		[NotNull]
		public Reference patient { get; set; }

		public Reference managingOrganization { get; set; }

		public Period period { get; set; }

		public ICollection<Reference> referralRequest { get; set; }

		public Reference careManager { get; set; }

		public ICollection<Reference> team { get; set; }

		public ICollection<Reference> account { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/EpisodeOfCare.statusHistory")]
		public partial class StatusHistoryComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			[ValueSetBinding("EpisodeOfCareStatus", "http://hl7.org/fhir/ValueSet/episode-of-care-status%7C4.0.1", true)]
			public CodeElement status { get; set; }

			[NotNull]
			public Period period { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/EpisodeOfCare.diagnosis")]
		public partial class DiagnosisComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			public Reference condition { get; set; }

			[ValueSetBinding("DiagnosisRole", "http://hl7.org/fhir/ValueSet/diagnosis-role", false)]
			public CodeableConcept role { get; set; }

			public PositiveIntElement rank { get; set; }
		}
	}
}

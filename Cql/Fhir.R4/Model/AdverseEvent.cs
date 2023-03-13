using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[FhirUri("http://hl7.org/fhir/StructureDefinition/AdverseEvent")]
	public partial class AdverseEvent : DomainResource
	{

		public Identifier identifier { get; set; }

		[NotNull]
		[ValueSetBinding("AdverseEventActuality", "http://hl7.org/fhir/ValueSet/adverse-event-actuality%7C4.0.1", true)]
		public CodeElement actuality { get; set; }

		[ValueSetBinding("AdverseEventCategory", "http://hl7.org/fhir/ValueSet/adverse-event-category", false)]
		public ICollection<CodeableConcept> category { get; set; }

		[ValueSetBinding("AdverseEventType", "http://hl7.org/fhir/ValueSet/adverse-event-type", false)]
		public CodeableConcept @event { get; set; }

		[NotNull]
		public Reference subject { get; set; }

		public Reference encounter { get; set; }

		public DateTimeElement date { get; set; }

		public DateTimeElement detected { get; set; }

		public DateTimeElement recordedDate { get; set; }

		public ICollection<Reference> resultingCondition { get; set; }

		public Reference location { get; set; }

		[ValueSetBinding("AdverseEventSeriousness", "http://hl7.org/fhir/ValueSet/adverse-event-seriousness", false)]
		public CodeableConcept seriousness { get; set; }

		[ValueSetBinding("AdverseEventSeverity", "http://hl7.org/fhir/ValueSet/adverse-event-severity%7C4.0.1", true)]
		public CodeableConcept severity { get; set; }

		[ValueSetBinding("AdverseEventOutcome", "http://hl7.org/fhir/ValueSet/adverse-event-outcome%7C4.0.1", true)]
		public CodeableConcept outcome { get; set; }

		public Reference recorder { get; set; }

		public ICollection<Reference> contributor { get; set; }

		public ICollection<SuspectEntityComponent> suspectEntity { get; set; }

		public ICollection<Reference> subjectMedicalHistory { get; set; }

		public ICollection<Reference> referenceDocument { get; set; }

		public ICollection<Reference> study { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/AdverseEvent.suspectEntity")]
		public partial class SuspectEntityComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			public Reference instance { get; set; }

			public ICollection<CausalityComponent> causality { get; set; }
			[FhirUri("http://hl7.org/fhir/StructureDefinition/AdverseEvent.suspectEntity.causality")]
			public partial class CausalityComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				[ValueSetBinding("AdverseEventCausalityAssessment", "http://hl7.org/fhir/ValueSet/adverse-event-causality-assess", false)]
				public CodeableConcept assessment { get; set; }

				public StringElement productRelatedness { get; set; }

				public Reference author { get; set; }

				[ValueSetBinding("AdverseEventCausalityMethod", "http://hl7.org/fhir/ValueSet/adverse-event-causality-method", false)]
				public CodeableConcept method { get; set; }
			}
		}
	}
}

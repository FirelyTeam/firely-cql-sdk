using Hl7.Cql.Poco.Fhir;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Hl7.Cql.Poco.Fhir.R4.Model
{
    [FhirUri("http://hl7.org/fhir/StructureDefinition/Appointment")]
	public partial class Appointment : DomainResource
	{

		public ICollection<Identifier> identifier { get; set; }

		[NotNull]
		[ValueSetBinding("AppointmentStatus", "http://hl7.org/fhir/ValueSet/appointmentstatus%7C4.0.1", true)]
		public CodeElement status { get; set; }

		[ValueSetBinding("cancelation-reason", "http://hl7.org/fhir/ValueSet/appointment-cancellation-reason", false)]
		public CodeableConcept cancelationReason { get; set; }

		[ValueSetBinding("service-category", "http://hl7.org/fhir/ValueSet/service-category", false)]
		public ICollection<CodeableConcept> serviceCategory { get; set; }

		[ValueSetBinding("service-type", "http://hl7.org/fhir/ValueSet/service-type", false)]
		public ICollection<CodeableConcept> serviceType { get; set; }

		[ValueSetBinding("specialty", "http://hl7.org/fhir/ValueSet/c80-practice-codes", false)]
		public ICollection<CodeableConcept> specialty { get; set; }

		[ValueSetBinding("appointment-type", "http://terminology.hl7.org/ValueSet/v2-0276", false)]
		public CodeableConcept appointmentType { get; set; }

		[ValueSetBinding("ApptReason", "http://hl7.org/fhir/ValueSet/encounter-reason", false)]
		public ICollection<CodeableConcept> reasonCode { get; set; }

		public ICollection<Reference> reasonReference { get; set; }

		public UnsignedIntElement priority { get; set; }

		public StringElement description { get; set; }

		public ICollection<Reference> supportingInformation { get; set; }

		public InstantElement start { get; set; }

		public InstantElement end { get; set; }

		public PositiveIntElement minutesDuration { get; set; }

		public ICollection<Reference> slot { get; set; }

		public DateTimeElement created { get; set; }

		public StringElement comment { get; set; }

		public StringElement patientInstruction { get; set; }

		public ICollection<Reference> basedOn { get; set; }

		public ICollection<ParticipantComponent> participant { get; set; }

		public ICollection<Period> requestedPeriod { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/Appointment.participant")]
		public partial class ParticipantComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[ValueSetBinding("ParticipantType", "http://hl7.org/fhir/ValueSet/encounter-participant-type", false)]
			public ICollection<CodeableConcept> type { get; set; }

			public Reference actor { get; set; }

			[ValueSetBinding("ParticipantRequired", "http://hl7.org/fhir/ValueSet/participantrequired%7C4.0.1", true)]
			public CodeElement required { get; set; }

			[NotNull]
			[ValueSetBinding("ParticipationStatus", "http://hl7.org/fhir/ValueSet/participationstatus%7C4.0.1", true)]
			public CodeElement status { get; set; }

			public Period period { get; set; }
		}
	}
}

using Hl7.Cql.Poco.Fhir;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Hl7.Cql.Poco.Fhir.R4.Model
{
    [FhirUri("http://hl7.org/fhir/StructureDefinition/MedicationRequest")]
	public partial class MedicationRequest : DomainResource
	{

		public ICollection<Identifier> identifier { get; set; }

		[NotNull]
		[ValueSetBinding("MedicationRequestStatus", "http://hl7.org/fhir/ValueSet/medicationrequest-status%7C4.0.1", true)]
		public CodeElement status { get; set; }

		[ValueSetBinding("MedicationRequestStatusReason", "http://hl7.org/fhir/ValueSet/medicationrequest-status-reason", false)]
		public CodeableConcept statusReason { get; set; }

		[NotNull]
		[ValueSetBinding("MedicationRequestIntent", "http://hl7.org/fhir/ValueSet/medicationrequest-intent%7C4.0.1", true)]
		public CodeElement intent { get; set; }

		[ValueSetBinding("MedicationRequestCategory", "http://hl7.org/fhir/ValueSet/medicationrequest-category", false)]
		public ICollection<CodeableConcept> category { get; set; }

		[ValueSetBinding("MedicationRequestPriority", "http://hl7.org/fhir/ValueSet/request-priority%7C4.0.1", true)]
		public CodeElement priority { get; set; }

		public BooleanElement doNotPerform { get; set; }

		[Choice(typeof(BooleanElement))]
		[Choice(typeof(Reference))]
		[JsonIgnore]
		public Element reported { get; set; }
		public BooleanElement reportedBoolean { get => ChoiceAttribute.AsExactly<BooleanElement>(reported); set { reported = value; } }
		public Reference reportedReference { get => ChoiceAttribute.AsExactly<Reference>(reported); set { reported = value; } }

		[NotNull]
		[Choice(typeof(CodeableConcept))]
		[Choice(typeof(Reference))]
		[JsonIgnore]
		[ValueSetBinding("MedicationCode", "http://hl7.org/fhir/ValueSet/medication-codes", false)]
		public Element medication { get; set; }
		public CodeableConcept medicationCodeableConcept { get => ChoiceAttribute.AsExactly<CodeableConcept>(medication); set { medication = value; } }
		public Reference medicationReference { get => ChoiceAttribute.AsExactly<Reference>(medication); set { medication = value; } }

		[NotNull]
		public Reference subject { get; set; }

		public Reference encounter { get; set; }

		public ICollection<Reference> supportingInformation { get; set; }

		public DateTimeElement authoredOn { get; set; }

		public Reference requester { get; set; }

		public Reference performer { get; set; }

		[ValueSetBinding("MedicationRequestPerformerType", "http://hl7.org/fhir/ValueSet/performer-role", false)]
		public CodeableConcept performerType { get; set; }

		public Reference recorder { get; set; }

		[ValueSetBinding("MedicationRequestReason", "http://hl7.org/fhir/ValueSet/condition-code", false)]
		public ICollection<CodeableConcept> reasonCode { get; set; }

		public ICollection<Reference> reasonReference { get; set; }

		public ICollection<CanonicalElement> instantiatesCanonical { get; set; }

		public ICollection<UriElement> instantiatesUri { get; set; }

		public ICollection<Reference> basedOn { get; set; }

		public Identifier groupIdentifier { get; set; }

		[ValueSetBinding("MedicationRequestCourseOfTherapy", "http://hl7.org/fhir/ValueSet/medicationrequest-course-of-therapy", false)]
		public CodeableConcept courseOfTherapyType { get; set; }

		public ICollection<Reference> insurance { get; set; }

		public ICollection<Annotation> note { get; set; }

		public ICollection<Dosage> dosageInstruction { get; set; }

		public DispenseRequestComponent dispenseRequest { get; set; }

		public SubstitutionComponent substitution { get; set; }

		public Reference priorPrescription { get; set; }

		public ICollection<Reference> detectedIssue { get; set; }

		public ICollection<Reference> eventHistory { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/MedicationRequest.dispenseRequest")]
		public partial class DispenseRequestComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public InitialFillComponent initialFill { get; set; }

			public Duration dispenseInterval { get; set; }

			public Period validityPeriod { get; set; }

			public UnsignedIntElement numberOfRepeatsAllowed { get; set; }

			public Quantity quantity { get; set; }

			public Duration expectedSupplyDuration { get; set; }

			public Reference performer { get; set; }
			[FhirUri("http://hl7.org/fhir/StructureDefinition/MedicationRequest.dispenseRequest.initialFill")]
			public partial class InitialFillComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				public Quantity quantity { get; set; }

				public Duration duration { get; set; }
			}
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/MedicationRequest.substitution")]
		public partial class SubstitutionComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			[Choice(typeof(BooleanElement))]
			[Choice(typeof(CodeableConcept))]
			[JsonIgnore]
			[ValueSetBinding("MedicationRequestSubstitution", "http://terminology.hl7.org/ValueSet/v3-ActSubstanceAdminSubstitutionCode", false)]
			public Element allowed { get; set; }
			public BooleanElement allowedBoolean { get => ChoiceAttribute.AsExactly<BooleanElement>(allowed); set { allowed = value; } }
			public CodeableConcept allowedCodeableConcept { get => ChoiceAttribute.AsExactly<CodeableConcept>(allowed); set { allowed = value; } }

			[ValueSetBinding("MedicationIntendedSubstitutionReason", "http://terminology.hl7.org/ValueSet/v3-SubstanceAdminSubstitutionReason", false)]
			public CodeableConcept reason { get; set; }
		}
	}
}

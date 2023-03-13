using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[FhirUri("http://hl7.org/fhir/StructureDefinition/MedicationDispense")]
	public partial class MedicationDispense : DomainResource
	{

		public ICollection<Identifier> identifier { get; set; }

		public ICollection<Reference> partOf { get; set; }

		[NotNull]
		[ValueSetBinding("MedicationDispenseStatus", "http://hl7.org/fhir/ValueSet/medicationdispense-status%7C4.0.1", true)]
		public CodeElement status { get; set; }

		[Choice(typeof(CodeableConcept))]
		[Choice(typeof(Reference))]
		[JsonIgnore]
		[ValueSetBinding("MedicationDispenseStatusReason", "http://hl7.org/fhir/ValueSet/medicationdispense-status-reason", false)]
		public Element statusReason { get; set; }
		public CodeableConcept statusReasonCodeableConcept { get => ChoiceAttribute.AsExactly<CodeableConcept>(statusReason); set { statusReason = value; } }
		public Reference statusReasonReference { get => ChoiceAttribute.AsExactly<Reference>(statusReason); set { statusReason = value; } }

		[ValueSetBinding("MedicationDispenseCategory", "http://hl7.org/fhir/ValueSet/medicationdispense-category", false)]
		public CodeableConcept category { get; set; }

		[NotNull]
		[Choice(typeof(CodeableConcept))]
		[Choice(typeof(Reference))]
		[JsonIgnore]
		[ValueSetBinding("MedicationCode", "http://hl7.org/fhir/ValueSet/medication-codes", false)]
		public Element medication { get; set; }
		public CodeableConcept medicationCodeableConcept { get => ChoiceAttribute.AsExactly<CodeableConcept>(medication); set { medication = value; } }
		public Reference medicationReference { get => ChoiceAttribute.AsExactly<Reference>(medication); set { medication = value; } }

		public Reference subject { get; set; }

		public Reference context { get; set; }

		public ICollection<Reference> supportingInformation { get; set; }

		public ICollection<PerformerComponent> performer { get; set; }

		public Reference location { get; set; }

		public ICollection<Reference> authorizingPrescription { get; set; }

		[ValueSetBinding("MedicationDispenseType", "http://terminology.hl7.org/ValueSet/v3-ActPharmacySupplyType", false)]
		public CodeableConcept type { get; set; }

		public Quantity quantity { get; set; }

		public Quantity daysSupply { get; set; }

		public DateTimeElement whenPrepared { get; set; }

		public DateTimeElement whenHandedOver { get; set; }

		public Reference destination { get; set; }

		public ICollection<Reference> receiver { get; set; }

		public ICollection<Annotation> note { get; set; }

		public ICollection<Dosage> dosageInstruction { get; set; }

		public SubstitutionComponent substitution { get; set; }

		public ICollection<Reference> detectedIssue { get; set; }

		public ICollection<Reference> eventHistory { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/MedicationDispense.performer")]
		public partial class PerformerComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[ValueSetBinding("MedicationDispensePerformerFunction", "http://hl7.org/fhir/ValueSet/medicationdispense-performer-function", false)]
			public CodeableConcept function { get; set; }

			[NotNull]
			public Reference actor { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/MedicationDispense.substitution")]
		public partial class SubstitutionComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			public BooleanElement wasSubstituted { get; set; }

			[ValueSetBinding("MedicationIntendedSubstitutionType", "http://terminology.hl7.org/ValueSet/v3-ActSubstanceAdminSubstitutionCode", false)]
			public CodeableConcept type { get; set; }

			[ValueSetBinding("MedicationIntendedSubstitutionReason", "http://terminology.hl7.org/ValueSet/v3-SubstanceAdminSubstitutionReason", false)]
			public ICollection<CodeableConcept> reason { get; set; }

			public ICollection<Reference> responsibleParty { get; set; }
		}
	}
}

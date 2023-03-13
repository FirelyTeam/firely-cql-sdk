using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[FhirUri("http://hl7.org/fhir/StructureDefinition/MedicationKnowledge")]
	public partial class MedicationKnowledge : DomainResource
	{

		[ValueSetBinding("MedicationFormalRepresentation", "http://hl7.org/fhir/ValueSet/medication-codes", false)]
		public CodeableConcept code { get; set; }

		[ValueSetBinding("MedicationKnowledgeStatus", "http://hl7.org/fhir/ValueSet/medicationknowledge-status%7C4.0.1", true)]
		public CodeElement status { get; set; }

		public Reference manufacturer { get; set; }

		[ValueSetBinding("MedicationForm", "http://hl7.org/fhir/ValueSet/medication-form-codes", false)]
		public CodeableConcept doseForm { get; set; }

		public Quantity amount { get; set; }

		public ICollection<StringElement> synonym { get; set; }

		public ICollection<RelatedMedicationKnowledgeComponent> relatedMedicationKnowledge { get; set; }

		public ICollection<Reference> associatedMedication { get; set; }

		public ICollection<CodeableConcept> productType { get; set; }

		public ICollection<MonographComponent> monograph { get; set; }

		public ICollection<IngredientComponent> ingredient { get; set; }

		public MarkdownElement preparationInstruction { get; set; }

		[ValueSetBinding("MedicationRoute", "http://hl7.org/fhir/ValueSet/route-codes", false)]
		public ICollection<CodeableConcept> intendedRoute { get; set; }

		public ICollection<CostComponent> cost { get; set; }

		public ICollection<MonitoringProgramComponent> monitoringProgram { get; set; }

		public ICollection<AdministrationGuidelinesComponent> administrationGuidelines { get; set; }

		public ICollection<MedicineClassificationComponent> medicineClassification { get; set; }

		public PackagingComponent packaging { get; set; }

		public ICollection<DrugCharacteristicComponent> drugCharacteristic { get; set; }

		public ICollection<Reference> contraindication { get; set; }

		public ICollection<RegulatoryComponent> regulatory { get; set; }

		public ICollection<KineticsComponent> kinetics { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/MedicationKnowledge.relatedMedicationKnowledge")]
		public partial class RelatedMedicationKnowledgeComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			public CodeableConcept type { get; set; }

			public ICollection<Reference> reference { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/MedicationKnowledge.monograph")]
		public partial class MonographComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public CodeableConcept type { get; set; }

			public Reference source { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/MedicationKnowledge.ingredient")]
		public partial class IngredientComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			[Choice(typeof(CodeableConcept))]
			[Choice(typeof(Reference))]
			[JsonIgnore]
			public Element item { get; set; }
			public CodeableConcept itemCodeableConcept { get => ChoiceAttribute.AsExactly<CodeableConcept>(item); set { item = value; } }
			public Reference itemReference { get => ChoiceAttribute.AsExactly<Reference>(item); set { item = value; } }

			public BooleanElement isActive { get; set; }

			public Ratio strength { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/MedicationKnowledge.cost")]
		public partial class CostComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			public CodeableConcept type { get; set; }

			public StringElement source { get; set; }

			[NotNull]
			public Money cost { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/MedicationKnowledge.monitoringProgram")]
		public partial class MonitoringProgramComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public CodeableConcept type { get; set; }

			public StringElement name { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/MedicationKnowledge.administrationGuidelines")]
		public partial class AdministrationGuidelinesComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public ICollection<DosageComponent> dosage { get; set; }

			[Choice(typeof(CodeableConcept))]
			[Choice(typeof(Reference))]
			[JsonIgnore]
			public Element indication { get; set; }
			public CodeableConcept indicationCodeableConcept { get => ChoiceAttribute.AsExactly<CodeableConcept>(indication); set { indication = value; } }
			public Reference indicationReference { get => ChoiceAttribute.AsExactly<Reference>(indication); set { indication = value; } }

			public ICollection<PatientCharacteristicsComponent> patientCharacteristics { get; set; }
			[FhirUri("http://hl7.org/fhir/StructureDefinition/MedicationKnowledge.administrationGuidelines.dosage")]
			public partial class DosageComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				[NotNull]
				public CodeableConcept type { get; set; }

				public ICollection<Dosage> dosage { get; set; }
			}
			[DebuggerDisplay("{value}")]
			[FhirUri("http://hl7.org/fhir/StructureDefinition/MedicationKnowledge.administrationGuidelines.patientCharacteristics")]
			public partial class PatientCharacteristicsComponent
			{

				public ICollection<StringElement> value { get; set; }

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				[NotNull]
				[Choice(typeof(CodeableConcept))]
				[Choice(typeof(Quantity))]
				[JsonIgnore]
				public Element characteristic { get; set; }
				public CodeableConcept characteristicCodeableConcept { get => ChoiceAttribute.AsExactly<CodeableConcept>(characteristic); set { characteristic = value; } }
				public Quantity characteristicQuantity { get => ChoiceAttribute.AsExactly<Quantity>(characteristic); set { characteristic = value; } }
			}
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/MedicationKnowledge.medicineClassification")]
		public partial class MedicineClassificationComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			public CodeableConcept type { get; set; }

			public ICollection<CodeableConcept> classification { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/MedicationKnowledge.packaging")]
		public partial class PackagingComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[ValueSetBinding("MedicationPackageType", "http://hl7.org/fhir/ValueSet/medicationknowledge-package-type", false)]
			public CodeableConcept type { get; set; }

			public Quantity quantity { get; set; }
		}
		[DebuggerDisplay("{value}")]
		[FhirUri("http://hl7.org/fhir/StructureDefinition/MedicationKnowledge.drugCharacteristic")]
		public partial class DrugCharacteristicComponent
		{

			[Choice(typeof(CodeableConcept))]
			[Choice(typeof(StringElement))]
			[Choice(typeof(Quantity))]
			[Choice(typeof(Base64BinaryElement))]
			[JsonIgnore]
			public Element value { get; set; }
			public CodeableConcept valueCodeableConcept { get => ChoiceAttribute.AsExactly<CodeableConcept>(value); set { this.value = value; } }
			public StringElement valueString { get => ChoiceAttribute.AsExactly<StringElement>(value); set { this.value = value; } }
			public Quantity valueQuantity { get => ChoiceAttribute.AsExactly<Quantity>(value); set { this.value = value; } }
			public Base64BinaryElement valueBase64Binary { get => ChoiceAttribute.AsExactly<Base64BinaryElement>(value); set { this.value = value; } }

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[ValueSetBinding("MedicationCharacteristic", "http://hl7.org/fhir/ValueSet/medicationknowledge-characteristic", false)]
			public CodeableConcept type { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/MedicationKnowledge.regulatory")]
		public partial class RegulatoryComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			public Reference regulatoryAuthority { get; set; }

			public ICollection<SubstitutionComponent> substitution { get; set; }

			public ICollection<ScheduleComponent> schedule { get; set; }

			public MaxDispenseComponent maxDispense { get; set; }
			[FhirUri("http://hl7.org/fhir/StructureDefinition/MedicationKnowledge.regulatory.substitution")]
			public partial class SubstitutionComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				[NotNull]
				public CodeableConcept type { get; set; }

				[NotNull]
				public BooleanElement allowed { get; set; }
			}
			[FhirUri("http://hl7.org/fhir/StructureDefinition/MedicationKnowledge.regulatory.schedule")]
			public partial class ScheduleComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				[NotNull]
				public CodeableConcept schedule { get; set; }
			}
			[FhirUri("http://hl7.org/fhir/StructureDefinition/MedicationKnowledge.regulatory.maxDispense")]
			public partial class MaxDispenseComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				[NotNull]
				public Quantity quantity { get; set; }

				public Duration period { get; set; }
			}
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/MedicationKnowledge.kinetics")]
		public partial class KineticsComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public ICollection<Quantity> areaUnderCurve { get; set; }

			public ICollection<Quantity> lethalDose50 { get; set; }

			public Duration halfLifePeriod { get; set; }
		}
	}
}

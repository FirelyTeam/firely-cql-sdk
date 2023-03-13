using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[FhirUri("http://hl7.org/fhir/StructureDefinition/MedicationAdministration")]
	public partial class MedicationAdministration : DomainResource
	{

		public ICollection<Identifier> identifier { get; set; }

		public ICollection<UriElement> instantiates { get; set; }

		public ICollection<Reference> partOf { get; set; }

		[NotNull]
		[ValueSetBinding("MedicationAdministrationStatus", "http://hl7.org/fhir/ValueSet/medication-admin-status%7C4.0.1", true)]
		public CodeElement status { get; set; }

		[ValueSetBinding("MedicationAdministrationNegationReason", "http://hl7.org/fhir/ValueSet/reason-medication-not-given-codes", false)]
		public ICollection<CodeableConcept> statusReason { get; set; }

		[ValueSetBinding("MedicationAdministrationCategory", "http://hl7.org/fhir/ValueSet/medication-admin-category", false)]
		public CodeableConcept category { get; set; }

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

		public Reference context { get; set; }

		public ICollection<Reference> supportingInformation { get; set; }

		[NotNull]
		[Choice(typeof(DateTimeElement))]
		[Choice(typeof(Period))]
		[JsonIgnore]
		public Element effective { get; set; }
		public DateTimeElement effectiveDateTime { get => ChoiceAttribute.AsExactly<DateTimeElement>(effective); set { effective = value; } }
		public Period effectivePeriod { get => ChoiceAttribute.AsExactly<Period>(effective); set { effective = value; } }

		public ICollection<PerformerComponent> performer { get; set; }

		[ValueSetBinding("MedicationAdministrationReason", "http://hl7.org/fhir/ValueSet/reason-medication-given-codes", false)]
		public ICollection<CodeableConcept> reasonCode { get; set; }

		public ICollection<Reference> reasonReference { get; set; }

		public Reference request { get; set; }

		public ICollection<Reference> device { get; set; }

		public ICollection<Annotation> note { get; set; }

		public DosageComponent dosage { get; set; }

		public ICollection<Reference> eventHistory { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/MedicationAdministration.performer")]
		public partial class PerformerComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[ValueSetBinding("MedicationAdministrationPerformerFunction", "http://hl7.org/fhir/ValueSet/med-admin-perform-function", false)]
			public CodeableConcept function { get; set; }

			[NotNull]
			public Reference actor { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/MedicationAdministration.dosage")]
		public partial class DosageComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public StringElement text { get; set; }

			[ValueSetBinding("MedicationAdministrationSite", "http://hl7.org/fhir/ValueSet/approach-site-codes", false)]
			public CodeableConcept site { get; set; }

			[ValueSetBinding("RouteOfAdministration", "http://hl7.org/fhir/ValueSet/route-codes", false)]
			public CodeableConcept route { get; set; }

			[ValueSetBinding("MedicationAdministrationMethod", "http://hl7.org/fhir/ValueSet/administration-method-codes", false)]
			public CodeableConcept method { get; set; }

			public Quantity dose { get; set; }

			[Choice(typeof(Ratio))]
			[Choice(typeof(Quantity))]
			[JsonIgnore]
			public Element rate { get; set; }
			public Ratio rateRatio { get => ChoiceAttribute.AsExactly<Ratio>(rate); set { rate = value; } }
			public Quantity rateQuantity { get => ChoiceAttribute.AsExactly<Quantity>(rate); set { rate = value; } }
		}
	}
}

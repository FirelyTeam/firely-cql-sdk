using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[FhirUri("http://hl7.org/fhir/StructureDefinition/MedicationStatement")]
	public partial class MedicationStatement : DomainResource
	{

		public ICollection<Identifier> identifier { get; set; }

		public ICollection<Reference> basedOn { get; set; }

		public ICollection<Reference> partOf { get; set; }

		[NotNull]
		[ValueSetBinding("MedicationStatementStatus", "http://hl7.org/fhir/ValueSet/medication-statement-status%7C4.0.1", true)]
		public CodeElement status { get; set; }

		[ValueSetBinding("MedicationStatementStatusReason", "http://hl7.org/fhir/ValueSet/reason-medication-status-codes", false)]
		public ICollection<CodeableConcept> statusReason { get; set; }

		[ValueSetBinding("MedicationStatementCategory", "http://hl7.org/fhir/ValueSet/medication-statement-category", false)]
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

		[Choice(typeof(DateTimeElement))]
		[Choice(typeof(Period))]
		[JsonIgnore]
		public Element effective { get; set; }
		public DateTimeElement effectiveDateTime { get => ChoiceAttribute.AsExactly<DateTimeElement>(effective); set { effective = value; } }
		public Period effectivePeriod { get => ChoiceAttribute.AsExactly<Period>(effective); set { effective = value; } }

		public DateTimeElement dateAsserted { get; set; }

		public Reference informationSource { get; set; }

		public ICollection<Reference> derivedFrom { get; set; }

		[ValueSetBinding("MedicationReason", "http://hl7.org/fhir/ValueSet/condition-code", false)]
		public ICollection<CodeableConcept> reasonCode { get; set; }

		public ICollection<Reference> reasonReference { get; set; }

		public ICollection<Annotation> note { get; set; }

		public ICollection<Dosage> dosage { get; set; }
	}
}

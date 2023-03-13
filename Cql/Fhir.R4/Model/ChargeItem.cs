using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[FhirUri("http://hl7.org/fhir/StructureDefinition/ChargeItem")]
	public partial class ChargeItem : DomainResource
	{

		public ICollection<Identifier> identifier { get; set; }

		public ICollection<UriElement> definitionUri { get; set; }

		public ICollection<CanonicalElement> definitionCanonical { get; set; }

		[NotNull]
		[ValueSetBinding("ChargeItemStatus", "http://hl7.org/fhir/ValueSet/chargeitem-status%7C4.0.1", true)]
		public CodeElement status { get; set; }

		public ICollection<Reference> partOf { get; set; }

		[NotNull]
		[ValueSetBinding("ChargeItemCode", "http://hl7.org/fhir/ValueSet/chargeitem-billingcodes", false)]
		public CodeableConcept code { get; set; }

		[NotNull]
		public Reference subject { get; set; }

		public Reference context { get; set; }

		[Choice(typeof(DateTimeElement))]
		[Choice(typeof(Period))]
		[Choice(typeof(Timing))]
		[JsonIgnore]
		public Element occurrence { get; set; }
		public DateTimeElement occurrenceDateTime { get => ChoiceAttribute.AsExactly<DateTimeElement>(occurrence); set { occurrence = value; } }
		public Period occurrencePeriod { get => ChoiceAttribute.AsExactly<Period>(occurrence); set { occurrence = value; } }
		public Timing occurrenceTiming { get => ChoiceAttribute.AsExactly<Timing>(occurrence); set { occurrence = value; } }

		public ICollection<PerformerComponent> performer { get; set; }

		public Reference performingOrganization { get; set; }

		public Reference requestingOrganization { get; set; }

		public Reference costCenter { get; set; }

		public Quantity quantity { get; set; }

		[ValueSetBinding("BodySite", "http://hl7.org/fhir/ValueSet/body-site", false)]
		public ICollection<CodeableConcept> bodysite { get; set; }

		public DecimalElement factorOverride { get; set; }

		public Money priceOverride { get; set; }

		public StringElement overrideReason { get; set; }

		public Reference enterer { get; set; }

		public DateTimeElement enteredDate { get; set; }

		[ValueSetBinding("ChargeItemReason", "http://hl7.org/fhir/ValueSet/icd-10", false)]
		public ICollection<CodeableConcept> reason { get; set; }

		public ICollection<Reference> service { get; set; }

		[Choice(typeof(Reference))]
		[Choice(typeof(CodeableConcept))]
		[JsonIgnore]
		[ValueSetBinding("ChargeItemProduct", "http://hl7.org/fhir/ValueSet/device-kind", false)]
		public Element product { get; set; }
		public Reference productReference { get => ChoiceAttribute.AsExactly<Reference>(product); set { product = value; } }
		public CodeableConcept productCodeableConcept { get => ChoiceAttribute.AsExactly<CodeableConcept>(product); set { product = value; } }

		public ICollection<Reference> account { get; set; }

		public ICollection<Annotation> note { get; set; }

		public ICollection<Reference> supportingInformation { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/ChargeItem.performer")]
		public partial class PerformerComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[ValueSetBinding("ChargeItemPerformerFunction", "http://hl7.org/fhir/ValueSet/performer-role", false)]
			public CodeableConcept function { get; set; }

			[NotNull]
			public Reference actor { get; set; }
		}
	}
}

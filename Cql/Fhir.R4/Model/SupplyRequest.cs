using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[FhirUri("http://hl7.org/fhir/StructureDefinition/SupplyRequest")]
	public partial class SupplyRequest : DomainResource
	{

		public ICollection<Identifier> identifier { get; set; }

		[ValueSetBinding("SupplyRequestStatus", "http://hl7.org/fhir/ValueSet/supplyrequest-status%7C4.0.1", true)]
		public CodeElement status { get; set; }

		[ValueSetBinding("SupplyRequestKind", "http://hl7.org/fhir/ValueSet/supplyrequest-kind", false)]
		public CodeableConcept category { get; set; }

		[ValueSetBinding("RequestPriority", "http://hl7.org/fhir/ValueSet/request-priority%7C4.0.1", true)]
		public CodeElement priority { get; set; }

		[NotNull]
		[Choice(typeof(CodeableConcept))]
		[Choice(typeof(Reference))]
		[JsonIgnore]
		[ValueSetBinding("SupplyRequestItem", "http://hl7.org/fhir/ValueSet/supply-item", false)]
		public Element item { get; set; }
		public CodeableConcept itemCodeableConcept { get => ChoiceAttribute.AsExactly<CodeableConcept>(item); set { item = value; } }
		public Reference itemReference { get => ChoiceAttribute.AsExactly<Reference>(item); set { item = value; } }

		[NotNull]
		public Quantity quantity { get; set; }

		public ICollection<ParameterComponent> parameter { get; set; }

		[Choice(typeof(DateTimeElement))]
		[Choice(typeof(Period))]
		[Choice(typeof(Timing))]
		[JsonIgnore]
		public Element occurrence { get; set; }
		public DateTimeElement occurrenceDateTime { get => ChoiceAttribute.AsExactly<DateTimeElement>(occurrence); set { occurrence = value; } }
		public Period occurrencePeriod { get => ChoiceAttribute.AsExactly<Period>(occurrence); set { occurrence = value; } }
		public Timing occurrenceTiming { get => ChoiceAttribute.AsExactly<Timing>(occurrence); set { occurrence = value; } }

		public DateTimeElement authoredOn { get; set; }

		public Reference requester { get; set; }

		public ICollection<Reference> supplier { get; set; }

		[ValueSetBinding("SupplyRequestReason", "http://hl7.org/fhir/ValueSet/supplyrequest-reason", false)]
		public ICollection<CodeableConcept> reasonCode { get; set; }

		public ICollection<Reference> reasonReference { get; set; }

		public Reference deliverFrom { get; set; }

		public Reference deliverTo { get; set; }
		[DebuggerDisplay("{value}")]
		[FhirUri("http://hl7.org/fhir/StructureDefinition/SupplyRequest.parameter")]
		public partial class ParameterComponent
		{

			[Choice(typeof(CodeableConcept))]
			[Choice(typeof(Quantity))]
			[Choice(typeof(Range))]
			[Choice(typeof(BooleanElement))]
			[JsonIgnore]
			public Element value { get; set; }
			public CodeableConcept valueCodeableConcept { get => ChoiceAttribute.AsExactly<CodeableConcept>(value); set { this.value = value; } }
			public Quantity valueQuantity { get => ChoiceAttribute.AsExactly<Quantity>(value); set { this.value = value; } }
			public Range valueRange { get => ChoiceAttribute.AsExactly<Range>(value); set { this.value = value; } }
			public BooleanElement valueBoolean { get => ChoiceAttribute.AsExactly<BooleanElement>(value); set { this.value = value; } }

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public CodeableConcept code { get; set; }
		}
	}
}

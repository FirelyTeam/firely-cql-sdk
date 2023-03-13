using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[FhirUri("http://hl7.org/fhir/StructureDefinition/SupplyDelivery")]
	public partial class SupplyDelivery : DomainResource
	{

		public ICollection<Identifier> identifier { get; set; }

		public ICollection<Reference> basedOn { get; set; }

		public ICollection<Reference> partOf { get; set; }

		[ValueSetBinding("SupplyDeliveryStatus", "http://hl7.org/fhir/ValueSet/supplydelivery-status%7C4.0.1", true)]
		public CodeElement status { get; set; }

		public Reference patient { get; set; }

		[ValueSetBinding("SupplyDeliveryType", "http://hl7.org/fhir/ValueSet/supplydelivery-type%7C4.0.1", true)]
		public CodeableConcept type { get; set; }

		public SuppliedItemComponent suppliedItem { get; set; }

		[Choice(typeof(DateTimeElement))]
		[Choice(typeof(Period))]
		[Choice(typeof(Timing))]
		[JsonIgnore]
		public Element occurrence { get; set; }
		public DateTimeElement occurrenceDateTime { get => ChoiceAttribute.AsExactly<DateTimeElement>(occurrence); set { occurrence = value; } }
		public Period occurrencePeriod { get => ChoiceAttribute.AsExactly<Period>(occurrence); set { occurrence = value; } }
		public Timing occurrenceTiming { get => ChoiceAttribute.AsExactly<Timing>(occurrence); set { occurrence = value; } }

		public Reference supplier { get; set; }

		public Reference destination { get; set; }

		public ICollection<Reference> receiver { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/SupplyDelivery.suppliedItem")]
		public partial class SuppliedItemComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public Quantity quantity { get; set; }

			[Choice(typeof(CodeableConcept))]
			[Choice(typeof(Reference))]
			[JsonIgnore]
			[ValueSetBinding("SupplyDeliveryItem", "http://hl7.org/fhir/ValueSet/supply-item", false)]
			public Element item { get; set; }
			public CodeableConcept itemCodeableConcept { get => ChoiceAttribute.AsExactly<CodeableConcept>(item); set { item = value; } }
			public Reference itemReference { get => ChoiceAttribute.AsExactly<Reference>(item); set { item = value; } }
		}
	}
}

using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[FhirUri("http://hl7.org/fhir/StructureDefinition/Invoice")]
	public partial class Invoice : DomainResource
	{

		public ICollection<Identifier> identifier { get; set; }

		[NotNull]
		[ValueSetBinding("InvoiceStatus", "http://hl7.org/fhir/ValueSet/invoice-status%7C4.0.1", true)]
		public CodeElement status { get; set; }

		public StringElement cancelledReason { get; set; }

		public CodeableConcept type { get; set; }

		public Reference subject { get; set; }

		public Reference recipient { get; set; }

		public DateTimeElement date { get; set; }

		public ICollection<ParticipantComponent> participant { get; set; }

		public Reference issuer { get; set; }

		public Reference account { get; set; }

		public ICollection<LineItemComponent> lineItem { get; set; }

		public Money totalNet { get; set; }

		public Money totalGross { get; set; }

		public MarkdownElement paymentTerms { get; set; }

		public ICollection<Annotation> note { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/Invoice.participant")]
		public partial class ParticipantComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public CodeableConcept role { get; set; }

			[NotNull]
			public Reference actor { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/Invoice.lineItem")]
		public partial class LineItemComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public PositiveIntElement sequence { get; set; }

			[NotNull]
			[Choice(typeof(Reference))]
			[Choice(typeof(CodeableConcept))]
			[JsonIgnore]
			public Element chargeItem { get; set; }
			public Reference chargeItemReference { get => ChoiceAttribute.AsExactly<Reference>(chargeItem); set { chargeItem = value; } }
			public CodeableConcept chargeItemCodeableConcept { get => ChoiceAttribute.AsExactly<CodeableConcept>(chargeItem); set { chargeItem = value; } }

			public ICollection<PriceComponentComponent> priceComponent { get; set; }
			[FhirUri("http://hl7.org/fhir/StructureDefinition/Invoice.lineItem.priceComponent")]
			public partial class PriceComponentComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				[NotNull]
				[ValueSetBinding("InvoicePriceComponentType", "http://hl7.org/fhir/ValueSet/invoice-priceComponentType%7C4.0.1", true)]
				public CodeElement type { get; set; }

				public CodeableConcept code { get; set; }

				public DecimalElement factor { get; set; }

				public Money amount { get; set; }
			}
		}
	}
}

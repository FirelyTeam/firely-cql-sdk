using Hl7.Cql.Poco.Fhir;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Hl7.Cql.Poco.Fhir.R4.Model
{
    [FhirUri("http://hl7.org/fhir/StructureDefinition/ClaimResponse")]
	public partial class ClaimResponse : DomainResource
	{

		public ICollection<Identifier> identifier { get; set; }

		[NotNull]
		[ValueSetBinding("ClaimResponseStatus", "http://hl7.org/fhir/ValueSet/fm-status%7C4.0.1", true)]
		public CodeElement status { get; set; }

		[NotNull]
		[ValueSetBinding("ClaimType", "http://hl7.org/fhir/ValueSet/claim-type", false)]
		public CodeableConcept type { get; set; }

		[ValueSetBinding("ClaimSubType", "http://hl7.org/fhir/ValueSet/claim-subtype", false)]
		public CodeableConcept subType { get; set; }

		[NotNull]
		[ValueSetBinding("Use", "http://hl7.org/fhir/ValueSet/claim-use%7C4.0.1", true)]
		public CodeElement use { get; set; }

		[NotNull]
		public Reference patient { get; set; }

		[NotNull]
		public DateTimeElement created { get; set; }

		[NotNull]
		public Reference insurer { get; set; }

		public Reference requestor { get; set; }

		public Reference request { get; set; }

		[NotNull]
		[ValueSetBinding("RemittanceOutcome", "http://hl7.org/fhir/ValueSet/remittance-outcome%7C4.0.1", true)]
		public CodeElement outcome { get; set; }

		public StringElement disposition { get; set; }

		public StringElement preAuthRef { get; set; }

		public Period preAuthPeriod { get; set; }

		[ValueSetBinding("PayeeType", "http://hl7.org/fhir/ValueSet/payeetype", false)]
		public CodeableConcept payeeType { get; set; }

		public ICollection<ItemComponent> item { get; set; }

		public ICollection<AddItemComponent> addItem { get; set; }

		public ICollection<TotalComponent> total { get; set; }

		public PaymentComponent payment { get; set; }

		[ValueSetBinding("FundsReserve", "http://hl7.org/fhir/ValueSet/fundsreserve", false)]
		public CodeableConcept fundsReserve { get; set; }

		[ValueSetBinding("Forms", "http://hl7.org/fhir/ValueSet/forms", false)]
		public CodeableConcept formCode { get; set; }

		public Attachment form { get; set; }

		public ICollection<ProcessNoteComponent> processNote { get; set; }

		public ICollection<Reference> communicationRequest { get; set; }

		public ICollection<InsuranceComponent> insurance { get; set; }

		public ICollection<ErrorComponent> error { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/ClaimResponse.item")]
		public partial class ItemComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			public PositiveIntElement itemSequence { get; set; }

			public ICollection<PositiveIntElement> noteNumber { get; set; }

			public ICollection<AdjudicationComponent> adjudication { get; set; }

			public ICollection<DetailComponent> detail { get; set; }
			[DebuggerDisplay("{value}")]
			[FhirUri("http://hl7.org/fhir/StructureDefinition/ClaimResponse.item.adjudication")]
			public partial class AdjudicationComponent
			{

				public DecimalElement value { get; set; }

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				[NotNull]
				[ValueSetBinding("Adjudication", "http://hl7.org/fhir/ValueSet/adjudication", false)]
				public CodeableConcept category { get; set; }

				[ValueSetBinding("AdjudicationReason", "http://hl7.org/fhir/ValueSet/adjudication-reason", false)]
				public CodeableConcept reason { get; set; }

				public Money amount { get; set; }
			}
			[FhirUri("http://hl7.org/fhir/StructureDefinition/ClaimResponse.item.detail")]
			public partial class DetailComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				[NotNull]
				public PositiveIntElement detailSequence { get; set; }

				public ICollection<PositiveIntElement> noteNumber { get; set; }

				public ICollection<SubDetailComponent> subDetail { get; set; }
				[FhirUri("http://hl7.org/fhir/StructureDefinition/ClaimResponse.item.detail.subDetail")]
				public partial class SubDetailComponent
				{

					public string id { get; set; }

					public ICollection<Extension> extension { get; set; }

					public ICollection<Extension> modifierExtension { get; set; }

					[NotNull]
					public PositiveIntElement subDetailSequence { get; set; }

					public ICollection<PositiveIntElement> noteNumber { get; set; }
				}
			}
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/ClaimResponse.addItem")]
		public partial class AddItemComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public ICollection<PositiveIntElement> itemSequence { get; set; }

			public ICollection<PositiveIntElement> detailSequence { get; set; }

			public ICollection<PositiveIntElement> subdetailSequence { get; set; }

			public ICollection<Reference> provider { get; set; }

			[NotNull]
			[ValueSetBinding("ServiceProduct", "http://hl7.org/fhir/ValueSet/service-uscls", false)]
			public CodeableConcept productOrService { get; set; }

			[ValueSetBinding("Modifiers", "http://hl7.org/fhir/ValueSet/claim-modifiers", false)]
			public ICollection<CodeableConcept> modifier { get; set; }

			[ValueSetBinding("ProgramCode", "http://hl7.org/fhir/ValueSet/ex-program-code", false)]
			public ICollection<CodeableConcept> programCode { get; set; }

			[Choice(typeof(DateElement))]
			[Choice(typeof(Period))]
			[JsonIgnore]
			public Element serviced { get; set; }
			public DateElement servicedDate { get => ChoiceAttribute.AsExactly<DateElement>(serviced); set { serviced = value; } }
			public Period servicedPeriod { get => ChoiceAttribute.AsExactly<Period>(serviced); set { serviced = value; } }

			[Choice(typeof(CodeableConcept))]
			[Choice(typeof(Address))]
			[Choice(typeof(Reference))]
			[JsonIgnore]
			[ValueSetBinding("ServicePlace", "http://hl7.org/fhir/ValueSet/service-place", false)]
			public Element location { get; set; }
			public CodeableConcept locationCodeableConcept { get => ChoiceAttribute.AsExactly<CodeableConcept>(location); set { location = value; } }
			public Address locationAddress { get => ChoiceAttribute.AsExactly<Address>(location); set { location = value; } }
			public Reference locationReference { get => ChoiceAttribute.AsExactly<Reference>(location); set { location = value; } }

			public Quantity quantity { get; set; }

			public Money unitPrice { get; set; }

			public DecimalElement factor { get; set; }

			public Money net { get; set; }

			[ValueSetBinding("OralSites", "http://hl7.org/fhir/ValueSet/tooth", false)]
			public CodeableConcept bodySite { get; set; }

			[ValueSetBinding("Surface", "http://hl7.org/fhir/ValueSet/surface", false)]
			public ICollection<CodeableConcept> subSite { get; set; }

			public ICollection<PositiveIntElement> noteNumber { get; set; }

			public ICollection<DetailComponent> detail { get; set; }
			[FhirUri("http://hl7.org/fhir/StructureDefinition/ClaimResponse.addItem.detail")]
			public partial class DetailComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				[NotNull]
				[ValueSetBinding("ServiceProduct", "http://hl7.org/fhir/ValueSet/service-uscls", false)]
				public CodeableConcept productOrService { get; set; }

				[ValueSetBinding("Modifiers", "http://hl7.org/fhir/ValueSet/claim-modifiers", false)]
				public ICollection<CodeableConcept> modifier { get; set; }

				public Quantity quantity { get; set; }

				public Money unitPrice { get; set; }

				public DecimalElement factor { get; set; }

				public Money net { get; set; }

				public ICollection<PositiveIntElement> noteNumber { get; set; }

				public ICollection<SubDetailComponent> subDetail { get; set; }
				[FhirUri("http://hl7.org/fhir/StructureDefinition/ClaimResponse.addItem.detail.subDetail")]
				public partial class SubDetailComponent
				{

					public string id { get; set; }

					public ICollection<Extension> extension { get; set; }

					public ICollection<Extension> modifierExtension { get; set; }

					[NotNull]
					[ValueSetBinding("ServiceProduct", "http://hl7.org/fhir/ValueSet/service-uscls", false)]
					public CodeableConcept productOrService { get; set; }

					[ValueSetBinding("Modifiers", "http://hl7.org/fhir/ValueSet/claim-modifiers", false)]
					public ICollection<CodeableConcept> modifier { get; set; }

					public Quantity quantity { get; set; }

					public Money unitPrice { get; set; }

					public DecimalElement factor { get; set; }

					public Money net { get; set; }

					public ICollection<PositiveIntElement> noteNumber { get; set; }
				}
			}
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/ClaimResponse.total")]
		public partial class TotalComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			[ValueSetBinding("Adjudication", "http://hl7.org/fhir/ValueSet/adjudication", false)]
			public CodeableConcept category { get; set; }

			[NotNull]
			public Money amount { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/ClaimResponse.payment")]
		public partial class PaymentComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			[ValueSetBinding("PaymentType", "http://hl7.org/fhir/ValueSet/ex-paymenttype", false)]
			public CodeableConcept type { get; set; }

			public Money adjustment { get; set; }

			[ValueSetBinding("PaymentAdjustmentReason", "http://hl7.org/fhir/ValueSet/payment-adjustment-reason", false)]
			public CodeableConcept adjustmentReason { get; set; }

			public DateElement date { get; set; }

			[NotNull]
			public Money amount { get; set; }

			public Identifier identifier { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/ClaimResponse.processNote")]
		public partial class ProcessNoteComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public PositiveIntElement number { get; set; }

			[ValueSetBinding("NoteType", "http://hl7.org/fhir/ValueSet/note-type%7C4.0.1", true)]
			public CodeElement type { get; set; }

			[NotNull]
			public StringElement text { get; set; }

			[ValueSetBinding("Language", "http://hl7.org/fhir/ValueSet/languages", false)]
			public CodeableConcept language { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/ClaimResponse.insurance")]
		public partial class InsuranceComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			public PositiveIntElement sequence { get; set; }

			[NotNull]
			public BooleanElement focal { get; set; }

			[NotNull]
			public Reference coverage { get; set; }

			public StringElement businessArrangement { get; set; }

			public Reference claimResponse { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/ClaimResponse.error")]
		public partial class ErrorComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public PositiveIntElement itemSequence { get; set; }

			public PositiveIntElement detailSequence { get; set; }

			public PositiveIntElement subDetailSequence { get; set; }

			[NotNull]
			[ValueSetBinding("AdjudicationError", "http://hl7.org/fhir/ValueSet/adjudication-error", false)]
			public CodeableConcept code { get; set; }
		}
	}
}

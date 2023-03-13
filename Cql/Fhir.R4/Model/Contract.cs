using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[FhirUri("http://hl7.org/fhir/StructureDefinition/Contract")]
	public partial class Contract : DomainResource
	{

		public ICollection<Identifier> identifier { get; set; }

		public UriElement url { get; set; }

		public StringElement version { get; set; }

		[ValueSetBinding("ContractStatus", "http://hl7.org/fhir/ValueSet/contract-status%7C4.0.1", true)]
		public CodeElement status { get; set; }

		[ValueSetBinding("ContractLegalState", "http://hl7.org/fhir/ValueSet/contract-legalstate", false)]
		public CodeableConcept legalState { get; set; }

		public Reference instantiatesCanonical { get; set; }

		public UriElement instantiatesUri { get; set; }

		[ValueSetBinding("ContractContentDerivative", "http://hl7.org/fhir/ValueSet/contract-content-derivative", false)]
		public CodeableConcept contentDerivative { get; set; }

		public DateTimeElement issued { get; set; }

		public Period applies { get; set; }

		[ValueSetBinding("ContractExpiration", "http://hl7.org/fhir/ValueSet/contract-expiration-type", false)]
		public CodeableConcept expirationType { get; set; }

		public ICollection<Reference> subject { get; set; }

		public ICollection<Reference> authority { get; set; }

		public ICollection<Reference> domain { get; set; }

		public ICollection<Reference> site { get; set; }

		public StringElement name { get; set; }

		public StringElement title { get; set; }

		public StringElement subtitle { get; set; }

		public ICollection<StringElement> alias { get; set; }

		public Reference author { get; set; }

		[ValueSetBinding("ContractScope", "http://hl7.org/fhir/ValueSet/contract-scope", false)]
		public CodeableConcept scope { get; set; }

		[Choice(typeof(CodeableConcept))]
		[Choice(typeof(Reference))]
		[JsonIgnore]
		public Element topic { get; set; }
		public CodeableConcept topicCodeableConcept { get => ChoiceAttribute.AsExactly<CodeableConcept>(topic); set { topic = value; } }
		public Reference topicReference { get => ChoiceAttribute.AsExactly<Reference>(topic); set { topic = value; } }

		[ValueSetBinding("ContractType", "http://hl7.org/fhir/ValueSet/contract-type", false)]
		public CodeableConcept type { get; set; }

		[ValueSetBinding("ContractSubtype", "http://hl7.org/fhir/ValueSet/contract-subtype", false)]
		public ICollection<CodeableConcept> subType { get; set; }

		public ContentDefinitionComponent contentDefinition { get; set; }

		public ICollection<TermComponent> term { get; set; }

		public ICollection<Reference> supportingInfo { get; set; }

		public ICollection<Reference> relevantHistory { get; set; }

		public ICollection<SignerComponent> signer { get; set; }

		public ICollection<FriendlyComponent> friendly { get; set; }

		public ICollection<LegalComponent> legal { get; set; }

		public ICollection<RuleComponent> rule { get; set; }

		[Choice(typeof(Attachment))]
		[Choice(typeof(Reference))]
		[JsonIgnore]
		public Element legallyBinding { get; set; }
		public Attachment legallyBindingAttachment { get => ChoiceAttribute.AsExactly<Attachment>(legallyBinding); set { legallyBinding = value; } }
		public Reference legallyBindingReference { get => ChoiceAttribute.AsExactly<Reference>(legallyBinding); set { legallyBinding = value; } }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/Contract.contentDefinition")]
		public partial class ContentDefinitionComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			[ValueSetBinding("ContractDefinitionType", "http://hl7.org/fhir/ValueSet/contract-definition-type", false)]
			public CodeableConcept type { get; set; }

			[ValueSetBinding("ContractDefinitionSubtype", "http://hl7.org/fhir/ValueSet/contract-definition-subtype", false)]
			public CodeableConcept subType { get; set; }

			public Reference publisher { get; set; }

			public DateTimeElement publicationDate { get; set; }

			[NotNull]
			[ValueSetBinding("ContractPublicationStatus", "http://hl7.org/fhir/ValueSet/contract-publicationstatus%7C4.0.1", true)]
			public CodeElement publicationStatus { get; set; }

			public MarkdownElement copyright { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/Contract.term")]
		public partial class TermComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public Identifier identifier { get; set; }

			public DateTimeElement issued { get; set; }

			public Period applies { get; set; }

			[Choice(typeof(CodeableConcept))]
			[Choice(typeof(Reference))]
			[JsonIgnore]
			public Element topic { get; set; }
			public CodeableConcept topicCodeableConcept { get => ChoiceAttribute.AsExactly<CodeableConcept>(topic); set { topic = value; } }
			public Reference topicReference { get => ChoiceAttribute.AsExactly<Reference>(topic); set { topic = value; } }

			[ValueSetBinding("ContractTermType", "http://hl7.org/fhir/ValueSet/contract-term-type", false)]
			public CodeableConcept type { get; set; }

			[ValueSetBinding("ContractTermSubType", "http://hl7.org/fhir/ValueSet/contract-term-subtype", false)]
			public CodeableConcept subType { get; set; }

			public StringElement text { get; set; }

			public ICollection<SecurityLabelComponent> securityLabel { get; set; }

			[NotNull]
			public OfferComponent offer { get; set; }

			public ICollection<AssetComponent> asset { get; set; }

			public ICollection<ActionComponent> action { get; set; }
			[FhirUri("http://hl7.org/fhir/StructureDefinition/Contract.term.securityLabel")]
			public partial class SecurityLabelComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				public ICollection<UnsignedIntElement> number { get; set; }

				[NotNull]
				[ValueSetBinding("ContractSecurityClassification", "http://hl7.org/fhir/ValueSet/contract-security-classification", false)]
				public Coding classification { get; set; }

				[ValueSetBinding("ContractSecurityCategory", "http://hl7.org/fhir/ValueSet/contract-security-category", false)]
				public ICollection<Coding> category { get; set; }

				[ValueSetBinding("ContractSecurityControl", "http://hl7.org/fhir/ValueSet/contract-security-control", false)]
				public ICollection<Coding> control { get; set; }
			}
			[FhirUri("http://hl7.org/fhir/StructureDefinition/Contract.term.offer")]
			public partial class OfferComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				public ICollection<Identifier> identifier { get; set; }

				public ICollection<PartyComponent> party { get; set; }

				public Reference topic { get; set; }

				[ValueSetBinding("ContractTermType", "http://hl7.org/fhir/ValueSet/contract-term-type", false)]
				public CodeableConcept type { get; set; }

				[ValueSetBinding("ContractDecisionType", "http://terminology.hl7.org/ValueSet/v3-ActConsentDirective", false)]
				public CodeableConcept decision { get; set; }

				[ValueSetBinding("ContractDecisionMode", "http://hl7.org/fhir/ValueSet/contract-decision-mode", false)]
				public ICollection<CodeableConcept> decisionMode { get; set; }

				public ICollection<AnswerComponent> answer { get; set; }

				public StringElement text { get; set; }

				public ICollection<StringElement> linkId { get; set; }

				public ICollection<UnsignedIntElement> securityLabelNumber { get; set; }
				[FhirUri("http://hl7.org/fhir/StructureDefinition/Contract.term.offer.party")]
				public partial class PartyComponent
				{

					public string id { get; set; }

					public ICollection<Extension> extension { get; set; }

					public ICollection<Extension> modifierExtension { get; set; }

					public ICollection<Reference> reference { get; set; }

					[NotNull]
					[ValueSetBinding("ContractPartyRole", "http://hl7.org/fhir/ValueSet/contract-party-role", false)]
					public CodeableConcept role { get; set; }
				}
				[DebuggerDisplay("{value}")]
				[FhirUri("http://hl7.org/fhir/StructureDefinition/Contract.term.offer.answer")]
				public partial class AnswerComponent
				{

					[NotNull]
					[Choice(typeof(BooleanElement))]
					[Choice(typeof(DecimalElement))]
					[Choice(typeof(IntegerElement))]
					[Choice(typeof(DateElement))]
					[Choice(typeof(DateTimeElement))]
					[Choice(typeof(TimeElement))]
					[Choice(typeof(StringElement))]
					[Choice(typeof(UriElement))]
					[Choice(typeof(Attachment))]
					[Choice(typeof(Coding))]
					[Choice(typeof(Quantity))]
					[Choice(typeof(Reference))]
					[JsonIgnore]
					public Element value { get; set; }
					public BooleanElement valueBoolean { get => ChoiceAttribute.AsExactly<BooleanElement>(value); set { this.value = value; } }
					public DecimalElement valueDecimal { get => ChoiceAttribute.AsExactly<DecimalElement>(value); set { this.value = value; } }
					public IntegerElement valueInteger { get => ChoiceAttribute.AsExactly<IntegerElement>(value); set { this.value = value; } }
					public DateElement valueDate { get => ChoiceAttribute.AsExactly<DateElement>(value); set { this.value = value; } }
					public DateTimeElement valueDateTime { get => ChoiceAttribute.AsExactly<DateTimeElement>(value); set { this.value = value; } }
					public TimeElement valueTime { get => ChoiceAttribute.AsExactly<TimeElement>(value); set { this.value = value; } }
					public StringElement valueString { get => ChoiceAttribute.AsExactly<StringElement>(value); set { this.value = value; } }
					public UriElement valueUri { get => ChoiceAttribute.AsExactly<UriElement>(value); set { this.value = value; } }
					public Attachment valueAttachment { get => ChoiceAttribute.AsExactly<Attachment>(value); set { this.value = value; } }
					public Coding valueCoding { get => ChoiceAttribute.AsExactly<Coding>(value); set { this.value = value; } }
					public Quantity valueQuantity { get => ChoiceAttribute.AsExactly<Quantity>(value); set { this.value = value; } }
					public Reference valueReference { get => ChoiceAttribute.AsExactly<Reference>(value); set { this.value = value; } }

					public string id { get; set; }

					public ICollection<Extension> extension { get; set; }

					public ICollection<Extension> modifierExtension { get; set; }
				}
			}
			[FhirUri("http://hl7.org/fhir/StructureDefinition/Contract.term.asset")]
			public partial class AssetComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				[ValueSetBinding("ContractAssetScope", "http://hl7.org/fhir/ValueSet/contract-assetscope", false)]
				public CodeableConcept scope { get; set; }

				[ValueSetBinding("ContractAssetType", "http://hl7.org/fhir/ValueSet/contract-assettype", false)]
				public ICollection<CodeableConcept> type { get; set; }

				public ICollection<Reference> typeReference { get; set; }

				[ValueSetBinding("ContractAssetSubtype", "http://hl7.org/fhir/ValueSet/contract-assetsubtype", false)]
				public ICollection<CodeableConcept> subtype { get; set; }

				[ValueSetBinding("ConsentContentClass", "http://hl7.org/fhir/ValueSet/consent-content-class", false)]
				public Coding relationship { get; set; }

				public ICollection<ContextComponent> context { get; set; }

				public StringElement condition { get; set; }

				[ValueSetBinding("AssetAvailabilityType", "http://hl7.org/fhir/ValueSet/asset-availability", false)]
				public ICollection<CodeableConcept> periodType { get; set; }

				public ICollection<Period> period { get; set; }

				public ICollection<Period> usePeriod { get; set; }

				public StringElement text { get; set; }

				public ICollection<StringElement> linkId { get; set; }

				public ICollection<UnsignedIntElement> securityLabelNumber { get; set; }

				public ICollection<ValuedItemComponent> valuedItem { get; set; }
				[FhirUri("http://hl7.org/fhir/StructureDefinition/Contract.term.asset.context")]
				public partial class ContextComponent
				{

					public string id { get; set; }

					public ICollection<Extension> extension { get; set; }

					public ICollection<Extension> modifierExtension { get; set; }

					public Reference reference { get; set; }

					[ValueSetBinding("ContractAssetContext", "http://hl7.org/fhir/ValueSet/contract-assetcontext", false)]
					public ICollection<CodeableConcept> code { get; set; }

					public StringElement text { get; set; }
				}
				[FhirUri("http://hl7.org/fhir/StructureDefinition/Contract.term.asset.valuedItem")]
				public partial class ValuedItemComponent
				{

					public string id { get; set; }

					public ICollection<Extension> extension { get; set; }

					public ICollection<Extension> modifierExtension { get; set; }

					[Choice(typeof(CodeableConcept))]
					[Choice(typeof(Reference))]
					[JsonIgnore]
					public Element entity { get; set; }
					public CodeableConcept entityCodeableConcept { get => ChoiceAttribute.AsExactly<CodeableConcept>(entity); set { entity = value; } }
					public Reference entityReference { get => ChoiceAttribute.AsExactly<Reference>(entity); set { entity = value; } }

					public Identifier identifier { get; set; }

					public DateTimeElement effectiveTime { get; set; }

					public Quantity quantity { get; set; }

					public Money unitPrice { get; set; }

					public DecimalElement factor { get; set; }

					public DecimalElement points { get; set; }

					public Money net { get; set; }

					public StringElement payment { get; set; }

					public DateTimeElement paymentDate { get; set; }

					public Reference responsible { get; set; }

					public Reference recipient { get; set; }

					public ICollection<StringElement> linkId { get; set; }

					public ICollection<UnsignedIntElement> securityLabelNumber { get; set; }
				}
			}
			[FhirUri("http://hl7.org/fhir/StructureDefinition/Contract.term.action")]
			public partial class ActionComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				public BooleanElement doNotPerform { get; set; }

				[NotNull]
				[ValueSetBinding("ContractAction", "http://hl7.org/fhir/ValueSet/contract-action", false)]
				public CodeableConcept type { get; set; }

				public ICollection<SubjectComponent> subject { get; set; }

				[NotNull]
				[ValueSetBinding("ContractActionReason", "http://terminology.hl7.org/ValueSet/v3-PurposeOfUse", false)]
				public CodeableConcept intent { get; set; }

				public ICollection<StringElement> linkId { get; set; }

				[NotNull]
				[ValueSetBinding("ContractActionStatus", "http://hl7.org/fhir/ValueSet/contract-actionstatus", false)]
				public CodeableConcept status { get; set; }

				public Reference context { get; set; }

				public ICollection<StringElement> contextLinkId { get; set; }

				[Choice(typeof(DateTimeElement))]
				[Choice(typeof(Period))]
				[Choice(typeof(Timing))]
				[JsonIgnore]
				public Element occurrence { get; set; }
				public DateTimeElement occurrenceDateTime { get => ChoiceAttribute.AsExactly<DateTimeElement>(occurrence); set { occurrence = value; } }
				public Period occurrencePeriod { get => ChoiceAttribute.AsExactly<Period>(occurrence); set { occurrence = value; } }
				public Timing occurrenceTiming { get => ChoiceAttribute.AsExactly<Timing>(occurrence); set { occurrence = value; } }

				public ICollection<Reference> requester { get; set; }

				public ICollection<StringElement> requesterLinkId { get; set; }

				[ValueSetBinding("ContractActionPerformerType", "http://hl7.org/fhir/ValueSet/provenance-agent-type", false)]
				public ICollection<CodeableConcept> performerType { get; set; }

				[ValueSetBinding("ContractActionPerformerRole", "http://hl7.org/fhir/ValueSet/provenance-agent-role", false)]
				public CodeableConcept performerRole { get; set; }

				public Reference performer { get; set; }

				public ICollection<StringElement> performerLinkId { get; set; }

				[ValueSetBinding("ContractActionReason", "http://terminology.hl7.org/ValueSet/v3-PurposeOfUse", false)]
				public ICollection<CodeableConcept> reasonCode { get; set; }

				public ICollection<Reference> reasonReference { get; set; }

				public ICollection<StringElement> reason { get; set; }

				public ICollection<StringElement> reasonLinkId { get; set; }

				public ICollection<Annotation> note { get; set; }

				public ICollection<UnsignedIntElement> securityLabelNumber { get; set; }
				[FhirUri("http://hl7.org/fhir/StructureDefinition/Contract.term.action.subject")]
				public partial class SubjectComponent
				{

					public string id { get; set; }

					public ICollection<Extension> extension { get; set; }

					public ICollection<Extension> modifierExtension { get; set; }

					public ICollection<Reference> reference { get; set; }

					[ValueSetBinding("ContractActorRole", "http://hl7.org/fhir/ValueSet/contract-actorrole", false)]
					public CodeableConcept role { get; set; }
				}
			}
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/Contract.signer")]
		public partial class SignerComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			[ValueSetBinding("ContractSignerType", "http://hl7.org/fhir/ValueSet/contract-signer-type", false)]
			public Coding type { get; set; }

			[NotNull]
			public Reference party { get; set; }

			public ICollection<Signature> signature { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/Contract.friendly")]
		public partial class FriendlyComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			[Choice(typeof(Attachment))]
			[Choice(typeof(Reference))]
			[JsonIgnore]
			public Element content { get; set; }
			public Attachment contentAttachment { get => ChoiceAttribute.AsExactly<Attachment>(content); set { content = value; } }
			public Reference contentReference { get => ChoiceAttribute.AsExactly<Reference>(content); set { content = value; } }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/Contract.legal")]
		public partial class LegalComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			[Choice(typeof(Attachment))]
			[Choice(typeof(Reference))]
			[JsonIgnore]
			public Element content { get; set; }
			public Attachment contentAttachment { get => ChoiceAttribute.AsExactly<Attachment>(content); set { content = value; } }
			public Reference contentReference { get => ChoiceAttribute.AsExactly<Reference>(content); set { content = value; } }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/Contract.rule")]
		public partial class RuleComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			[Choice(typeof(Attachment))]
			[Choice(typeof(Reference))]
			[JsonIgnore]
			public Element content { get; set; }
			public Attachment contentAttachment { get => ChoiceAttribute.AsExactly<Attachment>(content); set { content = value; } }
			public Reference contentReference { get => ChoiceAttribute.AsExactly<Reference>(content); set { content = value; } }
		}
	}
}

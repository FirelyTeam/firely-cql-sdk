using Hl7.Cql.Poco.Fhir;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Hl7.Cql.Poco.Fhir.R4.Model
{
    [FhirUri("http://hl7.org/fhir/StructureDefinition/ExplanationOfBenefit")]
	public partial class ExplanationOfBenefit : DomainResource
	{

		public ICollection<Identifier> identifier { get; set; }

		[NotNull]
		[ValueSetBinding("ExplanationOfBenefitStatus", "http://hl7.org/fhir/ValueSet/explanationofbenefit-status%7C4.0.1", true)]
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

		public Period billablePeriod { get; set; }

		[NotNull]
		public DateTimeElement created { get; set; }

		public Reference enterer { get; set; }

		[NotNull]
		public Reference insurer { get; set; }

		[NotNull]
		public Reference provider { get; set; }

		[ValueSetBinding("ProcessPriority", "http://terminology.hl7.org/CodeSystem/processpriority", false)]
		public CodeableConcept priority { get; set; }

		[ValueSetBinding("FundsReserve", "http://hl7.org/fhir/ValueSet/fundsreserve", false)]
		public CodeableConcept fundsReserveRequested { get; set; }

		[ValueSetBinding("FundsReserve", "http://hl7.org/fhir/ValueSet/fundsreserve", false)]
		public CodeableConcept fundsReserve { get; set; }

		public ICollection<RelatedComponent> related { get; set; }

		public Reference prescription { get; set; }

		public Reference originalPrescription { get; set; }

		public PayeeComponent payee { get; set; }

		public Reference referral { get; set; }

		public Reference facility { get; set; }

		public Reference claim { get; set; }

		public Reference claimResponse { get; set; }

		[NotNull]
		[ValueSetBinding("RemittanceOutcome", "http://hl7.org/fhir/ValueSet/remittance-outcome%7C4.0.1", true)]
		public CodeElement outcome { get; set; }

		public StringElement disposition { get; set; }

		public ICollection<StringElement> preAuthRef { get; set; }

		public ICollection<Period> preAuthRefPeriod { get; set; }

		public ICollection<CareTeamComponent> careTeam { get; set; }

		public ICollection<SupportingInfoComponent> supportingInfo { get; set; }

		public ICollection<DiagnosisComponent> diagnosis { get; set; }

		public ICollection<ProcedureComponent> procedure { get; set; }

		public PositiveIntElement precedence { get; set; }

		public ICollection<InsuranceComponent> insurance { get; set; }

		public AccidentComponent accident { get; set; }

		public ICollection<ItemComponent> item { get; set; }

		public ICollection<AddItemComponent> addItem { get; set; }

		public ICollection<TotalComponent> total { get; set; }

		public PaymentComponent payment { get; set; }

		[ValueSetBinding("Forms", "http://hl7.org/fhir/ValueSet/forms", false)]
		public CodeableConcept formCode { get; set; }

		public Attachment form { get; set; }

		public ICollection<ProcessNoteComponent> processNote { get; set; }

		public Period benefitPeriod { get; set; }

		public ICollection<BenefitBalanceComponent> benefitBalance { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/ExplanationOfBenefit.related")]
		public partial class RelatedComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public Reference claim { get; set; }

			[ValueSetBinding("RelatedClaimRelationship", "http://hl7.org/fhir/ValueSet/related-claim-relationship", false)]
			public CodeableConcept relationship { get; set; }

			public Identifier reference { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/ExplanationOfBenefit.payee")]
		public partial class PayeeComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[ValueSetBinding("PayeeType", "http://hl7.org/fhir/ValueSet/payeetype", false)]
			public CodeableConcept type { get; set; }

			public Reference party { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/ExplanationOfBenefit.careTeam")]
		public partial class CareTeamComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			public PositiveIntElement sequence { get; set; }

			[NotNull]
			public Reference provider { get; set; }

			public BooleanElement responsible { get; set; }

			[ValueSetBinding("CareTeamRole", "http://hl7.org/fhir/ValueSet/claim-careteamrole", false)]
			public CodeableConcept role { get; set; }

			[ValueSetBinding("ProviderQualification", "http://hl7.org/fhir/ValueSet/provider-qualification", false)]
			public CodeableConcept qualification { get; set; }
		}
		[DebuggerDisplay("{value}")]
		[FhirUri("http://hl7.org/fhir/StructureDefinition/ExplanationOfBenefit.supportingInfo")]
		public partial class SupportingInfoComponent
		{

			[Choice(typeof(BooleanElement))]
			[Choice(typeof(StringElement))]
			[Choice(typeof(Quantity))]
			[Choice(typeof(Attachment))]
			[Choice(typeof(Reference))]
			[JsonIgnore]
			public Element value { get; set; }
			public BooleanElement valueBoolean { get => ChoiceAttribute.AsExactly<BooleanElement>(value); set { this.value = value; } }
			public StringElement valueString { get => ChoiceAttribute.AsExactly<StringElement>(value); set { this.value = value; } }
			public Quantity valueQuantity { get => ChoiceAttribute.AsExactly<Quantity>(value); set { this.value = value; } }
			public Attachment valueAttachment { get => ChoiceAttribute.AsExactly<Attachment>(value); set { this.value = value; } }
			public Reference valueReference { get => ChoiceAttribute.AsExactly<Reference>(value); set { this.value = value; } }

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			public PositiveIntElement sequence { get; set; }

			[NotNull]
			[ValueSetBinding("InformationCategory", "http://hl7.org/fhir/ValueSet/claim-informationcategory", false)]
			public CodeableConcept category { get; set; }

			[ValueSetBinding("InformationCode", "http://hl7.org/fhir/ValueSet/claim-exception", false)]
			public CodeableConcept code { get; set; }

			[Choice(typeof(DateElement))]
			[Choice(typeof(Period))]
			[JsonIgnore]
			public Element timing { get; set; }
			public DateElement timingDate { get => ChoiceAttribute.AsExactly<DateElement>(timing); set { timing = value; } }
			public Period timingPeriod { get => ChoiceAttribute.AsExactly<Period>(timing); set { timing = value; } }

			[ValueSetBinding("MissingReason", "http://hl7.org/fhir/ValueSet/missing-tooth-reason", false)]
			public Coding reason { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/ExplanationOfBenefit.diagnosis")]
		public partial class DiagnosisComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			public PositiveIntElement sequence { get; set; }

			[NotNull]
			[Choice(typeof(CodeableConcept))]
			[Choice(typeof(Reference))]
			[JsonIgnore]
			[ValueSetBinding("ICD10", "http://hl7.org/fhir/ValueSet/icd-10", false)]
			public Element diagnosis { get; set; }
			public CodeableConcept diagnosisCodeableConcept { get => ChoiceAttribute.AsExactly<CodeableConcept>(diagnosis); set { diagnosis = value; } }
			public Reference diagnosisReference { get => ChoiceAttribute.AsExactly<Reference>(diagnosis); set { diagnosis = value; } }

			[ValueSetBinding("DiagnosisType", "http://hl7.org/fhir/ValueSet/ex-diagnosistype", false)]
			public ICollection<CodeableConcept> type { get; set; }

			[ValueSetBinding("DiagnosisOnAdmission", "http://hl7.org/fhir/ValueSet/ex-diagnosis-on-admission", false)]
			public CodeableConcept onAdmission { get; set; }

			[ValueSetBinding("DiagnosisRelatedGroup", "http://hl7.org/fhir/ValueSet/ex-diagnosisrelatedgroup", false)]
			public CodeableConcept packageCode { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/ExplanationOfBenefit.procedure")]
		public partial class ProcedureComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			public PositiveIntElement sequence { get; set; }

			[ValueSetBinding("ProcedureType", "http://hl7.org/fhir/ValueSet/ex-procedure-type", false)]
			public ICollection<CodeableConcept> type { get; set; }

			public DateTimeElement date { get; set; }

			[NotNull]
			[Choice(typeof(CodeableConcept))]
			[Choice(typeof(Reference))]
			[JsonIgnore]
			[ValueSetBinding("ICD10_Procedures", "http://hl7.org/fhir/ValueSet/icd-10-procedures", false)]
			public Element procedure { get; set; }
			public CodeableConcept procedureCodeableConcept { get => ChoiceAttribute.AsExactly<CodeableConcept>(procedure); set { procedure = value; } }
			public Reference procedureReference { get => ChoiceAttribute.AsExactly<Reference>(procedure); set { procedure = value; } }

			public ICollection<Reference> udi { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/ExplanationOfBenefit.insurance")]
		public partial class InsuranceComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			public BooleanElement focal { get; set; }

			[NotNull]
			public Reference coverage { get; set; }

			public ICollection<StringElement> preAuthRef { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/ExplanationOfBenefit.accident")]
		public partial class AccidentComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public DateElement date { get; set; }

			[ValueSetBinding("AccidentType", "http://terminology.hl7.org/ValueSet/v3-ActIncidentCode", false)]
			public CodeableConcept type { get; set; }

			[Choice(typeof(Address))]
			[Choice(typeof(Reference))]
			[JsonIgnore]
			public Element location { get; set; }
			public Address locationAddress { get => ChoiceAttribute.AsExactly<Address>(location); set { location = value; } }
			public Reference locationReference { get => ChoiceAttribute.AsExactly<Reference>(location); set { location = value; } }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/ExplanationOfBenefit.item")]
		public partial class ItemComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			public PositiveIntElement sequence { get; set; }

			public ICollection<PositiveIntElement> careTeamSequence { get; set; }

			public ICollection<PositiveIntElement> diagnosisSequence { get; set; }

			public ICollection<PositiveIntElement> procedureSequence { get; set; }

			public ICollection<PositiveIntElement> informationSequence { get; set; }

			[ValueSetBinding("RevenueCenter", "http://hl7.org/fhir/ValueSet/ex-revenue-center", false)]
			public CodeableConcept revenue { get; set; }

			[ValueSetBinding("BenefitCategory", "http://hl7.org/fhir/ValueSet/ex-benefitcategory", false)]
			public CodeableConcept category { get; set; }

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

			public ICollection<Reference> udi { get; set; }

			[ValueSetBinding("OralSites", "http://hl7.org/fhir/ValueSet/tooth", false)]
			public CodeableConcept bodySite { get; set; }

			[ValueSetBinding("Surface", "http://hl7.org/fhir/ValueSet/surface", false)]
			public ICollection<CodeableConcept> subSite { get; set; }

			public ICollection<Reference> encounter { get; set; }

			public ICollection<PositiveIntElement> noteNumber { get; set; }

			public ICollection<AdjudicationComponent> adjudication { get; set; }

			public ICollection<DetailComponent> detail { get; set; }
			[DebuggerDisplay("{value}")]
			[FhirUri("http://hl7.org/fhir/StructureDefinition/ExplanationOfBenefit.item.adjudication")]
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
			[FhirUri("http://hl7.org/fhir/StructureDefinition/ExplanationOfBenefit.item.detail")]
			public partial class DetailComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				[NotNull]
				public PositiveIntElement sequence { get; set; }

				[ValueSetBinding("RevenueCenter", "http://hl7.org/fhir/ValueSet/ex-revenue-center", false)]
				public CodeableConcept revenue { get; set; }

				[ValueSetBinding("BenefitCategory", "http://hl7.org/fhir/ValueSet/ex-benefitcategory", false)]
				public CodeableConcept category { get; set; }

				[NotNull]
				[ValueSetBinding("ServiceProduct", "http://hl7.org/fhir/ValueSet/service-uscls", false)]
				public CodeableConcept productOrService { get; set; }

				[ValueSetBinding("Modifiers", "http://hl7.org/fhir/ValueSet/claim-modifiers", false)]
				public ICollection<CodeableConcept> modifier { get; set; }

				[ValueSetBinding("ProgramCode", "http://hl7.org/fhir/ValueSet/ex-program-code", false)]
				public ICollection<CodeableConcept> programCode { get; set; }

				public Quantity quantity { get; set; }

				public Money unitPrice { get; set; }

				public DecimalElement factor { get; set; }

				public Money net { get; set; }

				public ICollection<Reference> udi { get; set; }

				public ICollection<PositiveIntElement> noteNumber { get; set; }

				public ICollection<SubDetailComponent> subDetail { get; set; }
				[FhirUri("http://hl7.org/fhir/StructureDefinition/ExplanationOfBenefit.item.detail.subDetail")]
				public partial class SubDetailComponent
				{

					public string id { get; set; }

					public ICollection<Extension> extension { get; set; }

					public ICollection<Extension> modifierExtension { get; set; }

					[NotNull]
					public PositiveIntElement sequence { get; set; }

					[ValueSetBinding("RevenueCenter", "http://hl7.org/fhir/ValueSet/ex-revenue-center", false)]
					public CodeableConcept revenue { get; set; }

					[ValueSetBinding("BenefitCategory", "http://hl7.org/fhir/ValueSet/ex-benefitcategory", false)]
					public CodeableConcept category { get; set; }

					[NotNull]
					[ValueSetBinding("ServiceProduct", "http://hl7.org/fhir/ValueSet/service-uscls", false)]
					public CodeableConcept productOrService { get; set; }

					[ValueSetBinding("Modifiers", "http://hl7.org/fhir/ValueSet/claim-modifiers", false)]
					public ICollection<CodeableConcept> modifier { get; set; }

					[ValueSetBinding("ProgramCode", "http://hl7.org/fhir/ValueSet/ex-program-code", false)]
					public ICollection<CodeableConcept> programCode { get; set; }

					public Quantity quantity { get; set; }

					public Money unitPrice { get; set; }

					public DecimalElement factor { get; set; }

					public Money net { get; set; }

					public ICollection<Reference> udi { get; set; }

					public ICollection<PositiveIntElement> noteNumber { get; set; }
				}
			}
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/ExplanationOfBenefit.addItem")]
		public partial class AddItemComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public ICollection<PositiveIntElement> itemSequence { get; set; }

			public ICollection<PositiveIntElement> detailSequence { get; set; }

			public ICollection<PositiveIntElement> subDetailSequence { get; set; }

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
			[FhirUri("http://hl7.org/fhir/StructureDefinition/ExplanationOfBenefit.addItem.detail")]
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
				[FhirUri("http://hl7.org/fhir/StructureDefinition/ExplanationOfBenefit.addItem.detail.subDetail")]
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
		[FhirUri("http://hl7.org/fhir/StructureDefinition/ExplanationOfBenefit.total")]
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
		[FhirUri("http://hl7.org/fhir/StructureDefinition/ExplanationOfBenefit.payment")]
		public partial class PaymentComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[ValueSetBinding("PaymentType", "http://hl7.org/fhir/ValueSet/ex-paymenttype", false)]
			public CodeableConcept type { get; set; }

			public Money adjustment { get; set; }

			[ValueSetBinding("PaymentAdjustmentReason", "http://hl7.org/fhir/ValueSet/payment-adjustment-reason", false)]
			public CodeableConcept adjustmentReason { get; set; }

			public DateElement date { get; set; }

			public Money amount { get; set; }

			public Identifier identifier { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/ExplanationOfBenefit.processNote")]
		public partial class ProcessNoteComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public PositiveIntElement number { get; set; }

			[ValueSetBinding("NoteType", "http://hl7.org/fhir/ValueSet/note-type%7C4.0.1", true)]
			public CodeElement type { get; set; }

			public StringElement text { get; set; }

			[ValueSetBinding("Language", "http://hl7.org/fhir/ValueSet/languages", false)]
			public CodeableConcept language { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/ExplanationOfBenefit.benefitBalance")]
		public partial class BenefitBalanceComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			[ValueSetBinding("BenefitCategory", "http://hl7.org/fhir/ValueSet/ex-benefitcategory", false)]
			public CodeableConcept category { get; set; }

			public BooleanElement excluded { get; set; }

			public StringElement name { get; set; }

			public StringElement description { get; set; }

			[ValueSetBinding("BenefitNetwork", "http://hl7.org/fhir/ValueSet/benefit-network", false)]
			public CodeableConcept network { get; set; }

			[ValueSetBinding("BenefitUnit", "http://hl7.org/fhir/ValueSet/benefit-unit", false)]
			public CodeableConcept unit { get; set; }

			[ValueSetBinding("BenefitTerm", "http://hl7.org/fhir/ValueSet/benefit-term", false)]
			public CodeableConcept term { get; set; }

			public ICollection<FinancialComponent> financial { get; set; }
			[FhirUri("http://hl7.org/fhir/StructureDefinition/ExplanationOfBenefit.benefitBalance.financial")]
			public partial class FinancialComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				[NotNull]
				[ValueSetBinding("BenefitType", "http://hl7.org/fhir/ValueSet/benefit-type", false)]
				public CodeableConcept type { get; set; }

				[Choice(typeof(UnsignedIntElement))]
				[Choice(typeof(StringElement))]
				[Choice(typeof(Money))]
				[JsonIgnore]
				public Element allowed { get; set; }
				public UnsignedIntElement allowedUnsignedInt { get => ChoiceAttribute.AsExactly<UnsignedIntElement>(allowed); set { allowed = value; } }
				public StringElement allowedString { get => ChoiceAttribute.AsExactly<StringElement>(allowed); set { allowed = value; } }
				public Money allowedMoney { get => ChoiceAttribute.AsExactly<Money>(allowed); set { allowed = value; } }

				[Choice(typeof(UnsignedIntElement))]
				[Choice(typeof(Money))]
				[JsonIgnore]
				public Element used { get; set; }
				public UnsignedIntElement usedUnsignedInt { get => ChoiceAttribute.AsExactly<UnsignedIntElement>(used); set { used = value; } }
				public Money usedMoney { get => ChoiceAttribute.AsExactly<Money>(used); set { used = value; } }
			}
		}
	}
}

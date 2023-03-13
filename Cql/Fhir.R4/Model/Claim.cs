using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[FhirUri("http://hl7.org/fhir/StructureDefinition/Claim")]
	public partial class Claim : DomainResource
	{

		public ICollection<Identifier> identifier { get; set; }

		[NotNull]
		[ValueSetBinding("ClaimStatus", "http://hl7.org/fhir/ValueSet/fm-status%7C4.0.1", true)]
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

		public Reference insurer { get; set; }

		[NotNull]
		public Reference provider { get; set; }

		[NotNull]
		[ValueSetBinding("ProcessPriority", "http://hl7.org/fhir/ValueSet/process-priority", false)]
		public CodeableConcept priority { get; set; }

		[ValueSetBinding("FundsReserve", "http://hl7.org/fhir/ValueSet/fundsreserve", false)]
		public CodeableConcept fundsReserve { get; set; }

		public ICollection<RelatedComponent> related { get; set; }

		public Reference prescription { get; set; }

		public Reference originalPrescription { get; set; }

		public PayeeComponent payee { get; set; }

		public Reference referral { get; set; }

		public Reference facility { get; set; }

		public ICollection<CareTeamComponent> careTeam { get; set; }

		public ICollection<SupportingInfoComponent> supportingInfo { get; set; }

		public ICollection<DiagnosisComponent> diagnosis { get; set; }

		public ICollection<ProcedureComponent> procedure { get; set; }

		public ICollection<InsuranceComponent> insurance { get; set; }

		public AccidentComponent accident { get; set; }

		public ICollection<ItemComponent> item { get; set; }

		public Money total { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/Claim.related")]
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
		[FhirUri("http://hl7.org/fhir/StructureDefinition/Claim.payee")]
		public partial class PayeeComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			[ValueSetBinding("PayeeType", "http://hl7.org/fhir/ValueSet/payeetype", false)]
			public CodeableConcept type { get; set; }

			public Reference party { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/Claim.careTeam")]
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
		[FhirUri("http://hl7.org/fhir/StructureDefinition/Claim.supportingInfo")]
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
			public CodeableConcept reason { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/Claim.diagnosis")]
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
		[FhirUri("http://hl7.org/fhir/StructureDefinition/Claim.procedure")]
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
		[FhirUri("http://hl7.org/fhir/StructureDefinition/Claim.insurance")]
		public partial class InsuranceComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			public PositiveIntElement sequence { get; set; }

			[NotNull]
			public BooleanElement focal { get; set; }

			public Identifier identifier { get; set; }

			[NotNull]
			public Reference coverage { get; set; }

			public StringElement businessArrangement { get; set; }

			public ICollection<StringElement> preAuthRef { get; set; }

			public Reference claimResponse { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/Claim.accident")]
		public partial class AccidentComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
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
		[FhirUri("http://hl7.org/fhir/StructureDefinition/Claim.item")]
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

			public ICollection<DetailComponent> detail { get; set; }
			[FhirUri("http://hl7.org/fhir/StructureDefinition/Claim.item.detail")]
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

				public ICollection<SubDetailComponent> subDetail { get; set; }
				[FhirUri("http://hl7.org/fhir/StructureDefinition/Claim.item.detail.subDetail")]
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
				}
			}
		}
	}
}

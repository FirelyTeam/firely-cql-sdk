using Hl7.Cql.Poco.Fhir;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Hl7.Cql.Poco.Fhir.R4.Model
{
    [FhirUri("http://hl7.org/fhir/StructureDefinition/CoverageEligibilityResponse")]
	public partial class CoverageEligibilityResponse : DomainResource
	{

		public ICollection<Identifier> identifier { get; set; }

		[NotNull]
		[ValueSetBinding("EligibilityResponseStatus", "http://hl7.org/fhir/ValueSet/fm-status%7C4.0.1", true)]
		public CodeElement status { get; set; }

		[ValueSetBinding("EligibilityResponsePurpose", "http://hl7.org/fhir/ValueSet/eligibilityresponse-purpose%7C4.0.1", true)]
		public ICollection<CodeElement> purpose { get; set; }

		[NotNull]
		public Reference patient { get; set; }

		[Choice(typeof(DateElement))]
		[Choice(typeof(Period))]
		[JsonIgnore]
		public Element serviced { get; set; }
		public DateElement servicedDate { get => ChoiceAttribute.AsExactly<DateElement>(serviced); set { serviced = value; } }
		public Period servicedPeriod { get => ChoiceAttribute.AsExactly<Period>(serviced); set { serviced = value; } }

		[NotNull]
		public DateTimeElement created { get; set; }

		public Reference requestor { get; set; }

		[NotNull]
		public Reference request { get; set; }

		[NotNull]
		[ValueSetBinding("RemittanceOutcome", "http://hl7.org/fhir/ValueSet/remittance-outcome%7C4.0.1", true)]
		public CodeElement outcome { get; set; }

		public StringElement disposition { get; set; }

		[NotNull]
		public Reference insurer { get; set; }

		public ICollection<InsuranceComponent> insurance { get; set; }

		public StringElement preAuthRef { get; set; }

		[ValueSetBinding("Forms", "http://hl7.org/fhir/ValueSet/forms", false)]
		public CodeableConcept form { get; set; }

		public ICollection<ErrorComponent> error { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/CoverageEligibilityResponse.insurance")]
		public partial class InsuranceComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			public Reference coverage { get; set; }

			public BooleanElement inforce { get; set; }

			public Period benefitPeriod { get; set; }

			public ICollection<ItemComponent> item { get; set; }
			[FhirUri("http://hl7.org/fhir/StructureDefinition/CoverageEligibilityResponse.insurance.item")]
			public partial class ItemComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				[ValueSetBinding("BenefitCategory", "http://hl7.org/fhir/ValueSet/ex-benefitcategory", false)]
				public CodeableConcept category { get; set; }

				[ValueSetBinding("ServiceProduct", "http://hl7.org/fhir/ValueSet/service-uscls", false)]
				public CodeableConcept productOrService { get; set; }

				[ValueSetBinding("Modifiers", "http://hl7.org/fhir/ValueSet/claim-modifiers", false)]
				public ICollection<CodeableConcept> modifier { get; set; }

				public Reference provider { get; set; }

				public BooleanElement excluded { get; set; }

				public StringElement name { get; set; }

				public StringElement description { get; set; }

				[ValueSetBinding("BenefitNetwork", "http://hl7.org/fhir/ValueSet/benefit-network", false)]
				public CodeableConcept network { get; set; }

				[ValueSetBinding("BenefitUnit", "http://hl7.org/fhir/ValueSet/benefit-unit", false)]
				public CodeableConcept unit { get; set; }

				[ValueSetBinding("BenefitTerm", "http://hl7.org/fhir/ValueSet/benefit-term", false)]
				public CodeableConcept term { get; set; }

				public ICollection<BenefitComponent> benefit { get; set; }

				public BooleanElement authorizationRequired { get; set; }

				[ValueSetBinding("AuthSupporting", "http://hl7.org/fhir/ValueSet/coverageeligibilityresponse-ex-auth-support", false)]
				public ICollection<CodeableConcept> authorizationSupporting { get; set; }

				public UriElement authorizationUrl { get; set; }
				[FhirUri("http://hl7.org/fhir/StructureDefinition/CoverageEligibilityResponse.insurance.item.benefit")]
				public partial class BenefitComponent
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
					[Choice(typeof(StringElement))]
					[Choice(typeof(Money))]
					[JsonIgnore]
					public Element used { get; set; }
					public UnsignedIntElement usedUnsignedInt { get => ChoiceAttribute.AsExactly<UnsignedIntElement>(used); set { used = value; } }
					public StringElement usedString { get => ChoiceAttribute.AsExactly<StringElement>(used); set { used = value; } }
					public Money usedMoney { get => ChoiceAttribute.AsExactly<Money>(used); set { used = value; } }
				}
			}
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/CoverageEligibilityResponse.error")]
		public partial class ErrorComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			[ValueSetBinding("AdjudicationError", "http://hl7.org/fhir/ValueSet/adjudication-error", false)]
			public CodeableConcept code { get; set; }
		}
	}
}

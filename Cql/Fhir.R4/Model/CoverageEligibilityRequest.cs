using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[FhirUri("http://hl7.org/fhir/StructureDefinition/CoverageEligibilityRequest")]
	public partial class CoverageEligibilityRequest : DomainResource
	{

		public ICollection<Identifier> identifier { get; set; }

		[NotNull]
		[ValueSetBinding("EligibilityRequestStatus", "http://hl7.org/fhir/ValueSet/fm-status%7C4.0.1", true)]
		public CodeElement status { get; set; }

		[ValueSetBinding("ProcessPriority", "http://hl7.org/fhir/ValueSet/process-priority", false)]
		public CodeableConcept priority { get; set; }

		[ValueSetBinding("EligibilityRequestPurpose", "http://hl7.org/fhir/ValueSet/eligibilityrequest-purpose%7C4.0.1", true)]
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

		public Reference enterer { get; set; }

		public Reference provider { get; set; }

		[NotNull]
		public Reference insurer { get; set; }

		public Reference facility { get; set; }

		public ICollection<SupportingInfoComponent> supportingInfo { get; set; }

		public ICollection<InsuranceComponent> insurance { get; set; }

		public ICollection<ItemComponent> item { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/CoverageEligibilityRequest.supportingInfo")]
		public partial class SupportingInfoComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			public PositiveIntElement sequence { get; set; }

			[NotNull]
			public Reference information { get; set; }

			public BooleanElement appliesToAll { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/CoverageEligibilityRequest.insurance")]
		public partial class InsuranceComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public BooleanElement focal { get; set; }

			[NotNull]
			public Reference coverage { get; set; }

			public StringElement businessArrangement { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/CoverageEligibilityRequest.item")]
		public partial class ItemComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public ICollection<PositiveIntElement> supportingInfoSequence { get; set; }

			[ValueSetBinding("BenefitCategory", "http://hl7.org/fhir/ValueSet/ex-benefitcategory", false)]
			public CodeableConcept category { get; set; }

			[ValueSetBinding("ServiceProduct", "http://hl7.org/fhir/ValueSet/service-uscls", false)]
			public CodeableConcept productOrService { get; set; }

			[ValueSetBinding("Modifiers", "http://hl7.org/fhir/ValueSet/claim-modifiers", false)]
			public ICollection<CodeableConcept> modifier { get; set; }

			public Reference provider { get; set; }

			public Quantity quantity { get; set; }

			public Money unitPrice { get; set; }

			public Reference facility { get; set; }

			public ICollection<DiagnosisComponent> diagnosis { get; set; }

			public ICollection<Reference> detail { get; set; }
			[FhirUri("http://hl7.org/fhir/StructureDefinition/CoverageEligibilityRequest.item.diagnosis")]
			public partial class DiagnosisComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				[Choice(typeof(CodeableConcept))]
				[Choice(typeof(Reference))]
				[JsonIgnore]
				[ValueSetBinding("ICD10", "http://hl7.org/fhir/ValueSet/icd-10", false)]
				public Element diagnosis { get; set; }
				public CodeableConcept diagnosisCodeableConcept { get => ChoiceAttribute.AsExactly<CodeableConcept>(diagnosis); set { diagnosis = value; } }
				public Reference diagnosisReference { get => ChoiceAttribute.AsExactly<Reference>(diagnosis); set { diagnosis = value; } }
			}
		}
	}
}

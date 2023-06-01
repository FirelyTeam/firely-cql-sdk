using Hl7.Cql.Poco.Fhir;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace Hl7.Cql.Poco.Fhir.R4.Model
{
    [FhirUri("http://hl7.org/fhir/StructureDefinition/InsurancePlan")]
	public partial class InsurancePlan : DomainResource
	{

		public ICollection<Identifier> identifier { get; set; }

		[ValueSetBinding("PublicationStatus", "http://hl7.org/fhir/ValueSet/publication-status%7C4.0.1", true)]
		public CodeElement status { get; set; }

		[ValueSetBinding("InsurancePlanType", "http://hl7.org/fhir/ValueSet/insuranceplan-type", false)]
		public ICollection<CodeableConcept> type { get; set; }

		public StringElement name { get; set; }

		public ICollection<StringElement> alias { get; set; }

		public Period period { get; set; }

		public Reference ownedBy { get; set; }

		public Reference administeredBy { get; set; }

		public ICollection<Reference> coverageArea { get; set; }

		public ICollection<ContactComponent> contact { get; set; }

		public ICollection<Reference> endpoint { get; set; }

		public ICollection<Reference> network { get; set; }

		public ICollection<CoverageComponent> coverage { get; set; }

		public ICollection<PlanComponent> plan { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/InsurancePlan.contact")]
		public partial class ContactComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[ValueSetBinding("ContactPartyType", "http://hl7.org/fhir/ValueSet/contactentity-type", false)]
			public CodeableConcept purpose { get; set; }

			public HumanName name { get; set; }

			public ICollection<ContactPoint> telecom { get; set; }

			public Address address { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/InsurancePlan.coverage")]
		public partial class CoverageComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			public CodeableConcept type { get; set; }

			public ICollection<Reference> network { get; set; }

			public ICollection<BenefitComponent> benefit { get; set; }
			[FhirUri("http://hl7.org/fhir/StructureDefinition/InsurancePlan.coverage.benefit")]
			public partial class BenefitComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				[NotNull]
				public CodeableConcept type { get; set; }

				public StringElement requirement { get; set; }

				public ICollection<LimitComponent> limit { get; set; }
				[DebuggerDisplay("{value}")]
				[FhirUri("http://hl7.org/fhir/StructureDefinition/InsurancePlan.coverage.benefit.limit")]
				public partial class LimitComponent
				{

					public Quantity value { get; set; }

					public string id { get; set; }

					public ICollection<Extension> extension { get; set; }

					public ICollection<Extension> modifierExtension { get; set; }

					public CodeableConcept code { get; set; }
				}
			}
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/InsurancePlan.plan")]
		public partial class PlanComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public ICollection<Identifier> identifier { get; set; }

			public CodeableConcept type { get; set; }

			public ICollection<Reference> coverageArea { get; set; }

			public ICollection<Reference> network { get; set; }

			public ICollection<GeneralCostComponent> generalCost { get; set; }

			public ICollection<SpecificCostComponent> specificCost { get; set; }
			[FhirUri("http://hl7.org/fhir/StructureDefinition/InsurancePlan.plan.generalCost")]
			public partial class GeneralCostComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				public CodeableConcept type { get; set; }

				public PositiveIntElement groupSize { get; set; }

				public Money cost { get; set; }

				public StringElement comment { get; set; }
			}
			[FhirUri("http://hl7.org/fhir/StructureDefinition/InsurancePlan.plan.specificCost")]
			public partial class SpecificCostComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				[NotNull]
				public CodeableConcept category { get; set; }

				public ICollection<BenefitComponent> benefit { get; set; }
				[FhirUri("http://hl7.org/fhir/StructureDefinition/InsurancePlan.plan.specificCost.benefit")]
				public partial class BenefitComponent
				{

					public string id { get; set; }

					public ICollection<Extension> extension { get; set; }

					public ICollection<Extension> modifierExtension { get; set; }

					[NotNull]
					public CodeableConcept type { get; set; }

					public ICollection<CostComponent> cost { get; set; }
					[DebuggerDisplay("{value}")]
					[FhirUri("http://hl7.org/fhir/StructureDefinition/InsurancePlan.plan.specificCost.benefit.cost")]
					public partial class CostComponent
					{

						public Quantity value { get; set; }

						public string id { get; set; }

						public ICollection<Extension> extension { get; set; }

						public ICollection<Extension> modifierExtension { get; set; }

						[NotNull]
						public CodeableConcept type { get; set; }

						[ValueSetBinding("BenefitCostApplicability", "http://hl7.org/fhir/ValueSet/insuranceplan-applicability%7C4.0.1", true)]
						public CodeableConcept applicability { get; set; }

						public ICollection<CodeableConcept> qualifiers { get; set; }
					}
				}
			}
		}
	}
}

using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[FhirUri("http://hl7.org/fhir/StructureDefinition/ChargeItemDefinition")]
	public partial class ChargeItemDefinition : DomainResource
	{

		[NotNull]
		public UriElement url { get; set; }

		public ICollection<Identifier> identifier { get; set; }

		public StringElement version { get; set; }

		public StringElement title { get; set; }

		public ICollection<UriElement> derivedFromUri { get; set; }

		public ICollection<CanonicalElement> partOf { get; set; }

		public ICollection<CanonicalElement> replaces { get; set; }

		[NotNull]
		[ValueSetBinding("PublicationStatus", "http://hl7.org/fhir/ValueSet/publication-status%7C4.0.1", true)]
		public CodeElement status { get; set; }

		public BooleanElement experimental { get; set; }

		public DateTimeElement date { get; set; }

		public StringElement publisher { get; set; }

		public ICollection<ContactDetail> contact { get; set; }

		public MarkdownElement description { get; set; }

		public ICollection<UsageContext> useContext { get; set; }

		[ValueSetBinding("Jurisdiction", "http://hl7.org/fhir/ValueSet/jurisdiction", false)]
		public ICollection<CodeableConcept> jurisdiction { get; set; }

		public MarkdownElement copyright { get; set; }

		public DateElement approvalDate { get; set; }

		public DateElement lastReviewDate { get; set; }

		public Period effectivePeriod { get; set; }

		[ValueSetBinding("ChargeItemDefinitionCode", "http://hl7.org/fhir/ValueSet/chargeitem-billingcodes", false)]
		public CodeableConcept code { get; set; }

		public ICollection<Reference> instance { get; set; }

		public ICollection<ApplicabilityComponent> applicability { get; set; }

		public ICollection<PropertyGroupComponent> propertyGroup { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/ChargeItemDefinition.applicability")]
		public partial class ApplicabilityComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public StringElement description { get; set; }

			public StringElement language { get; set; }

			public StringElement expression { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/ChargeItemDefinition.propertyGroup")]
		public partial class PropertyGroupComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public ICollection<PriceComponentComponent> priceComponent { get; set; }
			[FhirUri("http://hl7.org/fhir/StructureDefinition/ChargeItemDefinition.propertyGroup.priceComponent")]
			public partial class PriceComponentComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				[NotNull]
				[ValueSetBinding("ChargeItemDefinitionPriceComponentType", "http://hl7.org/fhir/ValueSet/invoice-priceComponentType%7C4.0.1", true)]
				public CodeElement type { get; set; }

				public CodeableConcept code { get; set; }

				public DecimalElement factor { get; set; }

				public Money amount { get; set; }
			}
		}
	}
}

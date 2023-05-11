using Hl7.Cql.Poco.Fhir;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Hl7.Cql.Poco.Fhir.R4.Model
{
    [FhirUri("http://hl7.org/fhir/StructureDefinition/MedicinalProduct")]
	public partial class MedicinalProduct : DomainResource
	{

		public ICollection<Identifier> identifier { get; set; }

		public CodeableConcept type { get; set; }

		public Coding domain { get; set; }

		public CodeableConcept combinedPharmaceuticalDoseForm { get; set; }

		public CodeableConcept legalStatusOfSupply { get; set; }

		public CodeableConcept additionalMonitoringIndicator { get; set; }

		public ICollection<StringElement> specialMeasures { get; set; }

		public CodeableConcept paediatricUseIndicator { get; set; }

		public ICollection<CodeableConcept> productClassification { get; set; }

		public ICollection<MarketingStatus> marketingStatus { get; set; }

		public ICollection<Reference> pharmaceuticalProduct { get; set; }

		public ICollection<Reference> packagedMedicinalProduct { get; set; }

		public ICollection<Reference> attachedDocument { get; set; }

		public ICollection<Reference> masterFile { get; set; }

		public ICollection<Reference> contact { get; set; }

		public ICollection<Reference> clinicalTrial { get; set; }

		public ICollection<NameComponent> name { get; set; }

		public ICollection<Identifier> crossReference { get; set; }

		public ICollection<ManufacturingBusinessOperationComponent> manufacturingBusinessOperation { get; set; }

		public ICollection<SpecialDesignationComponent> specialDesignation { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/MedicinalProduct.name")]
		public partial class NameComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			public StringElement productName { get; set; }

			public ICollection<NamePartComponent> namePart { get; set; }

			public ICollection<CountryLanguageComponent> countryLanguage { get; set; }
			[FhirUri("http://hl7.org/fhir/StructureDefinition/MedicinalProduct.name.namePart")]
			public partial class NamePartComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				[NotNull]
				public StringElement part { get; set; }

				[NotNull]
				public Coding type { get; set; }
			}
			[FhirUri("http://hl7.org/fhir/StructureDefinition/MedicinalProduct.name.countryLanguage")]
			public partial class CountryLanguageComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				[NotNull]
				public CodeableConcept country { get; set; }

				public CodeableConcept jurisdiction { get; set; }

				[NotNull]
				public CodeableConcept language { get; set; }
			}
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/MedicinalProduct.manufacturingBusinessOperation")]
		public partial class ManufacturingBusinessOperationComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public CodeableConcept operationType { get; set; }

			public Identifier authorisationReferenceNumber { get; set; }

			public DateTimeElement effectiveDate { get; set; }

			public CodeableConcept confidentialityIndicator { get; set; }

			public ICollection<Reference> manufacturer { get; set; }

			public Reference regulator { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/MedicinalProduct.specialDesignation")]
		public partial class SpecialDesignationComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public ICollection<Identifier> identifier { get; set; }

			public CodeableConcept type { get; set; }

			public CodeableConcept intendedUse { get; set; }

			[Choice(typeof(CodeableConcept))]
			[Choice(typeof(Reference))]
			[JsonIgnore]
			public Element indication { get; set; }
			public CodeableConcept indicationCodeableConcept { get => ChoiceAttribute.AsExactly<CodeableConcept>(indication); set { indication = value; } }
			public Reference indicationReference { get => ChoiceAttribute.AsExactly<Reference>(indication); set { indication = value; } }

			public CodeableConcept status { get; set; }

			public DateTimeElement date { get; set; }

			public CodeableConcept species { get; set; }
		}
	}
}

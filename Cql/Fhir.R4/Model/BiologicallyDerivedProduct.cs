using Hl7.Cql.Poco.Fhir;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Hl7.Cql.Poco.Fhir.R4.Model
{
    [FhirUri("http://hl7.org/fhir/StructureDefinition/BiologicallyDerivedProduct")]
	public partial class BiologicallyDerivedProduct : DomainResource
	{

		public ICollection<Identifier> identifier { get; set; }

		[ValueSetBinding("BiologicallyDerivedProductCategory", "http://hl7.org/fhir/ValueSet/product-category%7C4.0.1", true)]
		public CodeElement productCategory { get; set; }

		public CodeableConcept productCode { get; set; }

		[ValueSetBinding("BiologicallyDerivedProductStatus", "http://hl7.org/fhir/ValueSet/product-status%7C4.0.1", true)]
		public CodeElement status { get; set; }

		public ICollection<Reference> request { get; set; }

		public IntegerElement quantity { get; set; }

		public ICollection<Reference> parent { get; set; }

		public CollectionComponent collection { get; set; }

		public ICollection<ProcessingComponent> processing { get; set; }

		public ManipulationComponent manipulation { get; set; }

		public ICollection<StorageComponent> storage { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/BiologicallyDerivedProduct.collection")]
		public partial class CollectionComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public Reference collector { get; set; }

			public Reference source { get; set; }

			[Choice(typeof(DateTimeElement))]
			[Choice(typeof(Period))]
			[JsonIgnore]
			public Element collected { get; set; }
			public DateTimeElement collectedDateTime { get => ChoiceAttribute.AsExactly<DateTimeElement>(collected); set { collected = value; } }
			public Period collectedPeriod { get => ChoiceAttribute.AsExactly<Period>(collected); set { collected = value; } }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/BiologicallyDerivedProduct.processing")]
		public partial class ProcessingComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public StringElement description { get; set; }

			[ValueSetBinding("BiologicallyDerivedProductProcedure", "http://hl7.org/fhir/ValueSet/procedure-code", false)]
			public CodeableConcept procedure { get; set; }

			public Reference additive { get; set; }

			[Choice(typeof(DateTimeElement))]
			[Choice(typeof(Period))]
			[JsonIgnore]
			public Element time { get; set; }
			public DateTimeElement timeDateTime { get => ChoiceAttribute.AsExactly<DateTimeElement>(time); set { time = value; } }
			public Period timePeriod { get => ChoiceAttribute.AsExactly<Period>(time); set { time = value; } }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/BiologicallyDerivedProduct.manipulation")]
		public partial class ManipulationComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public StringElement description { get; set; }

			[Choice(typeof(DateTimeElement))]
			[Choice(typeof(Period))]
			[JsonIgnore]
			public Element time { get; set; }
			public DateTimeElement timeDateTime { get => ChoiceAttribute.AsExactly<DateTimeElement>(time); set { time = value; } }
			public Period timePeriod { get => ChoiceAttribute.AsExactly<Period>(time); set { time = value; } }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/BiologicallyDerivedProduct.storage")]
		public partial class StorageComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public StringElement description { get; set; }

			public DecimalElement temperature { get; set; }

			[ValueSetBinding("BiologicallyDerivedProductStorageScale", "http://hl7.org/fhir/ValueSet/product-storage-scale%7C4.0.1", true)]
			public CodeElement scale { get; set; }

			public Period duration { get; set; }
		}
	}
}

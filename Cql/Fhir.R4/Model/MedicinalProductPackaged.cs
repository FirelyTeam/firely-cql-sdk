using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[FhirUri("http://hl7.org/fhir/StructureDefinition/MedicinalProductPackaged")]
	public partial class MedicinalProductPackaged : DomainResource
	{

		public ICollection<Identifier> identifier { get; set; }

		public ICollection<Reference> subject { get; set; }

		public StringElement description { get; set; }

		public CodeableConcept legalStatusOfSupply { get; set; }

		public ICollection<MarketingStatus> marketingStatus { get; set; }

		public Reference marketingAuthorization { get; set; }

		public ICollection<Reference> manufacturer { get; set; }

		public ICollection<BatchIdentifierComponent> batchIdentifier { get; set; }

		public ICollection<PackageItemComponent> packageItem { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/MedicinalProductPackaged.batchIdentifier")]
		public partial class BatchIdentifierComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			public Identifier outerPackaging { get; set; }

			public Identifier immediatePackaging { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/MedicinalProductPackaged.packageItem")]
		public partial class PackageItemComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public ICollection<Identifier> identifier { get; set; }

			[NotNull]
			public CodeableConcept type { get; set; }

			[NotNull]
			public Quantity quantity { get; set; }

			public ICollection<CodeableConcept> material { get; set; }

			public ICollection<CodeableConcept> alternateMaterial { get; set; }

			public ICollection<Reference> device { get; set; }

			public ICollection<Reference> manufacturedItem { get; set; }

			public ProdCharacteristic physicalCharacteristics { get; set; }

			public ICollection<CodeableConcept> otherCharacteristics { get; set; }

			public ICollection<ProductShelfLife> shelfLifeStorage { get; set; }

			public ICollection<Reference> manufacturer { get; set; }
		}
	}
}

using Hl7.Cql.Poco.Fhir;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Hl7.Cql.Poco.Fhir.R4.Model
{
    [FhirUri("http://hl7.org/fhir/StructureDefinition/DeviceDefinition")]
	public partial class DeviceDefinition : DomainResource
	{

		public ICollection<Identifier> identifier { get; set; }

		public ICollection<UdiDeviceIdentifierComponent> udiDeviceIdentifier { get; set; }

		[Choice(typeof(StringElement))]
		[Choice(typeof(Reference))]
		[JsonIgnore]
		public Element manufacturer { get; set; }
		public StringElement manufacturerString { get => ChoiceAttribute.AsExactly<StringElement>(manufacturer); set { manufacturer = value; } }
		public Reference manufacturerReference { get => ChoiceAttribute.AsExactly<Reference>(manufacturer); set { manufacturer = value; } }

		public ICollection<DeviceNameComponent> deviceName { get; set; }

		public StringElement modelNumber { get; set; }

		[ValueSetBinding("DeviceKind", "http://hl7.org/fhir/ValueSet/device-kind", false)]
		public CodeableConcept type { get; set; }

		public ICollection<SpecializationComponent> specialization { get; set; }

		public ICollection<StringElement> version { get; set; }

		[ValueSetBinding("Safety", "http://hl7.org/fhir/ValueSet/device-safety", false)]
		public ICollection<CodeableConcept> safety { get; set; }

		public ICollection<ProductShelfLife> shelfLifeStorage { get; set; }

		public ProdCharacteristic physicalCharacteristics { get; set; }

		public ICollection<CodeableConcept> languageCode { get; set; }

		public ICollection<CapabilityComponent> capability { get; set; }

		public ICollection<PropertyComponent> property { get; set; }

		public Reference owner { get; set; }

		public ICollection<ContactPoint> contact { get; set; }

		public UriElement url { get; set; }

		public UriElement onlineInformation { get; set; }

		public ICollection<Annotation> note { get; set; }

		public Quantity quantity { get; set; }

		public Reference parentDevice { get; set; }

		public ICollection<MaterialComponent> material { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/DeviceDefinition.udiDeviceIdentifier")]
		public partial class UdiDeviceIdentifierComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			public StringElement deviceIdentifier { get; set; }

			[NotNull]
			public UriElement issuer { get; set; }

			[NotNull]
			public UriElement jurisdiction { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/DeviceDefinition.deviceName")]
		public partial class DeviceNameComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			public StringElement name { get; set; }

			[NotNull]
			[ValueSetBinding("DeviceNameType", "http://hl7.org/fhir/ValueSet/device-nametype%7C4.0.1", true)]
			public CodeElement type { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/DeviceDefinition.specialization")]
		public partial class SpecializationComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			public StringElement systemType { get; set; }

			public StringElement version { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/DeviceDefinition.capability")]
		public partial class CapabilityComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			public CodeableConcept type { get; set; }

			public ICollection<CodeableConcept> description { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/DeviceDefinition.property")]
		public partial class PropertyComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			public CodeableConcept type { get; set; }

			public ICollection<Quantity> valueQuantity { get; set; }

			public ICollection<CodeableConcept> valueCode { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/DeviceDefinition.material")]
		public partial class MaterialComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			public CodeableConcept substance { get; set; }

			public BooleanElement alternate { get; set; }

			public BooleanElement allergenicIndicator { get; set; }
		}
	}
}

using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[FhirUri("http://hl7.org/fhir/StructureDefinition/Device")]
	public partial class Device : DomainResource
	{

		public ICollection<Identifier> identifier { get; set; }

		public Reference definition { get; set; }

		public ICollection<UdiCarrierComponent> udiCarrier { get; set; }

		[ValueSetBinding("FHIRDeviceStatus", "http://hl7.org/fhir/ValueSet/device-status%7C4.0.1", true)]
		public CodeElement status { get; set; }

		[ValueSetBinding("FHIRDeviceStatusReason", "http://hl7.org/fhir/ValueSet/device-status-reason", false)]
		public ICollection<CodeableConcept> statusReason { get; set; }

		public StringElement distinctIdentifier { get; set; }

		public StringElement manufacturer { get; set; }

		public DateTimeElement manufactureDate { get; set; }

		public DateTimeElement expirationDate { get; set; }

		public StringElement lotNumber { get; set; }

		public StringElement serialNumber { get; set; }

		public ICollection<DeviceNameComponent> deviceName { get; set; }

		public StringElement modelNumber { get; set; }

		public StringElement partNumber { get; set; }

		[ValueSetBinding("DeviceType", "http://hl7.org/fhir/ValueSet/device-type", false)]
		public CodeableConcept type { get; set; }

		public ICollection<SpecializationComponent> specialization { get; set; }

		public ICollection<VersionComponent> version { get; set; }

		public ICollection<PropertyComponent> property { get; set; }

		public Reference patient { get; set; }

		public Reference owner { get; set; }

		public ICollection<ContactPoint> contact { get; set; }

		public Reference location { get; set; }

		public UriElement url { get; set; }

		public ICollection<Annotation> note { get; set; }

		public ICollection<CodeableConcept> safety { get; set; }

		public Reference parent { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/Device.udiCarrier")]
		public partial class UdiCarrierComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public StringElement deviceIdentifier { get; set; }

			public UriElement issuer { get; set; }

			public UriElement jurisdiction { get; set; }

			public Base64BinaryElement carrierAIDC { get; set; }

			public StringElement carrierHRF { get; set; }

			[ValueSetBinding("UDIEntryType", "http://hl7.org/fhir/ValueSet/udi-entry-type%7C4.0.1", true)]
			public CodeElement entryType { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/Device.deviceName")]
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
		[FhirUri("http://hl7.org/fhir/StructureDefinition/Device.specialization")]
		public partial class SpecializationComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			public CodeableConcept systemType { get; set; }

			public StringElement version { get; set; }
		}
		[DebuggerDisplay("{value}")]
		[FhirUri("http://hl7.org/fhir/StructureDefinition/Device.version")]
		public partial class VersionComponent
		{

			[NotNull]
			public StringElement value { get; set; }

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public CodeableConcept type { get; set; }

			public Identifier component { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/Device.property")]
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
	}
}

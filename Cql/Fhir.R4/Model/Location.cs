using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[FhirUri("http://hl7.org/fhir/StructureDefinition/Location")]
	public partial class Location : DomainResource
	{

		public ICollection<Identifier> identifier { get; set; }

		[ValueSetBinding("LocationStatus", "http://hl7.org/fhir/ValueSet/location-status%7C4.0.1", true)]
		public CodeElement status { get; set; }

		[ValueSetBinding("OperationalStatus", "http://terminology.hl7.org/ValueSet/v2-0116", false)]
		public Coding operationalStatus { get; set; }

		public StringElement name { get; set; }

		public ICollection<StringElement> alias { get; set; }

		public StringElement description { get; set; }

		[ValueSetBinding("LocationMode", "http://hl7.org/fhir/ValueSet/location-mode%7C4.0.1", true)]
		public CodeElement mode { get; set; }

		[ValueSetBinding("LocationType", "http://terminology.hl7.org/ValueSet/v3-ServiceDeliveryLocationRoleType", false)]
		public ICollection<CodeableConcept> type { get; set; }

		public ICollection<ContactPoint> telecom { get; set; }

		public Address address { get; set; }

		[ValueSetBinding("PhysicalType", "http://hl7.org/fhir/ValueSet/location-physical-type", false)]
		public CodeableConcept physicalType { get; set; }

		public PositionComponent position { get; set; }

		public Reference managingOrganization { get; set; }

		public Reference partOf { get; set; }

		public ICollection<HoursOfOperationComponent> hoursOfOperation { get; set; }

		public StringElement availabilityExceptions { get; set; }

		public ICollection<Reference> endpoint { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/Location.position")]
		public partial class PositionComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			public DecimalElement longitude { get; set; }

			[NotNull]
			public DecimalElement latitude { get; set; }

			public DecimalElement altitude { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/Location.hoursOfOperation")]
		public partial class HoursOfOperationComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[ValueSetBinding("DaysOfWeek", "http://hl7.org/fhir/ValueSet/days-of-week%7C4.0.1", true)]
			public ICollection<CodeElement> daysOfWeek { get; set; }

			public BooleanElement allDay { get; set; }

			public TimeElement openingTime { get; set; }

			public TimeElement closingTime { get; set; }
		}
	}
}

using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[FhirUri("http://hl7.org/fhir/StructureDefinition/PractitionerRole")]
	public partial class PractitionerRole : DomainResource
	{

		public ICollection<Identifier> identifier { get; set; }

		public BooleanElement active { get; set; }

		public Period period { get; set; }

		public Reference practitioner { get; set; }

		public Reference organization { get; set; }

		[ValueSetBinding("PractitionerRole", "http://hl7.org/fhir/ValueSet/practitioner-role", false)]
		public ICollection<CodeableConcept> code { get; set; }

		[ValueSetBinding("PractitionerSpecialty", "http://hl7.org/fhir/ValueSet/c80-practice-codes", false)]
		public ICollection<CodeableConcept> specialty { get; set; }

		public ICollection<Reference> location { get; set; }

		public ICollection<Reference> healthcareService { get; set; }

		public ICollection<ContactPoint> telecom { get; set; }

		public ICollection<AvailableTimeComponent> availableTime { get; set; }

		public ICollection<NotAvailableComponent> notAvailable { get; set; }

		public StringElement availabilityExceptions { get; set; }

		public ICollection<Reference> endpoint { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/PractitionerRole.availableTime")]
		public partial class AvailableTimeComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[ValueSetBinding("DaysOfWeek", "http://hl7.org/fhir/ValueSet/days-of-week%7C4.0.1", true)]
			public ICollection<CodeElement> daysOfWeek { get; set; }

			public BooleanElement allDay { get; set; }

			public TimeElement availableStartTime { get; set; }

			public TimeElement availableEndTime { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/PractitionerRole.notAvailable")]
		public partial class NotAvailableComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			public StringElement description { get; set; }

			public Period during { get; set; }
		}
	}
}

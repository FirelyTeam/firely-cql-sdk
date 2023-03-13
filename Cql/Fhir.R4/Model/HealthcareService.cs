using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[FhirUri("http://hl7.org/fhir/StructureDefinition/HealthcareService")]
	public partial class HealthcareService : DomainResource
	{

		public ICollection<Identifier> identifier { get; set; }

		public BooleanElement active { get; set; }

		public Reference providedBy { get; set; }

		[ValueSetBinding("service-category", "http://hl7.org/fhir/ValueSet/service-category", false)]
		public ICollection<CodeableConcept> category { get; set; }

		[ValueSetBinding("service-type", "http://hl7.org/fhir/ValueSet/service-type", false)]
		public ICollection<CodeableConcept> type { get; set; }

		[ValueSetBinding("service-specialty", "http://hl7.org/fhir/ValueSet/c80-practice-codes", false)]
		public ICollection<CodeableConcept> specialty { get; set; }

		public ICollection<Reference> location { get; set; }

		public StringElement name { get; set; }

		public StringElement comment { get; set; }

		public MarkdownElement extraDetails { get; set; }

		public Attachment photo { get; set; }

		public ICollection<ContactPoint> telecom { get; set; }

		public ICollection<Reference> coverageArea { get; set; }

		[ValueSetBinding("ServiceProvisionConditions", "http://hl7.org/fhir/ValueSet/service-provision-conditions", false)]
		public ICollection<CodeableConcept> serviceProvisionCode { get; set; }

		public ICollection<EligibilityComponent> eligibility { get; set; }

		[ValueSetBinding("Program", "http://hl7.org/fhir/ValueSet/program", false)]
		public ICollection<CodeableConcept> program { get; set; }

		public ICollection<CodeableConcept> characteristic { get; set; }

		[ValueSetBinding("Language", "http://hl7.org/fhir/ValueSet/languages", false)]
		public ICollection<CodeableConcept> communication { get; set; }

		[ValueSetBinding("ReferralMethod", "http://hl7.org/fhir/ValueSet/service-referral-method", false)]
		public ICollection<CodeableConcept> referralMethod { get; set; }

		public BooleanElement appointmentRequired { get; set; }

		public ICollection<AvailableTimeComponent> availableTime { get; set; }

		public ICollection<NotAvailableComponent> notAvailable { get; set; }

		public StringElement availabilityExceptions { get; set; }

		public ICollection<Reference> endpoint { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/HealthcareService.eligibility")]
		public partial class EligibilityComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public CodeableConcept code { get; set; }

			public MarkdownElement comment { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/HealthcareService.availableTime")]
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
		[FhirUri("http://hl7.org/fhir/StructureDefinition/HealthcareService.notAvailable")]
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

using Hl7.Cql.Poco.Fhir;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Hl7.Cql.Poco.Fhir.R4.Model
{
    [FhirUri("http://hl7.org/fhir/StructureDefinition/ServiceRequest")]
	public partial class ServiceRequest : DomainResource
	{

		public ICollection<Identifier> identifier { get; set; }

		public ICollection<CanonicalElement> instantiatesCanonical { get; set; }

		public ICollection<UriElement> instantiatesUri { get; set; }

		public ICollection<Reference> basedOn { get; set; }

		public ICollection<Reference> replaces { get; set; }

		public Identifier requisition { get; set; }

		[NotNull]
		[ValueSetBinding("ServiceRequestStatus", "http://hl7.org/fhir/ValueSet/request-status%7C4.0.1", true)]
		public CodeElement status { get; set; }

		[NotNull]
		[ValueSetBinding("ServiceRequestIntent", "http://hl7.org/fhir/ValueSet/request-intent%7C4.0.1", true)]
		public CodeElement intent { get; set; }

		[ValueSetBinding("ServiceRequestCategory", "http://hl7.org/fhir/ValueSet/servicerequest-category", false)]
		public ICollection<CodeableConcept> category { get; set; }

		[ValueSetBinding("ServiceRequestPriority", "http://hl7.org/fhir/ValueSet/request-priority%7C4.0.1", true)]
		public CodeElement priority { get; set; }

		public BooleanElement doNotPerform { get; set; }

		[ValueSetBinding("ServiceRequestCode", "http://hl7.org/fhir/ValueSet/procedure-code", false)]
		public CodeableConcept code { get; set; }

		[ValueSetBinding("OrderDetail", "http://hl7.org/fhir/ValueSet/servicerequest-orderdetail", false)]
		public ICollection<CodeableConcept> orderDetail { get; set; }

		[Choice(typeof(Quantity))]
		[Choice(typeof(Ratio))]
		[Choice(typeof(Range))]
		[JsonIgnore]
		public Element quantity { get; set; }
		public Quantity quantityQuantity { get => ChoiceAttribute.AsExactly<Quantity>(quantity); set { quantity = value; } }
		public Ratio quantityRatio { get => ChoiceAttribute.AsExactly<Ratio>(quantity); set { quantity = value; } }
		public Range quantityRange { get => ChoiceAttribute.AsExactly<Range>(quantity); set { quantity = value; } }

		[NotNull]
		public Reference subject { get; set; }

		public Reference encounter { get; set; }

		[Choice(typeof(DateTimeElement))]
		[Choice(typeof(Period))]
		[Choice(typeof(Timing))]
		[JsonIgnore]
		public Element occurrence { get; set; }
		public DateTimeElement occurrenceDateTime { get => ChoiceAttribute.AsExactly<DateTimeElement>(occurrence); set { occurrence = value; } }
		public Period occurrencePeriod { get => ChoiceAttribute.AsExactly<Period>(occurrence); set { occurrence = value; } }
		public Timing occurrenceTiming { get => ChoiceAttribute.AsExactly<Timing>(occurrence); set { occurrence = value; } }

		[Choice(typeof(BooleanElement))]
		[Choice(typeof(CodeableConcept))]
		[JsonIgnore]
		[ValueSetBinding("ProcedureAsNeededReason", "http://hl7.org/fhir/ValueSet/medication-as-needed-reason", false)]
		public Element asNeeded { get; set; }
		public BooleanElement asNeededBoolean { get => ChoiceAttribute.AsExactly<BooleanElement>(asNeeded); set { asNeeded = value; } }
		public CodeableConcept asNeededCodeableConcept { get => ChoiceAttribute.AsExactly<CodeableConcept>(asNeeded); set { asNeeded = value; } }

		public DateTimeElement authoredOn { get; set; }

		public Reference requester { get; set; }

		[ValueSetBinding("ServiceRequestParticipantRole", "http://hl7.org/fhir/ValueSet/participant-role", false)]
		public CodeableConcept performerType { get; set; }

		public ICollection<Reference> performer { get; set; }

		[ValueSetBinding("ServiceRequestLocation", "http://terminology.hl7.org/ValueSet/v3-ServiceDeliveryLocationRoleType", false)]
		public ICollection<CodeableConcept> locationCode { get; set; }

		public ICollection<Reference> locationReference { get; set; }

		[ValueSetBinding("ServiceRequestReason", "http://hl7.org/fhir/ValueSet/procedure-reason", false)]
		public ICollection<CodeableConcept> reasonCode { get; set; }

		public ICollection<Reference> reasonReference { get; set; }

		public ICollection<Reference> insurance { get; set; }

		public ICollection<Reference> supportingInfo { get; set; }

		public ICollection<Reference> specimen { get; set; }

		[ValueSetBinding("BodySite", "http://hl7.org/fhir/ValueSet/body-site", false)]
		public ICollection<CodeableConcept> bodySite { get; set; }

		public ICollection<Annotation> note { get; set; }

		public StringElement patientInstruction { get; set; }

		public ICollection<Reference> relevantHistory { get; set; }
	}
}

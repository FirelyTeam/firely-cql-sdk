using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[FhirUri("http://hl7.org/fhir/StructureDefinition/DeviceRequest")]
	public partial class DeviceRequest : DomainResource
	{

		public ICollection<Identifier> identifier { get; set; }

		public ICollection<CanonicalElement> instantiatesCanonical { get; set; }

		public ICollection<UriElement> instantiatesUri { get; set; }

		public ICollection<Reference> basedOn { get; set; }

		public ICollection<Reference> priorRequest { get; set; }

		public Identifier groupIdentifier { get; set; }

		[ValueSetBinding("DeviceRequestStatus", "http://hl7.org/fhir/ValueSet/request-status%7C4.0.1", true)]
		public CodeElement status { get; set; }

		[NotNull]
		[ValueSetBinding("RequestIntent", "http://hl7.org/fhir/ValueSet/request-intent%7C4.0.1", true)]
		public CodeElement intent { get; set; }

		[ValueSetBinding("RequestPriority", "http://hl7.org/fhir/ValueSet/request-priority%7C4.0.1", true)]
		public CodeElement priority { get; set; }

		[NotNull]
		[Choice(typeof(Reference))]
		[Choice(typeof(CodeableConcept))]
		[JsonIgnore]
		[ValueSetBinding("DeviceRequestCode", "http://hl7.org/fhir/ValueSet/device-kind", false)]
		public Element code { get; set; }
		public Reference codeReference { get => ChoiceAttribute.AsExactly<Reference>(code); set { code = value; } }
		public CodeableConcept codeCodeableConcept { get => ChoiceAttribute.AsExactly<CodeableConcept>(code); set { code = value; } }

		public ICollection<ParameterComponent> parameter { get; set; }

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

		public DateTimeElement authoredOn { get; set; }

		public Reference requester { get; set; }

		[ValueSetBinding("DeviceRequestParticipantRole", "http://hl7.org/fhir/ValueSet/participant-role", false)]
		public CodeableConcept performerType { get; set; }

		public Reference performer { get; set; }

		[ValueSetBinding("DeviceRequestReason", "http://hl7.org/fhir/ValueSet/condition-code", false)]
		public ICollection<CodeableConcept> reasonCode { get; set; }

		public ICollection<Reference> reasonReference { get; set; }

		public ICollection<Reference> insurance { get; set; }

		public ICollection<Reference> supportingInfo { get; set; }

		public ICollection<Annotation> note { get; set; }

		public ICollection<Reference> relevantHistory { get; set; }
		[DebuggerDisplay("{value}")]
		[FhirUri("http://hl7.org/fhir/StructureDefinition/DeviceRequest.parameter")]
		public partial class ParameterComponent
		{

			[Choice(typeof(CodeableConcept))]
			[Choice(typeof(Quantity))]
			[Choice(typeof(Range))]
			[Choice(typeof(BooleanElement))]
			[JsonIgnore]
			public Element value { get; set; }
			public CodeableConcept valueCodeableConcept { get => ChoiceAttribute.AsExactly<CodeableConcept>(value); set { this.value = value; } }
			public Quantity valueQuantity { get => ChoiceAttribute.AsExactly<Quantity>(value); set { this.value = value; } }
			public Range valueRange { get => ChoiceAttribute.AsExactly<Range>(value); set { this.value = value; } }
			public BooleanElement valueBoolean { get => ChoiceAttribute.AsExactly<BooleanElement>(value); set { this.value = value; } }

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public CodeableConcept code { get; set; }
		}
	}
}

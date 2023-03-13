using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[FhirUri("http://hl7.org/fhir/StructureDefinition/CommunicationRequest")]
	public partial class CommunicationRequest : DomainResource
	{

		public ICollection<Identifier> identifier { get; set; }

		public ICollection<Reference> basedOn { get; set; }

		public ICollection<Reference> replaces { get; set; }

		public Identifier groupIdentifier { get; set; }

		[NotNull]
		[ValueSetBinding("CommunicationRequestStatus", "http://hl7.org/fhir/ValueSet/request-status%7C4.0.1", true)]
		public CodeElement status { get; set; }

		public CodeableConcept statusReason { get; set; }

		[ValueSetBinding("CommunicationCategory", "http://hl7.org/fhir/ValueSet/communication-category", false)]
		public ICollection<CodeableConcept> category { get; set; }

		[ValueSetBinding("CommunicationPriority", "http://hl7.org/fhir/ValueSet/request-priority%7C4.0.1", true)]
		public CodeElement priority { get; set; }

		public BooleanElement doNotPerform { get; set; }

		[ValueSetBinding("CommunicationMedium", "http://terminology.hl7.org/ValueSet/v3-ParticipationMode", false)]
		public ICollection<CodeableConcept> medium { get; set; }

		public Reference subject { get; set; }

		public ICollection<Reference> about { get; set; }

		public Reference encounter { get; set; }

		public ICollection<PayloadComponent> payload { get; set; }

		[Choice(typeof(DateTimeElement))]
		[Choice(typeof(Period))]
		[JsonIgnore]
		public Element occurrence { get; set; }
		public DateTimeElement occurrenceDateTime { get => ChoiceAttribute.AsExactly<DateTimeElement>(occurrence); set { occurrence = value; } }
		public Period occurrencePeriod { get => ChoiceAttribute.AsExactly<Period>(occurrence); set { occurrence = value; } }

		public DateTimeElement authoredOn { get; set; }

		public Reference requester { get; set; }

		public ICollection<Reference> recipient { get; set; }

		public Reference sender { get; set; }

		[ValueSetBinding("CommunicationReason", "http://terminology.hl7.org/ValueSet/v3-ActReason", false)]
		public ICollection<CodeableConcept> reasonCode { get; set; }

		public ICollection<Reference> reasonReference { get; set; }

		public ICollection<Annotation> note { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/CommunicationRequest.payload")]
		public partial class PayloadComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			[Choice(typeof(StringElement))]
			[Choice(typeof(Attachment))]
			[Choice(typeof(Reference))]
			[JsonIgnore]
			public Element content { get; set; }
			public StringElement contentString { get => ChoiceAttribute.AsExactly<StringElement>(content); set { content = value; } }
			public Attachment contentAttachment { get => ChoiceAttribute.AsExactly<Attachment>(content); set { content = value; } }
			public Reference contentReference { get => ChoiceAttribute.AsExactly<Reference>(content); set { content = value; } }
		}
	}
}

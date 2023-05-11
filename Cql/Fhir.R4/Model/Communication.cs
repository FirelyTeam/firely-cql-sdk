using Hl7.Cql.Poco.Fhir;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Hl7.Cql.Poco.Fhir.R4.Model
{
    [FhirUri("http://hl7.org/fhir/StructureDefinition/Communication")]
	public partial class Communication : DomainResource
	{

		public ICollection<Identifier> identifier { get; set; }

		public ICollection<CanonicalElement> instantiatesCanonical { get; set; }

		public ICollection<UriElement> instantiatesUri { get; set; }

		public ICollection<Reference> basedOn { get; set; }

		public ICollection<Reference> partOf { get; set; }

		public ICollection<Reference> inResponseTo { get; set; }

		[NotNull]
		[ValueSetBinding("CommunicationStatus", "http://hl7.org/fhir/ValueSet/event-status%7C4.0.1", true)]
		public CodeElement status { get; set; }

		[ValueSetBinding("CommunicationNotDoneReason", "http://hl7.org/fhir/ValueSet/communication-not-done-reason", false)]
		public CodeableConcept statusReason { get; set; }

		[ValueSetBinding("CommunicationCategory", "http://hl7.org/fhir/ValueSet/communication-category", false)]
		public ICollection<CodeableConcept> category { get; set; }

		[ValueSetBinding("CommunicationPriority", "http://hl7.org/fhir/ValueSet/request-priority%7C4.0.1", true)]
		public CodeElement priority { get; set; }

		[ValueSetBinding("CommunicationMedium", "http://terminology.hl7.org/ValueSet/v3-ParticipationMode", false)]
		public ICollection<CodeableConcept> medium { get; set; }

		public Reference subject { get; set; }

		[ValueSetBinding("CommunicationTopic", "http://hl7.org/fhir/ValueSet/communication-topic", false)]
		public CodeableConcept topic { get; set; }

		public ICollection<Reference> about { get; set; }

		public Reference encounter { get; set; }

		public DateTimeElement sent { get; set; }

		public DateTimeElement received { get; set; }

		public ICollection<Reference> recipient { get; set; }

		public Reference sender { get; set; }

		[ValueSetBinding("CommunicationReason", "http://hl7.org/fhir/ValueSet/clinical-findings", false)]
		public ICollection<CodeableConcept> reasonCode { get; set; }

		public ICollection<Reference> reasonReference { get; set; }

		public ICollection<PayloadComponent> payload { get; set; }

		public ICollection<Annotation> note { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/Communication.payload")]
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

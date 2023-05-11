using Hl7.Cql.Poco.Fhir;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Hl7.Cql.Poco.Fhir.R4.Model
{
    [FhirUri("http://hl7.org/fhir/StructureDefinition/MessageHeader")]
	public partial class MessageHeader : DomainResource
	{

		[NotNull]
		[Choice(typeof(Coding))]
		[Choice(typeof(UriElement))]
		[JsonIgnore]
		[ValueSetBinding("MessageEvent", "http://hl7.org/fhir/ValueSet/message-events", false)]
		public Element @event { get; set; }
		public Coding @eventCoding { get => ChoiceAttribute.AsExactly<Coding>(@event); set { @event = value; } }
		public UriElement @eventUri { get => ChoiceAttribute.AsExactly<UriElement>(@event); set { @event = value; } }

		public ICollection<DestinationComponent> destination { get; set; }

		public Reference sender { get; set; }

		public Reference enterer { get; set; }

		public Reference author { get; set; }

		[NotNull]
		public SourceComponent source { get; set; }

		public Reference responsible { get; set; }

		[ValueSetBinding("EventReason", "http://hl7.org/fhir/ValueSet/message-reason-encounter", false)]
		public CodeableConcept reason { get; set; }

		public ResponseComponent response { get; set; }

		public ICollection<Reference> focus { get; set; }

		public CanonicalElement definition { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/MessageHeader.destination")]
		public partial class DestinationComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public StringElement name { get; set; }

			public Reference target { get; set; }

			[NotNull]
			public UrlElement endpoint { get; set; }

			public Reference receiver { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/MessageHeader.source")]
		public partial class SourceComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public StringElement name { get; set; }

			public StringElement software { get; set; }

			public StringElement version { get; set; }

			public ContactPoint contact { get; set; }

			[NotNull]
			public UrlElement endpoint { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/MessageHeader.response")]
		public partial class ResponseComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			public IdElement identifier { get; set; }

			[NotNull]
			[ValueSetBinding("ResponseType", "http://hl7.org/fhir/ValueSet/response-code%7C4.0.1", true)]
			public CodeElement code { get; set; }

			public Reference details { get; set; }
		}
	}
}

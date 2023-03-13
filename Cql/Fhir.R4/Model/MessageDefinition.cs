using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[FhirUri("http://hl7.org/fhir/StructureDefinition/MessageDefinition")]
	public partial class MessageDefinition : DomainResource
	{

		public UriElement url { get; set; }

		public ICollection<Identifier> identifier { get; set; }

		public StringElement version { get; set; }

		public StringElement name { get; set; }

		public StringElement title { get; set; }

		public ICollection<CanonicalElement> replaces { get; set; }

		[NotNull]
		[ValueSetBinding("PublicationStatus", "http://hl7.org/fhir/ValueSet/publication-status%7C4.0.1", true)]
		public CodeElement status { get; set; }

		public BooleanElement experimental { get; set; }

		[NotNull]
		public DateTimeElement date { get; set; }

		public StringElement publisher { get; set; }

		public ICollection<ContactDetail> contact { get; set; }

		public MarkdownElement description { get; set; }

		public ICollection<UsageContext> useContext { get; set; }

		[ValueSetBinding("Jurisdiction", "http://hl7.org/fhir/ValueSet/jurisdiction", false)]
		public ICollection<CodeableConcept> jurisdiction { get; set; }

		public MarkdownElement purpose { get; set; }

		public MarkdownElement copyright { get; set; }

		public CanonicalElement @base { get; set; }

		public ICollection<CanonicalElement> parent { get; set; }

		[NotNull]
		[Choice(typeof(Coding))]
		[Choice(typeof(UriElement))]
		[JsonIgnore]
		[ValueSetBinding("MessageEvent", "http://hl7.org/fhir/ValueSet/message-events", false)]
		public Element @event { get; set; }
		public Coding @eventCoding { get => ChoiceAttribute.AsExactly<Coding>(@event); set { @event = value; } }
		public UriElement @eventUri { get => ChoiceAttribute.AsExactly<UriElement>(@event); set { @event = value; } }

		[ValueSetBinding("MessageSignificanceCategory", "http://hl7.org/fhir/ValueSet/message-significance-category%7C4.0.1", true)]
		public CodeElement category { get; set; }

		public ICollection<FocusComponent> focus { get; set; }

		[ValueSetBinding("messageheader-response-request", "http://hl7.org/fhir/ValueSet/messageheader-response-request%7C4.0.1", true)]
		public CodeElement responseRequired { get; set; }

		public ICollection<AllowedResponseComponent> allowedResponse { get; set; }

		public ICollection<CanonicalElement> graph { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/MessageDefinition.focus")]
		public partial class FocusComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			[ValueSetBinding("ResourceType", "http://hl7.org/fhir/ValueSet/resource-types%7C4.0.1", true)]
			public CodeElement code { get; set; }

			public CanonicalElement profile { get; set; }

			[NotNull]
			public UnsignedIntElement min { get; set; }

			public StringElement max { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/MessageDefinition.allowedResponse")]
		public partial class AllowedResponseComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			public CanonicalElement message { get; set; }

			public MarkdownElement situation { get; set; }
		}
	}
}

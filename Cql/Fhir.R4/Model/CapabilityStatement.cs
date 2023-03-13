using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[FhirUri("http://hl7.org/fhir/StructureDefinition/CapabilityStatement")]
	public partial class CapabilityStatement : DomainResource
	{

		public UriElement url { get; set; }

		public StringElement version { get; set; }

		public StringElement name { get; set; }

		public StringElement title { get; set; }

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

		[NotNull]
		[ValueSetBinding("CapabilityStatementKind", "http://hl7.org/fhir/ValueSet/capability-statement-kind%7C4.0.1", true)]
		public CodeElement kind { get; set; }

		public ICollection<CanonicalElement> instantiates { get; set; }

		public ICollection<CanonicalElement> imports { get; set; }

		public SoftwareComponent software { get; set; }

		public ImplementationComponent implementation { get; set; }

		[NotNull]
		[ValueSetBinding("FHIRVersion", "http://hl7.org/fhir/ValueSet/FHIR-version%7C4.0.1", true)]
		public CodeElement fhirVersion { get; set; }

		[ValueSetBinding("MimeType", "http://hl7.org/fhir/ValueSet/mimetypes%7C4.0.1", true)]
		public ICollection<CodeElement> format { get; set; }

		[ValueSetBinding("MimeType", "http://hl7.org/fhir/ValueSet/mimetypes%7C4.0.1", true)]
		public ICollection<CodeElement> patchFormat { get; set; }

		public ICollection<CanonicalElement> implementationGuide { get; set; }

		public ICollection<RestComponent> rest { get; set; }

		public ICollection<MessagingComponent> messaging { get; set; }

		public ICollection<DocumentComponent> document { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/CapabilityStatement.software")]
		public partial class SoftwareComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			public StringElement name { get; set; }

			public StringElement version { get; set; }

			public DateTimeElement releaseDate { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/CapabilityStatement.implementation")]
		public partial class ImplementationComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			public StringElement description { get; set; }

			public UrlElement url { get; set; }

			public Reference custodian { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/CapabilityStatement.rest")]
		public partial class RestComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			[ValueSetBinding("RestfulCapabilityMode", "http://hl7.org/fhir/ValueSet/restful-capability-mode%7C4.0.1", true)]
			public CodeElement mode { get; set; }

			public MarkdownElement documentation { get; set; }

			public SecurityComponent security { get; set; }

			public ICollection<ResourceComponent> resource { get; set; }

			public ICollection<InteractionComponent> interaction { get; set; }

			public ICollection<CanonicalElement> compartment { get; set; }
			[FhirUri("http://hl7.org/fhir/StructureDefinition/CapabilityStatement.rest.security")]
			public partial class SecurityComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				public BooleanElement cors { get; set; }

				[ValueSetBinding("RestfulSecurityService", "http://hl7.org/fhir/ValueSet/restful-security-service", false)]
				public ICollection<CodeableConcept> service { get; set; }

				public MarkdownElement description { get; set; }
			}
			[FhirUri("http://hl7.org/fhir/StructureDefinition/CapabilityStatement.rest.resource")]
			public partial class ResourceComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				[NotNull]
				[ValueSetBinding("ResourceType", "http://hl7.org/fhir/ValueSet/resource-types%7C4.0.1", true)]
				public CodeElement type { get; set; }

				public CanonicalElement profile { get; set; }

				public ICollection<CanonicalElement> supportedProfile { get; set; }

				public MarkdownElement documentation { get; set; }

				public ICollection<InteractionComponent> interaction { get; set; }

				[ValueSetBinding("ResourceVersionPolicy", "http://hl7.org/fhir/ValueSet/versioning-policy%7C4.0.1", true)]
				public CodeElement versioning { get; set; }

				public BooleanElement readHistory { get; set; }

				public BooleanElement updateCreate { get; set; }

				public BooleanElement conditionalCreate { get; set; }

				[ValueSetBinding("ConditionalReadStatus", "http://hl7.org/fhir/ValueSet/conditional-read-status%7C4.0.1", true)]
				public CodeElement conditionalRead { get; set; }

				public BooleanElement conditionalUpdate { get; set; }

				[ValueSetBinding("ConditionalDeleteStatus", "http://hl7.org/fhir/ValueSet/conditional-delete-status%7C4.0.1", true)]
				public CodeElement conditionalDelete { get; set; }

				[ValueSetBinding("ReferenceHandlingPolicy", "http://hl7.org/fhir/ValueSet/reference-handling-policy%7C4.0.1", true)]
				public ICollection<CodeElement> referencePolicy { get; set; }

				public ICollection<StringElement> searchInclude { get; set; }

				public ICollection<StringElement> searchRevInclude { get; set; }

				public ICollection<SearchParamComponent> searchParam { get; set; }

				public ICollection<OperationComponent> operation { get; set; }
				[FhirUri("http://hl7.org/fhir/StructureDefinition/CapabilityStatement.rest.resource.interaction")]
				public partial class InteractionComponent
				{

					public string id { get; set; }

					public ICollection<Extension> extension { get; set; }

					public ICollection<Extension> modifierExtension { get; set; }

					[NotNull]
					[ValueSetBinding("TypeRestfulInteraction", "http://hl7.org/fhir/ValueSet/type-restful-interaction%7C4.0.1", true)]
					public CodeElement code { get; set; }

					public MarkdownElement documentation { get; set; }
				}
				[FhirUri("http://hl7.org/fhir/StructureDefinition/CapabilityStatement.rest.resource.searchParam")]
				public partial class SearchParamComponent
				{

					public string id { get; set; }

					public ICollection<Extension> extension { get; set; }

					public ICollection<Extension> modifierExtension { get; set; }

					[NotNull]
					public StringElement name { get; set; }

					public CanonicalElement definition { get; set; }

					[NotNull]
					[ValueSetBinding("SearchParamType", "http://hl7.org/fhir/ValueSet/search-param-type%7C4.0.1", true)]
					public CodeElement type { get; set; }

					public MarkdownElement documentation { get; set; }
				}
				[FhirUri("http://hl7.org/fhir/StructureDefinition/CapabilityStatement.rest.resource.operation")]
				public partial class OperationComponent
				{

					public string id { get; set; }

					public ICollection<Extension> extension { get; set; }

					public ICollection<Extension> modifierExtension { get; set; }

					[NotNull]
					public StringElement name { get; set; }

					[NotNull]
					public CanonicalElement definition { get; set; }

					public MarkdownElement documentation { get; set; }
				}
			}
			[FhirUri("http://hl7.org/fhir/StructureDefinition/CapabilityStatement.rest.interaction")]
			public partial class InteractionComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				[NotNull]
				[ValueSetBinding("SystemRestfulInteraction", "http://hl7.org/fhir/ValueSet/system-restful-interaction%7C4.0.1", true)]
				public CodeElement code { get; set; }

				public MarkdownElement documentation { get; set; }
			}
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/CapabilityStatement.messaging")]
		public partial class MessagingComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public ICollection<EndpointComponent> endpoint { get; set; }

			public UnsignedIntElement reliableCache { get; set; }

			public MarkdownElement documentation { get; set; }

			public ICollection<SupportedMessageComponent> supportedMessage { get; set; }
			[FhirUri("http://hl7.org/fhir/StructureDefinition/CapabilityStatement.messaging.endpoint")]
			public partial class EndpointComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				[NotNull]
				[ValueSetBinding("MessageTransport", "http://hl7.org/fhir/ValueSet/message-transport", false)]
				public Coding protocol { get; set; }

				[NotNull]
				public UrlElement address { get; set; }
			}
			[FhirUri("http://hl7.org/fhir/StructureDefinition/CapabilityStatement.messaging.supportedMessage")]
			public partial class SupportedMessageComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				[NotNull]
				[ValueSetBinding("EventCapabilityMode", "http://hl7.org/fhir/ValueSet/event-capability-mode%7C4.0.1", true)]
				public CodeElement mode { get; set; }

				[NotNull]
				public CanonicalElement definition { get; set; }
			}
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/CapabilityStatement.document")]
		public partial class DocumentComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			[ValueSetBinding("DocumentMode", "http://hl7.org/fhir/ValueSet/document-mode%7C4.0.1", true)]
			public CodeElement mode { get; set; }

			public MarkdownElement documentation { get; set; }

			[NotNull]
			public CanonicalElement profile { get; set; }
		}
	}
}

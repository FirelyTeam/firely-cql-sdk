using Hl7.Cql.Poco.Fhir;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace Hl7.Cql.Poco.Fhir.R4.Model
{
    [FhirUri("http://hl7.org/fhir/StructureDefinition/TestScript")]
	public partial class TestScript : DomainResource
	{

		[NotNull]
		public UriElement url { get; set; }

		public Identifier identifier { get; set; }

		public StringElement version { get; set; }

		[NotNull]
		public StringElement name { get; set; }

		public StringElement title { get; set; }

		[NotNull]
		[ValueSetBinding("PublicationStatus", "http://hl7.org/fhir/ValueSet/publication-status%7C4.0.1", true)]
		public CodeElement status { get; set; }

		public BooleanElement experimental { get; set; }

		public DateTimeElement date { get; set; }

		public StringElement publisher { get; set; }

		public ICollection<ContactDetail> contact { get; set; }

		public MarkdownElement description { get; set; }

		public ICollection<UsageContext> useContext { get; set; }

		[ValueSetBinding("Jurisdiction", "http://hl7.org/fhir/ValueSet/jurisdiction", false)]
		public ICollection<CodeableConcept> jurisdiction { get; set; }

		public MarkdownElement purpose { get; set; }

		public MarkdownElement copyright { get; set; }

		public ICollection<OriginComponent> origin { get; set; }

		public ICollection<DestinationComponent> destination { get; set; }

		public MetadataComponent metadata { get; set; }

		public ICollection<FixtureComponent> fixture { get; set; }

		public ICollection<Reference> profile { get; set; }

		public ICollection<VariableComponent> variable { get; set; }

		public SetupComponent setup { get; set; }

		public ICollection<TestComponent> test { get; set; }

		public TeardownComponent teardown { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/TestScript.origin")]
		public partial class OriginComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			public IntegerElement index { get; set; }

			[NotNull]
			[ValueSetBinding("TestScriptProfileOriginType", "http://hl7.org/fhir/ValueSet/testscript-profile-origin-types", false)]
			public Coding profile { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/TestScript.destination")]
		public partial class DestinationComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			public IntegerElement index { get; set; }

			[NotNull]
			[ValueSetBinding("TestScriptProfileDestinationType", "http://hl7.org/fhir/ValueSet/testscript-profile-destination-types", false)]
			public Coding profile { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/TestScript.metadata")]
		public partial class MetadataComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public ICollection<LinkComponent> link { get; set; }

			public ICollection<CapabilityComponent> capability { get; set; }
			[FhirUri("http://hl7.org/fhir/StructureDefinition/TestScript.metadata.link")]
			public partial class LinkComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				[NotNull]
				public UriElement url { get; set; }

				public StringElement description { get; set; }
			}
			[FhirUri("http://hl7.org/fhir/StructureDefinition/TestScript.metadata.capability")]
			public partial class CapabilityComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				[NotNull]
				public BooleanElement required { get; set; }

				[NotNull]
				public BooleanElement validated { get; set; }

				public StringElement description { get; set; }

				public ICollection<IntegerElement> origin { get; set; }

				public IntegerElement destination { get; set; }

				public ICollection<UriElement> link { get; set; }

				[NotNull]
				public CanonicalElement capabilities { get; set; }
			}
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/TestScript.fixture")]
		public partial class FixtureComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			public BooleanElement autocreate { get; set; }

			[NotNull]
			public BooleanElement autodelete { get; set; }

			public Reference resource { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/TestScript.variable")]
		public partial class VariableComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			public StringElement name { get; set; }

			public StringElement defaultValue { get; set; }

			public StringElement description { get; set; }

			public StringElement expression { get; set; }

			public StringElement headerField { get; set; }

			public StringElement hint { get; set; }

			public StringElement path { get; set; }

			public IdElement sourceId { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/TestScript.setup")]
		public partial class SetupComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public ICollection<ActionComponent> action { get; set; }
			[FhirUri("http://hl7.org/fhir/StructureDefinition/TestScript.setup.action")]
			public partial class ActionComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				public OperationComponent operation { get; set; }

				public AssertComponent assert { get; set; }
				[FhirUri("http://hl7.org/fhir/StructureDefinition/TestScript.setup.action.operation")]
				public partial class OperationComponent
				{

					public string id { get; set; }

					public ICollection<Extension> extension { get; set; }

					public ICollection<Extension> modifierExtension { get; set; }

					[ValueSetBinding("TestScriptOperationCode", "http://hl7.org/fhir/ValueSet/testscript-operation-codes", false)]
					public Coding type { get; set; }

					[ValueSetBinding("FHIRDefinedType", "http://hl7.org/fhir/ValueSet/defined-types%7C4.0.1", true)]
					public CodeElement resource { get; set; }

					public StringElement label { get; set; }

					public StringElement description { get; set; }

					[ValueSetBinding("MimeType", "http://hl7.org/fhir/ValueSet/mimetypes%7C4.0.1", true)]
					public CodeElement accept { get; set; }

					[ValueSetBinding("MimeType", "http://hl7.org/fhir/ValueSet/mimetypes%7C4.0.1", true)]
					public CodeElement contentType { get; set; }

					public IntegerElement destination { get; set; }

					[NotNull]
					public BooleanElement encodeRequestUrl { get; set; }

					[ValueSetBinding("TestScriptRequestMethodCode", "http://hl7.org/fhir/ValueSet/http-operations%7C4.0.1", true)]
					public CodeElement method { get; set; }

					public IntegerElement origin { get; set; }

					public StringElement @params { get; set; }

					public ICollection<RequestHeaderComponent> requestHeader { get; set; }

					public IdElement requestId { get; set; }

					public IdElement responseId { get; set; }

					public IdElement sourceId { get; set; }

					public IdElement targetId { get; set; }

					public StringElement url { get; set; }
					[DebuggerDisplay("{value}")]
					[FhirUri("http://hl7.org/fhir/StructureDefinition/TestScript.setup.action.operation.requestHeader")]
					public partial class RequestHeaderComponent
					{

						[NotNull]
						public StringElement value { get; set; }

						public string id { get; set; }

						public ICollection<Extension> extension { get; set; }

						public ICollection<Extension> modifierExtension { get; set; }

						[NotNull]
						public StringElement field { get; set; }
					}
				}
				[DebuggerDisplay("{value}")]
				[FhirUri("http://hl7.org/fhir/StructureDefinition/TestScript.setup.action.assert")]
				public partial class AssertComponent
				{

					public StringElement value { get; set; }

					public string id { get; set; }

					public ICollection<Extension> extension { get; set; }

					public ICollection<Extension> modifierExtension { get; set; }

					public StringElement label { get; set; }

					public StringElement description { get; set; }

					[ValueSetBinding("AssertionDirectionType", "http://hl7.org/fhir/ValueSet/assert-direction-codes%7C4.0.1", true)]
					public CodeElement direction { get; set; }

					public StringElement compareToSourceId { get; set; }

					public StringElement compareToSourceExpression { get; set; }

					public StringElement compareToSourcePath { get; set; }

					[ValueSetBinding("MimeType", "http://hl7.org/fhir/ValueSet/mimetypes%7C4.0.1", true)]
					public CodeElement contentType { get; set; }

					public StringElement expression { get; set; }

					public StringElement headerField { get; set; }

					public StringElement minimumId { get; set; }

					public BooleanElement navigationLinks { get; set; }

					[ValueSetBinding("AssertionOperatorType", "http://hl7.org/fhir/ValueSet/assert-operator-codes%7C4.0.1", true)]
					public CodeElement @operator { get; set; }

					public StringElement path { get; set; }

					[ValueSetBinding("TestScriptRequestMethodCode", "http://hl7.org/fhir/ValueSet/http-operations%7C4.0.1", true)]
					public CodeElement requestMethod { get; set; }

					public StringElement requestURL { get; set; }

					[ValueSetBinding("FHIRDefinedType", "http://hl7.org/fhir/ValueSet/defined-types%7C4.0.1", true)]
					public CodeElement resource { get; set; }

					[ValueSetBinding("AssertionResponseTypes", "http://hl7.org/fhir/ValueSet/assert-response-code-types%7C4.0.1", true)]
					public CodeElement response { get; set; }

					public StringElement responseCode { get; set; }

					public IdElement sourceId { get; set; }

					public IdElement validateProfileId { get; set; }

					[NotNull]
					public BooleanElement warningOnly { get; set; }
				}
			}
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/TestScript.test")]
		public partial class TestComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public StringElement name { get; set; }

			public StringElement description { get; set; }

			public ICollection<ActionComponent> action { get; set; }
			[FhirUri("http://hl7.org/fhir/StructureDefinition/TestScript.test.action")]
			public partial class ActionComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }
			}
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/TestScript.teardown")]
		public partial class TeardownComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public ICollection<ActionComponent> action { get; set; }
			[FhirUri("http://hl7.org/fhir/StructureDefinition/TestScript.teardown.action")]
			public partial class ActionComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }
			}
		}
	}
}

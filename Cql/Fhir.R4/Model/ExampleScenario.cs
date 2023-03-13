using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[FhirUri("http://hl7.org/fhir/StructureDefinition/ExampleScenario")]
	public partial class ExampleScenario : DomainResource
	{

		public UriElement url { get; set; }

		public ICollection<Identifier> identifier { get; set; }

		public StringElement version { get; set; }

		public StringElement name { get; set; }

		[NotNull]
		[ValueSetBinding("PublicationStatus", "http://hl7.org/fhir/ValueSet/publication-status%7C4.0.1", true)]
		public CodeElement status { get; set; }

		public BooleanElement experimental { get; set; }

		public DateTimeElement date { get; set; }

		public StringElement publisher { get; set; }

		public ICollection<ContactDetail> contact { get; set; }

		public ICollection<UsageContext> useContext { get; set; }

		[ValueSetBinding("Jurisdiction", "http://hl7.org/fhir/ValueSet/jurisdiction", false)]
		public ICollection<CodeableConcept> jurisdiction { get; set; }

		public MarkdownElement copyright { get; set; }

		public MarkdownElement purpose { get; set; }

		public ICollection<ActorComponent> actor { get; set; }

		public ICollection<InstanceComponent> instance { get; set; }

		public ICollection<ProcessComponent> process { get; set; }

		public ICollection<CanonicalElement> workflow { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/ExampleScenario.actor")]
		public partial class ActorComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			public StringElement actorId { get; set; }

			[NotNull]
			[ValueSetBinding("ExampleScenarioActorType", "http://hl7.org/fhir/ValueSet/examplescenario-actor-type%7C4.0.1", true)]
			public CodeElement type { get; set; }

			public StringElement name { get; set; }

			public MarkdownElement description { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/ExampleScenario.instance")]
		public partial class InstanceComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			public StringElement resourceId { get; set; }

			[NotNull]
			[ValueSetBinding("FHIRResourceType", "http://hl7.org/fhir/ValueSet/resource-types%7C4.0.1", true)]
			public CodeElement resourceType { get; set; }

			public StringElement name { get; set; }

			public MarkdownElement description { get; set; }

			public ICollection<VersionComponent> version { get; set; }

			public ICollection<ContainedInstanceComponent> containedInstance { get; set; }
			[FhirUri("http://hl7.org/fhir/StructureDefinition/ExampleScenario.instance.version")]
			public partial class VersionComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				[NotNull]
				public StringElement versionId { get; set; }

				[NotNull]
				public MarkdownElement description { get; set; }
			}
			[FhirUri("http://hl7.org/fhir/StructureDefinition/ExampleScenario.instance.containedInstance")]
			public partial class ContainedInstanceComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				[NotNull]
				public StringElement resourceId { get; set; }

				public StringElement versionId { get; set; }
			}
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/ExampleScenario.process")]
		public partial class ProcessComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			public StringElement title { get; set; }

			public MarkdownElement description { get; set; }

			public MarkdownElement preConditions { get; set; }

			public MarkdownElement postConditions { get; set; }

			public ICollection<StepComponent> step { get; set; }
			[FhirUri("http://hl7.org/fhir/StructureDefinition/ExampleScenario.process.step")]
			public partial class StepComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				public BooleanElement pause { get; set; }

				public OperationComponent operation { get; set; }

				public ICollection<AlternativeComponent> alternative { get; set; }
				[FhirUri("http://hl7.org/fhir/StructureDefinition/ExampleScenario.process.step.operation")]
				public partial class OperationComponent
				{

					public string id { get; set; }

					public ICollection<Extension> extension { get; set; }

					public ICollection<Extension> modifierExtension { get; set; }

					[NotNull]
					public StringElement number { get; set; }

					public StringElement type { get; set; }

					public StringElement name { get; set; }

					public StringElement initiator { get; set; }

					public StringElement receiver { get; set; }

					public MarkdownElement description { get; set; }

					public BooleanElement initiatorActive { get; set; }

					public BooleanElement receiverActive { get; set; }
				}
				[FhirUri("http://hl7.org/fhir/StructureDefinition/ExampleScenario.process.step.alternative")]
				public partial class AlternativeComponent
				{

					public string id { get; set; }

					public ICollection<Extension> extension { get; set; }

					public ICollection<Extension> modifierExtension { get; set; }

					[NotNull]
					public StringElement title { get; set; }

					public MarkdownElement description { get; set; }
				}
			}
		}
	}
}

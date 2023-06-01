using Hl7.Cql.Poco.Fhir;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Hl7.Cql.Poco.Fhir.R4.Model
{
    [FhirUri("http://hl7.org/fhir/StructureDefinition/ImplementationGuide")]
	public partial class ImplementationGuide : DomainResource
	{

		[NotNull]
		public UriElement url { get; set; }

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

		public MarkdownElement copyright { get; set; }

		[NotNull]
		public IdElement packageId { get; set; }

		[ValueSetBinding("SPDXLicense", "http://hl7.org/fhir/ValueSet/spdx-license%7C4.0.1", true)]
		public CodeElement license { get; set; }

		[ValueSetBinding("FHIRVersion", "http://hl7.org/fhir/ValueSet/FHIR-version%7C4.0.1", true)]
		public ICollection<CodeElement> fhirVersion { get; set; }

		public ICollection<DependsOnComponent> dependsOn { get; set; }

		public ICollection<GlobalComponent> global { get; set; }

		public DefinitionComponent definition { get; set; }

		public ManifestComponent manifest { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/ImplementationGuide.dependsOn")]
		public partial class DependsOnComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			public CanonicalElement uri { get; set; }

			public IdElement packageId { get; set; }

			public StringElement version { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/ImplementationGuide.global")]
		public partial class GlobalComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			[ValueSetBinding("ResourceType", "http://hl7.org/fhir/ValueSet/resource-types%7C4.0.1", true)]
			public CodeElement type { get; set; }

			[NotNull]
			public CanonicalElement profile { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/ImplementationGuide.definition")]
		public partial class DefinitionComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public ICollection<GroupingComponent> grouping { get; set; }

			public ICollection<ResourceComponent> resource { get; set; }

			public PageComponent page { get; set; }

			public ICollection<ParameterComponent> parameter { get; set; }

			public ICollection<TemplateComponent> template { get; set; }
			[FhirUri("http://hl7.org/fhir/StructureDefinition/ImplementationGuide.definition.grouping")]
			public partial class GroupingComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				[NotNull]
				public StringElement name { get; set; }

				public StringElement description { get; set; }
			}
			[FhirUri("http://hl7.org/fhir/StructureDefinition/ImplementationGuide.definition.resource")]
			public partial class ResourceComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				[NotNull]
				public Reference reference { get; set; }

				[ValueSetBinding("FHIRVersion", "http://hl7.org/fhir/ValueSet/FHIR-version%7C4.0.1", true)]
				public ICollection<CodeElement> fhirVersion { get; set; }

				public StringElement name { get; set; }

				public StringElement description { get; set; }

				[Choice(typeof(BooleanElement))]
				[Choice(typeof(CanonicalElement))]
				[JsonIgnore]
				public Element example { get; set; }
				public BooleanElement exampleBoolean { get => ChoiceAttribute.AsExactly<BooleanElement>(example); set { example = value; } }
				public CanonicalElement exampleCanonical { get => ChoiceAttribute.AsExactly<CanonicalElement>(example); set { example = value; } }

				public IdElement groupingId { get; set; }
			}
			[FhirUri("http://hl7.org/fhir/StructureDefinition/ImplementationGuide.definition.page")]
			public partial class PageComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				[NotNull]
				[Choice(typeof(UrlElement))]
				[Choice(typeof(Reference))]
				[JsonIgnore]
				public Element name { get; set; }
				public UrlElement nameUrl { get => ChoiceAttribute.AsExactly<UrlElement>(name); set { name = value; } }
				public Reference nameReference { get => ChoiceAttribute.AsExactly<Reference>(name); set { name = value; } }

				[NotNull]
				public StringElement title { get; set; }

				[NotNull]
				[ValueSetBinding("GuidePageGeneration", "http://hl7.org/fhir/ValueSet/guide-page-generation%7C4.0.1", true)]
				public CodeElement generation { get; set; }
			}
			[DebuggerDisplay("{value}")]
			[FhirUri("http://hl7.org/fhir/StructureDefinition/ImplementationGuide.definition.parameter")]
			public partial class ParameterComponent
			{

				[NotNull]
				public StringElement value { get; set; }

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				[NotNull]
				[ValueSetBinding("GuideParameterCode", "http://hl7.org/fhir/ValueSet/guide-parameter-code%7C4.0.1", true)]
				public CodeElement code { get; set; }
			}
			[FhirUri("http://hl7.org/fhir/StructureDefinition/ImplementationGuide.definition.template")]
			public partial class TemplateComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				[NotNull]
				public CodeElement code { get; set; }

				[NotNull]
				public StringElement source { get; set; }

				public StringElement scope { get; set; }
			}
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/ImplementationGuide.manifest")]
		public partial class ManifestComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public UrlElement rendering { get; set; }

			public ICollection<ResourceComponent> resource { get; set; }

			public ICollection<PageComponent> page { get; set; }

			public ICollection<StringElement> image { get; set; }

			public ICollection<StringElement> other { get; set; }
			[FhirUri("http://hl7.org/fhir/StructureDefinition/ImplementationGuide.manifest.resource")]
			public partial class ResourceComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				[NotNull]
				public Reference reference { get; set; }

				[Choice(typeof(BooleanElement))]
				[Choice(typeof(CanonicalElement))]
				[JsonIgnore]
				public Element example { get; set; }
				public BooleanElement exampleBoolean { get => ChoiceAttribute.AsExactly<BooleanElement>(example); set { example = value; } }
				public CanonicalElement exampleCanonical { get => ChoiceAttribute.AsExactly<CanonicalElement>(example); set { example = value; } }

				public UrlElement relativePath { get; set; }
			}
			[FhirUri("http://hl7.org/fhir/StructureDefinition/ImplementationGuide.manifest.page")]
			public partial class PageComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				[NotNull]
				public StringElement name { get; set; }

				public StringElement title { get; set; }

				public ICollection<StringElement> anchor { get; set; }
			}
		}
	}
}

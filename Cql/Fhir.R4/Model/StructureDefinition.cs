using Hl7.Cql.Poco.Fhir;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Hl7.Cql.Poco.Fhir.R4.Model
{
    [FhirUri("http://hl7.org/fhir/StructureDefinition/StructureDefinition")]
	public partial class StructureDefinition : DomainResource
	{

		[NotNull]
		public UriElement url { get; set; }

		public ICollection<Identifier> identifier { get; set; }

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

		[ValueSetBinding("StructureDefinitionKeyword", "http://hl7.org/fhir/ValueSet/definition-use", false)]
		public ICollection<Coding> keyword { get; set; }

		[ValueSetBinding("FHIRVersion", "http://hl7.org/fhir/ValueSet/FHIR-version%7C4.0.1", true)]
		public CodeElement fhirVersion { get; set; }

		public ICollection<MappingComponent> mapping { get; set; }

		[NotNull]
		[ValueSetBinding("StructureDefinitionKind", "http://hl7.org/fhir/ValueSet/structure-definition-kind%7C4.0.1", true)]
		public CodeElement kind { get; set; }

		[NotNull]
		public BooleanElement @abstract { get; set; }

		public ICollection<ContextComponent> context { get; set; }

		public ICollection<StringElement> contextInvariant { get; set; }

		[NotNull]
		[ValueSetBinding("FHIRDefinedTypeExt", "http://hl7.org/fhir/ValueSet/defined-types", false)]
		public UriElement type { get; set; }

		public CanonicalElement baseDefinition { get; set; }

		[ValueSetBinding("TypeDerivationRule", "http://hl7.org/fhir/ValueSet/type-derivation-rule%7C4.0.1", true)]
		public CodeElement derivation { get; set; }

		public SnapshotComponent snapshot { get; set; }

		public DifferentialComponent differential { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/StructureDefinition.mapping")]
		public partial class MappingComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			public IdElement identity { get; set; }

			public UriElement uri { get; set; }

			public StringElement name { get; set; }

			public StringElement comment { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/StructureDefinition.context")]
		public partial class ContextComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			[ValueSetBinding("ExtensionContextType", "http://hl7.org/fhir/ValueSet/extension-context-type%7C4.0.1", true)]
			public CodeElement type { get; set; }

			[NotNull]
			public StringElement expression { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/StructureDefinition.snapshot")]
		public partial class SnapshotComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public ICollection<ElementDefinition> element { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/StructureDefinition.differential")]
		public partial class DifferentialComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public ICollection<ElementDefinition> element { get; set; }
		}
	}
}

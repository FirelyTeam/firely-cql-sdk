using Hl7.Cql.Poco.Fhir;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Hl7.Cql.Poco.Fhir.R4.Model
{
    [FhirUri("http://hl7.org/fhir/StructureDefinition/CodeSystem")]
	public partial class CodeSystem : DomainResource
	{

		public UriElement url { get; set; }

		public ICollection<Identifier> identifier { get; set; }

		public StringElement version { get; set; }

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

		public BooleanElement caseSensitive { get; set; }

		public CanonicalElement valueSet { get; set; }

		[ValueSetBinding("CodeSystemHierarchyMeaning", "http://hl7.org/fhir/ValueSet/codesystem-hierarchy-meaning%7C4.0.1", true)]
		public CodeElement hierarchyMeaning { get; set; }

		public BooleanElement compositional { get; set; }

		public BooleanElement versionNeeded { get; set; }

		[NotNull]
		[ValueSetBinding("CodeSystemContentMode", "http://hl7.org/fhir/ValueSet/codesystem-content-mode%7C4.0.1", true)]
		public CodeElement content { get; set; }

		public CanonicalElement supplements { get; set; }

		public UnsignedIntElement count { get; set; }

		public ICollection<FilterComponent> filter { get; set; }

		public ICollection<PropertyComponent> property { get; set; }

		public ICollection<ConceptComponent> concept { get; set; }
		[DebuggerDisplay("{value}")]
		[FhirUri("http://hl7.org/fhir/StructureDefinition/CodeSystem.filter")]
		public partial class FilterComponent
		{

			[NotNull]
			public StringElement value { get; set; }

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			public CodeElement code { get; set; }

			public StringElement description { get; set; }

			[ValueSetBinding("FilterOperator", "http://hl7.org/fhir/ValueSet/filter-operator%7C4.0.1", true)]
			public ICollection<CodeElement> @operator { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/CodeSystem.property")]
		public partial class PropertyComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			public CodeElement code { get; set; }

			public UriElement uri { get; set; }

			public StringElement description { get; set; }

			[NotNull]
			[ValueSetBinding("PropertyType", "http://hl7.org/fhir/ValueSet/concept-property-type%7C4.0.1", true)]
			public CodeElement type { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/CodeSystem.concept")]
		public partial class ConceptComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			public CodeElement code { get; set; }

			public StringElement display { get; set; }

			public StringElement definition { get; set; }

			public ICollection<DesignationComponent> designation { get; set; }

			public ICollection<PropertyComponent> property { get; set; }
			[DebuggerDisplay("{value}")]
			[FhirUri("http://hl7.org/fhir/StructureDefinition/CodeSystem.concept.designation")]
			public partial class DesignationComponent
			{

				[NotNull]
				public StringElement value { get; set; }

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				[ValueSetBinding("Language", "http://hl7.org/fhir/ValueSet/languages", false)]
				public CodeElement language { get; set; }

				[ValueSetBinding("ConceptDesignationUse", "http://hl7.org/fhir/ValueSet/designation-use", false)]
				public Coding use { get; set; }
			}
			[DebuggerDisplay("{value}")]
			[FhirUri("http://hl7.org/fhir/StructureDefinition/CodeSystem.concept.property")]
			public partial class PropertyComponent
			{

				[NotNull]
				[Choice(typeof(CodeElement))]
				[Choice(typeof(Coding))]
				[Choice(typeof(StringElement))]
				[Choice(typeof(IntegerElement))]
				[Choice(typeof(BooleanElement))]
				[Choice(typeof(DateTimeElement))]
				[Choice(typeof(DecimalElement))]
				[JsonIgnore]
				public Element value { get; set; }
				public CodeElement valueCode { get => ChoiceAttribute.AsExactly<CodeElement>(value); set { this.value = value; } }
				public Coding valueCoding { get => ChoiceAttribute.AsExactly<Coding>(value); set { this.value = value; } }
				public StringElement valueString { get => ChoiceAttribute.AsExactly<StringElement>(value); set { this.value = value; } }
				public IntegerElement valueInteger { get => ChoiceAttribute.AsExactly<IntegerElement>(value); set { this.value = value; } }
				public BooleanElement valueBoolean { get => ChoiceAttribute.AsExactly<BooleanElement>(value); set { this.value = value; } }
				public DateTimeElement valueDateTime { get => ChoiceAttribute.AsExactly<DateTimeElement>(value); set { this.value = value; } }
				public DecimalElement valueDecimal { get => ChoiceAttribute.AsExactly<DecimalElement>(value); set { this.value = value; } }

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				[NotNull]
				public CodeElement code { get; set; }
			}
		}
	}
}

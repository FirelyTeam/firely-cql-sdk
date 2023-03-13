using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[FhirUri("http://hl7.org/fhir/StructureDefinition/ValueSet")]
	public partial class ValueSet : DomainResource
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

		public BooleanElement immutable { get; set; }

		public MarkdownElement purpose { get; set; }

		public MarkdownElement copyright { get; set; }

		public ComposeComponent compose { get; set; }

		public ExpansionComponent expansion { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/ValueSet.compose")]
		public partial class ComposeComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public DateElement lockedDate { get; set; }

			public BooleanElement inactive { get; set; }

			public ICollection<IncludeComponent> include { get; set; }
			[FhirUri("http://hl7.org/fhir/StructureDefinition/ValueSet.compose.include")]
			public partial class IncludeComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				public UriElement system { get; set; }

				public StringElement version { get; set; }

				public ICollection<ConceptComponent> concept { get; set; }

				public ICollection<FilterComponent> filter { get; set; }

				public ICollection<CanonicalElement> valueSet { get; set; }
				[FhirUri("http://hl7.org/fhir/StructureDefinition/ValueSet.compose.include.concept")]
				public partial class ConceptComponent
				{

					public string id { get; set; }

					public ICollection<Extension> extension { get; set; }

					public ICollection<Extension> modifierExtension { get; set; }

					[NotNull]
					public CodeElement code { get; set; }

					public StringElement display { get; set; }

					public ICollection<DesignationComponent> designation { get; set; }
					[DebuggerDisplay("{value}")]
					[FhirUri("http://hl7.org/fhir/StructureDefinition/ValueSet.compose.include.concept.designation")]
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
				}
				[DebuggerDisplay("{value}")]
				[FhirUri("http://hl7.org/fhir/StructureDefinition/ValueSet.compose.include.filter")]
				public partial class FilterComponent
				{

					[NotNull]
					public StringElement value { get; set; }

					public string id { get; set; }

					public ICollection<Extension> extension { get; set; }

					public ICollection<Extension> modifierExtension { get; set; }

					[NotNull]
					public CodeElement property { get; set; }

					[NotNull]
					[ValueSetBinding("FilterOperator", "http://hl7.org/fhir/ValueSet/filter-operator%7C4.0.1", true)]
					public CodeElement op { get; set; }
				}
			}
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/ValueSet.expansion")]
		public partial class ExpansionComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public UriElement identifier { get; set; }

			[NotNull]
			public DateTimeElement timestamp { get; set; }

			public IntegerElement total { get; set; }

			public IntegerElement offset { get; set; }

			public ICollection<ParameterComponent> parameter { get; set; }

			public ICollection<ContainsComponent> contains { get; set; }
			[DebuggerDisplay("{value}")]
			[FhirUri("http://hl7.org/fhir/StructureDefinition/ValueSet.expansion.parameter")]
			public partial class ParameterComponent
			{

				[Choice(typeof(StringElement))]
				[Choice(typeof(BooleanElement))]
				[Choice(typeof(IntegerElement))]
				[Choice(typeof(DecimalElement))]
				[Choice(typeof(UriElement))]
				[Choice(typeof(CodeElement))]
				[Choice(typeof(DateTimeElement))]
				[JsonIgnore]
				public Element value { get; set; }
				public StringElement valueString { get => ChoiceAttribute.AsExactly<StringElement>(value); set { this.value = value; } }
				public BooleanElement valueBoolean { get => ChoiceAttribute.AsExactly<BooleanElement>(value); set { this.value = value; } }
				public IntegerElement valueInteger { get => ChoiceAttribute.AsExactly<IntegerElement>(value); set { this.value = value; } }
				public DecimalElement valueDecimal { get => ChoiceAttribute.AsExactly<DecimalElement>(value); set { this.value = value; } }
				public UriElement valueUri { get => ChoiceAttribute.AsExactly<UriElement>(value); set { this.value = value; } }
				public CodeElement valueCode { get => ChoiceAttribute.AsExactly<CodeElement>(value); set { this.value = value; } }
				public DateTimeElement valueDateTime { get => ChoiceAttribute.AsExactly<DateTimeElement>(value); set { this.value = value; } }

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				[NotNull]
				public StringElement name { get; set; }
			}
			[FhirUri("http://hl7.org/fhir/StructureDefinition/ValueSet.expansion.contains")]
			public partial class ContainsComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				public UriElement system { get; set; }

				public BooleanElement @abstract { get; set; }

				public BooleanElement inactive { get; set; }

				public StringElement version { get; set; }

				public CodeElement code { get; set; }

				public StringElement display { get; set; }
			}
		}
	}
}

using Hl7.Cql.Poco.Fhir;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Hl7.Cql.Poco.Fhir.R4.Model
{
    [FhirUri("http://hl7.org/fhir/StructureDefinition/TerminologyCapabilities")]
	public partial class TerminologyCapabilities : DomainResource
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

		public SoftwareComponent software { get; set; }

		public ImplementationComponent implementation { get; set; }

		public BooleanElement lockedDate { get; set; }

		public ICollection<CodeSystemComponent> codeSystem { get; set; }

		public ExpansionComponent expansion { get; set; }

		[ValueSetBinding("CodeSearchSupport", "http://hl7.org/fhir/ValueSet/code-search-support%7C4.0.1", true)]
		public CodeElement codeSearch { get; set; }

		public ValidateCodeComponent validateCode { get; set; }

		public TranslationComponent translation { get; set; }

		public ClosureComponent closure { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/TerminologyCapabilities.software")]
		public partial class SoftwareComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			public StringElement name { get; set; }

			public StringElement version { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/TerminologyCapabilities.implementation")]
		public partial class ImplementationComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			public StringElement description { get; set; }

			public UrlElement url { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/TerminologyCapabilities.codeSystem")]
		public partial class CodeSystemComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public CanonicalElement uri { get; set; }

			public ICollection<VersionComponent> version { get; set; }

			public BooleanElement subsumption { get; set; }
			[FhirUri("http://hl7.org/fhir/StructureDefinition/TerminologyCapabilities.codeSystem.version")]
			public partial class VersionComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				public StringElement code { get; set; }

				public BooleanElement isDefault { get; set; }

				public BooleanElement compositional { get; set; }

				public ICollection<CodeElement> language { get; set; }

				public ICollection<FilterComponent> filter { get; set; }

				public ICollection<CodeElement> property { get; set; }
				[FhirUri("http://hl7.org/fhir/StructureDefinition/TerminologyCapabilities.codeSystem.version.filter")]
				public partial class FilterComponent
				{

					public string id { get; set; }

					public ICollection<Extension> extension { get; set; }

					public ICollection<Extension> modifierExtension { get; set; }

					[NotNull]
					public CodeElement code { get; set; }

					public ICollection<CodeElement> op { get; set; }
				}
			}
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/TerminologyCapabilities.expansion")]
		public partial class ExpansionComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public BooleanElement hierarchical { get; set; }

			public BooleanElement paging { get; set; }

			public BooleanElement incomplete { get; set; }

			public ICollection<ParameterComponent> parameter { get; set; }

			public MarkdownElement textFilter { get; set; }
			[FhirUri("http://hl7.org/fhir/StructureDefinition/TerminologyCapabilities.expansion.parameter")]
			public partial class ParameterComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				[NotNull]
				public CodeElement name { get; set; }

				public StringElement documentation { get; set; }
			}
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/TerminologyCapabilities.validateCode")]
		public partial class ValidateCodeComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			public BooleanElement translations { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/TerminologyCapabilities.translation")]
		public partial class TranslationComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			public BooleanElement needsMap { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/TerminologyCapabilities.closure")]
		public partial class ClosureComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public BooleanElement translation { get; set; }
		}
	}
}

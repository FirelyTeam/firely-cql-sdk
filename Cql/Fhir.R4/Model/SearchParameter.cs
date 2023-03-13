using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[FhirUri("http://hl7.org/fhir/StructureDefinition/SearchParameter")]
	public partial class SearchParameter : DomainResource
	{

		[NotNull]
		public UriElement url { get; set; }

		public StringElement version { get; set; }

		[NotNull]
		public StringElement name { get; set; }

		public CanonicalElement derivedFrom { get; set; }

		[NotNull]
		[ValueSetBinding("PublicationStatus", "http://hl7.org/fhir/ValueSet/publication-status%7C4.0.1", true)]
		public CodeElement status { get; set; }

		public BooleanElement experimental { get; set; }

		public DateTimeElement date { get; set; }

		public StringElement publisher { get; set; }

		public ICollection<ContactDetail> contact { get; set; }

		[NotNull]
		public MarkdownElement description { get; set; }

		public ICollection<UsageContext> useContext { get; set; }

		[ValueSetBinding("Jurisdiction", "http://hl7.org/fhir/ValueSet/jurisdiction", false)]
		public ICollection<CodeableConcept> jurisdiction { get; set; }

		public MarkdownElement purpose { get; set; }

		[NotNull]
		public CodeElement code { get; set; }

		[ValueSetBinding("ResourceType", "http://hl7.org/fhir/ValueSet/resource-types%7C4.0.1", true)]
		public ICollection<CodeElement> @base { get; set; }

		[NotNull]
		[ValueSetBinding("SearchParamType", "http://hl7.org/fhir/ValueSet/search-param-type%7C4.0.1", true)]
		public CodeElement type { get; set; }

		public StringElement expression { get; set; }

		public StringElement xpath { get; set; }

		[ValueSetBinding("XPathUsageType", "http://hl7.org/fhir/ValueSet/search-xpath-usage%7C4.0.1", true)]
		public CodeElement xpathUsage { get; set; }

		[ValueSetBinding("ResourceType", "http://hl7.org/fhir/ValueSet/resource-types%7C4.0.1", true)]
		public ICollection<CodeElement> target { get; set; }

		public BooleanElement multipleOr { get; set; }

		public BooleanElement multipleAnd { get; set; }

		[ValueSetBinding("SearchComparator", "http://hl7.org/fhir/ValueSet/search-comparator%7C4.0.1", true)]
		public ICollection<CodeElement> comparator { get; set; }

		[ValueSetBinding("SearchModifierCode", "http://hl7.org/fhir/ValueSet/search-modifier-code%7C4.0.1", true)]
		public ICollection<CodeElement> modifier { get; set; }

		public ICollection<StringElement> chain { get; set; }

		public ICollection<ComponentComponent> component { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/SearchParameter.component")]
		public partial class ComponentComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			public CanonicalElement definition { get; set; }

			[NotNull]
			public StringElement expression { get; set; }
		}
	}
}

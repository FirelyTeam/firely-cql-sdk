using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[FhirUri("http://hl7.org/fhir/StructureDefinition/OperationDefinition")]
	public partial class OperationDefinition : DomainResource
	{

		public UriElement url { get; set; }

		public StringElement version { get; set; }

		[NotNull]
		public StringElement name { get; set; }

		public StringElement title { get; set; }

		[NotNull]
		[ValueSetBinding("PublicationStatus", "http://hl7.org/fhir/ValueSet/publication-status%7C4.0.1", true)]
		public CodeElement status { get; set; }

		[NotNull]
		[ValueSetBinding("OperationKind", "http://hl7.org/fhir/ValueSet/operation-kind%7C4.0.1", true)]
		public CodeElement kind { get; set; }

		public BooleanElement experimental { get; set; }

		public DateTimeElement date { get; set; }

		public StringElement publisher { get; set; }

		public ICollection<ContactDetail> contact { get; set; }

		public MarkdownElement description { get; set; }

		public ICollection<UsageContext> useContext { get; set; }

		[ValueSetBinding("Jurisdiction", "http://hl7.org/fhir/ValueSet/jurisdiction", false)]
		public ICollection<CodeableConcept> jurisdiction { get; set; }

		public MarkdownElement purpose { get; set; }

		public BooleanElement affectsState { get; set; }

		[NotNull]
		public CodeElement code { get; set; }

		public MarkdownElement comment { get; set; }

		public CanonicalElement @base { get; set; }

		[ValueSetBinding("ResourceType", "http://hl7.org/fhir/ValueSet/resource-types%7C4.0.1", true)]
		public ICollection<CodeElement> resource { get; set; }

		[NotNull]
		public BooleanElement system { get; set; }

		[NotNull]
		public BooleanElement type { get; set; }

		[NotNull]
		public BooleanElement instance { get; set; }

		public CanonicalElement inputProfile { get; set; }

		public CanonicalElement outputProfile { get; set; }

		public ICollection<ParameterComponent> parameter { get; set; }

		public ICollection<OverloadComponent> overload { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/OperationDefinition.parameter")]
		public partial class ParameterComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			public CodeElement name { get; set; }

			[NotNull]
			[ValueSetBinding("OperationParameterUse", "http://hl7.org/fhir/ValueSet/operation-parameter-use%7C4.0.1", true)]
			public CodeElement use { get; set; }

			[NotNull]
			public IntegerElement min { get; set; }

			[NotNull]
			public StringElement max { get; set; }

			public StringElement documentation { get; set; }

			[ValueSetBinding("FHIRAllTypes", "http://hl7.org/fhir/ValueSet/all-types%7C4.0.1", true)]
			public CodeElement type { get; set; }

			public ICollection<CanonicalElement> targetProfile { get; set; }

			[ValueSetBinding("SearchParamType", "http://hl7.org/fhir/ValueSet/search-param-type%7C4.0.1", true)]
			public CodeElement searchType { get; set; }

			public BindingComponent binding { get; set; }

			public ICollection<ReferencedFromComponent> referencedFrom { get; set; }
			[FhirUri("http://hl7.org/fhir/StructureDefinition/OperationDefinition.parameter.binding")]
			public partial class BindingComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				[NotNull]
				[ValueSetBinding("BindingStrength", "http://hl7.org/fhir/ValueSet/binding-strength%7C4.0.1", true)]
				public CodeElement strength { get; set; }

				[NotNull]
				public CanonicalElement valueSet { get; set; }
			}
			[FhirUri("http://hl7.org/fhir/StructureDefinition/OperationDefinition.parameter.referencedFrom")]
			public partial class ReferencedFromComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				[NotNull]
				public StringElement source { get; set; }

				public StringElement sourceId { get; set; }
			}
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/OperationDefinition.overload")]
		public partial class OverloadComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public ICollection<StringElement> parameterName { get; set; }

			public StringElement comment { get; set; }
		}
	}
}

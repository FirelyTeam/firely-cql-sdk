using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[FhirUri("http://hl7.org/fhir/StructureDefinition/ConceptMap")]
	public partial class ConceptMap : DomainResource
	{

		public UriElement url { get; set; }

		public Identifier identifier { get; set; }

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

		[Choice(typeof(UriElement))]
		[Choice(typeof(CanonicalElement))]
		[JsonIgnore]
		public UriElement source { get; set; }
		public UriElement sourceUri { get => ChoiceAttribute.AsExactly<UriElement>(source); set { source = value; } }
		public CanonicalElement sourceCanonical { get => ChoiceAttribute.AsExactly<CanonicalElement>(source); set { source = value; } }

		[Choice(typeof(UriElement))]
		[Choice(typeof(CanonicalElement))]
		[JsonIgnore]
		public UriElement target { get; set; }
		public UriElement targetUri { get => ChoiceAttribute.AsExactly<UriElement>(target); set { target = value; } }
		public CanonicalElement targetCanonical { get => ChoiceAttribute.AsExactly<CanonicalElement>(target); set { target = value; } }

		public ICollection<GroupComponent> group { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/ConceptMap.group")]
		public partial class GroupComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public UriElement source { get; set; }

			public StringElement sourceVersion { get; set; }

			public UriElement target { get; set; }

			public StringElement targetVersion { get; set; }

			public ICollection<ElementComponent> element { get; set; }

			public UnmappedComponent unmapped { get; set; }
			[FhirUri("http://hl7.org/fhir/StructureDefinition/ConceptMap.group.element")]
			public partial class ElementComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				public CodeElement code { get; set; }

				public StringElement display { get; set; }

				public ICollection<TargetComponent> target { get; set; }
				[FhirUri("http://hl7.org/fhir/StructureDefinition/ConceptMap.group.element.target")]
				public partial class TargetComponent
				{

					public string id { get; set; }

					public ICollection<Extension> extension { get; set; }

					public ICollection<Extension> modifierExtension { get; set; }

					public CodeElement code { get; set; }

					public StringElement display { get; set; }

					[NotNull]
					[ValueSetBinding("ConceptMapEquivalence", "http://hl7.org/fhir/ValueSet/concept-map-equivalence%7C4.0.1", true)]
					public CodeElement equivalence { get; set; }

					public StringElement comment { get; set; }

					public ICollection<DependsOnComponent> dependsOn { get; set; }
					[DebuggerDisplay("{value}")]
					[FhirUri("http://hl7.org/fhir/StructureDefinition/ConceptMap.group.element.target.dependsOn")]
					public partial class DependsOnComponent
					{

						[NotNull]
						public StringElement value { get; set; }

						public string id { get; set; }

						public ICollection<Extension> extension { get; set; }

						public ICollection<Extension> modifierExtension { get; set; }

						[NotNull]
						public UriElement property { get; set; }

						public CanonicalElement system { get; set; }

						public StringElement display { get; set; }
					}
				}
			}
			[FhirUri("http://hl7.org/fhir/StructureDefinition/ConceptMap.group.unmapped")]
			public partial class UnmappedComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				[NotNull]
				[ValueSetBinding("ConceptMapGroupUnmappedMode", "http://hl7.org/fhir/ValueSet/conceptmap-unmapped-mode%7C4.0.1", true)]
				public CodeElement mode { get; set; }

				public CodeElement code { get; set; }

				public StringElement display { get; set; }

				public CanonicalElement url { get; set; }
			}
		}
	}
}

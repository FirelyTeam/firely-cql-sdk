using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[FhirUri("http://hl7.org/fhir/StructureDefinition/Measure")]
	public partial class Measure : DomainResource
	{

		public UriElement url { get; set; }

		public ICollection<Identifier> identifier { get; set; }

		public StringElement version { get; set; }

		public StringElement name { get; set; }

		public StringElement title { get; set; }

		public StringElement subtitle { get; set; }

		[NotNull]
		[ValueSetBinding("PublicationStatus", "http://hl7.org/fhir/ValueSet/publication-status%7C4.0.1", true)]
		public CodeElement status { get; set; }

		public BooleanElement experimental { get; set; }

		[Choice(typeof(CodeableConcept))]
		[Choice(typeof(Reference))]
		[JsonIgnore]
		[ValueSetBinding("SubjectType", "http://hl7.org/fhir/ValueSet/subject-type", false)]
		public Element subject { get; set; }
		public CodeableConcept subjectCodeableConcept { get => ChoiceAttribute.AsExactly<CodeableConcept>(subject); set { subject = value; } }
		public Reference subjectReference { get => ChoiceAttribute.AsExactly<Reference>(subject); set { subject = value; } }

		public DateTimeElement date { get; set; }

		public StringElement publisher { get; set; }

		public ICollection<ContactDetail> contact { get; set; }

		public MarkdownElement description { get; set; }

		public ICollection<UsageContext> useContext { get; set; }

		[ValueSetBinding("Jurisdiction", "http://hl7.org/fhir/ValueSet/jurisdiction", false)]
		public ICollection<CodeableConcept> jurisdiction { get; set; }

		public MarkdownElement purpose { get; set; }

		public StringElement usage { get; set; }

		public MarkdownElement copyright { get; set; }

		public DateElement approvalDate { get; set; }

		public DateElement lastReviewDate { get; set; }

		public Period effectivePeriod { get; set; }

		[ValueSetBinding("DefinitionTopic", "http://hl7.org/fhir/ValueSet/definition-topic", false)]
		public ICollection<CodeableConcept> topic { get; set; }

		public ICollection<ContactDetail> author { get; set; }

		public ICollection<ContactDetail> editor { get; set; }

		public ICollection<ContactDetail> reviewer { get; set; }

		public ICollection<ContactDetail> endorser { get; set; }

		public ICollection<RelatedArtifact> relatedArtifact { get; set; }

		public ICollection<CanonicalElement> library { get; set; }

		public MarkdownElement disclaimer { get; set; }

		[ValueSetBinding("MeasureScoring", "http://hl7.org/fhir/ValueSet/measure-scoring", false)]
		public CodeableConcept scoring { get; set; }

		[ValueSetBinding("CompositeMeasureScoring", "http://hl7.org/fhir/ValueSet/composite-measure-scoring", false)]
		public CodeableConcept compositeScoring { get; set; }

		[ValueSetBinding("MeasureType", "http://hl7.org/fhir/ValueSet/measure-type", false)]
		public ICollection<CodeableConcept> type { get; set; }

		public StringElement riskAdjustment { get; set; }

		public StringElement rateAggregation { get; set; }

		public MarkdownElement rationale { get; set; }

		public MarkdownElement clinicalRecommendationStatement { get; set; }

		[ValueSetBinding("MeasureImprovementNotation", "http://hl7.org/fhir/ValueSet/measure-improvement-notation%7C4.0.1", true)]
		public CodeableConcept improvementNotation { get; set; }

		public ICollection<MarkdownElement> definition { get; set; }

		public MarkdownElement guidance { get; set; }

		public ICollection<GroupComponent> group { get; set; }

		public ICollection<SupplementalDataComponent> supplementalData { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/Measure.group")]
		public partial class GroupComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public CodeableConcept code { get; set; }

			public StringElement description { get; set; }

			public ICollection<PopulationComponent> population { get; set; }

			public ICollection<StratifierComponent> stratifier { get; set; }
			[FhirUri("http://hl7.org/fhir/StructureDefinition/Measure.group.population")]
			public partial class PopulationComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				[ValueSetBinding("MeasurePopulationType", "http://hl7.org/fhir/ValueSet/measure-population", false)]
				public CodeableConcept code { get; set; }

				public StringElement description { get; set; }

				[NotNull]
				public Expression criteria { get; set; }
			}
			[FhirUri("http://hl7.org/fhir/StructureDefinition/Measure.group.stratifier")]
			public partial class StratifierComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				public CodeableConcept code { get; set; }

				public StringElement description { get; set; }

				public Expression criteria { get; set; }

				public ICollection<ComponentComponent> component { get; set; }
				[FhirUri("http://hl7.org/fhir/StructureDefinition/Measure.group.stratifier.component")]
				public partial class ComponentComponent
				{

					public string id { get; set; }

					public ICollection<Extension> extension { get; set; }

					public ICollection<Extension> modifierExtension { get; set; }

					public CodeableConcept code { get; set; }

					public StringElement description { get; set; }

					[NotNull]
					public Expression criteria { get; set; }
				}
			}
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/Measure.supplementalData")]
		public partial class SupplementalDataComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public CodeableConcept code { get; set; }

			[ValueSetBinding("MeasureDataUsage", "http://hl7.org/fhir/ValueSet/measure-data-usage", false)]
			public ICollection<CodeableConcept> usage { get; set; }

			public StringElement description { get; set; }

			[NotNull]
			public Expression criteria { get; set; }
		}
	}
}

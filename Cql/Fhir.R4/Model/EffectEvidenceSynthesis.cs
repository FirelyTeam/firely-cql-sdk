using Hl7.Cql.Poco.Fhir;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace Hl7.Cql.Poco.Fhir.R4.Model
{
    [FhirUri("http://hl7.org/fhir/StructureDefinition/EffectEvidenceSynthesis")]
	public partial class EffectEvidenceSynthesis : DomainResource
	{

		public UriElement url { get; set; }

		public ICollection<Identifier> identifier { get; set; }

		public StringElement version { get; set; }

		public StringElement name { get; set; }

		public StringElement title { get; set; }

		[NotNull]
		[ValueSetBinding("PublicationStatus", "http://hl7.org/fhir/ValueSet/publication-status%7C4.0.1", true)]
		public CodeElement status { get; set; }

		public DateTimeElement date { get; set; }

		public StringElement publisher { get; set; }

		public ICollection<ContactDetail> contact { get; set; }

		public MarkdownElement description { get; set; }

		public ICollection<Annotation> note { get; set; }

		public ICollection<UsageContext> useContext { get; set; }

		[ValueSetBinding("Jurisdiction", "http://hl7.org/fhir/ValueSet/jurisdiction", false)]
		public ICollection<CodeableConcept> jurisdiction { get; set; }

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

		[ValueSetBinding("SynthesisType", "http://hl7.org/fhir/ValueSet/synthesis-type", false)]
		public CodeableConcept synthesisType { get; set; }

		[ValueSetBinding("StudyType", "http://hl7.org/fhir/ValueSet/study-type", false)]
		public CodeableConcept studyType { get; set; }

		[NotNull]
		public Reference population { get; set; }

		[NotNull]
		public Reference exposure { get; set; }

		[NotNull]
		public Reference exposureAlternative { get; set; }

		[NotNull]
		public Reference outcome { get; set; }

		public SampleSizeComponent sampleSize { get; set; }

		public ICollection<ResultsByExposureComponent> resultsByExposure { get; set; }

		public ICollection<EffectEstimateComponent> effectEstimate { get; set; }

		public ICollection<CertaintyComponent> certainty { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/EffectEvidenceSynthesis.sampleSize")]
		public partial class SampleSizeComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public StringElement description { get; set; }

			public IntegerElement numberOfStudies { get; set; }

			public IntegerElement numberOfParticipants { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/EffectEvidenceSynthesis.resultsByExposure")]
		public partial class ResultsByExposureComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public StringElement description { get; set; }

			[ValueSetBinding("ExposureState", "http://hl7.org/fhir/ValueSet/exposure-state%7C4.0.1", true)]
			public CodeElement exposureState { get; set; }

			[ValueSetBinding("EvidenceVariantState", "http://hl7.org/fhir/ValueSet/evidence-variant-state", false)]
			public CodeableConcept variantState { get; set; }

			[NotNull]
			public Reference riskEvidenceSynthesis { get; set; }
		}
		[DebuggerDisplay("{value}")]
		[FhirUri("http://hl7.org/fhir/StructureDefinition/EffectEvidenceSynthesis.effectEstimate")]
		public partial class EffectEstimateComponent
		{

			public DecimalElement value { get; set; }

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public StringElement description { get; set; }

			[ValueSetBinding("EffectEstimateType", "http://hl7.org/fhir/ValueSet/effect-estimate-type", false)]
			public CodeableConcept type { get; set; }

			[ValueSetBinding("EvidenceVariantState", "http://hl7.org/fhir/ValueSet/evidence-variant-state", false)]
			public CodeableConcept variantState { get; set; }

			[ValueSetBinding("UCUMUnits", "http://hl7.org/fhir/ValueSet/ucum-units%7C4.0.1", true)]
			public CodeableConcept unitOfMeasure { get; set; }

			public ICollection<PrecisionEstimateComponent> precisionEstimate { get; set; }
			[FhirUri("http://hl7.org/fhir/StructureDefinition/EffectEvidenceSynthesis.effectEstimate.precisionEstimate")]
			public partial class PrecisionEstimateComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				[ValueSetBinding("PrecisionEstimateType", "http://hl7.org/fhir/ValueSet/precision-estimate-type", false)]
				public CodeableConcept type { get; set; }

				public DecimalElement level { get; set; }

				public DecimalElement from { get; set; }

				public DecimalElement to { get; set; }
			}
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/EffectEvidenceSynthesis.certainty")]
		public partial class CertaintyComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[ValueSetBinding("QualityOfEvidenceRating", "http://hl7.org/fhir/ValueSet/evidence-quality", false)]
			public ICollection<CodeableConcept> rating { get; set; }

			public ICollection<Annotation> note { get; set; }

			public ICollection<CertaintySubcomponentComponent> certaintySubcomponent { get; set; }
			[FhirUri("http://hl7.org/fhir/StructureDefinition/EffectEvidenceSynthesis.certainty.certaintySubcomponent")]
			public partial class CertaintySubcomponentComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				[ValueSetBinding("CertaintySubcomponentType", "http://hl7.org/fhir/ValueSet/certainty-subcomponent-type", false)]
				public CodeableConcept type { get; set; }

				[ValueSetBinding("CertaintySubcomponentRating", "http://hl7.org/fhir/ValueSet/certainty-subcomponent-rating", false)]
				public ICollection<CodeableConcept> rating { get; set; }

				public ICollection<Annotation> note { get; set; }
			}
		}
	}
}

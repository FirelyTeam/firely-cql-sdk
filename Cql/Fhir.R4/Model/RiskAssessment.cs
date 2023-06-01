using Hl7.Cql.Poco.Fhir;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Hl7.Cql.Poco.Fhir.R4.Model
{
    [FhirUri("http://hl7.org/fhir/StructureDefinition/RiskAssessment")]
	public partial class RiskAssessment : DomainResource
	{

		public ICollection<Identifier> identifier { get; set; }

		public Reference basedOn { get; set; }

		public Reference parent { get; set; }

		[NotNull]
		[ValueSetBinding("RiskAssessmentStatus", "http://hl7.org/fhir/ValueSet/observation-status%7C4.0.1", true)]
		public CodeElement status { get; set; }

		public CodeableConcept method { get; set; }

		public CodeableConcept code { get; set; }

		[NotNull]
		public Reference subject { get; set; }

		public Reference encounter { get; set; }

		[Choice(typeof(DateTimeElement))]
		[Choice(typeof(Period))]
		[JsonIgnore]
		public Element occurrence { get; set; }
		public DateTimeElement occurrenceDateTime { get => ChoiceAttribute.AsExactly<DateTimeElement>(occurrence); set { occurrence = value; } }
		public Period occurrencePeriod { get => ChoiceAttribute.AsExactly<Period>(occurrence); set { occurrence = value; } }

		public Reference condition { get; set; }

		public Reference performer { get; set; }

		public ICollection<CodeableConcept> reasonCode { get; set; }

		public ICollection<Reference> reasonReference { get; set; }

		public ICollection<Reference> basis { get; set; }

		public ICollection<PredictionComponent> prediction { get; set; }

		public StringElement mitigation { get; set; }

		public ICollection<Annotation> note { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/RiskAssessment.prediction")]
		public partial class PredictionComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public CodeableConcept outcome { get; set; }

			[Choice(typeof(DecimalElement))]
			[Choice(typeof(Range))]
			[JsonIgnore]
			public Element probability { get; set; }
			public DecimalElement probabilityDecimal { get => ChoiceAttribute.AsExactly<DecimalElement>(probability); set { probability = value; } }
			public Range probabilityRange { get => ChoiceAttribute.AsExactly<Range>(probability); set { probability = value; } }

			[ValueSetBinding("RiskAssessmentProbability", "http://hl7.org/fhir/ValueSet/risk-probability", false)]
			public CodeableConcept qualitativeRisk { get; set; }

			public DecimalElement relativeRisk { get; set; }

			[Choice(typeof(Period))]
			[Choice(typeof(Range))]
			[JsonIgnore]
			public Element when { get; set; }
			public Period whenPeriod { get => ChoiceAttribute.AsExactly<Period>(when); set { when = value; } }
			public Range whenRange { get => ChoiceAttribute.AsExactly<Range>(when); set { when = value; } }

			public StringElement rationale { get; set; }
		}
	}
}

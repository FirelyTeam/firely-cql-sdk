using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[FhirUri("http://hl7.org/fhir/StructureDefinition/Condition")]
	public partial class Condition : DomainResource
	{

		public ICollection<Identifier> identifier { get; set; }

		[ValueSetBinding("ConditionClinicalStatus", "http://hl7.org/fhir/ValueSet/condition-clinical%7C4.0.1", true)]
		public CodeableConcept clinicalStatus { get; set; }

		[ValueSetBinding("ConditionVerificationStatus", "http://hl7.org/fhir/ValueSet/condition-ver-status%7C4.0.1", true)]
		public CodeableConcept verificationStatus { get; set; }

		[ValueSetBinding("ConditionCategory", "http://hl7.org/fhir/ValueSet/condition-category", false)]
		public ICollection<CodeableConcept> category { get; set; }

		[ValueSetBinding("ConditionSeverity", "http://hl7.org/fhir/ValueSet/condition-severity", false)]
		public CodeableConcept severity { get; set; }

		[ValueSetBinding("ConditionKind", "http://hl7.org/fhir/ValueSet/condition-code", false)]
		public CodeableConcept code { get; set; }

		[ValueSetBinding("BodySite", "http://hl7.org/fhir/ValueSet/body-site", false)]
		public ICollection<CodeableConcept> bodySite { get; set; }

		[NotNull]
		public Reference subject { get; set; }

		public Reference encounter { get; set; }

		[Choice(typeof(DateTimeElement))]
		[Choice(typeof(Age))]
		[Choice(typeof(Period))]
		[Choice(typeof(Range))]
		[Choice(typeof(StringElement))]
		[JsonIgnore]
		public Element onset { get; set; }
		public DateTimeElement onsetDateTime { get => ChoiceAttribute.AsExactly<DateTimeElement>(onset); set { onset = value; } }
		public Age onsetAge { get => ChoiceAttribute.AsExactly<Age>(onset); set { onset = value; } }
		public Period onsetPeriod { get => ChoiceAttribute.AsExactly<Period>(onset); set { onset = value; } }
		public Range onsetRange { get => ChoiceAttribute.AsExactly<Range>(onset); set { onset = value; } }
		public StringElement onsetString { get => ChoiceAttribute.AsExactly<StringElement>(onset); set { onset = value; } }

		[Choice(typeof(DateTimeElement))]
		[Choice(typeof(Age))]
		[Choice(typeof(Period))]
		[Choice(typeof(Range))]
		[Choice(typeof(StringElement))]
		[JsonIgnore]
		public Element abatement { get; set; }
		public DateTimeElement abatementDateTime { get => ChoiceAttribute.AsExactly<DateTimeElement>(abatement); set { abatement = value; } }
		public Age abatementAge { get => ChoiceAttribute.AsExactly<Age>(abatement); set { abatement = value; } }
		public Period abatementPeriod { get => ChoiceAttribute.AsExactly<Period>(abatement); set { abatement = value; } }
		public Range abatementRange { get => ChoiceAttribute.AsExactly<Range>(abatement); set { abatement = value; } }
		public StringElement abatementString { get => ChoiceAttribute.AsExactly<StringElement>(abatement); set { abatement = value; } }

		public DateTimeElement recordedDate { get; set; }

		public Reference recorder { get; set; }

		public Reference asserter { get; set; }

		public ICollection<StageComponent> stage { get; set; }

		public ICollection<EvidenceComponent> evidence { get; set; }

		public ICollection<Annotation> note { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/Condition.stage")]
		public partial class StageComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[ValueSetBinding("ConditionStage", "http://hl7.org/fhir/ValueSet/condition-stage", false)]
			public CodeableConcept summary { get; set; }

			public ICollection<Reference> assessment { get; set; }

			[ValueSetBinding("ConditionStageType", "http://hl7.org/fhir/ValueSet/condition-stage-type", false)]
			public CodeableConcept type { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/Condition.evidence")]
		public partial class EvidenceComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[ValueSetBinding("ManifestationOrSymptom", "http://hl7.org/fhir/ValueSet/manifestation-or-symptom", false)]
			public ICollection<CodeableConcept> code { get; set; }

			public ICollection<Reference> detail { get; set; }
		}
	}
}

using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[FhirUri("http://hl7.org/fhir/StructureDefinition/ClinicalImpression")]
	public partial class ClinicalImpression : DomainResource
	{

		public ICollection<Identifier> identifier { get; set; }

		[NotNull]
		[ValueSetBinding("ClinicalImpressionStatus", "http://hl7.org/fhir/ValueSet/clinicalimpression-status%7C4.0.1", true)]
		public CodeElement status { get; set; }

		public CodeableConcept statusReason { get; set; }

		public CodeableConcept code { get; set; }

		public StringElement description { get; set; }

		[NotNull]
		public Reference subject { get; set; }

		public Reference encounter { get; set; }

		[Choice(typeof(DateTimeElement))]
		[Choice(typeof(Period))]
		[JsonIgnore]
		public Element effective { get; set; }
		public DateTimeElement effectiveDateTime { get => ChoiceAttribute.AsExactly<DateTimeElement>(effective); set { effective = value; } }
		public Period effectivePeriod { get => ChoiceAttribute.AsExactly<Period>(effective); set { effective = value; } }

		public DateTimeElement date { get; set; }

		public Reference assessor { get; set; }

		public Reference previous { get; set; }

		public ICollection<Reference> problem { get; set; }

		public ICollection<InvestigationComponent> investigation { get; set; }

		public ICollection<UriElement> protocol { get; set; }

		public StringElement summary { get; set; }

		public ICollection<FindingComponent> finding { get; set; }

		[ValueSetBinding("ClinicalImpressionPrognosis", "http://hl7.org/fhir/ValueSet/clinicalimpression-prognosis", false)]
		public ICollection<CodeableConcept> prognosisCodeableConcept { get; set; }

		public ICollection<Reference> prognosisReference { get; set; }

		public ICollection<Reference> supportingInfo { get; set; }

		public ICollection<Annotation> note { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/ClinicalImpression.investigation")]
		public partial class InvestigationComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			[ValueSetBinding("InvestigationGroupType", "http://hl7.org/fhir/ValueSet/investigation-sets", false)]
			public CodeableConcept code { get; set; }

			public ICollection<Reference> item { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/ClinicalImpression.finding")]
		public partial class FindingComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[ValueSetBinding("ConditionKind", "http://hl7.org/fhir/ValueSet/condition-code", false)]
			public CodeableConcept itemCodeableConcept { get; set; }

			public Reference itemReference { get; set; }

			public StringElement basis { get; set; }
		}
	}
}

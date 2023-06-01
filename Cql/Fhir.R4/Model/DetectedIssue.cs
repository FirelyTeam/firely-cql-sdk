using Hl7.Cql.Poco.Fhir;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Hl7.Cql.Poco.Fhir.R4.Model
{
    [FhirUri("http://hl7.org/fhir/StructureDefinition/DetectedIssue")]
	public partial class DetectedIssue : DomainResource
	{

		public ICollection<Identifier> identifier { get; set; }

		[NotNull]
		[ValueSetBinding("DetectedIssueStatus", "http://hl7.org/fhir/ValueSet/observation-status%7C4.0.1", true)]
		public CodeElement status { get; set; }

		[ValueSetBinding("DetectedIssueCategory", "http://hl7.org/fhir/ValueSet/detectedissue-category", false)]
		public CodeableConcept code { get; set; }

		[ValueSetBinding("DetectedIssueSeverity", "http://hl7.org/fhir/ValueSet/detectedissue-severity%7C4.0.1", true)]
		public CodeElement severity { get; set; }

		public Reference patient { get; set; }

		[Choice(typeof(DateTimeElement))]
		[Choice(typeof(Period))]
		[JsonIgnore]
		public Element identified { get; set; }
		public DateTimeElement identifiedDateTime { get => ChoiceAttribute.AsExactly<DateTimeElement>(identified); set { identified = value; } }
		public Period identifiedPeriod { get => ChoiceAttribute.AsExactly<Period>(identified); set { identified = value; } }

		public Reference author { get; set; }

		public ICollection<Reference> implicated { get; set; }

		public ICollection<EvidenceComponent> evidence { get; set; }

		public StringElement detail { get; set; }

		public UriElement reference { get; set; }

		public ICollection<MitigationComponent> mitigation { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/DetectedIssue.evidence")]
		public partial class EvidenceComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[ValueSetBinding("DetectedIssueEvidenceCode", "http://hl7.org/fhir/ValueSet/manifestation-or-symptom", false)]
			public ICollection<CodeableConcept> code { get; set; }

			public ICollection<Reference> detail { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/DetectedIssue.mitigation")]
		public partial class MitigationComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			[ValueSetBinding("DetectedIssueMitigationAction", "http://hl7.org/fhir/ValueSet/detectedissue-mitigation-action", false)]
			public CodeableConcept action { get; set; }

			public DateTimeElement date { get; set; }

			public Reference author { get; set; }
		}
	}
}

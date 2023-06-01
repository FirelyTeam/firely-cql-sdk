using Hl7.Cql.Poco.Fhir;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Hl7.Cql.Poco.Fhir.R4.Model
{
    [FhirUri("http://hl7.org/fhir/StructureDefinition/ResearchStudy")]
	public partial class ResearchStudy : DomainResource
	{

		public ICollection<Identifier> identifier { get; set; }

		public StringElement title { get; set; }

		public ICollection<Reference> protocol { get; set; }

		public ICollection<Reference> partOf { get; set; }

		[NotNull]
		[ValueSetBinding("ResearchStudyStatus", "http://hl7.org/fhir/ValueSet/research-study-status%7C4.0.1", true)]
		public CodeElement status { get; set; }

		[ValueSetBinding("ResearchStudyPrimaryPurposeType", "http://hl7.org/fhir/ValueSet/research-study-prim-purp-type", false)]
		public CodeableConcept primaryPurposeType { get; set; }

		[ValueSetBinding("ResearchStudyPhase", "http://hl7.org/fhir/ValueSet/research-study-phase", false)]
		public CodeableConcept phase { get; set; }

		public ICollection<CodeableConcept> category { get; set; }

		public ICollection<CodeableConcept> focus { get; set; }

		[ValueSetBinding("ConditionCode", "http://hl7.org/fhir/ValueSet/condition-code", false)]
		public ICollection<CodeableConcept> condition { get; set; }

		public ICollection<ContactDetail> contact { get; set; }

		public ICollection<RelatedArtifact> relatedArtifact { get; set; }

		public ICollection<CodeableConcept> keyword { get; set; }

		[ValueSetBinding("Jurisdiction", "http://hl7.org/fhir/ValueSet/jurisdiction", false)]
		public ICollection<CodeableConcept> location { get; set; }

		public MarkdownElement description { get; set; }

		public ICollection<Reference> enrollment { get; set; }

		public Period period { get; set; }

		public Reference sponsor { get; set; }

		public Reference principalInvestigator { get; set; }

		public ICollection<Reference> site { get; set; }

		[ValueSetBinding("ResearchStudyReasonStopped", "http://hl7.org/fhir/ValueSet/research-study-reason-stopped", false)]
		public CodeableConcept reasonStopped { get; set; }

		public ICollection<Annotation> note { get; set; }

		public ICollection<ArmComponent> arm { get; set; }

		public ICollection<ObjectiveComponent> objective { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/ResearchStudy.arm")]
		public partial class ArmComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			public StringElement name { get; set; }

			public CodeableConcept type { get; set; }

			public StringElement description { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/ResearchStudy.objective")]
		public partial class ObjectiveComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public StringElement name { get; set; }

			[ValueSetBinding("ResearchStudyObjectiveType", "http://hl7.org/fhir/ValueSet/research-study-objective-type", false)]
			public CodeableConcept type { get; set; }
		}
	}
}

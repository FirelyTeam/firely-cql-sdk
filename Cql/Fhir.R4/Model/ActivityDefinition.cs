using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[FhirUri("http://hl7.org/fhir/StructureDefinition/ActivityDefinition")]
	public partial class ActivityDefinition : DomainResource
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

		[ValueSetBinding("ActivityDefinitionKind", "http://hl7.org/fhir/ValueSet/request-resource-types%7C4.0.1", true)]
		public CodeElement kind { get; set; }

		public CanonicalElement profile { get; set; }

		[ValueSetBinding("ActivityDefinitionType", "http://hl7.org/fhir/ValueSet/procedure-code", false)]
		public CodeableConcept code { get; set; }

		[ValueSetBinding("RequestIntent", "http://hl7.org/fhir/ValueSet/request-intent%7C4.0.1", true)]
		public CodeElement intent { get; set; }

		[ValueSetBinding("RequestPriority", "http://hl7.org/fhir/ValueSet/request-priority%7C4.0.1", true)]
		public CodeElement priority { get; set; }

		public BooleanElement doNotPerform { get; set; }

		[Choice(typeof(Timing))]
		[Choice(typeof(DateTimeElement))]
		[Choice(typeof(Age))]
		[Choice(typeof(Period))]
		[Choice(typeof(Range))]
		[Choice(typeof(Duration))]
		[JsonIgnore]
		public Element timing { get; set; }
		public Timing timingTiming { get => ChoiceAttribute.AsExactly<Timing>(timing); set { timing = value; } }
		public DateTimeElement timingDateTime { get => ChoiceAttribute.AsExactly<DateTimeElement>(timing); set { timing = value; } }
		public Age timingAge { get => ChoiceAttribute.AsExactly<Age>(timing); set { timing = value; } }
		public Period timingPeriod { get => ChoiceAttribute.AsExactly<Period>(timing); set { timing = value; } }
		public Range timingRange { get => ChoiceAttribute.AsExactly<Range>(timing); set { timing = value; } }
		public Duration timingDuration { get => ChoiceAttribute.AsExactly<Duration>(timing); set { timing = value; } }

		public Reference location { get; set; }

		public ICollection<ParticipantComponent> participant { get; set; }

		[Choice(typeof(Reference))]
		[Choice(typeof(CodeableConcept))]
		[JsonIgnore]
		[ValueSetBinding("ActivityProduct", "http://hl7.org/fhir/ValueSet/medication-codes", false)]
		public Element product { get; set; }
		public Reference productReference { get => ChoiceAttribute.AsExactly<Reference>(product); set { product = value; } }
		public CodeableConcept productCodeableConcept { get => ChoiceAttribute.AsExactly<CodeableConcept>(product); set { product = value; } }

		public Quantity quantity { get; set; }

		public ICollection<Dosage> dosage { get; set; }

		[ValueSetBinding("BodySite", "http://hl7.org/fhir/ValueSet/body-site", false)]
		public ICollection<CodeableConcept> bodySite { get; set; }

		public ICollection<Reference> specimenRequirement { get; set; }

		public ICollection<Reference> observationRequirement { get; set; }

		public ICollection<Reference> observationResultRequirement { get; set; }

		public CanonicalElement transform { get; set; }

		public ICollection<DynamicValueComponent> dynamicValue { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/ActivityDefinition.participant")]
		public partial class ParticipantComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			[ValueSetBinding("ActivityParticipantType", "http://hl7.org/fhir/ValueSet/action-participant-type%7C4.0.1", true)]
			public CodeElement type { get; set; }

			[ValueSetBinding("ActivityParticipantRole", "http://hl7.org/fhir/ValueSet/action-participant-role", false)]
			public CodeableConcept role { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/ActivityDefinition.dynamicValue")]
		public partial class DynamicValueComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			public StringElement path { get; set; }

			[NotNull]
			public Expression expression { get; set; }
		}
	}
}

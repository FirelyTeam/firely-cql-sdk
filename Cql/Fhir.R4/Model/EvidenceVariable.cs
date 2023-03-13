using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[FhirUri("http://hl7.org/fhir/StructureDefinition/EvidenceVariable")]
	public partial class EvidenceVariable : DomainResource
	{

		public UriElement url { get; set; }

		public ICollection<Identifier> identifier { get; set; }

		public StringElement version { get; set; }

		public StringElement name { get; set; }

		public StringElement title { get; set; }

		public StringElement shortTitle { get; set; }

		public StringElement subtitle { get; set; }

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

		[ValueSetBinding("EvidenceVariableType", "http://hl7.org/fhir/ValueSet/variable-type%7C4.0.1", true)]
		public CodeElement type { get; set; }

		public ICollection<CharacteristicComponent> characteristic { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/EvidenceVariable.characteristic")]
		public partial class CharacteristicComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public StringElement description { get; set; }

			[NotNull]
			[Choice(typeof(Reference))]
			[Choice(typeof(CanonicalElement))]
			[Choice(typeof(CodeableConcept))]
			[Choice(typeof(Expression))]
			[Choice(typeof(DataRequirement))]
			[Choice(typeof(TriggerDefinition))]
			[JsonIgnore]
			public Element definition { get; set; }
			public Reference definitionReference { get => ChoiceAttribute.AsExactly<Reference>(definition); set { definition = value; } }
			public CanonicalElement definitionCanonical { get => ChoiceAttribute.AsExactly<CanonicalElement>(definition); set { definition = value; } }
			public CodeableConcept definitionCodeableConcept { get => ChoiceAttribute.AsExactly<CodeableConcept>(definition); set { definition = value; } }
			public Expression definitionExpression { get => ChoiceAttribute.AsExactly<Expression>(definition); set { definition = value; } }
			public DataRequirement definitionDataRequirement { get => ChoiceAttribute.AsExactly<DataRequirement>(definition); set { definition = value; } }
			public TriggerDefinition definitionTriggerDefinition { get => ChoiceAttribute.AsExactly<TriggerDefinition>(definition); set { definition = value; } }

			public ICollection<UsageContext> usageContext { get; set; }

			public BooleanElement exclude { get; set; }

			[Choice(typeof(DateTimeElement))]
			[Choice(typeof(Period))]
			[Choice(typeof(Duration))]
			[Choice(typeof(Timing))]
			[JsonIgnore]
			public Element participantEffective { get; set; }
			public DateTimeElement participantEffectiveDateTime { get => ChoiceAttribute.AsExactly<DateTimeElement>(participantEffective); set { participantEffective = value; } }
			public Period participantEffectivePeriod { get => ChoiceAttribute.AsExactly<Period>(participantEffective); set { participantEffective = value; } }
			public Duration participantEffectiveDuration { get => ChoiceAttribute.AsExactly<Duration>(participantEffective); set { participantEffective = value; } }
			public Timing participantEffectiveTiming { get => ChoiceAttribute.AsExactly<Timing>(participantEffective); set { participantEffective = value; } }

			public Duration timeFromStart { get; set; }

			[ValueSetBinding("GroupMeasure", "http://hl7.org/fhir/ValueSet/group-measure%7C4.0.1", true)]
			public CodeElement groupMeasure { get; set; }
		}
	}
}

using Hl7.Cql.Poco.Fhir;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Hl7.Cql.Poco.Fhir.R4.Model
{
    [FhirUri("http://hl7.org/fhir/StructureDefinition/PlanDefinition")]
	public partial class PlanDefinition : DomainResource
	{

		public UriElement url { get; set; }

		public ICollection<Identifier> identifier { get; set; }

		public StringElement version { get; set; }

		public StringElement name { get; set; }

		public StringElement title { get; set; }

		public StringElement subtitle { get; set; }

		[ValueSetBinding("PlanDefinitionType", "http://hl7.org/fhir/ValueSet/plan-definition-type", false)]
		public CodeableConcept type { get; set; }

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

		public ICollection<GoalComponent> goal { get; set; }

		public ICollection<ActionComponent> action { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/PlanDefinition.goal")]
		public partial class GoalComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[ValueSetBinding("GoalCategory", "http://hl7.org/fhir/ValueSet/goal-category", false)]
			public CodeableConcept category { get; set; }

			[NotNull]
			[ValueSetBinding("GoalDescription", "http://hl7.org/fhir/ValueSet/clinical-findings", false)]
			public CodeableConcept description { get; set; }

			[ValueSetBinding("GoalPriority", "http://hl7.org/fhir/ValueSet/goal-priority", false)]
			public CodeableConcept priority { get; set; }

			[ValueSetBinding("GoalStartEvent", "http://hl7.org/fhir/ValueSet/goal-start-event", false)]
			public CodeableConcept start { get; set; }

			[ValueSetBinding("GoalAddresses", "http://hl7.org/fhir/ValueSet/condition-code", false)]
			public ICollection<CodeableConcept> addresses { get; set; }

			public ICollection<RelatedArtifact> documentation { get; set; }

			public ICollection<TargetComponent> target { get; set; }
			[FhirUri("http://hl7.org/fhir/StructureDefinition/PlanDefinition.goal.target")]
			public partial class TargetComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				[ValueSetBinding("GoalTargetMeasure", "http://hl7.org/fhir/ValueSet/observation-codes", false)]
				public CodeableConcept measure { get; set; }

				[Choice(typeof(Quantity))]
				[Choice(typeof(Range))]
				[Choice(typeof(CodeableConcept))]
				[JsonIgnore]
				public Element detail { get; set; }
				public Quantity detailQuantity { get => ChoiceAttribute.AsExactly<Quantity>(detail); set { detail = value; } }
				public Range detailRange { get => ChoiceAttribute.AsExactly<Range>(detail); set { detail = value; } }
				public CodeableConcept detailCodeableConcept { get => ChoiceAttribute.AsExactly<CodeableConcept>(detail); set { detail = value; } }

				public Duration due { get; set; }
			}
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/PlanDefinition.action")]
		public partial class ActionComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public StringElement prefix { get; set; }

			public StringElement title { get; set; }

			public StringElement description { get; set; }

			public StringElement textEquivalent { get; set; }

			[ValueSetBinding("RequestPriority", "http://hl7.org/fhir/ValueSet/request-priority%7C4.0.1", true)]
			public CodeElement priority { get; set; }

			public ICollection<CodeableConcept> code { get; set; }

			public ICollection<CodeableConcept> reason { get; set; }

			public ICollection<RelatedArtifact> documentation { get; set; }

			public ICollection<IdElement> goalId { get; set; }

			[Choice(typeof(CodeableConcept))]
			[Choice(typeof(Reference))]
			[JsonIgnore]
			[ValueSetBinding("SubjectType", "http://hl7.org/fhir/ValueSet/subject-type", false)]
			public Element subject { get; set; }
			public CodeableConcept subjectCodeableConcept { get => ChoiceAttribute.AsExactly<CodeableConcept>(subject); set { subject = value; } }
			public Reference subjectReference { get => ChoiceAttribute.AsExactly<Reference>(subject); set { subject = value; } }

			public ICollection<TriggerDefinition> trigger { get; set; }

			public ICollection<ConditionComponent> condition { get; set; }

			public ICollection<DataRequirement> input { get; set; }

			public ICollection<DataRequirement> output { get; set; }

			public ICollection<RelatedActionComponent> relatedAction { get; set; }

			[Choice(typeof(DateTimeElement))]
			[Choice(typeof(Age))]
			[Choice(typeof(Period))]
			[Choice(typeof(Duration))]
			[Choice(typeof(Range))]
			[Choice(typeof(Timing))]
			[JsonIgnore]
			public Element timing { get; set; }
			public DateTimeElement timingDateTime { get => ChoiceAttribute.AsExactly<DateTimeElement>(timing); set { timing = value; } }
			public Age timingAge { get => ChoiceAttribute.AsExactly<Age>(timing); set { timing = value; } }
			public Period timingPeriod { get => ChoiceAttribute.AsExactly<Period>(timing); set { timing = value; } }
			public Duration timingDuration { get => ChoiceAttribute.AsExactly<Duration>(timing); set { timing = value; } }
			public Range timingRange { get => ChoiceAttribute.AsExactly<Range>(timing); set { timing = value; } }
			public Timing timingTiming { get => ChoiceAttribute.AsExactly<Timing>(timing); set { timing = value; } }

			public ICollection<ParticipantComponent> participant { get; set; }

			[ValueSetBinding("ActionType", "http://hl7.org/fhir/ValueSet/action-type", false)]
			public CodeableConcept type { get; set; }

			[ValueSetBinding("ActionGroupingBehavior", "http://hl7.org/fhir/ValueSet/action-grouping-behavior%7C4.0.1", true)]
			public CodeElement groupingBehavior { get; set; }

			[ValueSetBinding("ActionSelectionBehavior", "http://hl7.org/fhir/ValueSet/action-selection-behavior%7C4.0.1", true)]
			public CodeElement selectionBehavior { get; set; }

			[ValueSetBinding("ActionRequiredBehavior", "http://hl7.org/fhir/ValueSet/action-required-behavior%7C4.0.1", true)]
			public CodeElement requiredBehavior { get; set; }

			[ValueSetBinding("ActionPrecheckBehavior", "http://hl7.org/fhir/ValueSet/action-precheck-behavior%7C4.0.1", true)]
			public CodeElement precheckBehavior { get; set; }

			[ValueSetBinding("ActionCardinalityBehavior", "http://hl7.org/fhir/ValueSet/action-cardinality-behavior%7C4.0.1", true)]
			public CodeElement cardinalityBehavior { get; set; }

			[Choice(typeof(CanonicalElement))]
			[Choice(typeof(UriElement))]
			[JsonIgnore]
			public UriElement definition { get; set; }
			public CanonicalElement definitionCanonical { get => ChoiceAttribute.AsExactly<CanonicalElement>(definition); set { definition = value; } }
			public UriElement definitionUri { get => ChoiceAttribute.AsExactly<UriElement>(definition); set { definition = value; } }

			public CanonicalElement transform { get; set; }

			public ICollection<DynamicValueComponent> dynamicValue { get; set; }
			[FhirUri("http://hl7.org/fhir/StructureDefinition/PlanDefinition.action.condition")]
			public partial class ConditionComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				[NotNull]
				[ValueSetBinding("ActionConditionKind", "http://hl7.org/fhir/ValueSet/action-condition-kind%7C4.0.1", true)]
				public CodeElement kind { get; set; }

				public Expression expression { get; set; }
			}
			[FhirUri("http://hl7.org/fhir/StructureDefinition/PlanDefinition.action.relatedAction")]
			public partial class RelatedActionComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				[NotNull]
				public IdElement actionId { get; set; }

				[NotNull]
				[ValueSetBinding("ActionRelationshipType", "http://hl7.org/fhir/ValueSet/action-relationship-type%7C4.0.1", true)]
				public CodeElement relationship { get; set; }

				[Choice(typeof(Duration))]
				[Choice(typeof(Range))]
				[JsonIgnore]
				public Element offset { get; set; }
				public Duration offsetDuration { get => ChoiceAttribute.AsExactly<Duration>(offset); set { offset = value; } }
				public Range offsetRange { get => ChoiceAttribute.AsExactly<Range>(offset); set { offset = value; } }
			}
			[FhirUri("http://hl7.org/fhir/StructureDefinition/PlanDefinition.action.participant")]
			public partial class ParticipantComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				[NotNull]
				[ValueSetBinding("ActionParticipantType", "http://hl7.org/fhir/ValueSet/action-participant-type%7C4.0.1", true)]
				public CodeElement type { get; set; }

				[ValueSetBinding("ActionParticipantRole", "http://hl7.org/fhir/ValueSet/action-participant-role", false)]
				public CodeableConcept role { get; set; }
			}
			[FhirUri("http://hl7.org/fhir/StructureDefinition/PlanDefinition.action.dynamicValue")]
			public partial class DynamicValueComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				public StringElement path { get; set; }

				public Expression expression { get; set; }
			}
		}
	}
}

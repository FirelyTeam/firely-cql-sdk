using Hl7.Cql.Poco.Fhir;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Hl7.Cql.Poco.Fhir.R4.Model
{
    [FhirUri("http://hl7.org/fhir/StructureDefinition/Goal")]
	public partial class Goal : DomainResource
	{

		public ICollection<Identifier> identifier { get; set; }

		[NotNull]
		[ValueSetBinding("GoalLifecycleStatus", "http://hl7.org/fhir/ValueSet/goal-status%7C4.0.1", true)]
		public CodeElement lifecycleStatus { get; set; }

		[ValueSetBinding("GoalAchievementStatus", "http://hl7.org/fhir/ValueSet/goal-achievement", false)]
		public CodeableConcept achievementStatus { get; set; }

		[ValueSetBinding("GoalCategory", "http://hl7.org/fhir/ValueSet/goal-category", false)]
		public ICollection<CodeableConcept> category { get; set; }

		[ValueSetBinding("GoalPriority", "http://hl7.org/fhir/ValueSet/goal-priority", false)]
		public CodeableConcept priority { get; set; }

		[NotNull]
		[ValueSetBinding("GoalDescription", "http://hl7.org/fhir/ValueSet/clinical-findings", false)]
		public CodeableConcept description { get; set; }

		[NotNull]
		public Reference subject { get; set; }

		[Choice(typeof(DateElement))]
		[Choice(typeof(CodeableConcept))]
		[JsonIgnore]
		[ValueSetBinding("GoalStartEvent", "http://hl7.org/fhir/ValueSet/goal-start-event", false)]
		public Element start { get; set; }
		public DateElement startDate { get => ChoiceAttribute.AsExactly<DateElement>(start); set { start = value; } }
		public CodeableConcept startCodeableConcept { get => ChoiceAttribute.AsExactly<CodeableConcept>(start); set { start = value; } }

		public ICollection<TargetComponent> target { get; set; }

		public DateElement statusDate { get; set; }

		public StringElement statusReason { get; set; }

		public Reference expressedBy { get; set; }

		public ICollection<Reference> addresses { get; set; }

		public ICollection<Annotation> note { get; set; }

		[ValueSetBinding("GoalOutcome", "http://hl7.org/fhir/ValueSet/clinical-findings", false)]
		public ICollection<CodeableConcept> outcomeCode { get; set; }

		public ICollection<Reference> outcomeReference { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/Goal.target")]
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
			[Choice(typeof(StringElement))]
			[Choice(typeof(BooleanElement))]
			[Choice(typeof(IntegerElement))]
			[Choice(typeof(Ratio))]
			[JsonIgnore]
			public Element detail { get; set; }
			public Quantity detailQuantity { get => ChoiceAttribute.AsExactly<Quantity>(detail); set { detail = value; } }
			public Range detailRange { get => ChoiceAttribute.AsExactly<Range>(detail); set { detail = value; } }
			public CodeableConcept detailCodeableConcept { get => ChoiceAttribute.AsExactly<CodeableConcept>(detail); set { detail = value; } }
			public StringElement detailString { get => ChoiceAttribute.AsExactly<StringElement>(detail); set { detail = value; } }
			public BooleanElement detailBoolean { get => ChoiceAttribute.AsExactly<BooleanElement>(detail); set { detail = value; } }
			public IntegerElement detailInteger { get => ChoiceAttribute.AsExactly<IntegerElement>(detail); set { detail = value; } }
			public Ratio detailRatio { get => ChoiceAttribute.AsExactly<Ratio>(detail); set { detail = value; } }

			[Choice(typeof(DateElement))]
			[Choice(typeof(Duration))]
			[JsonIgnore]
			public Element due { get; set; }
			public DateElement dueDate { get => ChoiceAttribute.AsExactly<DateElement>(due); set { due = value; } }
			public Duration dueDuration { get => ChoiceAttribute.AsExactly<Duration>(due); set { due = value; } }
		}
	}
}

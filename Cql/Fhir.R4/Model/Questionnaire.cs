using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[FhirUri("http://hl7.org/fhir/StructureDefinition/Questionnaire")]
	public partial class Questionnaire : DomainResource
	{

		public UriElement url { get; set; }

		public ICollection<Identifier> identifier { get; set; }

		public StringElement version { get; set; }

		public StringElement name { get; set; }

		public StringElement title { get; set; }

		public ICollection<CanonicalElement> derivedFrom { get; set; }

		[NotNull]
		[ValueSetBinding("PublicationStatus", "http://hl7.org/fhir/ValueSet/publication-status%7C4.0.1", true)]
		public CodeElement status { get; set; }

		public BooleanElement experimental { get; set; }

		[ValueSetBinding("ResourceType", "http://hl7.org/fhir/ValueSet/resource-types%7C4.0.1", true)]
		public ICollection<CodeElement> subjectType { get; set; }

		public DateTimeElement date { get; set; }

		public StringElement publisher { get; set; }

		public ICollection<ContactDetail> contact { get; set; }

		public MarkdownElement description { get; set; }

		public ICollection<UsageContext> useContext { get; set; }

		[ValueSetBinding("Jurisdiction", "http://hl7.org/fhir/ValueSet/jurisdiction", false)]
		public ICollection<CodeableConcept> jurisdiction { get; set; }

		public MarkdownElement purpose { get; set; }

		public MarkdownElement copyright { get; set; }

		public DateElement approvalDate { get; set; }

		public DateElement lastReviewDate { get; set; }

		public Period effectivePeriod { get; set; }

		[ValueSetBinding("QuestionnaireConcept", "http://hl7.org/fhir/ValueSet/questionnaire-questions", false)]
		public ICollection<Coding> code { get; set; }

		public ICollection<ItemComponent> item { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/Questionnaire.item")]
		public partial class ItemComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			public StringElement linkId { get; set; }

			public UriElement definition { get; set; }

			[ValueSetBinding("QuestionnaireConcept", "http://hl7.org/fhir/ValueSet/questionnaire-questions", false)]
			public ICollection<Coding> code { get; set; }

			public StringElement prefix { get; set; }

			public StringElement text { get; set; }

			[NotNull]
			[ValueSetBinding("QuestionnaireItemType", "http://hl7.org/fhir/ValueSet/item-type%7C4.0.1", true)]
			public CodeElement type { get; set; }

			public ICollection<EnableWhenComponent> enableWhen { get; set; }

			[ValueSetBinding("EnableWhenBehavior", "http://hl7.org/fhir/ValueSet/questionnaire-enable-behavior%7C4.0.1", true)]
			public CodeElement enableBehavior { get; set; }

			public BooleanElement required { get; set; }

			public BooleanElement repeats { get; set; }

			public BooleanElement readOnly { get; set; }

			public IntegerElement maxLength { get; set; }

			public CanonicalElement answerValueSet { get; set; }

			public ICollection<AnswerOptionComponent> answerOption { get; set; }

			public ICollection<InitialComponent> initial { get; set; }
			[FhirUri("http://hl7.org/fhir/StructureDefinition/Questionnaire.item.enableWhen")]
			public partial class EnableWhenComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				[NotNull]
				public StringElement question { get; set; }

				[NotNull]
				[ValueSetBinding("QuestionnaireItemOperator", "http://hl7.org/fhir/ValueSet/questionnaire-enable-operator%7C4.0.1", true)]
				public CodeElement @operator { get; set; }

				[NotNull]
				[Choice(typeof(BooleanElement))]
				[Choice(typeof(DecimalElement))]
				[Choice(typeof(IntegerElement))]
				[Choice(typeof(DateElement))]
				[Choice(typeof(DateTimeElement))]
				[Choice(typeof(TimeElement))]
				[Choice(typeof(StringElement))]
				[Choice(typeof(Coding))]
				[Choice(typeof(Quantity))]
				[Choice(typeof(Reference))]
				[JsonIgnore]
				[ValueSetBinding("QuestionnaireQuestionOption3", "http://hl7.org/fhir/ValueSet/questionnaire-answers", false)]
				public Element answer { get; set; }
				public BooleanElement answerBoolean { get => ChoiceAttribute.AsExactly<BooleanElement>(answer); set { answer = value; } }
				public DecimalElement answerDecimal { get => ChoiceAttribute.AsExactly<DecimalElement>(answer); set { answer = value; } }
				public IntegerElement answerInteger { get => ChoiceAttribute.AsExactly<IntegerElement>(answer); set { answer = value; } }
				public DateElement answerDate { get => ChoiceAttribute.AsExactly<DateElement>(answer); set { answer = value; } }
				public DateTimeElement answerDateTime { get => ChoiceAttribute.AsExactly<DateTimeElement>(answer); set { answer = value; } }
				public TimeElement answerTime { get => ChoiceAttribute.AsExactly<TimeElement>(answer); set { answer = value; } }
				public StringElement answerString { get => ChoiceAttribute.AsExactly<StringElement>(answer); set { answer = value; } }
				public Coding answerCoding { get => ChoiceAttribute.AsExactly<Coding>(answer); set { answer = value; } }
				public Quantity answerQuantity { get => ChoiceAttribute.AsExactly<Quantity>(answer); set { answer = value; } }
				public Reference answerReference { get => ChoiceAttribute.AsExactly<Reference>(answer); set { answer = value; } }
			}
			[DebuggerDisplay("{value}")]
			[FhirUri("http://hl7.org/fhir/StructureDefinition/Questionnaire.item.answerOption")]
			public partial class AnswerOptionComponent
			{

				[NotNull]
				[Choice(typeof(IntegerElement))]
				[Choice(typeof(DateElement))]
				[Choice(typeof(TimeElement))]
				[Choice(typeof(StringElement))]
				[Choice(typeof(Coding))]
				[Choice(typeof(Reference))]
				[JsonIgnore]
				[ValueSetBinding("QuestionnaireQuestionOption", "http://hl7.org/fhir/ValueSet/questionnaire-answers", false)]
				public Element value { get; set; }
				public IntegerElement valueInteger { get => ChoiceAttribute.AsExactly<IntegerElement>(value); set { this.value = value; } }
				public DateElement valueDate { get => ChoiceAttribute.AsExactly<DateElement>(value); set { this.value = value; } }
				public TimeElement valueTime { get => ChoiceAttribute.AsExactly<TimeElement>(value); set { this.value = value; } }
				public StringElement valueString { get => ChoiceAttribute.AsExactly<StringElement>(value); set { this.value = value; } }
				public Coding valueCoding { get => ChoiceAttribute.AsExactly<Coding>(value); set { this.value = value; } }
				public Reference valueReference { get => ChoiceAttribute.AsExactly<Reference>(value); set { this.value = value; } }

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				public BooleanElement initialSelected { get; set; }
			}
			[DebuggerDisplay("{value}")]
			[FhirUri("http://hl7.org/fhir/StructureDefinition/Questionnaire.item.initial")]
			public partial class InitialComponent
			{

				[NotNull]
				[Choice(typeof(BooleanElement))]
				[Choice(typeof(DecimalElement))]
				[Choice(typeof(IntegerElement))]
				[Choice(typeof(DateElement))]
				[Choice(typeof(DateTimeElement))]
				[Choice(typeof(TimeElement))]
				[Choice(typeof(StringElement))]
				[Choice(typeof(UriElement))]
				[Choice(typeof(Attachment))]
				[Choice(typeof(Coding))]
				[Choice(typeof(Quantity))]
				[Choice(typeof(Reference))]
				[JsonIgnore]
				[ValueSetBinding("QuestionnaireQuestionOption2", "http://hl7.org/fhir/ValueSet/questionnaire-answers", false)]
				public Element value { get; set; }
				public BooleanElement valueBoolean { get => ChoiceAttribute.AsExactly<BooleanElement>(value); set { this.value = value; } }
				public DecimalElement valueDecimal { get => ChoiceAttribute.AsExactly<DecimalElement>(value); set { this.value = value; } }
				public IntegerElement valueInteger { get => ChoiceAttribute.AsExactly<IntegerElement>(value); set { this.value = value; } }
				public DateElement valueDate { get => ChoiceAttribute.AsExactly<DateElement>(value); set { this.value = value; } }
				public DateTimeElement valueDateTime { get => ChoiceAttribute.AsExactly<DateTimeElement>(value); set { this.value = value; } }
				public TimeElement valueTime { get => ChoiceAttribute.AsExactly<TimeElement>(value); set { this.value = value; } }
				public StringElement valueString { get => ChoiceAttribute.AsExactly<StringElement>(value); set { this.value = value; } }
				public UriElement valueUri { get => ChoiceAttribute.AsExactly<UriElement>(value); set { this.value = value; } }
				public Attachment valueAttachment { get => ChoiceAttribute.AsExactly<Attachment>(value); set { this.value = value; } }
				public Coding valueCoding { get => ChoiceAttribute.AsExactly<Coding>(value); set { this.value = value; } }
				public Quantity valueQuantity { get => ChoiceAttribute.AsExactly<Quantity>(value); set { this.value = value; } }
				public Reference valueReference { get => ChoiceAttribute.AsExactly<Reference>(value); set { this.value = value; } }

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }
			}
		}
	}
}

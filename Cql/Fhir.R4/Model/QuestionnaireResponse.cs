using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[FhirUri("http://hl7.org/fhir/StructureDefinition/QuestionnaireResponse")]
	public partial class QuestionnaireResponse : DomainResource
	{

		public Identifier identifier { get; set; }

		public ICollection<Reference> basedOn { get; set; }

		public ICollection<Reference> partOf { get; set; }

		public CanonicalElement questionnaire { get; set; }

		[NotNull]
		[ValueSetBinding("QuestionnaireResponseStatus", "http://hl7.org/fhir/ValueSet/questionnaire-answers-status%7C4.0.1", true)]
		public CodeElement status { get; set; }

		public Reference subject { get; set; }

		public Reference encounter { get; set; }

		public DateTimeElement authored { get; set; }

		public Reference author { get; set; }

		public Reference source { get; set; }

		public ICollection<ItemComponent> item { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/QuestionnaireResponse.item")]
		public partial class ItemComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			public StringElement linkId { get; set; }

			public UriElement definition { get; set; }

			public StringElement text { get; set; }

			public ICollection<AnswerComponent> answer { get; set; }
			[DebuggerDisplay("{value}")]
			[FhirUri("http://hl7.org/fhir/StructureDefinition/QuestionnaireResponse.item.answer")]
			public partial class AnswerComponent
			{

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
				[ValueSetBinding("QuestionnaireAnswer", "http://hl7.org/fhir/ValueSet/questionnaire-answers", false)]
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

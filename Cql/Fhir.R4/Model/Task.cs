using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[FhirUri("http://hl7.org/fhir/StructureDefinition/Task")]
	public partial class Task : DomainResource
	{

		public ICollection<Identifier> identifier { get; set; }

		public CanonicalElement instantiatesCanonical { get; set; }

		public UriElement instantiatesUri { get; set; }

		public ICollection<Reference> basedOn { get; set; }

		public Identifier groupIdentifier { get; set; }

		public ICollection<Reference> partOf { get; set; }

		[NotNull]
		[ValueSetBinding("TaskStatus", "http://hl7.org/fhir/ValueSet/task-status%7C4.0.1", true)]
		public CodeElement status { get; set; }

		public CodeableConcept statusReason { get; set; }

		public CodeableConcept businessStatus { get; set; }

		[NotNull]
		[ValueSetBinding("TaskIntent", "http://hl7.org/fhir/ValueSet/task-intent%7C4.0.1", true)]
		public CodeElement intent { get; set; }

		[ValueSetBinding("TaskPriority", "http://hl7.org/fhir/ValueSet/request-priority%7C4.0.1", true)]
		public CodeElement priority { get; set; }

		[ValueSetBinding("TaskCode", "http://hl7.org/fhir/ValueSet/task-code", false)]
		public CodeableConcept code { get; set; }

		public StringElement description { get; set; }

		public Reference focus { get; set; }

		public Reference @for { get; set; }

		public Reference encounter { get; set; }

		public Period executionPeriod { get; set; }

		public DateTimeElement authoredOn { get; set; }

		public DateTimeElement lastModified { get; set; }

		public Reference requester { get; set; }

		[ValueSetBinding("TaskPerformerType", "http://hl7.org/fhir/ValueSet/performer-role", false)]
		public ICollection<CodeableConcept> performerType { get; set; }

		public Reference owner { get; set; }

		public Reference location { get; set; }

		public CodeableConcept reasonCode { get; set; }

		public Reference reasonReference { get; set; }

		public ICollection<Reference> insurance { get; set; }

		public ICollection<Annotation> note { get; set; }

		public ICollection<Reference> relevantHistory { get; set; }

		public RestrictionComponent restriction { get; set; }

		public ICollection<InputComponent> input { get; set; }

		public ICollection<OutputComponent> output { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/Task.restriction")]
		public partial class RestrictionComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public PositiveIntElement repetitions { get; set; }

			public Period period { get; set; }

			public ICollection<Reference> recipient { get; set; }
		}
		[DebuggerDisplay("{value}")]
		[FhirUri("http://hl7.org/fhir/StructureDefinition/Task.input")]
		public partial class InputComponent
		{

			[NotNull]
			[Choice(typeof(Base64BinaryElement))]
			[Choice(typeof(BooleanElement))]
			[Choice(typeof(CanonicalElement))]
			[Choice(typeof(CodeElement))]
			[Choice(typeof(DateElement))]
			[Choice(typeof(DateTimeElement))]
			[Choice(typeof(DecimalElement))]
			[Choice(typeof(IdElement))]
			[Choice(typeof(InstantElement))]
			[Choice(typeof(IntegerElement))]
			[Choice(typeof(MarkdownElement))]
			[Choice(typeof(OidElement))]
			[Choice(typeof(PositiveIntElement))]
			[Choice(typeof(StringElement))]
			[Choice(typeof(TimeElement))]
			[Choice(typeof(UnsignedIntElement))]
			[Choice(typeof(UriElement))]
			[Choice(typeof(UrlElement))]
			[Choice(typeof(UuidElement))]
			[Choice(typeof(Address))]
			[Choice(typeof(Age))]
			[Choice(typeof(Annotation))]
			[Choice(typeof(Attachment))]
			[Choice(typeof(CodeableConcept))]
			[Choice(typeof(Coding))]
			[Choice(typeof(ContactPoint))]
			[Choice(typeof(Count))]
			[Choice(typeof(Distance))]
			[Choice(typeof(Duration))]
			[Choice(typeof(HumanName))]
			[Choice(typeof(Identifier))]
			[Choice(typeof(Money))]
			[Choice(typeof(Period))]
			[Choice(typeof(Quantity))]
			[Choice(typeof(Range))]
			[Choice(typeof(Ratio))]
			[Choice(typeof(Reference))]
			[Choice(typeof(SampledData))]
			[Choice(typeof(Signature))]
			[Choice(typeof(Timing))]
			[Choice(typeof(ContactDetail))]
			[Choice(typeof(Contributor))]
			[Choice(typeof(DataRequirement))]
			[Choice(typeof(Expression))]
			[Choice(typeof(ParameterDefinition))]
			[Choice(typeof(RelatedArtifact))]
			[Choice(typeof(TriggerDefinition))]
			[Choice(typeof(UsageContext))]
			[Choice(typeof(Dosage))]
			[Choice(typeof(Meta))]
			[JsonIgnore]
			public Element value { get; set; }
			public Base64BinaryElement valueBase64Binary { get => ChoiceAttribute.AsExactly<Base64BinaryElement>(value); set { this.value = value; } }
			public BooleanElement valueBoolean { get => ChoiceAttribute.AsExactly<BooleanElement>(value); set { this.value = value; } }
			public CanonicalElement valueCanonical { get => ChoiceAttribute.AsExactly<CanonicalElement>(value); set { this.value = value; } }
			public CodeElement valueCode { get => ChoiceAttribute.AsExactly<CodeElement>(value); set { this.value = value; } }
			public DateElement valueDate { get => ChoiceAttribute.AsExactly<DateElement>(value); set { this.value = value; } }
			public DateTimeElement valueDateTime { get => ChoiceAttribute.AsExactly<DateTimeElement>(value); set { this.value = value; } }
			public DecimalElement valueDecimal { get => ChoiceAttribute.AsExactly<DecimalElement>(value); set { this.value = value; } }
			public IdElement valueId { get => ChoiceAttribute.AsExactly<IdElement>(value); set { this.value = value; } }
			public InstantElement valueInstant { get => ChoiceAttribute.AsExactly<InstantElement>(value); set { this.value = value; } }
			public IntegerElement valueInteger { get => ChoiceAttribute.AsExactly<IntegerElement>(value); set { this.value = value; } }
			public MarkdownElement valueMarkdown { get => ChoiceAttribute.AsExactly<MarkdownElement>(value); set { this.value = value; } }
			public OidElement valueOid { get => ChoiceAttribute.AsExactly<OidElement>(value); set { this.value = value; } }
			public PositiveIntElement valuePositiveInt { get => ChoiceAttribute.AsExactly<PositiveIntElement>(value); set { this.value = value; } }
			public StringElement valueString { get => ChoiceAttribute.AsExactly<StringElement>(value); set { this.value = value; } }
			public TimeElement valueTime { get => ChoiceAttribute.AsExactly<TimeElement>(value); set { this.value = value; } }
			public UnsignedIntElement valueUnsignedInt { get => ChoiceAttribute.AsExactly<UnsignedIntElement>(value); set { this.value = value; } }
			public UriElement valueUri { get => ChoiceAttribute.AsExactly<UriElement>(value); set { this.value = value; } }
			public UrlElement valueUrl { get => ChoiceAttribute.AsExactly<UrlElement>(value); set { this.value = value; } }
			public UuidElement valueUuid { get => ChoiceAttribute.AsExactly<UuidElement>(value); set { this.value = value; } }
			public Address valueAddress { get => ChoiceAttribute.AsExactly<Address>(value); set { this.value = value; } }
			public Age valueAge { get => ChoiceAttribute.AsExactly<Age>(value); set { this.value = value; } }
			public Annotation valueAnnotation { get => ChoiceAttribute.AsExactly<Annotation>(value); set { this.value = value; } }
			public Attachment valueAttachment { get => ChoiceAttribute.AsExactly<Attachment>(value); set { this.value = value; } }
			public CodeableConcept valueCodeableConcept { get => ChoiceAttribute.AsExactly<CodeableConcept>(value); set { this.value = value; } }
			public Coding valueCoding { get => ChoiceAttribute.AsExactly<Coding>(value); set { this.value = value; } }
			public ContactPoint valueContactPoint { get => ChoiceAttribute.AsExactly<ContactPoint>(value); set { this.value = value; } }
			public Count valueCount { get => ChoiceAttribute.AsExactly<Count>(value); set { this.value = value; } }
			public Distance valueDistance { get => ChoiceAttribute.AsExactly<Distance>(value); set { this.value = value; } }
			public Duration valueDuration { get => ChoiceAttribute.AsExactly<Duration>(value); set { this.value = value; } }
			public HumanName valueHumanName { get => ChoiceAttribute.AsExactly<HumanName>(value); set { this.value = value; } }
			public Identifier valueIdentifier { get => ChoiceAttribute.AsExactly<Identifier>(value); set { this.value = value; } }
			public Money valueMoney { get => ChoiceAttribute.AsExactly<Money>(value); set { this.value = value; } }
			public Period valuePeriod { get => ChoiceAttribute.AsExactly<Period>(value); set { this.value = value; } }
			public Quantity valueQuantity { get => ChoiceAttribute.AsExactly<Quantity>(value); set { this.value = value; } }
			public Range valueRange { get => ChoiceAttribute.AsExactly<Range>(value); set { this.value = value; } }
			public Ratio valueRatio { get => ChoiceAttribute.AsExactly<Ratio>(value); set { this.value = value; } }
			public Reference valueReference { get => ChoiceAttribute.AsExactly<Reference>(value); set { this.value = value; } }
			public SampledData valueSampledData { get => ChoiceAttribute.AsExactly<SampledData>(value); set { this.value = value; } }
			public Signature valueSignature { get => ChoiceAttribute.AsExactly<Signature>(value); set { this.value = value; } }
			public Timing valueTiming { get => ChoiceAttribute.AsExactly<Timing>(value); set { this.value = value; } }
			public ContactDetail valueContactDetail { get => ChoiceAttribute.AsExactly<ContactDetail>(value); set { this.value = value; } }
			public Contributor valueContributor { get => ChoiceAttribute.AsExactly<Contributor>(value); set { this.value = value; } }
			public DataRequirement valueDataRequirement { get => ChoiceAttribute.AsExactly<DataRequirement>(value); set { this.value = value; } }
			public Expression valueExpression { get => ChoiceAttribute.AsExactly<Expression>(value); set { this.value = value; } }
			public ParameterDefinition valueParameterDefinition { get => ChoiceAttribute.AsExactly<ParameterDefinition>(value); set { this.value = value; } }
			public RelatedArtifact valueRelatedArtifact { get => ChoiceAttribute.AsExactly<RelatedArtifact>(value); set { this.value = value; } }
			public TriggerDefinition valueTriggerDefinition { get => ChoiceAttribute.AsExactly<TriggerDefinition>(value); set { this.value = value; } }
			public UsageContext valueUsageContext { get => ChoiceAttribute.AsExactly<UsageContext>(value); set { this.value = value; } }
			public Dosage valueDosage { get => ChoiceAttribute.AsExactly<Dosage>(value); set { this.value = value; } }
			public Meta valueMeta { get => ChoiceAttribute.AsExactly<Meta>(value); set { this.value = value; } }

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			public CodeableConcept type { get; set; }
		}
		[DebuggerDisplay("{value}")]
		[FhirUri("http://hl7.org/fhir/StructureDefinition/Task.output")]
		public partial class OutputComponent
		{

			[NotNull]
			[Choice(typeof(Base64BinaryElement))]
			[Choice(typeof(BooleanElement))]
			[Choice(typeof(CanonicalElement))]
			[Choice(typeof(CodeElement))]
			[Choice(typeof(DateElement))]
			[Choice(typeof(DateTimeElement))]
			[Choice(typeof(DecimalElement))]
			[Choice(typeof(IdElement))]
			[Choice(typeof(InstantElement))]
			[Choice(typeof(IntegerElement))]
			[Choice(typeof(MarkdownElement))]
			[Choice(typeof(OidElement))]
			[Choice(typeof(PositiveIntElement))]
			[Choice(typeof(StringElement))]
			[Choice(typeof(TimeElement))]
			[Choice(typeof(UnsignedIntElement))]
			[Choice(typeof(UriElement))]
			[Choice(typeof(UrlElement))]
			[Choice(typeof(UuidElement))]
			[Choice(typeof(Address))]
			[Choice(typeof(Age))]
			[Choice(typeof(Annotation))]
			[Choice(typeof(Attachment))]
			[Choice(typeof(CodeableConcept))]
			[Choice(typeof(Coding))]
			[Choice(typeof(ContactPoint))]
			[Choice(typeof(Count))]
			[Choice(typeof(Distance))]
			[Choice(typeof(Duration))]
			[Choice(typeof(HumanName))]
			[Choice(typeof(Identifier))]
			[Choice(typeof(Money))]
			[Choice(typeof(Period))]
			[Choice(typeof(Quantity))]
			[Choice(typeof(Range))]
			[Choice(typeof(Ratio))]
			[Choice(typeof(Reference))]
			[Choice(typeof(SampledData))]
			[Choice(typeof(Signature))]
			[Choice(typeof(Timing))]
			[Choice(typeof(ContactDetail))]
			[Choice(typeof(Contributor))]
			[Choice(typeof(DataRequirement))]
			[Choice(typeof(Expression))]
			[Choice(typeof(ParameterDefinition))]
			[Choice(typeof(RelatedArtifact))]
			[Choice(typeof(TriggerDefinition))]
			[Choice(typeof(UsageContext))]
			[Choice(typeof(Dosage))]
			[Choice(typeof(Meta))]
			[JsonIgnore]
			public Element value { get; set; }
			public Base64BinaryElement valueBase64Binary { get => ChoiceAttribute.AsExactly<Base64BinaryElement>(value); set { this.value = value; } }
			public BooleanElement valueBoolean { get => ChoiceAttribute.AsExactly<BooleanElement>(value); set { this.value = value; } }
			public CanonicalElement valueCanonical { get => ChoiceAttribute.AsExactly<CanonicalElement>(value); set { this.value = value; } }
			public CodeElement valueCode { get => ChoiceAttribute.AsExactly<CodeElement>(value); set { this.value = value; } }
			public DateElement valueDate { get => ChoiceAttribute.AsExactly<DateElement>(value); set { this.value = value; } }
			public DateTimeElement valueDateTime { get => ChoiceAttribute.AsExactly<DateTimeElement>(value); set { this.value = value; } }
			public DecimalElement valueDecimal { get => ChoiceAttribute.AsExactly<DecimalElement>(value); set { this.value = value; } }
			public IdElement valueId { get => ChoiceAttribute.AsExactly<IdElement>(value); set { this.value = value; } }
			public InstantElement valueInstant { get => ChoiceAttribute.AsExactly<InstantElement>(value); set { this.value = value; } }
			public IntegerElement valueInteger { get => ChoiceAttribute.AsExactly<IntegerElement>(value); set { this.value = value; } }
			public MarkdownElement valueMarkdown { get => ChoiceAttribute.AsExactly<MarkdownElement>(value); set { this.value = value; } }
			public OidElement valueOid { get => ChoiceAttribute.AsExactly<OidElement>(value); set { this.value = value; } }
			public PositiveIntElement valuePositiveInt { get => ChoiceAttribute.AsExactly<PositiveIntElement>(value); set { this.value = value; } }
			public StringElement valueString { get => ChoiceAttribute.AsExactly<StringElement>(value); set { this.value = value; } }
			public TimeElement valueTime { get => ChoiceAttribute.AsExactly<TimeElement>(value); set { this.value = value; } }
			public UnsignedIntElement valueUnsignedInt { get => ChoiceAttribute.AsExactly<UnsignedIntElement>(value); set { this.value = value; } }
			public UriElement valueUri { get => ChoiceAttribute.AsExactly<UriElement>(value); set { this.value = value; } }
			public UrlElement valueUrl { get => ChoiceAttribute.AsExactly<UrlElement>(value); set { this.value = value; } }
			public UuidElement valueUuid { get => ChoiceAttribute.AsExactly<UuidElement>(value); set { this.value = value; } }
			public Address valueAddress { get => ChoiceAttribute.AsExactly<Address>(value); set { this.value = value; } }
			public Age valueAge { get => ChoiceAttribute.AsExactly<Age>(value); set { this.value = value; } }
			public Annotation valueAnnotation { get => ChoiceAttribute.AsExactly<Annotation>(value); set { this.value = value; } }
			public Attachment valueAttachment { get => ChoiceAttribute.AsExactly<Attachment>(value); set { this.value = value; } }
			public CodeableConcept valueCodeableConcept { get => ChoiceAttribute.AsExactly<CodeableConcept>(value); set { this.value = value; } }
			public Coding valueCoding { get => ChoiceAttribute.AsExactly<Coding>(value); set { this.value = value; } }
			public ContactPoint valueContactPoint { get => ChoiceAttribute.AsExactly<ContactPoint>(value); set { this.value = value; } }
			public Count valueCount { get => ChoiceAttribute.AsExactly<Count>(value); set { this.value = value; } }
			public Distance valueDistance { get => ChoiceAttribute.AsExactly<Distance>(value); set { this.value = value; } }
			public Duration valueDuration { get => ChoiceAttribute.AsExactly<Duration>(value); set { this.value = value; } }
			public HumanName valueHumanName { get => ChoiceAttribute.AsExactly<HumanName>(value); set { this.value = value; } }
			public Identifier valueIdentifier { get => ChoiceAttribute.AsExactly<Identifier>(value); set { this.value = value; } }
			public Money valueMoney { get => ChoiceAttribute.AsExactly<Money>(value); set { this.value = value; } }
			public Period valuePeriod { get => ChoiceAttribute.AsExactly<Period>(value); set { this.value = value; } }
			public Quantity valueQuantity { get => ChoiceAttribute.AsExactly<Quantity>(value); set { this.value = value; } }
			public Range valueRange { get => ChoiceAttribute.AsExactly<Range>(value); set { this.value = value; } }
			public Ratio valueRatio { get => ChoiceAttribute.AsExactly<Ratio>(value); set { this.value = value; } }
			public Reference valueReference { get => ChoiceAttribute.AsExactly<Reference>(value); set { this.value = value; } }
			public SampledData valueSampledData { get => ChoiceAttribute.AsExactly<SampledData>(value); set { this.value = value; } }
			public Signature valueSignature { get => ChoiceAttribute.AsExactly<Signature>(value); set { this.value = value; } }
			public Timing valueTiming { get => ChoiceAttribute.AsExactly<Timing>(value); set { this.value = value; } }
			public ContactDetail valueContactDetail { get => ChoiceAttribute.AsExactly<ContactDetail>(value); set { this.value = value; } }
			public Contributor valueContributor { get => ChoiceAttribute.AsExactly<Contributor>(value); set { this.value = value; } }
			public DataRequirement valueDataRequirement { get => ChoiceAttribute.AsExactly<DataRequirement>(value); set { this.value = value; } }
			public Expression valueExpression { get => ChoiceAttribute.AsExactly<Expression>(value); set { this.value = value; } }
			public ParameterDefinition valueParameterDefinition { get => ChoiceAttribute.AsExactly<ParameterDefinition>(value); set { this.value = value; } }
			public RelatedArtifact valueRelatedArtifact { get => ChoiceAttribute.AsExactly<RelatedArtifact>(value); set { this.value = value; } }
			public TriggerDefinition valueTriggerDefinition { get => ChoiceAttribute.AsExactly<TriggerDefinition>(value); set { this.value = value; } }
			public UsageContext valueUsageContext { get => ChoiceAttribute.AsExactly<UsageContext>(value); set { this.value = value; } }
			public Dosage valueDosage { get => ChoiceAttribute.AsExactly<Dosage>(value); set { this.value = value; } }
			public Meta valueMeta { get => ChoiceAttribute.AsExactly<Meta>(value); set { this.value = value; } }

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			public CodeableConcept type { get; set; }
		}
	}
}

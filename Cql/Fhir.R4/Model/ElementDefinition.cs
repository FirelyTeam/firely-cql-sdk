using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[FhirUri("http://hl7.org/fhir/StructureDefinition/ElementDefinition")]
	public partial class ElementDefinition : BackboneElement
	{

		[NotNull]
		public StringElement path { get; set; }

		[ValueSetBinding("PropertyRepresentation", "http://hl7.org/fhir/ValueSet/property-representation%7C4.0.1", true)]
		public ICollection<CodeElement> representation { get; set; }

		public StringElement sliceName { get; set; }

		public BooleanElement sliceIsConstraining { get; set; }

		public StringElement label { get; set; }

		[ValueSetBinding("ElementDefinitionCode", "http://hl7.org/fhir/ValueSet/observation-codes", false)]
		public ICollection<Coding> code { get; set; }

		public SlicingComponent slicing { get; set; }

		public StringElement @short { get; set; }

		public MarkdownElement definition { get; set; }

		public MarkdownElement comment { get; set; }

		public MarkdownElement requirements { get; set; }

		public ICollection<StringElement> alias { get; set; }

		public UnsignedIntElement min { get; set; }

		public StringElement max { get; set; }

		public BaseComponent @base { get; set; }

		public UriElement contentReference { get; set; }

		public ICollection<TypeComponent> type { get; set; }

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
		public Element defaultValue { get; set; }
		public Base64BinaryElement defaultValueBase64Binary { get => ChoiceAttribute.AsExactly<Base64BinaryElement>(defaultValue); set { defaultValue = value; } }
		public BooleanElement defaultValueBoolean { get => ChoiceAttribute.AsExactly<BooleanElement>(defaultValue); set { defaultValue = value; } }
		public CanonicalElement defaultValueCanonical { get => ChoiceAttribute.AsExactly<CanonicalElement>(defaultValue); set { defaultValue = value; } }
		public CodeElement defaultValueCode { get => ChoiceAttribute.AsExactly<CodeElement>(defaultValue); set { defaultValue = value; } }
		public DateElement defaultValueDate { get => ChoiceAttribute.AsExactly<DateElement>(defaultValue); set { defaultValue = value; } }
		public DateTimeElement defaultValueDateTime { get => ChoiceAttribute.AsExactly<DateTimeElement>(defaultValue); set { defaultValue = value; } }
		public DecimalElement defaultValueDecimal { get => ChoiceAttribute.AsExactly<DecimalElement>(defaultValue); set { defaultValue = value; } }
		public IdElement defaultValueId { get => ChoiceAttribute.AsExactly<IdElement>(defaultValue); set { defaultValue = value; } }
		public InstantElement defaultValueInstant { get => ChoiceAttribute.AsExactly<InstantElement>(defaultValue); set { defaultValue = value; } }
		public IntegerElement defaultValueInteger { get => ChoiceAttribute.AsExactly<IntegerElement>(defaultValue); set { defaultValue = value; } }
		public MarkdownElement defaultValueMarkdown { get => ChoiceAttribute.AsExactly<MarkdownElement>(defaultValue); set { defaultValue = value; } }
		public OidElement defaultValueOid { get => ChoiceAttribute.AsExactly<OidElement>(defaultValue); set { defaultValue = value; } }
		public PositiveIntElement defaultValuePositiveInt { get => ChoiceAttribute.AsExactly<PositiveIntElement>(defaultValue); set { defaultValue = value; } }
		public StringElement defaultValueString { get => ChoiceAttribute.AsExactly<StringElement>(defaultValue); set { defaultValue = value; } }
		public TimeElement defaultValueTime { get => ChoiceAttribute.AsExactly<TimeElement>(defaultValue); set { defaultValue = value; } }
		public UnsignedIntElement defaultValueUnsignedInt { get => ChoiceAttribute.AsExactly<UnsignedIntElement>(defaultValue); set { defaultValue = value; } }
		public UriElement defaultValueUri { get => ChoiceAttribute.AsExactly<UriElement>(defaultValue); set { defaultValue = value; } }
		public UrlElement defaultValueUrl { get => ChoiceAttribute.AsExactly<UrlElement>(defaultValue); set { defaultValue = value; } }
		public UuidElement defaultValueUuid { get => ChoiceAttribute.AsExactly<UuidElement>(defaultValue); set { defaultValue = value; } }
		public Address defaultValueAddress { get => ChoiceAttribute.AsExactly<Address>(defaultValue); set { defaultValue = value; } }
		public Age defaultValueAge { get => ChoiceAttribute.AsExactly<Age>(defaultValue); set { defaultValue = value; } }
		public Annotation defaultValueAnnotation { get => ChoiceAttribute.AsExactly<Annotation>(defaultValue); set { defaultValue = value; } }
		public Attachment defaultValueAttachment { get => ChoiceAttribute.AsExactly<Attachment>(defaultValue); set { defaultValue = value; } }
		public CodeableConcept defaultValueCodeableConcept { get => ChoiceAttribute.AsExactly<CodeableConcept>(defaultValue); set { defaultValue = value; } }
		public Coding defaultValueCoding { get => ChoiceAttribute.AsExactly<Coding>(defaultValue); set { defaultValue = value; } }
		public ContactPoint defaultValueContactPoint { get => ChoiceAttribute.AsExactly<ContactPoint>(defaultValue); set { defaultValue = value; } }
		public Count defaultValueCount { get => ChoiceAttribute.AsExactly<Count>(defaultValue); set { defaultValue = value; } }
		public Distance defaultValueDistance { get => ChoiceAttribute.AsExactly<Distance>(defaultValue); set { defaultValue = value; } }
		public Duration defaultValueDuration { get => ChoiceAttribute.AsExactly<Duration>(defaultValue); set { defaultValue = value; } }
		public HumanName defaultValueHumanName { get => ChoiceAttribute.AsExactly<HumanName>(defaultValue); set { defaultValue = value; } }
		public Identifier defaultValueIdentifier { get => ChoiceAttribute.AsExactly<Identifier>(defaultValue); set { defaultValue = value; } }
		public Money defaultValueMoney { get => ChoiceAttribute.AsExactly<Money>(defaultValue); set { defaultValue = value; } }
		public Period defaultValuePeriod { get => ChoiceAttribute.AsExactly<Period>(defaultValue); set { defaultValue = value; } }
		public Quantity defaultValueQuantity { get => ChoiceAttribute.AsExactly<Quantity>(defaultValue); set { defaultValue = value; } }
		public Range defaultValueRange { get => ChoiceAttribute.AsExactly<Range>(defaultValue); set { defaultValue = value; } }
		public Ratio defaultValueRatio { get => ChoiceAttribute.AsExactly<Ratio>(defaultValue); set { defaultValue = value; } }
		public Reference defaultValueReference { get => ChoiceAttribute.AsExactly<Reference>(defaultValue); set { defaultValue = value; } }
		public SampledData defaultValueSampledData { get => ChoiceAttribute.AsExactly<SampledData>(defaultValue); set { defaultValue = value; } }
		public Signature defaultValueSignature { get => ChoiceAttribute.AsExactly<Signature>(defaultValue); set { defaultValue = value; } }
		public Timing defaultValueTiming { get => ChoiceAttribute.AsExactly<Timing>(defaultValue); set { defaultValue = value; } }
		public ContactDetail defaultValueContactDetail { get => ChoiceAttribute.AsExactly<ContactDetail>(defaultValue); set { defaultValue = value; } }
		public Contributor defaultValueContributor { get => ChoiceAttribute.AsExactly<Contributor>(defaultValue); set { defaultValue = value; } }
		public DataRequirement defaultValueDataRequirement { get => ChoiceAttribute.AsExactly<DataRequirement>(defaultValue); set { defaultValue = value; } }
		public Expression defaultValueExpression { get => ChoiceAttribute.AsExactly<Expression>(defaultValue); set { defaultValue = value; } }
		public ParameterDefinition defaultValueParameterDefinition { get => ChoiceAttribute.AsExactly<ParameterDefinition>(defaultValue); set { defaultValue = value; } }
		public RelatedArtifact defaultValueRelatedArtifact { get => ChoiceAttribute.AsExactly<RelatedArtifact>(defaultValue); set { defaultValue = value; } }
		public TriggerDefinition defaultValueTriggerDefinition { get => ChoiceAttribute.AsExactly<TriggerDefinition>(defaultValue); set { defaultValue = value; } }
		public UsageContext defaultValueUsageContext { get => ChoiceAttribute.AsExactly<UsageContext>(defaultValue); set { defaultValue = value; } }
		public Dosage defaultValueDosage { get => ChoiceAttribute.AsExactly<Dosage>(defaultValue); set { defaultValue = value; } }
		public Meta defaultValueMeta { get => ChoiceAttribute.AsExactly<Meta>(defaultValue); set { defaultValue = value; } }

		public MarkdownElement meaningWhenMissing { get; set; }

		public StringElement orderMeaning { get; set; }

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
		public Element @fixed { get; set; }
		public Base64BinaryElement @fixedBase64Binary { get => ChoiceAttribute.AsExactly<Base64BinaryElement>(@fixed); set { @fixed = value; } }
		public BooleanElement @fixedBoolean { get => ChoiceAttribute.AsExactly<BooleanElement>(@fixed); set { @fixed = value; } }
		public CanonicalElement @fixedCanonical { get => ChoiceAttribute.AsExactly<CanonicalElement>(@fixed); set { @fixed = value; } }
		public CodeElement @fixedCode { get => ChoiceAttribute.AsExactly<CodeElement>(@fixed); set { @fixed = value; } }
		public DateElement @fixedDate { get => ChoiceAttribute.AsExactly<DateElement>(@fixed); set { @fixed = value; } }
		public DateTimeElement @fixedDateTime { get => ChoiceAttribute.AsExactly<DateTimeElement>(@fixed); set { @fixed = value; } }
		public DecimalElement @fixedDecimal { get => ChoiceAttribute.AsExactly<DecimalElement>(@fixed); set { @fixed = value; } }
		public IdElement @fixedId { get => ChoiceAttribute.AsExactly<IdElement>(@fixed); set { @fixed = value; } }
		public InstantElement @fixedInstant { get => ChoiceAttribute.AsExactly<InstantElement>(@fixed); set { @fixed = value; } }
		public IntegerElement @fixedInteger { get => ChoiceAttribute.AsExactly<IntegerElement>(@fixed); set { @fixed = value; } }
		public MarkdownElement @fixedMarkdown { get => ChoiceAttribute.AsExactly<MarkdownElement>(@fixed); set { @fixed = value; } }
		public OidElement @fixedOid { get => ChoiceAttribute.AsExactly<OidElement>(@fixed); set { @fixed = value; } }
		public PositiveIntElement @fixedPositiveInt { get => ChoiceAttribute.AsExactly<PositiveIntElement>(@fixed); set { @fixed = value; } }
		public StringElement @fixedString { get => ChoiceAttribute.AsExactly<StringElement>(@fixed); set { @fixed = value; } }
		public TimeElement @fixedTime { get => ChoiceAttribute.AsExactly<TimeElement>(@fixed); set { @fixed = value; } }
		public UnsignedIntElement @fixedUnsignedInt { get => ChoiceAttribute.AsExactly<UnsignedIntElement>(@fixed); set { @fixed = value; } }
		public UriElement @fixedUri { get => ChoiceAttribute.AsExactly<UriElement>(@fixed); set { @fixed = value; } }
		public UrlElement @fixedUrl { get => ChoiceAttribute.AsExactly<UrlElement>(@fixed); set { @fixed = value; } }
		public UuidElement @fixedUuid { get => ChoiceAttribute.AsExactly<UuidElement>(@fixed); set { @fixed = value; } }
		public Address @fixedAddress { get => ChoiceAttribute.AsExactly<Address>(@fixed); set { @fixed = value; } }
		public Age @fixedAge { get => ChoiceAttribute.AsExactly<Age>(@fixed); set { @fixed = value; } }
		public Annotation @fixedAnnotation { get => ChoiceAttribute.AsExactly<Annotation>(@fixed); set { @fixed = value; } }
		public Attachment @fixedAttachment { get => ChoiceAttribute.AsExactly<Attachment>(@fixed); set { @fixed = value; } }
		public CodeableConcept @fixedCodeableConcept { get => ChoiceAttribute.AsExactly<CodeableConcept>(@fixed); set { @fixed = value; } }
		public Coding @fixedCoding { get => ChoiceAttribute.AsExactly<Coding>(@fixed); set { @fixed = value; } }
		public ContactPoint @fixedContactPoint { get => ChoiceAttribute.AsExactly<ContactPoint>(@fixed); set { @fixed = value; } }
		public Count @fixedCount { get => ChoiceAttribute.AsExactly<Count>(@fixed); set { @fixed = value; } }
		public Distance @fixedDistance { get => ChoiceAttribute.AsExactly<Distance>(@fixed); set { @fixed = value; } }
		public Duration @fixedDuration { get => ChoiceAttribute.AsExactly<Duration>(@fixed); set { @fixed = value; } }
		public HumanName @fixedHumanName { get => ChoiceAttribute.AsExactly<HumanName>(@fixed); set { @fixed = value; } }
		public Identifier @fixedIdentifier { get => ChoiceAttribute.AsExactly<Identifier>(@fixed); set { @fixed = value; } }
		public Money @fixedMoney { get => ChoiceAttribute.AsExactly<Money>(@fixed); set { @fixed = value; } }
		public Period @fixedPeriod { get => ChoiceAttribute.AsExactly<Period>(@fixed); set { @fixed = value; } }
		public Quantity @fixedQuantity { get => ChoiceAttribute.AsExactly<Quantity>(@fixed); set { @fixed = value; } }
		public Range @fixedRange { get => ChoiceAttribute.AsExactly<Range>(@fixed); set { @fixed = value; } }
		public Ratio @fixedRatio { get => ChoiceAttribute.AsExactly<Ratio>(@fixed); set { @fixed = value; } }
		public Reference @fixedReference { get => ChoiceAttribute.AsExactly<Reference>(@fixed); set { @fixed = value; } }
		public SampledData @fixedSampledData { get => ChoiceAttribute.AsExactly<SampledData>(@fixed); set { @fixed = value; } }
		public Signature @fixedSignature { get => ChoiceAttribute.AsExactly<Signature>(@fixed); set { @fixed = value; } }
		public Timing @fixedTiming { get => ChoiceAttribute.AsExactly<Timing>(@fixed); set { @fixed = value; } }
		public ContactDetail @fixedContactDetail { get => ChoiceAttribute.AsExactly<ContactDetail>(@fixed); set { @fixed = value; } }
		public Contributor @fixedContributor { get => ChoiceAttribute.AsExactly<Contributor>(@fixed); set { @fixed = value; } }
		public DataRequirement @fixedDataRequirement { get => ChoiceAttribute.AsExactly<DataRequirement>(@fixed); set { @fixed = value; } }
		public Expression @fixedExpression { get => ChoiceAttribute.AsExactly<Expression>(@fixed); set { @fixed = value; } }
		public ParameterDefinition @fixedParameterDefinition { get => ChoiceAttribute.AsExactly<ParameterDefinition>(@fixed); set { @fixed = value; } }
		public RelatedArtifact @fixedRelatedArtifact { get => ChoiceAttribute.AsExactly<RelatedArtifact>(@fixed); set { @fixed = value; } }
		public TriggerDefinition @fixedTriggerDefinition { get => ChoiceAttribute.AsExactly<TriggerDefinition>(@fixed); set { @fixed = value; } }
		public UsageContext @fixedUsageContext { get => ChoiceAttribute.AsExactly<UsageContext>(@fixed); set { @fixed = value; } }
		public Dosage @fixedDosage { get => ChoiceAttribute.AsExactly<Dosage>(@fixed); set { @fixed = value; } }
		public Meta @fixedMeta { get => ChoiceAttribute.AsExactly<Meta>(@fixed); set { @fixed = value; } }

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
		public Element pattern { get; set; }
		public Base64BinaryElement patternBase64Binary { get => ChoiceAttribute.AsExactly<Base64BinaryElement>(pattern); set { pattern = value; } }
		public BooleanElement patternBoolean { get => ChoiceAttribute.AsExactly<BooleanElement>(pattern); set { pattern = value; } }
		public CanonicalElement patternCanonical { get => ChoiceAttribute.AsExactly<CanonicalElement>(pattern); set { pattern = value; } }
		public CodeElement patternCode { get => ChoiceAttribute.AsExactly<CodeElement>(pattern); set { pattern = value; } }
		public DateElement patternDate { get => ChoiceAttribute.AsExactly<DateElement>(pattern); set { pattern = value; } }
		public DateTimeElement patternDateTime { get => ChoiceAttribute.AsExactly<DateTimeElement>(pattern); set { pattern = value; } }
		public DecimalElement patternDecimal { get => ChoiceAttribute.AsExactly<DecimalElement>(pattern); set { pattern = value; } }
		public IdElement patternId { get => ChoiceAttribute.AsExactly<IdElement>(pattern); set { pattern = value; } }
		public InstantElement patternInstant { get => ChoiceAttribute.AsExactly<InstantElement>(pattern); set { pattern = value; } }
		public IntegerElement patternInteger { get => ChoiceAttribute.AsExactly<IntegerElement>(pattern); set { pattern = value; } }
		public MarkdownElement patternMarkdown { get => ChoiceAttribute.AsExactly<MarkdownElement>(pattern); set { pattern = value; } }
		public OidElement patternOid { get => ChoiceAttribute.AsExactly<OidElement>(pattern); set { pattern = value; } }
		public PositiveIntElement patternPositiveInt { get => ChoiceAttribute.AsExactly<PositiveIntElement>(pattern); set { pattern = value; } }
		public StringElement patternString { get => ChoiceAttribute.AsExactly<StringElement>(pattern); set { pattern = value; } }
		public TimeElement patternTime { get => ChoiceAttribute.AsExactly<TimeElement>(pattern); set { pattern = value; } }
		public UnsignedIntElement patternUnsignedInt { get => ChoiceAttribute.AsExactly<UnsignedIntElement>(pattern); set { pattern = value; } }
		public UriElement patternUri { get => ChoiceAttribute.AsExactly<UriElement>(pattern); set { pattern = value; } }
		public UrlElement patternUrl { get => ChoiceAttribute.AsExactly<UrlElement>(pattern); set { pattern = value; } }
		public UuidElement patternUuid { get => ChoiceAttribute.AsExactly<UuidElement>(pattern); set { pattern = value; } }
		public Address patternAddress { get => ChoiceAttribute.AsExactly<Address>(pattern); set { pattern = value; } }
		public Age patternAge { get => ChoiceAttribute.AsExactly<Age>(pattern); set { pattern = value; } }
		public Annotation patternAnnotation { get => ChoiceAttribute.AsExactly<Annotation>(pattern); set { pattern = value; } }
		public Attachment patternAttachment { get => ChoiceAttribute.AsExactly<Attachment>(pattern); set { pattern = value; } }
		public CodeableConcept patternCodeableConcept { get => ChoiceAttribute.AsExactly<CodeableConcept>(pattern); set { pattern = value; } }
		public Coding patternCoding { get => ChoiceAttribute.AsExactly<Coding>(pattern); set { pattern = value; } }
		public ContactPoint patternContactPoint { get => ChoiceAttribute.AsExactly<ContactPoint>(pattern); set { pattern = value; } }
		public Count patternCount { get => ChoiceAttribute.AsExactly<Count>(pattern); set { pattern = value; } }
		public Distance patternDistance { get => ChoiceAttribute.AsExactly<Distance>(pattern); set { pattern = value; } }
		public Duration patternDuration { get => ChoiceAttribute.AsExactly<Duration>(pattern); set { pattern = value; } }
		public HumanName patternHumanName { get => ChoiceAttribute.AsExactly<HumanName>(pattern); set { pattern = value; } }
		public Identifier patternIdentifier { get => ChoiceAttribute.AsExactly<Identifier>(pattern); set { pattern = value; } }
		public Money patternMoney { get => ChoiceAttribute.AsExactly<Money>(pattern); set { pattern = value; } }
		public Period patternPeriod { get => ChoiceAttribute.AsExactly<Period>(pattern); set { pattern = value; } }
		public Quantity patternQuantity { get => ChoiceAttribute.AsExactly<Quantity>(pattern); set { pattern = value; } }
		public Range patternRange { get => ChoiceAttribute.AsExactly<Range>(pattern); set { pattern = value; } }
		public Ratio patternRatio { get => ChoiceAttribute.AsExactly<Ratio>(pattern); set { pattern = value; } }
		public Reference patternReference { get => ChoiceAttribute.AsExactly<Reference>(pattern); set { pattern = value; } }
		public SampledData patternSampledData { get => ChoiceAttribute.AsExactly<SampledData>(pattern); set { pattern = value; } }
		public Signature patternSignature { get => ChoiceAttribute.AsExactly<Signature>(pattern); set { pattern = value; } }
		public Timing patternTiming { get => ChoiceAttribute.AsExactly<Timing>(pattern); set { pattern = value; } }
		public ContactDetail patternContactDetail { get => ChoiceAttribute.AsExactly<ContactDetail>(pattern); set { pattern = value; } }
		public Contributor patternContributor { get => ChoiceAttribute.AsExactly<Contributor>(pattern); set { pattern = value; } }
		public DataRequirement patternDataRequirement { get => ChoiceAttribute.AsExactly<DataRequirement>(pattern); set { pattern = value; } }
		public Expression patternExpression { get => ChoiceAttribute.AsExactly<Expression>(pattern); set { pattern = value; } }
		public ParameterDefinition patternParameterDefinition { get => ChoiceAttribute.AsExactly<ParameterDefinition>(pattern); set { pattern = value; } }
		public RelatedArtifact patternRelatedArtifact { get => ChoiceAttribute.AsExactly<RelatedArtifact>(pattern); set { pattern = value; } }
		public TriggerDefinition patternTriggerDefinition { get => ChoiceAttribute.AsExactly<TriggerDefinition>(pattern); set { pattern = value; } }
		public UsageContext patternUsageContext { get => ChoiceAttribute.AsExactly<UsageContext>(pattern); set { pattern = value; } }
		public Dosage patternDosage { get => ChoiceAttribute.AsExactly<Dosage>(pattern); set { pattern = value; } }
		public Meta patternMeta { get => ChoiceAttribute.AsExactly<Meta>(pattern); set { pattern = value; } }

		public ICollection<ExampleComponent> example { get; set; }

		[Choice(typeof(DateElement))]
		[Choice(typeof(DateTimeElement))]
		[Choice(typeof(InstantElement))]
		[Choice(typeof(TimeElement))]
		[Choice(typeof(DecimalElement))]
		[Choice(typeof(IntegerElement))]
		[Choice(typeof(PositiveIntElement))]
		[Choice(typeof(UnsignedIntElement))]
		[Choice(typeof(Quantity))]
		[JsonIgnore]
		public Element minValue { get; set; }
		public DateElement minValueDate { get => ChoiceAttribute.AsExactly<DateElement>(minValue); set { minValue = value; } }
		public DateTimeElement minValueDateTime { get => ChoiceAttribute.AsExactly<DateTimeElement>(minValue); set { minValue = value; } }
		public InstantElement minValueInstant { get => ChoiceAttribute.AsExactly<InstantElement>(minValue); set { minValue = value; } }
		public TimeElement minValueTime { get => ChoiceAttribute.AsExactly<TimeElement>(minValue); set { minValue = value; } }
		public DecimalElement minValueDecimal { get => ChoiceAttribute.AsExactly<DecimalElement>(minValue); set { minValue = value; } }
		public IntegerElement minValueInteger { get => ChoiceAttribute.AsExactly<IntegerElement>(minValue); set { minValue = value; } }
		public PositiveIntElement minValuePositiveInt { get => ChoiceAttribute.AsExactly<PositiveIntElement>(minValue); set { minValue = value; } }
		public UnsignedIntElement minValueUnsignedInt { get => ChoiceAttribute.AsExactly<UnsignedIntElement>(minValue); set { minValue = value; } }
		public Quantity minValueQuantity { get => ChoiceAttribute.AsExactly<Quantity>(minValue); set { minValue = value; } }

		[Choice(typeof(DateElement))]
		[Choice(typeof(DateTimeElement))]
		[Choice(typeof(InstantElement))]
		[Choice(typeof(TimeElement))]
		[Choice(typeof(DecimalElement))]
		[Choice(typeof(IntegerElement))]
		[Choice(typeof(PositiveIntElement))]
		[Choice(typeof(UnsignedIntElement))]
		[Choice(typeof(Quantity))]
		[JsonIgnore]
		public Element maxValue { get; set; }
		public DateElement maxValueDate { get => ChoiceAttribute.AsExactly<DateElement>(maxValue); set { maxValue = value; } }
		public DateTimeElement maxValueDateTime { get => ChoiceAttribute.AsExactly<DateTimeElement>(maxValue); set { maxValue = value; } }
		public InstantElement maxValueInstant { get => ChoiceAttribute.AsExactly<InstantElement>(maxValue); set { maxValue = value; } }
		public TimeElement maxValueTime { get => ChoiceAttribute.AsExactly<TimeElement>(maxValue); set { maxValue = value; } }
		public DecimalElement maxValueDecimal { get => ChoiceAttribute.AsExactly<DecimalElement>(maxValue); set { maxValue = value; } }
		public IntegerElement maxValueInteger { get => ChoiceAttribute.AsExactly<IntegerElement>(maxValue); set { maxValue = value; } }
		public PositiveIntElement maxValuePositiveInt { get => ChoiceAttribute.AsExactly<PositiveIntElement>(maxValue); set { maxValue = value; } }
		public UnsignedIntElement maxValueUnsignedInt { get => ChoiceAttribute.AsExactly<UnsignedIntElement>(maxValue); set { maxValue = value; } }
		public Quantity maxValueQuantity { get => ChoiceAttribute.AsExactly<Quantity>(maxValue); set { maxValue = value; } }

		public IntegerElement maxLength { get; set; }

		public ICollection<IdElement> condition { get; set; }

		public ICollection<ConstraintComponent> constraint { get; set; }

		public BooleanElement mustSupport { get; set; }

		public BooleanElement isModifier { get; set; }

		public StringElement isModifierReason { get; set; }

		public BooleanElement isSummary { get; set; }

		public BindingComponent binding { get; set; }

		public ICollection<MappingComponent> mapping { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/ElementDefinition.slicing")]
		public partial class SlicingComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<DiscriminatorComponent> discriminator { get; set; }

			public StringElement description { get; set; }

			public BooleanElement ordered { get; set; }

			[NotNull]
			[ValueSetBinding("SlicingRules", "http://hl7.org/fhir/ValueSet/resource-slicing-rules%7C4.0.1", true)]
			public CodeElement rules { get; set; }
			[FhirUri("http://hl7.org/fhir/StructureDefinition/ElementDefinition.slicing.discriminator")]
			public partial class DiscriminatorComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				[NotNull]
				[ValueSetBinding("DiscriminatorType", "http://hl7.org/fhir/ValueSet/discriminator-type%7C4.0.1", true)]
				public CodeElement type { get; set; }

				[NotNull]
				public StringElement path { get; set; }
			}
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/ElementDefinition.base")]
		public partial class BaseComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			[NotNull]
			public StringElement path { get; set; }

			[NotNull]
			public UnsignedIntElement min { get; set; }

			[NotNull]
			public StringElement max { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/ElementDefinition.type")]
		public partial class TypeComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			[NotNull]
			[ValueSetBinding("FHIRDefinedTypeExt", "http://hl7.org/fhir/ValueSet/defined-types", false)]
			public UriElement code { get; set; }

			public ICollection<CanonicalElement> profile { get; set; }

			public ICollection<CanonicalElement> targetProfile { get; set; }

			[ValueSetBinding("AggregationMode", "http://hl7.org/fhir/ValueSet/resource-aggregation-mode%7C4.0.1", true)]
			public ICollection<CodeElement> aggregation { get; set; }

			[ValueSetBinding("ReferenceVersionRules", "http://hl7.org/fhir/ValueSet/reference-version-rules%7C4.0.1", true)]
			public CodeElement versioning { get; set; }
		}
		[DebuggerDisplay("{value}")]
		[FhirUri("http://hl7.org/fhir/StructureDefinition/ElementDefinition.example")]
		public partial class ExampleComponent
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

			[NotNull]
			public StringElement label { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/ElementDefinition.constraint")]
		public partial class ConstraintComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			[NotNull]
			public IdElement key { get; set; }

			public StringElement requirements { get; set; }

			[NotNull]
			[ValueSetBinding("ConstraintSeverity", "http://hl7.org/fhir/ValueSet/constraint-severity%7C4.0.1", true)]
			public CodeElement severity { get; set; }

			[NotNull]
			public StringElement human { get; set; }

			public StringElement expression { get; set; }

			public StringElement xpath { get; set; }

			public CanonicalElement source { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/ElementDefinition.binding")]
		public partial class BindingComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			[NotNull]
			[ValueSetBinding("BindingStrength", "http://hl7.org/fhir/ValueSet/binding-strength%7C4.0.1", true)]
			public CodeElement strength { get; set; }

			public StringElement description { get; set; }

			public CanonicalElement valueSet { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/ElementDefinition.mapping")]
		public partial class MappingComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			[NotNull]
			public IdElement identity { get; set; }

			[ValueSetBinding("MimeType", "http://hl7.org/fhir/ValueSet/mimetypes%7C4.0.1", true)]
			public CodeElement language { get; set; }

			[NotNull]
			public StringElement map { get; set; }

			public StringElement comment { get; set; }
		}
	}
}

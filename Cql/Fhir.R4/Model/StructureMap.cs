using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[FhirUri("http://hl7.org/fhir/StructureDefinition/StructureMap")]
	public partial class StructureMap : DomainResource
	{

		[NotNull]
		public UriElement url { get; set; }

		public ICollection<Identifier> identifier { get; set; }

		public StringElement version { get; set; }

		[NotNull]
		public StringElement name { get; set; }

		public StringElement title { get; set; }

		[NotNull]
		[ValueSetBinding("PublicationStatus", "http://hl7.org/fhir/ValueSet/publication-status%7C4.0.1", true)]
		public CodeElement status { get; set; }

		public BooleanElement experimental { get; set; }

		public DateTimeElement date { get; set; }

		public StringElement publisher { get; set; }

		public ICollection<ContactDetail> contact { get; set; }

		public MarkdownElement description { get; set; }

		public ICollection<UsageContext> useContext { get; set; }

		[ValueSetBinding("Jurisdiction", "http://hl7.org/fhir/ValueSet/jurisdiction", false)]
		public ICollection<CodeableConcept> jurisdiction { get; set; }

		public MarkdownElement purpose { get; set; }

		public MarkdownElement copyright { get; set; }

		public ICollection<StructureComponent> structure { get; set; }

		public ICollection<CanonicalElement> import { get; set; }

		public ICollection<GroupComponent> group { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/StructureMap.structure")]
		public partial class StructureComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			public CanonicalElement url { get; set; }

			[NotNull]
			[ValueSetBinding("StructureMapModelMode", "http://hl7.org/fhir/ValueSet/map-model-mode%7C4.0.1", true)]
			public CodeElement mode { get; set; }

			public StringElement alias { get; set; }

			public StringElement documentation { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/StructureMap.group")]
		public partial class GroupComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			public IdElement name { get; set; }

			public IdElement extends { get; set; }

			[NotNull]
			[ValueSetBinding("StructureMapGroupTypeMode", "http://hl7.org/fhir/ValueSet/map-group-type-mode%7C4.0.1", true)]
			public CodeElement typeMode { get; set; }

			public StringElement documentation { get; set; }

			public ICollection<InputComponent> input { get; set; }

			public ICollection<RuleComponent> rule { get; set; }
			[FhirUri("http://hl7.org/fhir/StructureDefinition/StructureMap.group.input")]
			public partial class InputComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				[NotNull]
				public IdElement name { get; set; }

				public StringElement type { get; set; }

				[NotNull]
				[ValueSetBinding("StructureMapInputMode", "http://hl7.org/fhir/ValueSet/map-input-mode%7C4.0.1", true)]
				public CodeElement mode { get; set; }

				public StringElement documentation { get; set; }
			}
			[FhirUri("http://hl7.org/fhir/StructureDefinition/StructureMap.group.rule")]
			public partial class RuleComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				[NotNull]
				public IdElement name { get; set; }

				public ICollection<SourceComponent> source { get; set; }

				public ICollection<TargetComponent> target { get; set; }

				public ICollection<DependentComponent> dependent { get; set; }

				public StringElement documentation { get; set; }
				[FhirUri("http://hl7.org/fhir/StructureDefinition/StructureMap.group.rule.source")]
				public partial class SourceComponent
				{

					public string id { get; set; }

					public ICollection<Extension> extension { get; set; }

					public ICollection<Extension> modifierExtension { get; set; }

					[NotNull]
					public IdElement context { get; set; }

					public IntegerElement min { get; set; }

					public StringElement max { get; set; }

					public StringElement type { get; set; }

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

					public StringElement element { get; set; }

					[ValueSetBinding("StructureMapSourceListMode", "http://hl7.org/fhir/ValueSet/map-source-list-mode%7C4.0.1", true)]
					public CodeElement listMode { get; set; }

					public IdElement variable { get; set; }

					public StringElement condition { get; set; }

					public StringElement check { get; set; }

					public StringElement logMessage { get; set; }
				}
				[FhirUri("http://hl7.org/fhir/StructureDefinition/StructureMap.group.rule.target")]
				public partial class TargetComponent
				{

					public string id { get; set; }

					public ICollection<Extension> extension { get; set; }

					public ICollection<Extension> modifierExtension { get; set; }

					public IdElement context { get; set; }

					[ValueSetBinding("StructureMapContextType", "http://hl7.org/fhir/ValueSet/map-context-type%7C4.0.1", true)]
					public CodeElement contextType { get; set; }

					public StringElement element { get; set; }

					public IdElement variable { get; set; }

					[ValueSetBinding("StructureMapTargetListMode", "http://hl7.org/fhir/ValueSet/map-target-list-mode%7C4.0.1", true)]
					public ICollection<CodeElement> listMode { get; set; }

					public IdElement listRuleId { get; set; }

					[ValueSetBinding("StructureMapTransform", "http://hl7.org/fhir/ValueSet/map-transform%7C4.0.1", true)]
					public CodeElement transform { get; set; }

					public ICollection<ParameterComponent> parameter { get; set; }
					[DebuggerDisplay("{value}")]
					[FhirUri("http://hl7.org/fhir/StructureDefinition/StructureMap.group.rule.target.parameter")]
					public partial class ParameterComponent
					{

						[NotNull]
						[Choice(typeof(IdElement))]
						[Choice(typeof(StringElement))]
						[Choice(typeof(BooleanElement))]
						[Choice(typeof(IntegerElement))]
						[Choice(typeof(DecimalElement))]
						[JsonIgnore]
						public Element value { get; set; }
						public IdElement valueId { get => ChoiceAttribute.AsExactly<IdElement>(value); set { this.value = value; } }
						public StringElement valueString { get => ChoiceAttribute.AsExactly<StringElement>(value); set { this.value = value; } }
						public BooleanElement valueBoolean { get => ChoiceAttribute.AsExactly<BooleanElement>(value); set { this.value = value; } }
						public IntegerElement valueInteger { get => ChoiceAttribute.AsExactly<IntegerElement>(value); set { this.value = value; } }
						public DecimalElement valueDecimal { get => ChoiceAttribute.AsExactly<DecimalElement>(value); set { this.value = value; } }

						public string id { get; set; }

						public ICollection<Extension> extension { get; set; }

						public ICollection<Extension> modifierExtension { get; set; }
					}
				}
				[FhirUri("http://hl7.org/fhir/StructureDefinition/StructureMap.group.rule.dependent")]
				public partial class DependentComponent
				{

					public string id { get; set; }

					public ICollection<Extension> extension { get; set; }

					public ICollection<Extension> modifierExtension { get; set; }

					[NotNull]
					public IdElement name { get; set; }

					public ICollection<StringElement> variable { get; set; }
				}
			}
		}
	}
}

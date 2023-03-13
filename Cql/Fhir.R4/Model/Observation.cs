using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[DebuggerDisplay("{value}")]
	[FhirUri("http://hl7.org/fhir/StructureDefinition/Observation")]
	public partial class Observation : DomainResource
	{

		[Choice(typeof(Quantity))]
		[Choice(typeof(CodeableConcept))]
		[Choice(typeof(StringElement))]
		[Choice(typeof(BooleanElement))]
		[Choice(typeof(IntegerElement))]
		[Choice(typeof(Range))]
		[Choice(typeof(Ratio))]
		[Choice(typeof(SampledData))]
		[Choice(typeof(TimeElement))]
		[Choice(typeof(DateTimeElement))]
		[Choice(typeof(Period))]
		[JsonIgnore]
		public Element value { get; set; }
		public Quantity valueQuantity { get => ChoiceAttribute.AsExactly<Quantity>(value); set { this.value = value; } }
		public CodeableConcept valueCodeableConcept { get => ChoiceAttribute.AsExactly<CodeableConcept>(value); set { this.value = value; } }
		public StringElement valueString { get => ChoiceAttribute.AsExactly<StringElement>(value); set { this.value = value; } }
		public BooleanElement valueBoolean { get => ChoiceAttribute.AsExactly<BooleanElement>(value); set { this.value = value; } }
		public IntegerElement valueInteger { get => ChoiceAttribute.AsExactly<IntegerElement>(value); set { this.value = value; } }
		public Range valueRange { get => ChoiceAttribute.AsExactly<Range>(value); set { this.value = value; } }
		public Ratio valueRatio { get => ChoiceAttribute.AsExactly<Ratio>(value); set { this.value = value; } }
		public SampledData valueSampledData { get => ChoiceAttribute.AsExactly<SampledData>(value); set { this.value = value; } }
		public TimeElement valueTime { get => ChoiceAttribute.AsExactly<TimeElement>(value); set { this.value = value; } }
		public DateTimeElement valueDateTime { get => ChoiceAttribute.AsExactly<DateTimeElement>(value); set { this.value = value; } }
		public Period valuePeriod { get => ChoiceAttribute.AsExactly<Period>(value); set { this.value = value; } }

		public ICollection<Identifier> identifier { get; set; }

		public ICollection<Reference> basedOn { get; set; }

		public ICollection<Reference> partOf { get; set; }

		[NotNull]
		[ValueSetBinding("ObservationStatus", "http://hl7.org/fhir/ValueSet/observation-status%7C4.0.1", true)]
		public CodeElement status { get; set; }

		[ValueSetBinding("ObservationCategory", "http://hl7.org/fhir/ValueSet/observation-category", false)]
		public ICollection<CodeableConcept> category { get; set; }

		[NotNull]
		[ValueSetBinding("ObservationCode", "http://hl7.org/fhir/ValueSet/observation-codes", false)]
		public CodeableConcept code { get; set; }

		public Reference subject { get; set; }

		public ICollection<Reference> focus { get; set; }

		public Reference encounter { get; set; }

		[Choice(typeof(DateTimeElement))]
		[Choice(typeof(Period))]
		[Choice(typeof(Timing))]
		[Choice(typeof(InstantElement))]
		[JsonIgnore]
		public Element effective { get; set; }
		public DateTimeElement effectiveDateTime { get => ChoiceAttribute.AsExactly<DateTimeElement>(effective); set { effective = value; } }
		public Period effectivePeriod { get => ChoiceAttribute.AsExactly<Period>(effective); set { effective = value; } }
		public Timing effectiveTiming { get => ChoiceAttribute.AsExactly<Timing>(effective); set { effective = value; } }
		public InstantElement effectiveInstant { get => ChoiceAttribute.AsExactly<InstantElement>(effective); set { effective = value; } }

		public InstantElement issued { get; set; }

		public ICollection<Reference> performer { get; set; }

		[ValueSetBinding("ObservationValueAbsentReason", "http://hl7.org/fhir/ValueSet/data-absent-reason", false)]
		public CodeableConcept dataAbsentReason { get; set; }

		[ValueSetBinding("ObservationInterpretation", "http://hl7.org/fhir/ValueSet/observation-interpretation", false)]
		public ICollection<CodeableConcept> interpretation { get; set; }

		public ICollection<Annotation> note { get; set; }

		[ValueSetBinding("BodySite", "http://hl7.org/fhir/ValueSet/body-site", false)]
		public CodeableConcept bodySite { get; set; }

		[ValueSetBinding("ObservationMethod", "http://hl7.org/fhir/ValueSet/observation-methods", false)]
		public CodeableConcept method { get; set; }

		public Reference specimen { get; set; }

		public Reference device { get; set; }

		public ICollection<ReferenceRangeComponent> referenceRange { get; set; }

		public ICollection<Reference> hasMember { get; set; }

		public ICollection<Reference> derivedFrom { get; set; }

		public ICollection<ComponentComponent> component { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/Observation.referenceRange")]
		public partial class ReferenceRangeComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public Quantity low { get; set; }

			public Quantity high { get; set; }

			[ValueSetBinding("ObservationRangeMeaning", "http://hl7.org/fhir/ValueSet/referencerange-meaning", false)]
			public CodeableConcept type { get; set; }

			[ValueSetBinding("ObservationRangeType", "http://hl7.org/fhir/ValueSet/referencerange-appliesto", false)]
			public ICollection<CodeableConcept> appliesTo { get; set; }

			public Range age { get; set; }

			public StringElement text { get; set; }
		}
		[DebuggerDisplay("{value}")]
		[FhirUri("http://hl7.org/fhir/StructureDefinition/Observation.component")]
		public partial class ComponentComponent
		{

			[Choice(typeof(Quantity))]
			[Choice(typeof(CodeableConcept))]
			[Choice(typeof(StringElement))]
			[Choice(typeof(BooleanElement))]
			[Choice(typeof(IntegerElement))]
			[Choice(typeof(Range))]
			[Choice(typeof(Ratio))]
			[Choice(typeof(SampledData))]
			[Choice(typeof(TimeElement))]
			[Choice(typeof(DateTimeElement))]
			[Choice(typeof(Period))]
			[JsonIgnore]
			public Element value { get; set; }
			public Quantity valueQuantity { get => ChoiceAttribute.AsExactly<Quantity>(value); set { this.value = value; } }
			public CodeableConcept valueCodeableConcept { get => ChoiceAttribute.AsExactly<CodeableConcept>(value); set { this.value = value; } }
			public StringElement valueString { get => ChoiceAttribute.AsExactly<StringElement>(value); set { this.value = value; } }
			public BooleanElement valueBoolean { get => ChoiceAttribute.AsExactly<BooleanElement>(value); set { this.value = value; } }
			public IntegerElement valueInteger { get => ChoiceAttribute.AsExactly<IntegerElement>(value); set { this.value = value; } }
			public Range valueRange { get => ChoiceAttribute.AsExactly<Range>(value); set { this.value = value; } }
			public Ratio valueRatio { get => ChoiceAttribute.AsExactly<Ratio>(value); set { this.value = value; } }
			public SampledData valueSampledData { get => ChoiceAttribute.AsExactly<SampledData>(value); set { this.value = value; } }
			public TimeElement valueTime { get => ChoiceAttribute.AsExactly<TimeElement>(value); set { this.value = value; } }
			public DateTimeElement valueDateTime { get => ChoiceAttribute.AsExactly<DateTimeElement>(value); set { this.value = value; } }
			public Period valuePeriod { get => ChoiceAttribute.AsExactly<Period>(value); set { this.value = value; } }

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			[ValueSetBinding("ObservationCode", "http://hl7.org/fhir/ValueSet/observation-codes", false)]
			public CodeableConcept code { get; set; }

			[ValueSetBinding("ObservationValueAbsentReason", "http://hl7.org/fhir/ValueSet/data-absent-reason", false)]
			public CodeableConcept dataAbsentReason { get; set; }

			[ValueSetBinding("ObservationInterpretation", "http://hl7.org/fhir/ValueSet/observation-interpretation", false)]
			public ICollection<CodeableConcept> interpretation { get; set; }
		}
	}
}

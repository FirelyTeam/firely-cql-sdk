using Hl7.Cql.Poco.Fhir;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Hl7.Cql.Poco.Fhir.R4.Model
{
    [FhirUri("http://hl7.org/fhir/StructureDefinition/RequestGroup")]
	public partial class RequestGroup : DomainResource
	{

		public ICollection<Identifier> identifier { get; set; }

		public ICollection<CanonicalElement> instantiatesCanonical { get; set; }

		public ICollection<UriElement> instantiatesUri { get; set; }

		public ICollection<Reference> basedOn { get; set; }

		public ICollection<Reference> replaces { get; set; }

		public Identifier groupIdentifier { get; set; }

		[NotNull]
		[ValueSetBinding("RequestStatus", "http://hl7.org/fhir/ValueSet/request-status%7C4.0.1", true)]
		public CodeElement status { get; set; }

		[NotNull]
		[ValueSetBinding("RequestIntent", "http://hl7.org/fhir/ValueSet/request-intent%7C4.0.1", true)]
		public CodeElement intent { get; set; }

		[ValueSetBinding("RequestPriority", "http://hl7.org/fhir/ValueSet/request-priority%7C4.0.1", true)]
		public CodeElement priority { get; set; }

		public CodeableConcept code { get; set; }

		public Reference subject { get; set; }

		public Reference encounter { get; set; }

		public DateTimeElement authoredOn { get; set; }

		public Reference author { get; set; }

		public ICollection<CodeableConcept> reasonCode { get; set; }

		public ICollection<Reference> reasonReference { get; set; }

		public ICollection<Annotation> note { get; set; }

		public ICollection<ActionComponent> action { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/RequestGroup.action")]
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

			public ICollection<RelatedArtifact> documentation { get; set; }

			public ICollection<ConditionComponent> condition { get; set; }

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

			public ICollection<Reference> participant { get; set; }

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

			public Reference resource { get; set; }
			[FhirUri("http://hl7.org/fhir/StructureDefinition/RequestGroup.action.condition")]
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
			[FhirUri("http://hl7.org/fhir/StructureDefinition/RequestGroup.action.relatedAction")]
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
		}
	}
}

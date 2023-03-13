using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[FhirUri("http://hl7.org/fhir/StructureDefinition/CarePlan")]
	public partial class CarePlan : DomainResource
	{

		public ICollection<Identifier> identifier { get; set; }

		public ICollection<CanonicalElement> instantiatesCanonical { get; set; }

		public ICollection<UriElement> instantiatesUri { get; set; }

		public ICollection<Reference> basedOn { get; set; }

		public ICollection<Reference> replaces { get; set; }

		public ICollection<Reference> partOf { get; set; }

		[NotNull]
		[ValueSetBinding("CarePlanStatus", "http://hl7.org/fhir/ValueSet/request-status%7C4.0.1", true)]
		public CodeElement status { get; set; }

		[NotNull]
		[ValueSetBinding("CarePlanIntent", "http://hl7.org/fhir/ValueSet/care-plan-intent%7C4.0.1", true)]
		public CodeElement intent { get; set; }

		[ValueSetBinding("CarePlanCategory", "http://hl7.org/fhir/ValueSet/care-plan-category", false)]
		public ICollection<CodeableConcept> category { get; set; }

		public StringElement title { get; set; }

		public StringElement description { get; set; }

		[NotNull]
		public Reference subject { get; set; }

		public Reference encounter { get; set; }

		public Period period { get; set; }

		public DateTimeElement created { get; set; }

		public Reference author { get; set; }

		public ICollection<Reference> contributor { get; set; }

		public ICollection<Reference> careTeam { get; set; }

		public ICollection<Reference> addresses { get; set; }

		public ICollection<Reference> supportingInfo { get; set; }

		public ICollection<Reference> goal { get; set; }

		public ICollection<ActivityComponent> activity { get; set; }

		public ICollection<Annotation> note { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/CarePlan.activity")]
		public partial class ActivityComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[ValueSetBinding("CarePlanActivityOutcome", "http://hl7.org/fhir/ValueSet/care-plan-activity-outcome", false)]
			public ICollection<CodeableConcept> outcomeCodeableConcept { get; set; }

			public ICollection<Reference> outcomeReference { get; set; }

			public ICollection<Annotation> progress { get; set; }

			public Reference reference { get; set; }

			public DetailComponent detail { get; set; }
			[FhirUri("http://hl7.org/fhir/StructureDefinition/CarePlan.activity.detail")]
			public partial class DetailComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				[ValueSetBinding("CarePlanActivityKind", "http://hl7.org/fhir/ValueSet/care-plan-activity-kind%7C4.0.1", true)]
				public CodeElement kind { get; set; }

				public ICollection<CanonicalElement> instantiatesCanonical { get; set; }

				public ICollection<UriElement> instantiatesUri { get; set; }

				[ValueSetBinding("CarePlanActivityType", "http://hl7.org/fhir/ValueSet/procedure-code", false)]
				public CodeableConcept code { get; set; }

				[ValueSetBinding("CarePlanActivityReason", "http://hl7.org/fhir/ValueSet/clinical-findings", false)]
				public ICollection<CodeableConcept> reasonCode { get; set; }

				public ICollection<Reference> reasonReference { get; set; }

				public ICollection<Reference> goal { get; set; }

				[NotNull]
				[ValueSetBinding("CarePlanActivityStatus", "http://hl7.org/fhir/ValueSet/care-plan-activity-status%7C4.0.1", true)]
				public CodeElement status { get; set; }

				public CodeableConcept statusReason { get; set; }

				public BooleanElement doNotPerform { get; set; }

				[Choice(typeof(Timing))]
				[Choice(typeof(Period))]
				[Choice(typeof(StringElement))]
				[JsonIgnore]
				public Element scheduled { get; set; }
				public Timing scheduledTiming { get => ChoiceAttribute.AsExactly<Timing>(scheduled); set { scheduled = value; } }
				public Period scheduledPeriod { get => ChoiceAttribute.AsExactly<Period>(scheduled); set { scheduled = value; } }
				public StringElement scheduledString { get => ChoiceAttribute.AsExactly<StringElement>(scheduled); set { scheduled = value; } }

				public Reference location { get; set; }

				public ICollection<Reference> performer { get; set; }

				[Choice(typeof(CodeableConcept))]
				[Choice(typeof(Reference))]
				[JsonIgnore]
				[ValueSetBinding("CarePlanProduct", "http://hl7.org/fhir/ValueSet/medication-codes", false)]
				public Element product { get; set; }
				public CodeableConcept productCodeableConcept { get => ChoiceAttribute.AsExactly<CodeableConcept>(product); set { product = value; } }
				public Reference productReference { get => ChoiceAttribute.AsExactly<Reference>(product); set { product = value; } }

				public Quantity dailyAmount { get; set; }

				public Quantity quantity { get; set; }

				public StringElement description { get; set; }
			}
		}
	}
}

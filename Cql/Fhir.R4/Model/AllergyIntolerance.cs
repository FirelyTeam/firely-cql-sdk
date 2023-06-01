using Hl7.Cql.Poco.Fhir;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Hl7.Cql.Poco.Fhir.R4.Model
{
    [FhirUri("http://hl7.org/fhir/StructureDefinition/AllergyIntolerance")]
	public partial class AllergyIntolerance : DomainResource
	{

		public ICollection<Identifier> identifier { get; set; }

		[ValueSetBinding("AllergyIntoleranceClinicalStatus", "http://hl7.org/fhir/ValueSet/allergyintolerance-clinical%7C4.0.1", true)]
		public CodeableConcept clinicalStatus { get; set; }

		[ValueSetBinding("AllergyIntoleranceVerificationStatus", "http://hl7.org/fhir/ValueSet/allergyintolerance-verification%7C4.0.1", true)]
		public CodeableConcept verificationStatus { get; set; }

		[ValueSetBinding("AllergyIntoleranceType", "http://hl7.org/fhir/ValueSet/allergy-intolerance-type%7C4.0.1", true)]
		public CodeElement type { get; set; }

		[ValueSetBinding("AllergyIntoleranceCategory", "http://hl7.org/fhir/ValueSet/allergy-intolerance-category%7C4.0.1", true)]
		public ICollection<CodeElement> category { get; set; }

		[ValueSetBinding("AllergyIntoleranceCriticality", "http://hl7.org/fhir/ValueSet/allergy-intolerance-criticality%7C4.0.1", true)]
		public CodeElement criticality { get; set; }

		[ValueSetBinding("AllergyIntoleranceCode", "http://hl7.org/fhir/ValueSet/allergyintolerance-code", false)]
		public CodeableConcept code { get; set; }

		[NotNull]
		public Reference patient { get; set; }

		public Reference encounter { get; set; }

		[Choice(typeof(DateTimeElement))]
		[Choice(typeof(Age))]
		[Choice(typeof(Period))]
		[Choice(typeof(Range))]
		[Choice(typeof(StringElement))]
		[JsonIgnore]
		public Element onset { get; set; }
		public DateTimeElement onsetDateTime { get => ChoiceAttribute.AsExactly<DateTimeElement>(onset); set { onset = value; } }
		public Age onsetAge { get => ChoiceAttribute.AsExactly<Age>(onset); set { onset = value; } }
		public Period onsetPeriod { get => ChoiceAttribute.AsExactly<Period>(onset); set { onset = value; } }
		public Range onsetRange { get => ChoiceAttribute.AsExactly<Range>(onset); set { onset = value; } }
		public StringElement onsetString { get => ChoiceAttribute.AsExactly<StringElement>(onset); set { onset = value; } }

		public DateTimeElement recordedDate { get; set; }

		public Reference recorder { get; set; }

		public Reference asserter { get; set; }

		public DateTimeElement lastOccurrence { get; set; }

		public ICollection<Annotation> note { get; set; }

		public ICollection<ReactionComponent> reaction { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/AllergyIntolerance.reaction")]
		public partial class ReactionComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[ValueSetBinding("SubstanceCode", "http://hl7.org/fhir/ValueSet/substance-code", false)]
			public CodeableConcept substance { get; set; }

			[ValueSetBinding("Manifestation", "http://hl7.org/fhir/ValueSet/clinical-findings", false)]
			public ICollection<CodeableConcept> manifestation { get; set; }

			public StringElement description { get; set; }

			public DateTimeElement onset { get; set; }

			[ValueSetBinding("AllergyIntoleranceSeverity", "http://hl7.org/fhir/ValueSet/reaction-event-severity%7C4.0.1", true)]
			public CodeElement severity { get; set; }

			[ValueSetBinding("RouteOfAdministration", "http://hl7.org/fhir/ValueSet/route-codes", false)]
			public CodeableConcept exposureRoute { get; set; }

			public ICollection<Annotation> note { get; set; }
		}
	}
}

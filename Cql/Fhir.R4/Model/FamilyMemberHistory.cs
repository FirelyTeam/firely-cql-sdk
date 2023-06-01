using Hl7.Cql.Poco.Fhir;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Hl7.Cql.Poco.Fhir.R4.Model
{
    [FhirUri("http://hl7.org/fhir/StructureDefinition/FamilyMemberHistory")]
	public partial class FamilyMemberHistory : DomainResource
	{

		public ICollection<Identifier> identifier { get; set; }

		public ICollection<CanonicalElement> instantiatesCanonical { get; set; }

		public ICollection<UriElement> instantiatesUri { get; set; }

		[NotNull]
		[ValueSetBinding("FamilyHistoryStatus", "http://hl7.org/fhir/ValueSet/history-status%7C4.0.1", true)]
		public CodeElement status { get; set; }

		[ValueSetBinding("FamilyHistoryAbsentReason", "http://hl7.org/fhir/ValueSet/history-absent-reason", false)]
		public CodeableConcept dataAbsentReason { get; set; }

		[NotNull]
		public Reference patient { get; set; }

		public DateTimeElement date { get; set; }

		public StringElement name { get; set; }

		[NotNull]
		[ValueSetBinding("FamilialRelationship", "http://terminology.hl7.org/ValueSet/v3-FamilyMember", false)]
		public CodeableConcept relationship { get; set; }

		[ValueSetBinding("Sex", "http://hl7.org/fhir/ValueSet/administrative-gender", false)]
		public CodeableConcept sex { get; set; }

		[Choice(typeof(Period))]
		[Choice(typeof(DateElement))]
		[Choice(typeof(StringElement))]
		[JsonIgnore]
		public Element born { get; set; }
		public Period bornPeriod { get => ChoiceAttribute.AsExactly<Period>(born); set { born = value; } }
		public DateElement bornDate { get => ChoiceAttribute.AsExactly<DateElement>(born); set { born = value; } }
		public StringElement bornString { get => ChoiceAttribute.AsExactly<StringElement>(born); set { born = value; } }

		[Choice(typeof(Age))]
		[Choice(typeof(Range))]
		[Choice(typeof(StringElement))]
		[JsonIgnore]
		public Element age { get; set; }
		public Age ageAge { get => ChoiceAttribute.AsExactly<Age>(age); set { age = value; } }
		public Range ageRange { get => ChoiceAttribute.AsExactly<Range>(age); set { age = value; } }
		public StringElement ageString { get => ChoiceAttribute.AsExactly<StringElement>(age); set { age = value; } }

		public BooleanElement estimatedAge { get; set; }

		[Choice(typeof(BooleanElement))]
		[Choice(typeof(Age))]
		[Choice(typeof(Range))]
		[Choice(typeof(DateElement))]
		[Choice(typeof(StringElement))]
		[JsonIgnore]
		public Element deceased { get; set; }
		public BooleanElement deceasedBoolean { get => ChoiceAttribute.AsExactly<BooleanElement>(deceased); set { deceased = value; } }
		public Age deceasedAge { get => ChoiceAttribute.AsExactly<Age>(deceased); set { deceased = value; } }
		public Range deceasedRange { get => ChoiceAttribute.AsExactly<Range>(deceased); set { deceased = value; } }
		public DateElement deceasedDate { get => ChoiceAttribute.AsExactly<DateElement>(deceased); set { deceased = value; } }
		public StringElement deceasedString { get => ChoiceAttribute.AsExactly<StringElement>(deceased); set { deceased = value; } }

		[ValueSetBinding("FamilyHistoryReason", "http://hl7.org/fhir/ValueSet/clinical-findings", false)]
		public ICollection<CodeableConcept> reasonCode { get; set; }

		public ICollection<Reference> reasonReference { get; set; }

		public ICollection<Annotation> note { get; set; }

		public ICollection<ConditionComponent> condition { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/FamilyMemberHistory.condition")]
		public partial class ConditionComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			[ValueSetBinding("ConditionCode", "http://hl7.org/fhir/ValueSet/condition-code", false)]
			public CodeableConcept code { get; set; }

			[ValueSetBinding("ConditionOutcome", "http://hl7.org/fhir/ValueSet/condition-outcome", false)]
			public CodeableConcept outcome { get; set; }

			public BooleanElement contributedToDeath { get; set; }

			[Choice(typeof(Age))]
			[Choice(typeof(Range))]
			[Choice(typeof(Period))]
			[Choice(typeof(StringElement))]
			[JsonIgnore]
			public Element onset { get; set; }
			public Age onsetAge { get => ChoiceAttribute.AsExactly<Age>(onset); set { onset = value; } }
			public Range onsetRange { get => ChoiceAttribute.AsExactly<Range>(onset); set { onset = value; } }
			public Period onsetPeriod { get => ChoiceAttribute.AsExactly<Period>(onset); set { onset = value; } }
			public StringElement onsetString { get => ChoiceAttribute.AsExactly<StringElement>(onset); set { onset = value; } }

			public ICollection<Annotation> note { get; set; }
		}
	}
}

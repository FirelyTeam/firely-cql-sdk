using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[FhirUri("http://hl7.org/fhir/StructureDefinition/Immunization")]
	public partial class Immunization : DomainResource
	{

		public ICollection<Identifier> identifier { get; set; }

		[NotNull]
		[ValueSetBinding("ImmunizationStatus", "http://hl7.org/fhir/ValueSet/immunization-status%7C4.0.1", true)]
		public CodeElement status { get; set; }

		[ValueSetBinding("ImmunizationStatusReason", "http://hl7.org/fhir/ValueSet/immunization-status-reason", false)]
		public CodeableConcept statusReason { get; set; }

		[NotNull]
		[ValueSetBinding("VaccineCode", "http://hl7.org/fhir/ValueSet/vaccine-code", false)]
		public CodeableConcept vaccineCode { get; set; }

		[NotNull]
		public Reference patient { get; set; }

		public Reference encounter { get; set; }

		[NotNull]
		[Choice(typeof(DateTimeElement))]
		[Choice(typeof(StringElement))]
		[JsonIgnore]
		public Element occurrence { get; set; }
		public DateTimeElement occurrenceDateTime { get => ChoiceAttribute.AsExactly<DateTimeElement>(occurrence); set { occurrence = value; } }
		public StringElement occurrenceString { get => ChoiceAttribute.AsExactly<StringElement>(occurrence); set { occurrence = value; } }

		public DateTimeElement recorded { get; set; }

		public BooleanElement primarySource { get; set; }

		[ValueSetBinding("ImmunizationReportOrigin", "http://hl7.org/fhir/ValueSet/immunization-origin", false)]
		public CodeableConcept reportOrigin { get; set; }

		public Reference location { get; set; }

		public Reference manufacturer { get; set; }

		public StringElement lotNumber { get; set; }

		public DateElement expirationDate { get; set; }

		[ValueSetBinding("ImmunizationSite", "http://hl7.org/fhir/ValueSet/immunization-site", false)]
		public CodeableConcept site { get; set; }

		[ValueSetBinding("ImmunizationRoute", "http://hl7.org/fhir/ValueSet/immunization-route", false)]
		public CodeableConcept route { get; set; }

		public Quantity doseQuantity { get; set; }

		public ICollection<PerformerComponent> performer { get; set; }

		public ICollection<Annotation> note { get; set; }

		[ValueSetBinding("ImmunizationReason", "http://hl7.org/fhir/ValueSet/immunization-reason", false)]
		public ICollection<CodeableConcept> reasonCode { get; set; }

		public ICollection<Reference> reasonReference { get; set; }

		public BooleanElement isSubpotent { get; set; }

		[ValueSetBinding("SubpotentReason", "http://hl7.org/fhir/ValueSet/immunization-subpotent-reason", false)]
		public ICollection<CodeableConcept> subpotentReason { get; set; }

		public ICollection<EducationComponent> education { get; set; }

		[ValueSetBinding("ProgramEligibility", "http://hl7.org/fhir/ValueSet/immunization-program-eligibility", false)]
		public ICollection<CodeableConcept> programEligibility { get; set; }

		[ValueSetBinding("FundingSource", "http://hl7.org/fhir/ValueSet/immunization-funding-source", false)]
		public CodeableConcept fundingSource { get; set; }

		public ICollection<ReactionComponent> reaction { get; set; }

		public ICollection<ProtocolAppliedComponent> protocolApplied { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/Immunization.performer")]
		public partial class PerformerComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[ValueSetBinding("ImmunizationFunction", "http://hl7.org/fhir/ValueSet/immunization-function", false)]
			public CodeableConcept function { get; set; }

			[NotNull]
			public Reference actor { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/Immunization.education")]
		public partial class EducationComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public StringElement documentType { get; set; }

			public UriElement reference { get; set; }

			public DateTimeElement publicationDate { get; set; }

			public DateTimeElement presentationDate { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/Immunization.reaction")]
		public partial class ReactionComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public DateTimeElement date { get; set; }

			public Reference detail { get; set; }

			public BooleanElement reported { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/Immunization.protocolApplied")]
		public partial class ProtocolAppliedComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public StringElement series { get; set; }

			public Reference authority { get; set; }

			[ValueSetBinding("TargetDisease", "http://hl7.org/fhir/ValueSet/immunization-target-disease", false)]
			public ICollection<CodeableConcept> targetDisease { get; set; }

			[NotNull]
			[Choice(typeof(PositiveIntElement))]
			[Choice(typeof(StringElement))]
			[JsonIgnore]
			public Element doseNumber { get; set; }
			public PositiveIntElement doseNumberPositiveInt { get => ChoiceAttribute.AsExactly<PositiveIntElement>(doseNumber); set { doseNumber = value; } }
			public StringElement doseNumberString { get => ChoiceAttribute.AsExactly<StringElement>(doseNumber); set { doseNumber = value; } }

			[Choice(typeof(PositiveIntElement))]
			[Choice(typeof(StringElement))]
			[JsonIgnore]
			public Element seriesDoses { get; set; }
			public PositiveIntElement seriesDosesPositiveInt { get => ChoiceAttribute.AsExactly<PositiveIntElement>(seriesDoses); set { seriesDoses = value; } }
			public StringElement seriesDosesString { get => ChoiceAttribute.AsExactly<StringElement>(seriesDoses); set { seriesDoses = value; } }
		}
	}
}

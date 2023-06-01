using Hl7.Cql.Poco.Fhir;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Hl7.Cql.Poco.Fhir.R4.Model
{
    [FhirUri("http://hl7.org/fhir/StructureDefinition/ImmunizationRecommendation")]
	public partial class ImmunizationRecommendation : DomainResource
	{

		public ICollection<Identifier> identifier { get; set; }

		[NotNull]
		public Reference patient { get; set; }

		[NotNull]
		public DateTimeElement date { get; set; }

		public Reference authority { get; set; }

		public ICollection<RecommendationComponent> recommendation { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/ImmunizationRecommendation.recommendation")]
		public partial class RecommendationComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[ValueSetBinding("VaccineCode", "http://hl7.org/fhir/ValueSet/vaccine-code", false)]
			public ICollection<CodeableConcept> vaccineCode { get; set; }

			[ValueSetBinding("TargetDisease", "http://hl7.org/fhir/ValueSet/immunization-recommendation-target-disease", false)]
			public CodeableConcept targetDisease { get; set; }

			[ValueSetBinding("VaccineCode", "http://hl7.org/fhir/ValueSet/vaccine-code", false)]
			public ICollection<CodeableConcept> contraindicatedVaccineCode { get; set; }

			[NotNull]
			[ValueSetBinding("ImmunizationRecommendationStatus", "http://hl7.org/fhir/ValueSet/immunization-recommendation-status", false)]
			public CodeableConcept forecastStatus { get; set; }

			[ValueSetBinding("ImmunizationRecommendationReason", "http://hl7.org/fhir/ValueSet/immunization-recommendation-reason", false)]
			public ICollection<CodeableConcept> forecastReason { get; set; }

			public ICollection<DateCriterionComponent> dateCriterion { get; set; }

			public StringElement description { get; set; }

			public StringElement series { get; set; }

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

			public ICollection<Reference> supportingImmunization { get; set; }

			public ICollection<Reference> supportingPatientInformation { get; set; }
			[DebuggerDisplay("{value}")]
			[FhirUri("http://hl7.org/fhir/StructureDefinition/ImmunizationRecommendation.recommendation.dateCriterion")]
			public partial class DateCriterionComponent
			{

				[NotNull]
				public DateTimeElement value { get; set; }

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				[NotNull]
				[ValueSetBinding("ImmunizationRecommendationDateCriterion", "http://hl7.org/fhir/ValueSet/immunization-recommendation-date-criterion", false)]
				public CodeableConcept code { get; set; }
			}
		}
	}
}

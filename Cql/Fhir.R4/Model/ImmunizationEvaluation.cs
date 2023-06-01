using Hl7.Cql.Poco.Fhir;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Hl7.Cql.Poco.Fhir.R4.Model
{
    [FhirUri("http://hl7.org/fhir/StructureDefinition/ImmunizationEvaluation")]
	public partial class ImmunizationEvaluation : DomainResource
	{

		public ICollection<Identifier> identifier { get; set; }

		[NotNull]
		[ValueSetBinding("ImmunizationEvaluationStatus", "http://hl7.org/fhir/ValueSet/immunization-evaluation-status%7C4.0.1", true)]
		public CodeElement status { get; set; }

		[NotNull]
		public Reference patient { get; set; }

		public DateTimeElement date { get; set; }

		public Reference authority { get; set; }

		[NotNull]
		[ValueSetBinding("EvaluationTargetDisease", "http://hl7.org/fhir/ValueSet/immunization-evaluation-target-disease", false)]
		public CodeableConcept targetDisease { get; set; }

		[NotNull]
		public Reference immunizationEvent { get; set; }

		[NotNull]
		[ValueSetBinding("EvaluationDoseStatus", "http://hl7.org/fhir/ValueSet/immunization-evaluation-dose-status", false)]
		public CodeableConcept doseStatus { get; set; }

		[ValueSetBinding("EvaluationDoseStatusReason", "http://hl7.org/fhir/ValueSet/immunization-evaluation-dose-status-reason", false)]
		public ICollection<CodeableConcept> doseStatusReason { get; set; }

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
	}
}

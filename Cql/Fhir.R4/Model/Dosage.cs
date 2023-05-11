using Hl7.Cql.Poco.Fhir;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Hl7.Cql.Poco.Fhir.R4.Model
{
    [FhirUri("http://hl7.org/fhir/StructureDefinition/Dosage")]
	public partial class Dosage : BackboneElement
	{

		public IntegerElement sequence { get; set; }

		public StringElement text { get; set; }

		[ValueSetBinding("AdditionalInstruction", "http://hl7.org/fhir/ValueSet/additional-instruction-codes", false)]
		public ICollection<CodeableConcept> additionalInstruction { get; set; }

		public StringElement patientInstruction { get; set; }

		public Timing timing { get; set; }

		[Choice(typeof(BooleanElement))]
		[Choice(typeof(CodeableConcept))]
		[JsonIgnore]
		[ValueSetBinding("MedicationAsNeededReason", "http://hl7.org/fhir/ValueSet/medication-as-needed-reason", false)]
		public Element asNeeded { get; set; }
		public BooleanElement asNeededBoolean { get => ChoiceAttribute.AsExactly<BooleanElement>(asNeeded); set { asNeeded = value; } }
		public CodeableConcept asNeededCodeableConcept { get => ChoiceAttribute.AsExactly<CodeableConcept>(asNeeded); set { asNeeded = value; } }

		[ValueSetBinding("MedicationAdministrationSite", "http://hl7.org/fhir/ValueSet/approach-site-codes", false)]
		public CodeableConcept site { get; set; }

		[ValueSetBinding("RouteOfAdministration", "http://hl7.org/fhir/ValueSet/route-codes", false)]
		public CodeableConcept route { get; set; }

		[ValueSetBinding("MedicationAdministrationMethod", "http://hl7.org/fhir/ValueSet/administration-method-codes", false)]
		public CodeableConcept method { get; set; }

		public ICollection<DoseAndRateComponent> doseAndRate { get; set; }

		public Ratio maxDosePerPeriod { get; set; }

		public Quantity maxDosePerAdministration { get; set; }

		public Quantity maxDosePerLifetime { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/Dosage.doseAndRate")]
		public partial class DoseAndRateComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			[ValueSetBinding("DoseAndRateType", "http://hl7.org/fhir/ValueSet/dose-rate-type", false)]
			public CodeableConcept type { get; set; }

			[Choice(typeof(Range))]
			[Choice(typeof(Quantity))]
			[JsonIgnore]
			public Element dose { get; set; }
			public Range doseRange { get => ChoiceAttribute.AsExactly<Range>(dose); set { dose = value; } }
			public Quantity doseQuantity { get => ChoiceAttribute.AsExactly<Quantity>(dose); set { dose = value; } }

			[Choice(typeof(Ratio))]
			[Choice(typeof(Range))]
			[Choice(typeof(Quantity))]
			[JsonIgnore]
			public Element rate { get; set; }
			public Ratio rateRatio { get => ChoiceAttribute.AsExactly<Ratio>(rate); set { rate = value; } }
			public Range rateRange { get => ChoiceAttribute.AsExactly<Range>(rate); set { rate = value; } }
			public Quantity rateQuantity { get => ChoiceAttribute.AsExactly<Quantity>(rate); set { rate = value; } }
		}
	}
}

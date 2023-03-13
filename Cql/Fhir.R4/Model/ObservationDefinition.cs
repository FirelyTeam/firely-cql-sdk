using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[FhirUri("http://hl7.org/fhir/StructureDefinition/ObservationDefinition")]
	public partial class ObservationDefinition : DomainResource
	{

		[ValueSetBinding("ObservationCategory", "http://hl7.org/fhir/ValueSet/observation-category", false)]
		public ICollection<CodeableConcept> category { get; set; }

		[NotNull]
		[ValueSetBinding("ObservationCode", "http://hl7.org/fhir/ValueSet/observation-codes", false)]
		public CodeableConcept code { get; set; }

		public ICollection<Identifier> identifier { get; set; }

		[ValueSetBinding("ObservationDataType", "http://hl7.org/fhir/ValueSet/permitted-data-type%7C4.0.1", true)]
		public ICollection<CodeElement> permittedDataType { get; set; }

		public BooleanElement multipleResultsAllowed { get; set; }

		[ValueSetBinding("ObservationMethod", "http://hl7.org/fhir/ValueSet/observation-methods", false)]
		public CodeableConcept method { get; set; }

		public StringElement preferredReportName { get; set; }

		public QuantitativeDetailsComponent quantitativeDetails { get; set; }

		public ICollection<QualifiedIntervalComponent> qualifiedInterval { get; set; }

		public Reference validCodedValueSet { get; set; }

		public Reference normalCodedValueSet { get; set; }

		public Reference abnormalCodedValueSet { get; set; }

		public Reference criticalCodedValueSet { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/ObservationDefinition.quantitativeDetails")]
		public partial class QuantitativeDetailsComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[ValueSetBinding("ObservationUnit", "http://hl7.org/fhir/ValueSet/ucum-units", false)]
			public CodeableConcept customaryUnit { get; set; }

			[ValueSetBinding("ObservationUnit", "http://hl7.org/fhir/ValueSet/ucum-units", false)]
			public CodeableConcept unit { get; set; }

			public DecimalElement conversionFactor { get; set; }

			public IntegerElement decimalPrecision { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/ObservationDefinition.qualifiedInterval")]
		public partial class QualifiedIntervalComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[ValueSetBinding("ObservationRangeCategory", "http://hl7.org/fhir/ValueSet/observation-range-category%7C4.0.1", true)]
			public CodeElement category { get; set; }

			public Range range { get; set; }

			[ValueSetBinding("ObservationRangeMeaning", "http://hl7.org/fhir/ValueSet/referencerange-meaning", false)]
			public CodeableConcept context { get; set; }

			[ValueSetBinding("ObservationRangeAppliesTo", "http://hl7.org/fhir/ValueSet/referencerange-appliesto", false)]
			public ICollection<CodeableConcept> appliesTo { get; set; }

			[ValueSetBinding("AdministrativeGender", "http://hl7.org/fhir/ValueSet/administrative-gender%7C4.0.1", true)]
			public CodeElement gender { get; set; }

			public Range age { get; set; }

			public Range gestationalAge { get; set; }

			public StringElement condition { get; set; }
		}
	}
}

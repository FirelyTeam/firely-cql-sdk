using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[FhirUri("http://hl7.org/fhir/StructureDefinition/NutritionOrder")]
	public partial class NutritionOrder : DomainResource
	{

		public ICollection<Identifier> identifier { get; set; }

		public ICollection<CanonicalElement> instantiatesCanonical { get; set; }

		public ICollection<UriElement> instantiatesUri { get; set; }

		public ICollection<UriElement> instantiates { get; set; }

		[NotNull]
		[ValueSetBinding("NutritionOrderStatus", "http://hl7.org/fhir/ValueSet/request-status%7C4.0.1", true)]
		public CodeElement status { get; set; }

		[NotNull]
		[ValueSetBinding("NutritiionOrderIntent", "http://hl7.org/fhir/ValueSet/request-intent%7C4.0.1", true)]
		public CodeElement intent { get; set; }

		[NotNull]
		public Reference patient { get; set; }

		public Reference encounter { get; set; }

		[NotNull]
		public DateTimeElement dateTime { get; set; }

		public Reference orderer { get; set; }

		public ICollection<Reference> allergyIntolerance { get; set; }

		[ValueSetBinding("PatientDiet", "http://hl7.org/fhir/ValueSet/encounter-diet", false)]
		public ICollection<CodeableConcept> foodPreferenceModifier { get; set; }

		[ValueSetBinding("FoodType", "http://hl7.org/fhir/ValueSet/food-type", false)]
		public ICollection<CodeableConcept> excludeFoodModifier { get; set; }

		public OralDietComponent oralDiet { get; set; }

		public ICollection<SupplementComponent> supplement { get; set; }

		public EnteralFormulaComponent enteralFormula { get; set; }

		public ICollection<Annotation> note { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/NutritionOrder.oralDiet")]
		public partial class OralDietComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[ValueSetBinding("OralDiet", "http://hl7.org/fhir/ValueSet/diet-type", false)]
			public ICollection<CodeableConcept> type { get; set; }

			public ICollection<Timing> schedule { get; set; }

			public ICollection<NutrientComponent> nutrient { get; set; }

			public ICollection<TextureComponent> texture { get; set; }

			[ValueSetBinding("FluidConsistencyType", "http://hl7.org/fhir/ValueSet/consistency-type", false)]
			public ICollection<CodeableConcept> fluidConsistencyType { get; set; }

			public StringElement instruction { get; set; }
			[FhirUri("http://hl7.org/fhir/StructureDefinition/NutritionOrder.oralDiet.nutrient")]
			public partial class NutrientComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				[ValueSetBinding("NutrientModifier", "http://hl7.org/fhir/ValueSet/nutrient-code", false)]
				public CodeableConcept modifier { get; set; }

				public Quantity amount { get; set; }
			}
			[FhirUri("http://hl7.org/fhir/StructureDefinition/NutritionOrder.oralDiet.texture")]
			public partial class TextureComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				[ValueSetBinding("TextureModifier", "http://hl7.org/fhir/ValueSet/texture-code", false)]
				public CodeableConcept modifier { get; set; }

				[ValueSetBinding("TextureModifiedFoodType", "http://hl7.org/fhir/ValueSet/modified-foodtype", false)]
				public CodeableConcept foodType { get; set; }
			}
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/NutritionOrder.supplement")]
		public partial class SupplementComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[ValueSetBinding("SupplementType", "http://hl7.org/fhir/ValueSet/supplement-type", false)]
			public CodeableConcept type { get; set; }

			public StringElement productName { get; set; }

			public ICollection<Timing> schedule { get; set; }

			public Quantity quantity { get; set; }

			public StringElement instruction { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/NutritionOrder.enteralFormula")]
		public partial class EnteralFormulaComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[ValueSetBinding("EnteralFormulaType", "http://hl7.org/fhir/ValueSet/entformula-type", false)]
			public CodeableConcept baseFormulaType { get; set; }

			public StringElement baseFormulaProductName { get; set; }

			[ValueSetBinding("EnteralFormulaAdditiveType", "http://hl7.org/fhir/ValueSet/entformula-additive", false)]
			public CodeableConcept additiveType { get; set; }

			public StringElement additiveProductName { get; set; }

			public Quantity caloricDensity { get; set; }

			[ValueSetBinding("EnteralRouteOfAdministration", "http://hl7.org/fhir/ValueSet/enteral-route", false)]
			public CodeableConcept routeofAdministration { get; set; }

			public ICollection<AdministrationComponent> administration { get; set; }

			public Quantity maxVolumeToDeliver { get; set; }

			public StringElement administrationInstruction { get; set; }
			[FhirUri("http://hl7.org/fhir/StructureDefinition/NutritionOrder.enteralFormula.administration")]
			public partial class AdministrationComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				public Timing schedule { get; set; }

				public Quantity quantity { get; set; }

				[Choice(typeof(Quantity))]
				[Choice(typeof(Ratio))]
				[JsonIgnore]
				public Element rate { get; set; }
				public Quantity rateQuantity { get => ChoiceAttribute.AsExactly<Quantity>(rate); set { rate = value; } }
				public Ratio rateRatio { get => ChoiceAttribute.AsExactly<Ratio>(rate); set { rate = value; } }
			}
		}
	}
}

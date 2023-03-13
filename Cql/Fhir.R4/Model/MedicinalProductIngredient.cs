using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[FhirUri("http://hl7.org/fhir/StructureDefinition/MedicinalProductIngredient")]
	public partial class MedicinalProductIngredient : DomainResource
	{

		public Identifier identifier { get; set; }

		[NotNull]
		public CodeableConcept role { get; set; }

		public BooleanElement allergenicIndicator { get; set; }

		public ICollection<Reference> manufacturer { get; set; }

		public ICollection<SpecifiedSubstanceComponent> specifiedSubstance { get; set; }

		public SubstanceComponent substance { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/MedicinalProductIngredient.specifiedSubstance")]
		public partial class SpecifiedSubstanceComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			public CodeableConcept code { get; set; }

			[NotNull]
			public CodeableConcept group { get; set; }

			public CodeableConcept confidentiality { get; set; }

			public ICollection<StrengthComponent> strength { get; set; }
			[FhirUri("http://hl7.org/fhir/StructureDefinition/MedicinalProductIngredient.specifiedSubstance.strength")]
			public partial class StrengthComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				[NotNull]
				public Ratio presentation { get; set; }

				public Ratio presentationLowLimit { get; set; }

				public Ratio concentration { get; set; }

				public Ratio concentrationLowLimit { get; set; }

				public StringElement measurementPoint { get; set; }

				public ICollection<CodeableConcept> country { get; set; }

				public ICollection<ReferenceStrengthComponent> referenceStrength { get; set; }
				[FhirUri("http://hl7.org/fhir/StructureDefinition/MedicinalProductIngredient.specifiedSubstance.strength.referenceStrength")]
				public partial class ReferenceStrengthComponent
				{

					public string id { get; set; }

					public ICollection<Extension> extension { get; set; }

					public ICollection<Extension> modifierExtension { get; set; }

					public CodeableConcept substance { get; set; }

					[NotNull]
					public Ratio strength { get; set; }

					public Ratio strengthLowLimit { get; set; }

					public StringElement measurementPoint { get; set; }

					public ICollection<CodeableConcept> country { get; set; }
				}
			}
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/MedicinalProductIngredient.substance")]
		public partial class SubstanceComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			public CodeableConcept code { get; set; }
		}
	}
}

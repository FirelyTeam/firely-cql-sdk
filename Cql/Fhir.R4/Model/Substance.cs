using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[FhirUri("http://hl7.org/fhir/StructureDefinition/Substance")]
	public partial class Substance : DomainResource
	{

		public ICollection<Identifier> identifier { get; set; }

		[ValueSetBinding("FHIRSubstanceStatus", "http://hl7.org/fhir/ValueSet/substance-status%7C4.0.1", true)]
		public CodeElement status { get; set; }

		[ValueSetBinding("SubstanceCategory", "http://hl7.org/fhir/ValueSet/substance-category", false)]
		public ICollection<CodeableConcept> category { get; set; }

		[NotNull]
		[ValueSetBinding("SubstanceCode", "http://hl7.org/fhir/ValueSet/substance-code", false)]
		public CodeableConcept code { get; set; }

		public StringElement description { get; set; }

		public ICollection<InstanceComponent> instance { get; set; }

		public ICollection<IngredientComponent> ingredient { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/Substance.instance")]
		public partial class InstanceComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public Identifier identifier { get; set; }

			public DateTimeElement expiry { get; set; }

			public Quantity quantity { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/Substance.ingredient")]
		public partial class IngredientComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public Ratio quantity { get; set; }

			[NotNull]
			[Choice(typeof(CodeableConcept))]
			[Choice(typeof(Reference))]
			[JsonIgnore]
			[ValueSetBinding("SubstanceIngredient", "http://hl7.org/fhir/ValueSet/substance-code", false)]
			public Element substance { get; set; }
			public CodeableConcept substanceCodeableConcept { get => ChoiceAttribute.AsExactly<CodeableConcept>(substance); set { substance = value; } }
			public Reference substanceReference { get => ChoiceAttribute.AsExactly<Reference>(substance); set { substance = value; } }
		}
	}
}

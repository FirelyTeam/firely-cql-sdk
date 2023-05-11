using Hl7.Cql.Poco.Fhir;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Hl7.Cql.Poco.Fhir.R4.Model
{
    [FhirUri("http://hl7.org/fhir/StructureDefinition/SubstanceSpecification")]
	public partial class SubstanceSpecification : DomainResource
	{

		public Identifier identifier { get; set; }

		public CodeableConcept type { get; set; }

		public CodeableConcept status { get; set; }

		public CodeableConcept domain { get; set; }

		public StringElement description { get; set; }

		public ICollection<Reference> source { get; set; }

		public StringElement comment { get; set; }

		public ICollection<MoietyComponent> moiety { get; set; }

		public ICollection<PropertyComponent> property { get; set; }

		public Reference referenceInformation { get; set; }

		public StructureComponent structure { get; set; }

		public ICollection<CodeComponent> code { get; set; }

		public ICollection<NameComponent> name { get; set; }

		public ICollection<RelationshipComponent> relationship { get; set; }

		public Reference nucleicAcid { get; set; }

		public Reference polymer { get; set; }

		public Reference protein { get; set; }

		public Reference sourceMaterial { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/SubstanceSpecification.moiety")]
		public partial class MoietyComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public CodeableConcept role { get; set; }

			public Identifier identifier { get; set; }

			public StringElement name { get; set; }

			public CodeableConcept stereochemistry { get; set; }

			public CodeableConcept opticalActivity { get; set; }

			public StringElement molecularFormula { get; set; }

			[Choice(typeof(Quantity))]
			[Choice(typeof(StringElement))]
			[JsonIgnore]
			public Element amount { get; set; }
			public Quantity amountQuantity { get => ChoiceAttribute.AsExactly<Quantity>(amount); set { amount = value; } }
			public StringElement amountString { get => ChoiceAttribute.AsExactly<StringElement>(amount); set { amount = value; } }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/SubstanceSpecification.property")]
		public partial class PropertyComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public CodeableConcept category { get; set; }

			public CodeableConcept code { get; set; }

			public StringElement parameters { get; set; }

			[Choice(typeof(Reference))]
			[Choice(typeof(CodeableConcept))]
			[JsonIgnore]
			public Element definingSubstance { get; set; }
			public Reference definingSubstanceReference { get => ChoiceAttribute.AsExactly<Reference>(definingSubstance); set { definingSubstance = value; } }
			public CodeableConcept definingSubstanceCodeableConcept { get => ChoiceAttribute.AsExactly<CodeableConcept>(definingSubstance); set { definingSubstance = value; } }

			[Choice(typeof(Quantity))]
			[Choice(typeof(StringElement))]
			[JsonIgnore]
			public Element amount { get; set; }
			public Quantity amountQuantity { get => ChoiceAttribute.AsExactly<Quantity>(amount); set { amount = value; } }
			public StringElement amountString { get => ChoiceAttribute.AsExactly<StringElement>(amount); set { amount = value; } }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/SubstanceSpecification.structure")]
		public partial class StructureComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public CodeableConcept stereochemistry { get; set; }

			public CodeableConcept opticalActivity { get; set; }

			public StringElement molecularFormula { get; set; }

			public StringElement molecularFormulaByMoiety { get; set; }

			public ICollection<IsotopeComponent> isotope { get; set; }

			public ICollection<Reference> source { get; set; }

			public ICollection<RepresentationComponent> representation { get; set; }
			[FhirUri("http://hl7.org/fhir/StructureDefinition/SubstanceSpecification.structure.isotope")]
			public partial class IsotopeComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				public Identifier identifier { get; set; }

				public CodeableConcept name { get; set; }

				public CodeableConcept substitution { get; set; }

				public Quantity halfLife { get; set; }

				public MolecularWeightComponent molecularWeight { get; set; }
				[FhirUri("http://hl7.org/fhir/StructureDefinition/SubstanceSpecification.structure.isotope.molecularWeight")]
				public partial class MolecularWeightComponent
				{

					public string id { get; set; }

					public ICollection<Extension> extension { get; set; }

					public ICollection<Extension> modifierExtension { get; set; }

					public CodeableConcept method { get; set; }

					public CodeableConcept type { get; set; }

					public Quantity amount { get; set; }
				}
			}
			[FhirUri("http://hl7.org/fhir/StructureDefinition/SubstanceSpecification.structure.representation")]
			public partial class RepresentationComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				public CodeableConcept type { get; set; }

				public StringElement representation { get; set; }

				public Attachment attachment { get; set; }
			}
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/SubstanceSpecification.code")]
		public partial class CodeComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public CodeableConcept code { get; set; }

			public CodeableConcept status { get; set; }

			public DateTimeElement statusDate { get; set; }

			public StringElement comment { get; set; }

			public ICollection<Reference> source { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/SubstanceSpecification.name")]
		public partial class NameComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			public StringElement name { get; set; }

			public CodeableConcept type { get; set; }

			public CodeableConcept status { get; set; }

			public BooleanElement preferred { get; set; }

			public ICollection<CodeableConcept> language { get; set; }

			public ICollection<CodeableConcept> domain { get; set; }

			public ICollection<CodeableConcept> jurisdiction { get; set; }

			public ICollection<OfficialComponent> official { get; set; }

			public ICollection<Reference> source { get; set; }
			[FhirUri("http://hl7.org/fhir/StructureDefinition/SubstanceSpecification.name.official")]
			public partial class OfficialComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				public CodeableConcept authority { get; set; }

				public CodeableConcept status { get; set; }

				public DateTimeElement date { get; set; }
			}
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/SubstanceSpecification.relationship")]
		public partial class RelationshipComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[Choice(typeof(Reference))]
			[Choice(typeof(CodeableConcept))]
			[JsonIgnore]
			public Element substance { get; set; }
			public Reference substanceReference { get => ChoiceAttribute.AsExactly<Reference>(substance); set { substance = value; } }
			public CodeableConcept substanceCodeableConcept { get => ChoiceAttribute.AsExactly<CodeableConcept>(substance); set { substance = value; } }

			public CodeableConcept relationship { get; set; }

			public BooleanElement isDefining { get; set; }

			[Choice(typeof(Quantity))]
			[Choice(typeof(Range))]
			[Choice(typeof(Ratio))]
			[Choice(typeof(StringElement))]
			[JsonIgnore]
			public Element amount { get; set; }
			public Quantity amountQuantity { get => ChoiceAttribute.AsExactly<Quantity>(amount); set { amount = value; } }
			public Range amountRange { get => ChoiceAttribute.AsExactly<Range>(amount); set { amount = value; } }
			public Ratio amountRatio { get => ChoiceAttribute.AsExactly<Ratio>(amount); set { amount = value; } }
			public StringElement amountString { get => ChoiceAttribute.AsExactly<StringElement>(amount); set { amount = value; } }

			public Ratio amountRatioLowLimit { get; set; }

			public CodeableConcept amountType { get; set; }

			public ICollection<Reference> source { get; set; }
		}
	}
}

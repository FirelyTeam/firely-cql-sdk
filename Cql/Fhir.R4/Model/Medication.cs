using Hl7.Cql.Poco.Fhir;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Hl7.Cql.Poco.Fhir.R4.Model
{
    [FhirUri("http://hl7.org/fhir/StructureDefinition/Medication")]
	public partial class Medication : DomainResource
	{

		public ICollection<Identifier> identifier { get; set; }

		[ValueSetBinding("MedicationFormalRepresentation", "http://hl7.org/fhir/ValueSet/medication-codes", false)]
		public CodeableConcept code { get; set; }

		[ValueSetBinding("MedicationStatus", "http://hl7.org/fhir/ValueSet/medication-status%7C4.0.1", true)]
		public CodeElement status { get; set; }

		public Reference manufacturer { get; set; }

		[ValueSetBinding("MedicationForm", "http://hl7.org/fhir/ValueSet/medication-form-codes", false)]
		public CodeableConcept form { get; set; }

		public Ratio amount { get; set; }

		public ICollection<IngredientComponent> ingredient { get; set; }

		public BatchComponent batch { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/Medication.ingredient")]
		public partial class IngredientComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			[Choice(typeof(CodeableConcept))]
			[Choice(typeof(Reference))]
			[JsonIgnore]
			public Element item { get; set; }
			public CodeableConcept itemCodeableConcept { get => ChoiceAttribute.AsExactly<CodeableConcept>(item); set { item = value; } }
			public Reference itemReference { get => ChoiceAttribute.AsExactly<Reference>(item); set { item = value; } }

			public BooleanElement isActive { get; set; }

			public Ratio strength { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/Medication.batch")]
		public partial class BatchComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public StringElement lotNumber { get; set; }

			public DateTimeElement expirationDate { get; set; }
		}
	}
}

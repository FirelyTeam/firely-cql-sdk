using Hl7.Cql.Poco.Fhir;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Hl7.Cql.Poco.Fhir.R4.Model
{
    [FhirUri("http://hl7.org/fhir/StructureDefinition/MedicinalProductInteraction")]
	public partial class MedicinalProductInteraction : DomainResource
	{

		public ICollection<Reference> subject { get; set; }

		public StringElement description { get; set; }

		public ICollection<InteractantComponent> interactant { get; set; }

		public CodeableConcept type { get; set; }

		public CodeableConcept effect { get; set; }

		public CodeableConcept incidence { get; set; }

		public CodeableConcept management { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/MedicinalProductInteraction.interactant")]
		public partial class InteractantComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			[Choice(typeof(Reference))]
			[Choice(typeof(CodeableConcept))]
			[JsonIgnore]
			public Element item { get; set; }
			public Reference itemReference { get => ChoiceAttribute.AsExactly<Reference>(item); set { item = value; } }
			public CodeableConcept itemCodeableConcept { get => ChoiceAttribute.AsExactly<CodeableConcept>(item); set { item = value; } }
		}
	}
}

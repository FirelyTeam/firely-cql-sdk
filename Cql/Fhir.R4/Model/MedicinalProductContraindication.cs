using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[FhirUri("http://hl7.org/fhir/StructureDefinition/MedicinalProductContraindication")]
	public partial class MedicinalProductContraindication : DomainResource
	{

		public ICollection<Reference> subject { get; set; }

		public CodeableConcept disease { get; set; }

		public CodeableConcept diseaseStatus { get; set; }

		public ICollection<CodeableConcept> comorbidity { get; set; }

		public ICollection<Reference> therapeuticIndication { get; set; }

		public ICollection<OtherTherapyComponent> otherTherapy { get; set; }

		public ICollection<Population> population { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/MedicinalProductContraindication.otherTherapy")]
		public partial class OtherTherapyComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			public CodeableConcept therapyRelationshipType { get; set; }

			[NotNull]
			[Choice(typeof(CodeableConcept))]
			[Choice(typeof(Reference))]
			[JsonIgnore]
			public Element medication { get; set; }
			public CodeableConcept medicationCodeableConcept { get => ChoiceAttribute.AsExactly<CodeableConcept>(medication); set { medication = value; } }
			public Reference medicationReference { get => ChoiceAttribute.AsExactly<Reference>(medication); set { medication = value; } }
		}
	}
}

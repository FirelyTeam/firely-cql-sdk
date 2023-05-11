using Hl7.Cql.Poco.Fhir;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Hl7.Cql.Poco.Fhir.R4.Model
{
    [FhirUri("http://hl7.org/fhir/StructureDefinition/SubstanceReferenceInformation")]
	public partial class SubstanceReferenceInformation : DomainResource
	{

		public StringElement comment { get; set; }

		public ICollection<GeneComponent> gene { get; set; }

		public ICollection<GeneElementComponent> geneElement { get; set; }

		public ICollection<ClassificationComponent> classification { get; set; }

		public ICollection<TargetComponent> target { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/SubstanceReferenceInformation.gene")]
		public partial class GeneComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public CodeableConcept geneSequenceOrigin { get; set; }

			public CodeableConcept gene { get; set; }

			public ICollection<Reference> source { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/SubstanceReferenceInformation.geneElement")]
		public partial class GeneElementComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public CodeableConcept type { get; set; }

			public Identifier element { get; set; }

			public ICollection<Reference> source { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/SubstanceReferenceInformation.classification")]
		public partial class ClassificationComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public CodeableConcept domain { get; set; }

			public CodeableConcept classification { get; set; }

			public ICollection<CodeableConcept> subtype { get; set; }

			public ICollection<Reference> source { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/SubstanceReferenceInformation.target")]
		public partial class TargetComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public Identifier target { get; set; }

			public CodeableConcept type { get; set; }

			public CodeableConcept interaction { get; set; }

			public CodeableConcept organism { get; set; }

			public CodeableConcept organismType { get; set; }

			[Choice(typeof(Quantity))]
			[Choice(typeof(Range))]
			[Choice(typeof(StringElement))]
			[JsonIgnore]
			public Element amount { get; set; }
			public Quantity amountQuantity { get => ChoiceAttribute.AsExactly<Quantity>(amount); set { amount = value; } }
			public Range amountRange { get => ChoiceAttribute.AsExactly<Range>(amount); set { amount = value; } }
			public StringElement amountString { get => ChoiceAttribute.AsExactly<StringElement>(amount); set { amount = value; } }

			public CodeableConcept amountType { get; set; }

			public ICollection<Reference> source { get; set; }
		}
	}
}

using Hl7.Cql.Poco.Fhir;
using System.Collections.Generic;

namespace Hl7.Cql.Poco.Fhir.R4.Model
{
    [FhirUri("http://hl7.org/fhir/StructureDefinition/SubstanceSourceMaterial")]
	public partial class SubstanceSourceMaterial : DomainResource
	{

		public CodeableConcept sourceMaterialClass { get; set; }

		public CodeableConcept sourceMaterialType { get; set; }

		public CodeableConcept sourceMaterialState { get; set; }

		public Identifier organismId { get; set; }

		public StringElement organismName { get; set; }

		public ICollection<Identifier> parentSubstanceId { get; set; }

		public ICollection<StringElement> parentSubstanceName { get; set; }

		public ICollection<CodeableConcept> countryOfOrigin { get; set; }

		public ICollection<StringElement> geographicalLocation { get; set; }

		public CodeableConcept developmentStage { get; set; }

		public ICollection<FractionDescriptionComponent> fractionDescription { get; set; }

		public OrganismComponent organism { get; set; }

		public ICollection<PartDescriptionComponent> partDescription { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/SubstanceSourceMaterial.fractionDescription")]
		public partial class FractionDescriptionComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public StringElement fraction { get; set; }

			public CodeableConcept materialType { get; set; }
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/SubstanceSourceMaterial.organism")]
		public partial class OrganismComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public CodeableConcept family { get; set; }

			public CodeableConcept genus { get; set; }

			public CodeableConcept species { get; set; }

			public CodeableConcept intraspecificType { get; set; }

			public StringElement intraspecificDescription { get; set; }

			public ICollection<AuthorComponent> author { get; set; }

			public HybridComponent hybrid { get; set; }

			public OrganismGeneralComponent organismGeneral { get; set; }
			[FhirUri("http://hl7.org/fhir/StructureDefinition/SubstanceSourceMaterial.organism.author")]
			public partial class AuthorComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				public CodeableConcept authorType { get; set; }

				public StringElement authorDescription { get; set; }
			}
			[FhirUri("http://hl7.org/fhir/StructureDefinition/SubstanceSourceMaterial.organism.hybrid")]
			public partial class HybridComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				public StringElement maternalOrganismId { get; set; }

				public StringElement maternalOrganismName { get; set; }

				public StringElement paternalOrganismId { get; set; }

				public StringElement paternalOrganismName { get; set; }

				public CodeableConcept hybridType { get; set; }
			}
			[FhirUri("http://hl7.org/fhir/StructureDefinition/SubstanceSourceMaterial.organism.organismGeneral")]
			public partial class OrganismGeneralComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				public CodeableConcept kingdom { get; set; }

				public CodeableConcept phylum { get; set; }

				public CodeableConcept @class { get; set; }

				public CodeableConcept order { get; set; }
			}
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/SubstanceSourceMaterial.partDescription")]
		public partial class PartDescriptionComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public CodeableConcept part { get; set; }

			public CodeableConcept partLocation { get; set; }
		}
	}
}

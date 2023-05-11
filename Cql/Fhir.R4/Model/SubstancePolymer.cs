using Hl7.Cql.Poco.Fhir;
using System.Collections.Generic;

namespace Hl7.Cql.Poco.Fhir.R4.Model
{
    [FhirUri("http://hl7.org/fhir/StructureDefinition/SubstancePolymer")]
	public partial class SubstancePolymer : DomainResource
	{

		public CodeableConcept @class { get; set; }

		public CodeableConcept geometry { get; set; }

		public ICollection<CodeableConcept> copolymerConnectivity { get; set; }

		public ICollection<StringElement> modification { get; set; }

		public ICollection<MonomerSetComponent> monomerSet { get; set; }

		public ICollection<RepeatComponent> repeat { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/SubstancePolymer.monomerSet")]
		public partial class MonomerSetComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public CodeableConcept ratioType { get; set; }

			public ICollection<StartingMaterialComponent> startingMaterial { get; set; }
			[FhirUri("http://hl7.org/fhir/StructureDefinition/SubstancePolymer.monomerSet.startingMaterial")]
			public partial class StartingMaterialComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				public CodeableConcept material { get; set; }

				public CodeableConcept type { get; set; }

				public BooleanElement isDefining { get; set; }

				public SubstanceAmount amount { get; set; }
			}
		}
		[FhirUri("http://hl7.org/fhir/StructureDefinition/SubstancePolymer.repeat")]
		public partial class RepeatComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public IntegerElement numberOfUnits { get; set; }

			public StringElement averageMolecularFormula { get; set; }

			public CodeableConcept repeatUnitAmountType { get; set; }

			public ICollection<RepeatUnitComponent> repeatUnit { get; set; }
			[FhirUri("http://hl7.org/fhir/StructureDefinition/SubstancePolymer.repeat.repeatUnit")]
			public partial class RepeatUnitComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				public CodeableConcept orientationOfPolymerisation { get; set; }

				public StringElement repeatUnit { get; set; }

				public SubstanceAmount amount { get; set; }

				public ICollection<DegreeOfPolymerisationComponent> degreeOfPolymerisation { get; set; }

				public ICollection<StructuralRepresentationComponent> structuralRepresentation { get; set; }
				[FhirUri("http://hl7.org/fhir/StructureDefinition/SubstancePolymer.repeat.repeatUnit.degreeOfPolymerisation")]
				public partial class DegreeOfPolymerisationComponent
				{

					public string id { get; set; }

					public ICollection<Extension> extension { get; set; }

					public ICollection<Extension> modifierExtension { get; set; }

					public CodeableConcept degree { get; set; }

					public SubstanceAmount amount { get; set; }
				}
				[FhirUri("http://hl7.org/fhir/StructureDefinition/SubstancePolymer.repeat.repeatUnit.structuralRepresentation")]
				public partial class StructuralRepresentationComponent
				{

					public string id { get; set; }

					public ICollection<Extension> extension { get; set; }

					public ICollection<Extension> modifierExtension { get; set; }

					public CodeableConcept type { get; set; }

					public StringElement representation { get; set; }

					public Attachment attachment { get; set; }
				}
			}
		}
	}
}

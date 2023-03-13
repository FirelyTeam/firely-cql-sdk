using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[FhirUri("http://hl7.org/fhir/StructureDefinition/SubstanceNucleicAcid")]
	public partial class SubstanceNucleicAcid : DomainResource
	{

		public CodeableConcept sequenceType { get; set; }

		public IntegerElement numberOfSubunits { get; set; }

		public StringElement areaOfHybridisation { get; set; }

		public CodeableConcept oligoNucleotideType { get; set; }

		public ICollection<SubunitComponent> subunit { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/SubstanceNucleicAcid.subunit")]
		public partial class SubunitComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public IntegerElement subunit { get; set; }

			public StringElement sequence { get; set; }

			public IntegerElement length { get; set; }

			public Attachment sequenceAttachment { get; set; }

			public CodeableConcept fivePrime { get; set; }

			public CodeableConcept threePrime { get; set; }

			public ICollection<LinkageComponent> linkage { get; set; }

			public ICollection<SugarComponent> sugar { get; set; }
			[FhirUri("http://hl7.org/fhir/StructureDefinition/SubstanceNucleicAcid.subunit.linkage")]
			public partial class LinkageComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				public StringElement connectivity { get; set; }

				public Identifier identifier { get; set; }

				public StringElement name { get; set; }

				public StringElement residueSite { get; set; }
			}
			[FhirUri("http://hl7.org/fhir/StructureDefinition/SubstanceNucleicAcid.subunit.sugar")]
			public partial class SugarComponent
			{

				public string id { get; set; }

				public ICollection<Extension> extension { get; set; }

				public ICollection<Extension> modifierExtension { get; set; }

				public Identifier identifier { get; set; }

				public StringElement name { get; set; }

				public StringElement residueSite { get; set; }
			}
		}
	}
}

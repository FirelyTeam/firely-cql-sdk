using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[FhirUri("http://hl7.org/fhir/StructureDefinition/SubstanceProtein")]
	public partial class SubstanceProtein : DomainResource
	{

		public CodeableConcept sequenceType { get; set; }

		public IntegerElement numberOfSubunits { get; set; }

		public ICollection<StringElement> disulfideLinkage { get; set; }

		public ICollection<SubunitComponent> subunit { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/SubstanceProtein.subunit")]
		public partial class SubunitComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			public IntegerElement subunit { get; set; }

			public StringElement sequence { get; set; }

			public IntegerElement length { get; set; }

			public Attachment sequenceAttachment { get; set; }

			public Identifier nTerminalModificationId { get; set; }

			public StringElement nTerminalModification { get; set; }

			public Identifier cTerminalModificationId { get; set; }

			public StringElement cTerminalModification { get; set; }
		}
	}
}

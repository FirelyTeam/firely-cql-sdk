using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[FhirUri("http://hl7.org/fhir/StructureDefinition/Linkage")]
	public partial class Linkage : DomainResource
	{

		public BooleanElement active { get; set; }

		public Reference author { get; set; }

		public ICollection<ItemComponent> item { get; set; }
		[FhirUri("http://hl7.org/fhir/StructureDefinition/Linkage.item")]
		public partial class ItemComponent
		{

			public string id { get; set; }

			public ICollection<Extension> extension { get; set; }

			public ICollection<Extension> modifierExtension { get; set; }

			[NotNull]
			[ValueSetBinding("LinkageType", "http://hl7.org/fhir/ValueSet/linkage-type%7C4.0.1", true)]
			public CodeElement type { get; set; }

			[NotNull]
			public Reference resource { get; set; }
		}
	}
}

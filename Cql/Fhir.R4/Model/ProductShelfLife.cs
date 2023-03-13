using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[FhirUri("http://hl7.org/fhir/StructureDefinition/ProductShelfLife")]
	public partial class ProductShelfLife : BackboneElement
	{

		public Identifier identifier { get; set; }

		[NotNull]
		public CodeableConcept type { get; set; }

		[NotNull]
		public Quantity period { get; set; }

		public ICollection<CodeableConcept> specialPrecautionsForStorage { get; set; }
	}
}

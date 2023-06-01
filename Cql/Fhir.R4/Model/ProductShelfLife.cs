using Hl7.Cql.Poco.Fhir;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Hl7.Cql.Poco.Fhir.R4.Model
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

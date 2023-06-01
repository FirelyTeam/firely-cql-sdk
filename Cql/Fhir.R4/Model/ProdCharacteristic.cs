using Hl7.Cql.Poco.Fhir;
using System.Collections.Generic;

namespace Hl7.Cql.Poco.Fhir.R4.Model
{
    [FhirUri("http://hl7.org/fhir/StructureDefinition/ProdCharacteristic")]
	public partial class ProdCharacteristic : BackboneElement
	{

		public Quantity height { get; set; }

		public Quantity width { get; set; }

		public Quantity depth { get; set; }

		public Quantity weight { get; set; }

		public Quantity nominalVolume { get; set; }

		public Quantity externalDiameter { get; set; }

		public StringElement shape { get; set; }

		public ICollection<StringElement> color { get; set; }

		public ICollection<StringElement> imprint { get; set; }

		public ICollection<Attachment> image { get; set; }

		public CodeableConcept scoring { get; set; }
	}
}

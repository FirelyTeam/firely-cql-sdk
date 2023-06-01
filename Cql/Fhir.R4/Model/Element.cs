using Hl7.Cql.Poco.Fhir;
using System.Collections.Generic;

namespace Hl7.Cql.Poco.Fhir.R4.Model
{
    [FhirUri("http://hl7.org/fhir/StructureDefinition/Element")]
	public partial class Element
	{

		public string id { get; set; }

		public ICollection<Extension> extension { get; set; }
	}
}

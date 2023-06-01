using Hl7.Cql.Poco.Fhir;
using System.Collections.Generic;

namespace Hl7.Cql.Poco.Fhir.R4.Model
{
    [FhirUri("http://hl7.org/fhir/StructureDefinition/DomainResource")]
	public partial class DomainResource : Resource
	{

		public Narrative text { get; set; }

		public ICollection<Resource> contained { get; set; }

		public ICollection<Extension> extension { get; set; }

		public ICollection<Extension> modifierExtension { get; set; }
	}
}

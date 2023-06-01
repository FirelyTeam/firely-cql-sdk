using Hl7.Cql.Poco.Fhir;
using System.Collections.Generic;

namespace Hl7.Cql.Poco.Fhir.R4.Model
{
    [FhirUri("http://hl7.org/fhir/StructureDefinition/BackboneElement")]
	public partial class BackboneElement : Element
	{

		public ICollection<Extension> modifierExtension { get; set; }
	}
}
